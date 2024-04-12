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
    LEFT JOIN dba_role_privs r ON u.USERNAME = r.GRANTEE;
/
--- Lấy các quyền có trên hệ thống
CREATE OR REPLACE VIEW V_DETAIL_USER_2
AS
    SELECT PRIVILEGE
    FROM DBA_SYS_PRIVS;
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
    JOIN DBA_ROLE_PRIVS rp ON tp.GRANTEE = rp.GRANTED_ROLE;
/
-- Lấy các dòng thông tin update trên dòng
-- Update trên toàn bộ bảng (không ghi cụ thể dòng) được thể hiện ở bảng trên
CREATE OR REPLACE VIEW V_DETAIL_USER_4
AS
    SELECT DISTINCT
        rp.GRANTEE AS User_Name,
        cp.PRIVILEGE AS Privilege,
        cp.TABLE_NAME AS Table_Name,
        cp.COLUMN_NAME AS Column_Name
    FROM DBA_COL_PRIVS cp
    JOIN DBA_ROLE_PRIVS rp ON cp.GRANTEE = rp.GRANTED_ROLE
    --WHERE INSTR(cp.TABLE_NAME, '$') = 0;









----------------------
-- Xem toàn bộ roles
CREATE OR REPLACE VIEW VIEW_ALL_ROLES
AS
    SELECT DISTINCT
    ROLE_ID AS RoleID,
    ROLE AS Role_Name,
    PASSWORD_REQUIRED AS Password_Required
    FROM dba_roles;



