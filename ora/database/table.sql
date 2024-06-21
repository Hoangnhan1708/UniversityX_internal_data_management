ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

-- tạo schema mới
--- Xoá nếu nó đã tồn tại
BEGIN
    EXECUTE IMMEDIATE 'DROP USER QLTRUONGHOC CASCADE';
EXCEPTION
    WHEN OTHERS THEN
        IF SQLCODE = -01918 THEN
            NULL;
        ELSE
            RAISE;
        END IF;
END;
/
GRANT DBA, SET CONTAINER, LBAC_DBA TO QLTRUONGHOC IDENTIFIED BY 123123;
GRANT ALL PRIVILEGES TO QLTRUONGHOC;
/
ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE;
/
conn QLTRUONGHOC@xepdb1;
/



ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
ALTER SESSION SET CURRENT_SCHEMA = QLTRUONGHOC;
/
--- drop all table
DECLARE
    TYPE table_array IS VARRAY(7) OF VARCHAR2(30);
    v_table_names table_array := table_array('NHANSU', 'SINHVIEN', 'DONVI', 'HOCPHAN', 'KHMO', 'PHANCONG', 'DANGKY');
    v_sql        VARCHAR2(100);
BEGIN
    FOR i IN 1 .. v_table_names.COUNT LOOP
        BEGIN
            v_sql := 'DROP TABLE ' || v_table_names(i) || ' CASCADE CONSTRAINTS';
            EXECUTE IMMEDIATE v_sql;
        EXCEPTION
            WHEN OTHERS THEN
                IF SQLCODE != -942 THEN
                    RAISE;
                END IF;
        END;
    END LOOP;
END;

/
--- create table
CREATE TABLE NHANSU
(
    MANV VARCHAR2(6) NOT NULL,
    HOTEN NVARCHAR2(50),
    PHAI NVARCHAR2(5)CONSTRAINT CHK_PHAI_NS CHECK (PHAI IN ('Nam', 'Nữ')),
    NGSINH DATE,
    PHUCAP INT,
    DT VARCHAR2(10),
    VAITRO NVARCHAR2(20) CONSTRAINT CHK_VAITRO CHECK (VAITRO IN ('Nhân viên cơ bản', 'Giảng viên', 'Giáo vụ', 'Trưởng đơn vị', 'Trưởng khoa')),
    MADV VARCHAR2(6),
    CONSTRAINT PK_NS
    PRIMARY KEY(MANV)
);

    CREATE TABLE SINHVIEN
    (
        MASV VARCHAR2(6) NOT NULL,
        HOTEN NVARCHAR2(50),
        PHAI NVARCHAR2(5) CONSTRAINT CHK_PHAI_SV CHECK (PHAI IN ('Nam', 'Nữ')),
        NGSINH DATE,
        DCHI NVARCHAR2(100),
        DT VARCHAR2(10),
        MACT VARCHAR2(6) CONSTRAINT CHK_CT_SV CHECK (MACT IN('CQ','CLC','CTTT','VP')),   
        MANGANH VARCHAR2(6),
        SOTCTL INT,
        DTBTL FLOAT,
        CONSTRAINT PK_SV
        PRIMARY KEY(MASV)
    );

CREATE TABLE DONVI
(
    MADV VARCHAR2(6) NOT NULL CONSTRAINT CHK_MADV CHECK (MADV IN ('VPK','HTTT','CNPM','KHMT','CNTT','TGMT','MMT_VT')),
    TENDV NVARCHAR2(40) CONSTRAINT CHK_TENDV CHECK (TENDV IN ('Văn phòng khoa','Bộ môn Hệ thống thông tin','Bộ môn Công nghệ phần mềm','Bộ môn Khoa học thông tin','Bộ môn Công nghệ thông tin','Bộ môn Thị giác máy tính','Bộ môn Mạng máy tính và Viễn thông')),
    TRGDV VARCHAR2(6),
    CONSTRAINT PK_DV
    PRIMARY KEY(MADV),
    CONSTRAINT FK_TRGDV
    FOREIGN KEY(TRGDV) REFERENCES NHANSU(MANV)
);

CREATE TABLE HOCPHAN
(
    MAHP VARCHAR2(6) NOT NULL, 
    TENHP NVARCHAR2(30),
    SOTC INT,
    STLT INT,
    STTH INT,
    SOSVTD INT,
    MADV VARCHAR2(6),
    CONSTRAINT PK_HP
    PRIMARY KEY(MAHP),
    CONSTRAINT FK_DVPHUTRACH
    FOREIGN KEY(MADV) REFERENCES DONVI(MADV)  
);

