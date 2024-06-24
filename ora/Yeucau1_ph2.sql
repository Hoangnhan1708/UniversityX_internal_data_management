-- CS#1
CREATE OR REPLACE VIEW V_INFO_NHANSU
AS
    SELECT *
    FROM QLTRUONGHOC.NHANSU
    WHERE TRIM(UPPER(MANV)) = SYS_CONTEXT('USERENV', 'SESSION_USER');

GRANT SELECT ON V_INFO_NHANSU TO NHANVIEN;
GRANT UPDATE(DT) ON V_INFO_NHANSU TO NHANVIEN;
/
GRANT SELECT ON QLTRUONGHOC.SINHVIEN TO NHANVIEN;
GRANT SELECT ON QLTRUONGHOC.DONVI TO NHANVIEN;
GRANT SELECT ON QLTRUONGHOC.HOCPHAN TO NHANVIEN;
GRANT SELECT ON QLTRUONGHOC.KHMO TO NHANVIEN;
/
-- CS#2
GRANT SELECT ON V_INFO_NHANSU TO GIANGVIEN;
GRANT UPDATE(DT) ON V_INFO_NHANSU TO GIANGVIEN;
GRANT SELECT ON QLTRUONGHOC.SINHVIEN TO GIANGVIEN;
GRANT SELECT ON QLTRUONGHOC.DONVI TO GIANGVIEN;
GRANT SELECT ON QLTRUONGHOC.HOCPHAN TO GIANGVIEN;
GRANT SELECT ON QLTRUONGHOC.KHMO TO GIANGVIEN;
/
CREATE OR REPLACE VIEW V_INFO_PHANCONG
AS
    SELECT *
    FROM QLTRUONGHOC.PHANCONG
    WHERE TRIM(UPPER(MAGV)) = SYS_CONTEXT('USERENV', 'SESSION_USER');

GRANT SELECT ON V_INFO_PHANCONG TO GIANGVIEN;
/
CREATE OR REPLACE VIEW V_INFO_LOPPHANCONG
AS
    SELECT *
    FROM QLTRUONGHOC.DANGKY
    WHERE TRIM(UPPER(MAGV)) = SYS_CONTEXT('USERENV', 'SESSION_USER');
    
GRANT SELECT ON V_INFO_LOPPHANCONG TO GIANGVIEN;
/
GRANT UPDATE(DIEMTH,DIEMQT,DIEMCK,DIEMTK) ON V_INFO_LOPPHANCONG TO GIANGVIEN;
/
-- CS#3
GRANT SELECT ON V_INFO_NHANSU TO GIAOVU;
GRANT UPDATE(DT) ON V_INFO_NHANSU TO GIAOVU;
GRANT SELECT ON QLTRUONGHOC.SINHVIEN TO GIAOVU;
GRANT SELECT ON QLTRUONGHOC.DONVI TO GIAOVU;
GRANT SELECT ON QLTRUONGHOC.HOCPHAN TO GIAOVU;
GRANT SELECT ON QLTRUONGHOC.KHMO TO GIAOVU;
/
GRANT INSERT,UPDATE ON QLTRUONGHOC.SINHVIEN TO GIAOVU;
GRANT INSERT,UPDATE ON QLTRUONGHOC.DONVI TO GIAOVU;
GRANT INSERT,UPDATE ON QLTRUONGHOC.HOCPHAN TO GIAOVU;
GRANT INSERT,UPDATE ON QLTRUONGHOC.KHMO TO GIAOVU;
/
GRANT SELECT ON QLTRUONGHOC.PHANCONG TO GIAOVU;

CREATE OR REPLACE VIEW V_PHANCONG_GIAOVU
AS
    SELECT PC.*,DV.TENDV
    FROM PHANCONG PC JOIN HOCPHAN HP ON PC.MAHP = HP.MAHP JOIN DONVI DV ON HP.MADV = DV.MADV
    WHERE DV.TENDV = 'Văn phòng khoa';

