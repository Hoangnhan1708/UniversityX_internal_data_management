-- Xem toàn bộ các user
CREATE OR REPLACE VIEW V_ALL_USERS
AS
    SELECT DISTINCT 
        u.USER_ID AS UserID,
        u.USERNAME AS Name,
        r.GRANTED_ROLE AS Role,
        u.ACCOUNT_STATUS AS Status,
        u.CREATED AS Created_date,
        u.EXPIRY_DATE AS Expiry_date
    FROM dba_users u
    LEFT JOIN dba_role_privs r ON u.USERNAME = r.GRANTEE 
    ORDER BY u.USER_ID;
/

-- Tạo user mới
CREATE OR REPLACE PROCEDURE P_CREATE_USER(
    v_uname IN varchar,
    v_pass IN varchar)
AS  
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE' ;
    EXECUTE IMMEDIATE(STRSQL);
    
    STRSQL := 'CREATE USER '||v_uname||' IDENTIFIED BY '||v_pass;
    EXECUTE IMMEDIATE(STRSQL);
        
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
END P_CREATE_USER;
/

-- Xóa user 
CREATE OR REPLACE PROCEDURE P_DROP_USER(
    v_uname IN varchar)
AS  
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE' ;
    EXECUTE IMMEDIATE(STRSQL);
    
    STRSQL := 'DROP USER '||v_uname;
    EXECUTE IMMEDIATE(STRSQL);
    
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
END P_DROP_USER;
/


-- Tạo role mới
CREATE OR REPLACE PROCEDURE P_CREATE_ROLE(
    v_rolename IN varchar)
AS  
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE' ;
    EXECUTE IMMEDIATE(STRSQL);
    
    STRSQL := 'CREATE ROLE '||v_rolename;
    EXECUTE IMMEDIATE(STRSQL);
        
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
END P_CREATE_ROLE;
/

-- Xóa role 
CREATE OR REPLACE PROCEDURE P_DROP_ROLE(
    v_rolename IN varchar)
AS  
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE' ;
    EXECUTE IMMEDIATE(STRSQL);
    
    STRSQL := 'DROP ROLE '||v_rolename;
    EXECUTE IMMEDIATE(STRSQL);
    
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
END P_DROP_ROLE;
/



-- Xem chi tiết tài khoản
--- Lấy id, tên, trạng thái và các roles
CREATE OR REPLACE VIEW V_DETAIL_USER_1
AS
    SELECT DISTINCT
        u.USER_ID AS UserID,
        u.USERNAME AS Name,
        r.GRANTED_ROLE AS Role,
        u.ACCOUNT_STATUS AS Status
    FROM dba_users u
    LEFT JOIN dba_role_privs r ON u.USERNAME = r.GRANTEE
    ORDER BY UserID;
/

--- Lấy các quyền có trên hệ thống
CREATE OR REPLACE VIEW V_DETAIL_USER_2
AS
    SELECT distinct
        GRANTEE AS User_Name, 
        PRIVILEGE AS Privileges,
        ADMIN_OPTION AS ADM
    FROM DBA_SYS_PRIVS
    WHERE  GRANTEE IN (SELECT Name
        FROM V_ALL_USERS)
    ORDER BY User_Name;
/

--- Lấy các thông tin trên các ọbject
CREATE OR REPLACE VIEW V_DETAIL_USER_3
AS
    SELECT DISTINCT
        rp.GRANTEE AS User_Name,
        tp.PRIVILEGE AS Privilege,
        tp.TABLE_NAME AS Object_Name,
        tp.TYPE AS Type
    FROM DBA_TAB_PRIVS tp
    JOIN DBA_ROLE_PRIVS rp ON tp.GRANTEE = rp.GRANTED_ROLE
    UNION
    SELECT DISTINCT
        GRANTEE AS User_Name,
        PRIVILEGE AS Privilege,
        TABLE_NAME AS Object_Name,
        TYPE AS Type
    FROM DBA_TAB_PRIVS
    WHERE GRANTEE IN (SELECT Name FROM V_ALL_USERS)    
    ORDER BY User_Name;
/

-- Lấy các dòng thông tin update trên dòng
-- Update trên toàn bộ bảng (không ghi cụ thể dòng) được thể hiện ở bảng trên
CREATE OR REPLACE VIEW V_DETAIL_USER_4
AS
    SELECT DISTINCT
        rp.GRANTEE AS User_Name,
        cp.PRIVILEGE AS Privilege,
        cp.COLUMN_NAME AS Column_Name,
        cp.TABLE_NAME AS Table_Name,
        cp.GRANTABLE AS ADM
    FROM DBA_COL_PRIVS cp
    JOIN DBA_ROLE_PRIVS rp ON cp.GRANTEE = rp.GRANTED_ROLE
    WHERE cp.OWNER = SYS_CONTEXT('userenv','session_user')
    UNION
    SELECT DISTINCT
        GRANTEE AS User_Name,
        PRIVILEGE AS Privilege,
        COLUMN_NAME AS Column_Name,
        TABLE_NAME AS Table_Name,
        GRANTABLE AS ADM
    FROM DBA_COL_PRIVS
    WHERE OWNER = SYS_CONTEXT('userenv','session_user')
    ORDER BY User_Name;