CREATE TABLE KHMO
(
    MAHP VARCHAR2(6) NOT NULL,
    HK INT NOT NULL CONSTRAINT CHK_KHM CHECK (HK IN (1,2,3)),
    NAM INT NOT NULL,
    MACT VARCHAR2(6) NOT NULL CONSTRAINT CHK_CT_KHM CHECK (MACT IN('CQ','CLC','CTTT','VP')),
    CONSTRAINT PK_KHMO
    PRIMARY KEY(MAHP,HK,NAM,MACT),
    CONSTRAINT FK_HPMO
    FOREIGN KEY(MAHP) REFERENCES HOCPHAN(MAHP)
);

CREATE TABLE PHANCONG 
(
    MAGV VARCHAR2(6) NOT NULL,
    MAHP VARCHAR2(6) NOT NULL,
    HK INT NOT NULL,
    NAM INT NOT NULL,
    MACT VARCHAR2(6) NOT NULL,
    CONSTRAINT PK_PHANCONG
    PRIMARY KEY(MAGV,MAHP,HK,NAM,MACT),
    CONSTRAINT FK_PHANCONG_GV
    FOREIGN KEY(MAGV) REFERENCES NHANSU(MANV),
    CONSTRAINT FK_PHANCONG_KHMO
    FOREIGN KEY(MAHP,HK,NAM,MACT) REFERENCES KHMO(MAHP,HK,NAM,MACT)
    
);

CREATE TABLE DANGKY
(
    MASV VARCHAR2(6) NOT NULL,
    MAGV VARCHAR2(6) NOT NULL,
    MAHP VARCHAR2(6) NOT NULL,
    HK INT NOT NULL,
    NAM INT NOT NULL,
    MACT VARCHAR2(6) NOT NULL,
    DIEMTH FLOAT,
    DIEMQT FLOAT,
    DIEMCK FLOAT,
    DIEMTK FLOAT,
    CONSTRAINT PK_DANGKY
    PRIMARY KEY(MASV,MAGV,MAHP,HK,NAM,MACT),
    CONSTRAINT FK_DANGKY_SV
    FOREIGN KEY(MASV) REFERENCES SINHVIEN(MASV),
    CONSTRAINT FK_DANGKY_PHANCONG
    FOREIGN KEY(MAGV,MAHP,HK,NAM,MACT) REFERENCES PHANCONG(MAGV,MAHP,HK,NAM,MACT)
);
/
ALTER TABLE NHANSU
ADD CONSTRAINT FK_NS_DV
FOREIGN KEY (MADV) REFERENCES DONVI(MADV);
/
------ các ràng buộc toàn vẹn
-- update trưởng phòng
CREATE OR REPLACE TRIGGER trg_donvi_update
BEFORE INSERT OR UPDATE OF TRGDV ON DONVI
FOR EACH ROW
DECLARE
    v_count NUMBER;
    v_old_TRGDV NHANSU.MANV%TYPE;
    v_old_TRGDV_role NHANSU.VAITRO%TYPE;
    v_new_TRGDV_role NHANSU.VAITRO%TYPE;
BEGIN
    -- If the new TRGDV is not NULL, perform the validation and updates
    IF :NEW.TRGDV IS NOT NULL THEN
        -- Kiểm tra xem nhân sự mới có vai trò là 'Giảng viên', 'Trưởng đơn vị', 'Trưởng khoa' trong đơn vị mới hay không
        SELECT COUNT(*)
        INTO v_count
        FROM NHANSU
        WHERE MANV = :NEW.TRGDV
            AND MADV = :NEW.MADV;

        -- Nếu không có giảng viên nào thỏa mãn điều kiện, phát sinh lỗi
        IF v_count = 0 THEN
            RAISE_APPLICATION_ERROR(-20001, 'Chỉ có trong đơn vị mới được trở thành trưởng đơn vị.');
        END IF;

        -- Nếu là UPDATE thì cần cập nhật vai trò của trưởng đơn vị cũ
        IF UPDATING THEN
            -- Đưa vai trò của trưởng phòng mới cho trưởng phòng cũ       
            SELECT VAITRO INTO v_new_TRGDV_role
            FROM NHANSU
            WHERE MANV = :NEW.TRGDV;

            -- Hoán đổi vai trò
            UPDATE NHANSU
            SET VAITRO = v_new_TRGDV_role
            WHERE MANV = :OLD.TRGDV;
            
            IF :OLD.TRGDV IS NOT NULL THEN
                SELECT VAITRO INTO v_old_TRGDV_role
                FROM NHANSU
                WHERE MANV = :OLD.TRGDV;
    
                -- Hoán đổi vai trò
                UPDATE NHANSU
                SET VAITRO = v_old_TRGDV_role
                WHERE MANV = :NEW.TRGDV;
            END IF;
            
            
        END IF;
        IF INSERTING THEN
            UPDATE NHANSU
            SET VAITRO = 'Trưởng đơn vị'
            WHERE MANV = :NEW.TRGDV;
        END IF;
    END IF;