GRANT SELECT,UPDATE ON V_PHANCONG_GIAOVU TO GIAOVU
/
CREATE OR REPLACE VIEW V_DANGKY_GIAOVU
AS
    SELECT DK.*
    FROM DANGKY DK
    JOIN KHMO KH ON DK.MAHP = KH.MAHP
    WHERE 
    DK.HK = KH.HK AND
    DK.NAM = KH.NAM AND
    DK.MACT = KH.MACT AND
        (
            (DK.HK = 1 AND SYSDATE >= TO_DATE('01-01-' || TO_CHAR(SYSDATE, 'YYYY'), 'DD-MM-YYYY') AND SYSDATE < TO_DATE('15-01-' || TO_CHAR(SYSDATE, 'YYYY'), 'DD-MM-YYYY')) OR
            (DK.HK = 2 AND SYSDATE >= TO_DATE('01-06-' || TO_CHAR(SYSDATE, 'YYYY'), 'DD-MM-YYYY') AND SYSDATE < TO_DATE('30-06-' || TO_CHAR(SYSDATE, 'YYYY'), 'DD-MM-YYYY')) OR
            (DK.HK = 3 AND SYSDATE >= TO_DATE('01-09-' || TO_CHAR(SYSDATE, 'YYYY'), 'DD-MM-YYYY') AND SYSDATE < TO_DATE('15-09-' || TO_CHAR(SYSDATE, 'YYYY'), 'DD-MM-YYYY'))
        )
WITH CHECK OPTION;
/
CREATE OR REPLACE TRIGGER trg_insert_v_dangky_giaovu
INSTEAD OF INSERT ON v_dangky_giaovu
FOR EACH ROW
DECLARE
    l_sysdate DATE := SYSDATE;
BEGIN
    -- Kiểm tra các điều kiện của view
    IF (:NEW.HK = 1 AND l_sysdate >= TO_DATE('01-01-' || TO_CHAR(l_sysdate, 'YYYY'), 'DD-MM-YYYY') AND l_sysdate < TO_DATE('15-01-' || TO_CHAR(l_sysdate, 'YYYY'), 'DD-MM-YYYY')) OR
       (:NEW.HK = 2 AND l_sysdate >= TO_DATE('01-06-' || TO_CHAR(l_sysdate, 'YYYY'), 'DD-MM-YYYY') AND l_sysdate < TO_DATE('30-06-' || TO_CHAR(l_sysdate, 'YYYY'), 'DD-MM-YYYY')) OR
       (:NEW.HK = 3 AND l_sysdate >= TO_DATE('01-09-' || TO_CHAR(l_sysdate, 'YYYY'), 'DD-MM-YYYY') AND l_sysdate < TO_DATE('15-09-' || TO_CHAR(l_sysdate, 'YYYY'), 'DD-MM-YYYY')) THEN
       
       -- Chèn dữ liệu vào bảng thực sự
            INSERT INTO DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT, DIEMTH, DIEMQT, DIEMCK, DIEMTK)
            VALUES (:NEW.MASV, :NEW.MAGV, :NEW.MAHP, :NEW.HK, :NEW.NAM, :NEW.MACT, :NEW.DIEMTH, :NEW.DIEMQT, :NEW.DIEMCK, :NEW.DIEMTK);
        ELSE
       RAISE_APPLICATION_ERROR(-20001, 'Dữ liệu không thỏa mãn các điều kiện của view.');
    END IF;
END;
/

/
GRANT SELECT, INSERT, DELETE ON V_DANGKY_GIAOVU TO GIAOVU;
/
-- CS#4
GRANT SELECT ON V_INFO_NHANSU TO TRUONGDONVI;
GRANT UPDATE(DT) ON V_INFO_NHANSU TO TRUONGDONVI;
GRANT SELECT ON QLTRUONGHOC.SINHVIEN TO TRUONGDONVI;
GRANT SELECT ON QLTRUONGHOC.DONVI TO TRUONGDONVI;
GRANT SELECT ON QLTRUONGHOC.HOCPHAN TO TRUONGDONVI;
GRANT SELECT ON QLTRUONGHOC.KHMO TO TRUONGDONVI;
GRANT SELECT ON V_INFO_PHANCONG TO TRUONGDONVI;
GRANT SELECT ON V_INFO_LOPPHANCONG TO TRUONGDONVI;
GRANT UPDATE(DIEMTH,DIEMQT,DIEMCK,DIEMTK) ON V_INFO_LOPPHANCONG TO TRUONGDONVI;
/
CREATE OR REPLACE VIEW V_PHANCONG_TDV
AS
    SELECT PC.*
    FROM PHANCONG PC JOIN HOCPHAN HP ON PC.MAHP = HP.MAHP
    WHERE HP.MADV = (SELECT MADV
                    FROM NHANSU
                    WHERE TRIM(UPPER(MANV)) = SYS_CONTEXT('USERENV', 'SESSION_USER'))
    WITH CHECK OPTION;