/

----------------------
-- Xem toàn bộ roles
CREATE OR REPLACE VIEW V_ALL_ROLES
AS
    SELECT DISTINCT
    ROLE_ID AS RoleID,
    ROLE AS Role_Name,
    PASSWORD_REQUIRED AS Password_Required
    FROM dba_roles
    ORDER BY RoleID;
/

--
CREATE OR REPLACE VIEW V_DETAIL_ROLES_1
AS
    SELECT DISTINCT
        ROLE_ID AS RoleID,
        ROLE AS Role,
        PASSWORD_REQUIRED AS Password,
        INHERITED AS Inherited
    FROM dba_roles
    ORDER BY RoleID;
/

--- Lấy các quyền có trên hệ thống
CREATE OR REPLACE VIEW V_DETAIL_ROLES_2
AS
    SELECT distinct
        GRANTEE AS Role_Name, 
        PRIVILEGE AS Privileges,
        ADMIN_OPTION AS ADM
    FROM DBA_SYS_PRIVS
    WHERE GRANTEE IN (SELECT Role_Name
        FROM V_ALL_ROLES)
    ORDER BY Role_Name;
/

--- Lấy các thông tin trên các ọbject
CREATE OR REPLACE VIEW V_DETAIL_ROLES_3
AS
    SELECT DISTINCT
        GRANTEE AS Role_Name,
        PRIVILEGE AS Privilege,
        TABLE_NAME AS Object_Name,
        TYPE AS Type,
        GRANTABLE AS ADM
    FROM DBA_TAB_PRIVS 
    WHERE GRANTEE IN (SELECT Role_Name
        FROM V_ALL_ROLES)
    ORDER BY Role_Name;
/

-- Lấy các dòng thông tin update trên dòng
-- Update trên toàn bộ bảng (không ghi cụ thể dòng) được thể hiện ở bảng trên
CREATE OR REPLACE VIEW V_DETAIL_ROLES_4
AS
    SELECT DISTINCT
        GRANTEE AS Role_Name,
        PRIVILEGE AS Privilege,
        COLUMN_NAME AS Column_Name,
        TABLE_NAME AS Table_Name,
        GRANTABLE AS ADM
    FROM DBA_COL_PRIVS
    WHERE GRANTEE IN (SELECT Role_Name
        FROM V_ALL_ROLES)
    ORDER BY Role_Name;
/   

-----------------------------------
CREATE OR REPLACE VIEW V_ADMIN_OPTION
AS
    SELECT DISTINCT
        GRANTEE AS UserName,
        GRANTED_ROLE AS Role,
        ADMIN_OPTION AS ADM
    FROM dba_role_privs;
/

-----------------------------------
CREATE OR REPLACE VIEW V_ALL_SYS_PRIVS
AS
    SELECT DISTINCT
        PRIVILEGE AS Privileges
    FROM DBA_SYS_PRIVS;
/
-----------------------------------
CREATE OR REPLACE VIEW V_ALL_OBJECT
AS
    SELECT DISTINCT 
        TABLE_NAME AS Object_Name,
        TYPE AS Type        
    FROM DBA_TAB_PRIVS 
    WHERE PRIVILEGE IN ('SELECT','UPDATE','INSERT','DELETE','EXCUTE')
    AND ROWNUM <= 500;
/

----------------------------

CREATE OR REPLACE VIEW V_ALL_TABLE
AS
    SELECT DISTINCT OBJECT_NAME,OBJECT_TYPE
    FROM (
        SELECT DISTINCT OBJECT_NAME, CREATED,OBJECT_TYPE
        FROM ALL_OBJECTS
        WHERE OBJECT_TYPE IN ('TABLE','VIEW')
        AND DEFAULT_COLLATION = 'USING_NLS_COMP'
        AND OWNER = SYS_CONTEXT('userenv','session_user')
        ORDER BY CREATED DESC)
    WHERE ROWNUM <= 50;
    
/

CREATE OR REPLACE VIEW V_ALL_COLUMN
AS
    SELECT DISTINCT TABLE_NAME, COLUMN_NAME
    FROM ALL_TAB_COLUMNS
    WHERE TABLE_NAME IN (SELECT OBJECT_NAME FROM V_ALL_TABLE)
    ORDER BY TABLE_NAME;
/
COMMIT;
