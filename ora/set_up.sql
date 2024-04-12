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


----------------------
-- Xem toàn bộ roles
CREATE OR REPLACE VIEW VIEW_ALL_ROLES
AS
    SELECT DISTINCT
    ROLE_ID AS RoleID,
    ROLE AS Role_Name,
    PASSWORD_REQUIRED AS Password_Required
    FROM dba_roles;

-----------------------------------