/
CREATE OR REPLACE TRIGGER trg_insert_v_phancong_tdv
INSTEAD OF INSERT ON V_PHANCONG_TDV
FOR EACH ROW
BEGIN
    INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT)
    VALUES (:NEW.MAGV, :NEW.MAHP, :NEW.HK, :NEW.NAM, :NEW.MACT);
END;
/
CREATE OR REPLACE TRIGGER trg_update_v_phancong_tdv
INSTEAD OF UPDATE ON V_PHANCONG_TDV
FOR EACH ROW
BEGIN
    UPDATE PHANCONG
    SET MAGV = :NEW.MAGV  
    WHERE MAGV = :OLD.MAGV
        AND MAHP = :OLD.MAHP
        AND HK = :OLD.HK
        AND NAM = :OLD.NAM
        AND MACT = :OLD.MACT;
END;
/

GRANT SELECT,INSERT,UPDATE(MAGV),DELETE ON V_PHANCONG_TDV TO TRUONGDONVI;
/
-- CS#5
GRANT SELECT ON V_INFO_NHANSU TO TRUONGKHOA;
GRANT UPDATE(DT) ON V_INFO_NHANSU TO TRUONGKHOA;
GRANT SELECT ON QLTRUONGHOC.SINHVIEN TO TRUONGKHOA;
GRANT SELECT ON QLTRUONGHOC.DONVI TO TRUONGKHOA;
GRANT SELECT ON QLTRUONGHOC.HOCPHAN TO TRUONGKHOA;
GRANT SELECT ON QLTRUONGHOC.KHMO TO TRUONGKHOA;
GRANT SELECT ON V_INFO_PHANCONG TO TRUONGKHOA;
GRANT SELECT ON V_INFO_LOPPHANCONG TO TRUONGKHOA;
GRANT UPDATE(DIEMTH,DIEMQT,DIEMCK,DIEMTK) ON V_INFO_LOPPHANCONG TO TRUONGKHOA;
/
CREATE OR REPLACE VIEW V_PHANCONG_TK
AS
    SELECT PC.*
    FROM PHANCONG PC JOIN HOCPHAN HP ON PC.MAHP = HP.MAHP JOIN DONVI DV ON HP.MADV = DV.MADV
    WHERE DV.TENDV = 'Văn phòng khoa'
    WITH CHECK OPTION;
/
CREATE OR REPLACE TRIGGER trg_insert_v_phancong_tk
INSTEAD OF INSERT ON V_PHANCONG_TK
FOR EACH ROW
BEGIN
    -- Insert into PHANCONG table
    INSERT INTO PHANCONG (MAGV, MAHP, HK, NAM, MACT)
    VALUES (:NEW.MAGV, :NEW.MAHP, :NEW.HK, :NEW.NAM, :NEW.MACT);
END;
/
CREATE OR REPLACE TRIGGER trg_update_v_phancong_tk
INSTEAD OF UPDATE ON V_PHANCONG_TK
FOR EACH ROW
BEGIN
    -- Update PHANCONG table
    UPDATE PHANCONG
    SET MAGV = :NEW.MAGV  
    WHERE MAGV = :OLD.MAGV
        AND MAHP = :OLD.MAHP
        AND HK = :OLD.HK
        AND NAM = :OLD.NAM
        AND MACT = :OLD.MACT;
END;
/

GRANT SELECT,INSERT,UPDATE,DELETE ON V_PHANCONG_TK TO TRUONGKHOA;
/
GRANT SELECT,INSERT,UPDATe,DELETE ON NHANSU TO TRUONGKHOA;
/
GRANT SELECT ON NHANSU TO TRUONGKHOA; 
GRANT SELECT ON SINHVIEN TO TRUONGKHOA; 
GRANT SELECT ON DONVI TO TRUONGKHOA; 
GRANT SELECT ON HOCPHAN TO TRUONGKHOA; 
GRANT SELECT ON KHMO TO TRUONGKHOA; 
GRANT SELECT ON PHANCONG TO TRUONGKHOA; 
GRANT SELECT ON DANGKY TO TRUONGKHOA; 
/
-- CS#6
CREATE OR REPLACE FUNCTION PF_INFO_SINHVIEN
(p_schema IN VARCHAR2, p_object IN VARCHAR2)
RETURN VARCHAR2
AS
BEGIN
    RETURN '(
        (SELECT COUNT(*) FROM SESSION_ROLES WHERE ROLE = ''SINHVIEN'') > 0
        AND TRIM(UPPER(MASV)) = SYS_CONTEXT(''USERENV'', ''SESSION_USER'')
    )
    OR
    (
        (SELECT COUNT(*) FROM SESSION_ROLES 
         WHERE ROLE IN (''NHANVIEN'', ''GIAOVU'', ''GIANGVIEN'', ''TRUONGDONVI'', ''TRUONGKHOA'')) > 0
    )';
