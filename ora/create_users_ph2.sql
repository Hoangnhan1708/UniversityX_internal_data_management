ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

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
EXEC createuser_table_sinhvien;
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
    roles_to_drop role_list_t := role_list_t('TRUONGKHOA', 'TRUONGDONVI', 'GIAOVU','NHANVIEN','GIANGVIEN','SINHVIEN');
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
CREATE ROLE NHANVIEN;
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
            WHEN 'Nhân viên cơ bản' THEN ROLE := 'NHANVIEN';
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
commit;