END;
/

-- Cập nhập điểm trung bình tích lũy
CREATE OR REPLACE TRIGGER TRG_DTLTC
AFTER INSERT OR UPDATE OF DIEMTK ON DANGKY
FOR EACH ROW
DECLARE
  v_tong_diem NUMBER;
  v_tong_tinchi NUMBER;
BEGIN
  -- Tính tổng điểm * tín chỉ và tổng tín chỉ của sinh viên
  SELECT SUM(DIEMTK * SOTC), SUM(SOTC)
  INTO v_tong_diem, v_tong_tinchi
  FROM DANGKY D JOIN HOCPHAN H ON D.MAHP = H.MAHP
  WHERE D.MASV = :NEW.MASV AND D.DIEMTK IS NOT NULL; 

  -- Cập nhật điểm trung bình tích lũy và số tín chỉ tích lũy cho sinh viên
  UPDATE SINHVIEN
  SET DTBTL = v_tong_diem / v_tong_tinchi,
      SOTCTL = v_tong_tinchi
  WHERE MASV = :NEW.MASV;
END;
/
----- Add data from csv
--host sqlldr userid=QLTRUONGHOC/123123@XE control=donvi.ctl;
--host sqlldr userid=QLTRUONGHOC/123123@XE control=nhansu.ctl;


host sqlldr userid=QLTRUONGHOC/123123@"(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=0.tcp.ap.ngrok.io)(PORT=16088))(CONNECT_DATA=(SERVICE_NAME=XE)))" control=donvi.ctl;
host sqlldr userid=QLTRUONGHOC/123123@"(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=0.tcp.ap.ngrok.io)(PORT=16088))(CONNECT_DATA=(SERVICE_NAME=XE)))" control=nhansu.ctl;
-- Update TRGDV in DONVI table after NHANSU is loaded
/
UPDATE DONVI D
SET TRGDV = (
    SELECT MANV 
    FROM NHANSU N 
    WHERE N.MADV = D.MADV 
        AND (N.VAITRO = 'Trưởng đơn vị' OR N.VAITRO = 'Trưởng khoa')
    )
WHERE EXISTS (
    SELECT 1
    FROM NHANSU N 
    WHERE N.MADV = D.MADV 
        AND (N.VAITRO = 'Trưởng đơn vị' OR N.VAITRO = 'Trưởng khoa'));
/
--host sqlldr userid=QLTRUONGHOC/123123@XE control=sinhvien.ctl;
host sqlldr userid=QLTRUONGHOC/123123@"(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=0.tcp.ap.ngrok.io)(PORT=16088))(CONNECT_DATA=(SERVICE_NAME=XE)))" control=sinhvien.ctl;
/

-------------------------------------------------------------------------------------------
-- Tạo user, role, grant role to user
CREATE OR REPLACE PROCEDURE CREATEUSER_TABLE_SINHVIEN
AS
    CURSOR CUR IS (SELECT MASV
                    FROM SINHVIEN
                    WHERE MASV NOT IN (SELECT USERNAME
                                                      FROM ALL_USERS)
                    );
    STRSQL VARCHAR(2000);
    USR VARCHAR2(10);
BEGIN
    OPEN CUR;
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE(STRSQL);
    LOOP
        FETCH CUR INTO USR;
        EXIT WHEN CUR%NOTFOUND;

        STRSQL := 'CREATE USER ' || USR || ' IDENTIFIED BY ' ||USR;
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'GRANT CONNECT TO ' ||USR;
        EXECUTE IMMEDIATE(STRSQL);
    END LOOP;
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
    CLOSE CUR;