END;
/
GRANT SELECT ON SINHVIEN TO SINHVIEN;
BEGIN
    -- Tạo chính sách cho bảng SINHVIEN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLTRUONGHOC',
        object_name     => 'SINHVIEN',
        policy_name     => 'POL_INFO_SV_1',
        policy_function => 'PF_INFO_SINHVIEN',
        statement_types => 'SELECT'
    );
END;
/
GRANT UPDATE(DCHI,DT) ON SINHVIEN TO SINHVIEN;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLTRUONGHOC',
        object_name     => 'SINHVIEN',
        policy_name     => 'POL_INFO_SV_2',
        policy_function => 'PF_INFO_SINHVIEN',
        statement_types => 'UPDATE',
        sec_relevant_cols => 'DCHI,DT',
        update_check => true
    );
END;
/
GRANT SELECT ON KHMO TO SINHVIEN;
/
CREATE OR REPLACE FUNCTION PF_KHMO_SINHVIEN
(p_schema IN VARCHAR2, p_object IN VARCHAR2)
RETURN VARCHAR2
AS
BEGIN
    RETURN '(
        (SELECT COUNT(*) FROM SESSION_ROLES WHERE ROLE = ''SINHVIEN'') > 0
        AND (MACT = (SELECT MACT FROM SINHVIEN))
    )
    OR
    (
        (SELECT COUNT(*) FROM SESSION_ROLES 
         WHERE ROLE IN (''NHANVIEN'', ''GIAOVU'', ''GIANGVIEN'', ''TRUONGDONVI'', ''TRUONGKHOA'')) > 0
    )';
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLTRUONGHOC',
        object_name     => 'KHMO',
        policy_name     => 'POL_KHMO_SV',
        policy_function => 'PF_KHMO_SINHVIEN',
        statement_types => 'SELECT'
    );
END;
/
GRANT SELECT ON HOCPHAN TO SINHVIEN;
/
CREATE OR REPLACE FUNCTION PF_HOCPHAN_SINHVIEN
(p_schema IN VARCHAR2, p_object IN VARCHAR2)
RETURN VARCHAR2
AS
BEGIN
    RETURN '(
        (SELECT COUNT(*) FROM SESSION_ROLES WHERE ROLE = ''SINHVIEN'') > 0
        AND MAHP IN (SELECT MAHP FROM QLTRUONGHOC.KHMO)
    )
    OR
    (
        (SELECT COUNT(*) FROM SESSION_ROLES 
         WHERE ROLE IN (''NHANVIEN'', ''GIAOVU'', ''GIANGVIEN'', ''TRUONGDONVI'', ''TRUONGKHOA'')) > 0
    )';
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLTRUONGHOC',
        object_name     => 'HOCPHAN',
        policy_name     => 'POL_HOCPHAN_SV',
        policy_function => 'PF_HOCPHAN_SINHVIEN',
        statement_types => 'SELECT'
    );
END;
/
GRANT SELECT, INSERT, DELETE ON DANGKY TO SINHVIEN;
CREATE OR REPLACE FUNCTION PF_DANGKY_SINHVIEN
(p_schema IN VARCHAR2, p_object IN VARCHAR2)
RETURN VARCHAR2
AS
BEGIN
    RETURN '(
        (SELECT COUNT(*) FROM SESSION_ROLES WHERE ROLE = ''SINHVIEN'') > 0
        AND TRIM(UPPER(MASV)) = SYS_CONTEXT(''USERENV'', ''SESSION_USER'') 
        AND ( 
        (HK = 1 AND SYSDATE >= TO_DATE(''01-01-'' || TO_CHAR(SYSDATE, ''YYYY''), ''DD-MM-YYYY'') AND SYSDATE < TO_DATE(''15-01-'' || TO_CHAR(SYSDATE, ''YYYY''), ''DD-MM-YYYY'')) OR
        (HK = 2 AND SYSDATE >= TO_DATE(''01-06-'' || TO_CHAR(SYSDATE, ''YYYY''), ''DD-MM-YYYY'') AND SYSDATE < TO_DATE(''30-06-'' || TO_CHAR(SYSDATE, ''YYYY''), ''DD-MM-YYYY'')) OR
        (HK = 3 AND SYSDATE >= TO_DATE(''01-09-'' || TO_CHAR(SYSDATE, ''YYYY''), ''DD-MM-YYYY'') AND SYSDATE < TO_DATE(''15-09-'' || TO_CHAR(SYSDATE, ''YYYY''), ''DD-MM-YYYY''))
        )
    )
    OR
    (
        (SELECT COUNT(*) FROM SESSION_ROLES 
         WHERE ROLE IN (''NHANVIEN'', ''GIAOVU'', ''GIANGVIEN'', ''TRUONGDONVI'', ''TRUONGKHOA'')) > 0
    )';
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLTRUONGHOC',
        object_name     => 'DANGKY',
        policy_name     => 'POL_DANGKY_SV',
        policy_function => 'PF_DANGKY_SINHVIEN',
        statement_types => 'INSERT,DELETE',
        update_check => true
    );
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLTRUONGHOC',
        object_name     => 'DANGKY',
        policy_name     => 'POL_INFO_DANGKY_SV',
        policy_function => 'PF_INFO_SINHVIEN',
        statement_types => 'SELECT'
    );
