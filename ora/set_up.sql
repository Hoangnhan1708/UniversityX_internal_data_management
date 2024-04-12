CREATE OR REPLACE VIEW VIEW_ALL_USERS
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
----------------------
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
----------------------
CREATE OR REPLACE VIEW VIEW_ALL_ROLES
AS
    SELECT DISTINCT
    ROLE_ID AS RoleID,
    ROLE AS Role_Name,
    PASSWORD_REQUIRED AS Password_Required
    FROM dba_roles;
----------------------



---------------
CREATE OR REPLACE VIEW VIEW_PRIVILEGES_USER
AS
SELECT 
    rp.grantee AS username,
    rp.granted_role AS role_name,
    NULL AS table_name,
    NULL AS column_name,
    NULL AS privilege,
    sp.privilege AS system_privilege
FROM 
    dba_role_privs rp
LEFT JOIN 
    dba_sys_privs sp 
ON 
    rp.grantee = sp.grantee;
/
----------------
CREATE OR REPLACE VIEW TEST AS
SELECT *
FROM DISTINCT 
        GRANTEE as ROLE, 
        TABLE_NAME as Object_name, 
        PRIVILEGE
FROM DBA_TAB_PRIVS
WHERE GRANTEE IN (
    SELECT DISTINCT role
    FROM DBA_ROLES
) 
ORDER BY GRANTEE;

-----------------------------------