END;
/
EXEC createuser_table_sinhvien
/
CREATE OR REPLACE PROCEDURE CREATEUSER_TABLE_NHANSU
AS
    CURSOR CUR IS (SELECT MANV
                    FROM NHANSU
                    WHERE MANV NOT IN (SELECT USERNAME
                                                      FROM ALL_USERS)
                    );
    STRSQL VARCHAR(2000);
    USR VARCHAR2(10);
BEGIN
    OPEN CUR;
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE(STRSQL);
    LOOP
        FETCH CUR INTO USR;
        EXIT WHEN CUR%NOTFOUND;

        STRSQL := 'CREATE USER ' || USR || ' IDENTIFIED BY ' ||USR;
        EXECUTE IMMEDIATE(STRSQL);
        STRSQL := 'GRANT CONNECT TO ' ||USR;
        EXECUTE IMMEDIATE(STRSQL);
    END LOOP;
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
    CLOSE CUR;
END;
/
EXEC createuser_table_nhansu;
/
DECLARE
    TYPE role_list_t IS TABLE OF VARCHAR2(100); -- Define a collection type to hold role names
    roles_to_drop role_list_t := role_list_t('TRUONGKHOA', 'TRUONGDONVI', 'GIAOVU','NHANVIENCOBAN','GIANGVIEN','SINHVIEN');
    role_exists NUMBER;
BEGIN
    FOR i IN 1..roles_to_drop.COUNT LOOP
        -- Check if the role exists
        SELECT COUNT(*)
        INTO role_exists
        FROM dba_roles
        WHERE role = roles_to_drop(i);

        -- If the role exists, drop it
        IF role_exists > 0 THEN
            EXECUTE IMMEDIATE 'DROP ROLE ' || roles_to_drop(i);
        END IF;
    END LOOP;
END;
/
-- Create roles
CREATE ROLE TRUONGKHOA;
CREATE ROLE TRUONGDONVI;
CREATE ROLE GIAOVU;
CREATE ROLE NHANVIENCOBAN;
CREATE ROLE GIANGVIEN;
CREATE ROLE SINHVIEN;
/
CREATE OR REPLACE PROCEDURE GRANT_ROLE
AS
    -- Cursor for NHANSU table
    CURSOR CUR_NHANSU IS
        SELECT MANV, VAITRO
        FROM NHANSU;
    
    -- Cursor for SINHVIEN table
    CURSOR CUR_SINHVIEN IS
        SELECT MASV
        FROM SINHVIEN;
        
    STRSQL VARCHAR(2000);
    USR VARCHAR2(30);
    VAITRO VARCHAR2(30);
    ROLE VARCHAR2(30);
BEGIN
    -- Grant roles based on NHANSU table
    OPEN CUR_NHANSU;
    LOOP
        FETCH CUR_NHANSU INTO USR, VAITRO;
        EXIT WHEN CUR_NHANSU%NOTFOUND;

        -- Map Vietnamese roles to English roles
        CASE VAITRO
            WHEN 'Trưởng khoa' THEN ROLE := 'TRUONGKHOA';
            WHEN 'Trưởng đơn vị' THEN ROLE := 'TRUONGDONVI';
            WHEN 'Giáo vụ' THEN ROLE := 'GIAOVU';
            WHEN 'Nhân viên cơ bản' THEN ROLE := 'NHANVIENCOBAN';
            WHEN 'Giảng viên' THEN ROLE := 'GIANGVIEN';
            ELSE ROLE := NULL;
        END CASE;

        -- Grant the role to the user if a valid role is found
        IF ROLE IS NOT NULL THEN
            STRSQL := 'GRANT ' || ROLE || ' TO ' || USR;
            EXECUTE IMMEDIATE STRSQL;
        END IF;
    END LOOP;
    CLOSE CUR_NHANSU;

    -- Grant SINH_VIEN role to users in SINHVIEN table
    OPEN CUR_SINHVIEN;
    LOOP
        FETCH CUR_SINHVIEN INTO USR;
        EXIT WHEN CUR_SINHVIEN%NOTFOUND;

        STRSQL := 'GRANT SINHVIEN TO ' || USR;
        EXECUTE IMMEDIATE STRSQL;
    END LOOP;
    CLOSE CUR_SINHVIEN;
END;
/
exec grant_role;
/
----------------------------------------------------------------------