END;
/
GRANT UPDATE ON DANGKY TO SINHVIEN;
CREATE OR REPLACE FUNCTION PF_DANGKY_DIEMSO_SINHVIEN
(p_schema IN VARCHAR2, p_object IN VARCHAR2)
RETURN VARCHAR2
AS
BEGIN
    RETURN '(SELECT COUNT(*) FROM SESSION_ROLES 
         WHERE ROLE IN (''NHANVIEN'', ''GIAOVU'', ''GIANGVIEN'', ''TRUONGDONVI'', ''TRUONGKHOA'')) > 0';
END;
/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLTRUONGHOC',
        object_name     => 'DANGKY',
        policy_name     => 'POL_DANGKY_DIEMSO_SV',
        policy_function => 'PF_DANGKY_DIEMSO_SINHVIEN',
        statement_types => 'UPDATE',
        sec_relevant_cols => 'DIEMTH,DIEMQT,DIEMCK,DIEMTK'
    );
END;
/
CREATE OR REPLACE FUNCTION PF_PHANCONG_SINHVIEN
(p_schema IN VARCHAR2, p_object IN VARCHAR2)
RETURN VARCHAR2
AS
BEGIN
    RETURN '(
        (SELECT COUNT(*) FROM SESSION_ROLES WHERE ROLE = ''SINHVIEN'') > 0
        AND ( 
        (HK = 1 AND SYSDATE >= TO_DATE(''01-01-'' || TO_CHAR(SYSDATE, ''YYYY''), ''DD-MM-YYYY'') AND SYSDATE < TO_DATE(''15-01-'' || TO_CHAR(SYSDATE, ''YYYY''), ''DD-MM-YYYY'')) OR
        (HK = 2 AND SYSDATE >= TO_DATE(''01-06-'' || TO_CHAR(SYSDATE, ''YYYY''), ''DD-MM-YYYY'') AND SYSDATE < TO_DATE(''30-06-'' || TO_CHAR(SYSDATE, ''YYYY''), ''DD-MM-YYYY'')) OR
        (HK = 3 AND SYSDATE >= TO_DATE(''01-09-'' || TO_CHAR(SYSDATE, ''YYYY''), ''DD-MM-YYYY'') AND SYSDATE < TO_DATE(''15-09-'' || TO_CHAR(SYSDATE, ''YYYY''), ''DD-MM-YYYY''))
        )
    )
    OR
    (
        (SELECT COUNT(*) FROM SESSION_ROLES 
         WHERE ROLE IN (''NHANVIEN'', ''GIAOVU'', ''GIANGVIEN'', ''TRUONGDONVI'', ''TRUONGKHOA'')) > 0
    )';
END;
/
CREATE OR REPLACE VIEW V_DKHP_SINHVIEN
AS
    SELECT PC.*, HP.TENHP
    FROM PHANCONG PC JOIN HOCPHAN HP ON PC.MAHP = HP.MAHP;

GRANT SELECT ON V_DKHP_SINHVIEN TO SINHVIEN;

/
BEGIN
    DBMS_RLS.ADD_POLICY(
        object_schema   => 'QLTRUONGHOC',
        object_name     => 'V_DKHP_SINHVIEN',
        policy_name     => 'POL_PHACONG_SV',
        policy_function => 'PF_PHANCONG_SINHVIEN',
        statement_types => 'SELECT'
    );
END;
/


/


commit