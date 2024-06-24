ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;

-- Kích hoạt audit
ALTER SYSTEM SET audit_trail = DB, EXTENDED SCOPE = SPFILE;
SHUTDOWN IMMEDIATE;
STARTUP;

SHOW PARAMETER AUDIT_TRAIL;

-- Audit lại hành động connect, disconnect trong database
AUDIT SESSION;

-- Audit lại tất cả các hành động select, insert, delete, update lên các table khi nó thành công
AUDIT SELECT, INSERT, UPDATE, DELETE ON QLTRUONGHOC.NHANSU BY ACCESS WHENEVER SUCCESSFUL;
AUDIT SELECT, INSERT, UPDATE, DELETE ON QLTRUONGHOC.SINHVIEN BY ACCESS WHENEVER SUCCESSFUL;
AUDIT SELECT, INSERT, UPDATE, DELETE ON QLTRUONGHOC.DONVI BY ACCESS WHENEVER SUCCESSFUL;
AUDIT SELECT, INSERT, UPDATE, DELETE ON QLTRUONGHOC.HOCPHAN BY ACCESS WHENEVER SUCCESSFUL;
AUDIT SELECT, INSERT, UPDATE, DELETE ON QLTRUONGHOC.KHMO BY ACCESS WHENEVER SUCCESSFUL;
AUDIT SELECT, INSERT, UPDATE, DELETE ON QLTRUONGHOC.PHANCONG BY ACCESS WHENEVER SUCCESSFUL;
AUDIT SELECT, INSERT, UPDATE, DELETE ON QLTRUONGHOC.DANGKY BY ACCESS WHENEVER SUCCESSFUL;

-- Hàm audit hành vi của user lên các stored procedure
CREATE OR REPLACE PROCEDURE AUDIT_USER_PROCEDURE (USERNAME IN VARCHAR2) IS
    STRSQL VARCHAR(2000);
BEGIN
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE(STRSQL);

    STRSQL := 'AUDIT EXECUTE PROCEDURE BY' || USERNAME;
    EXECUTE IMMEDIATE(STRSQL);
    
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE(STRSQL);
END;
/

-- Fine-grained audit: Hành vi Cập nhật quan hệ ĐANGKY tại các trường liên quan đến điểm số nhưng người đó không thuộc vai trò Giảng viên
BEGIN
    DBMS_FGA.drop_policy (object_schema      => 'QLTRUONGHOC',
                            object_name        => 'DANGKY',
                             policy_name        => 'AUDIT_UPDATE_DIEM_DANGKY'
                            );
END;
/
BEGIN
  DBMS_FGA.add_policy(
    object_schema   => 'QLTRUONGHOC',
    object_name     => 'DANGKY',
    policy_name     => 'AUDIT_UPDATE_DIEM_DANGKY',
    audit_condition => 'SYS_CONTEXT(''SYS_SESSION_ROLES'',''GIANGVIEN'') = ''FALSE'')',
    audit_column    => 'DIEMTH,DIEMQT,DIEMCK,DIEMTK',
    statement_types => 'UPDATE');
END;
/


-- Fine-grained audit: Hành vi của người dùng này có thể đọc trên trường PHUCAP của người khác ở quan hệ NHANSU
BEGIN
    DBMS_FGA.drop_policy (object_schema      => 'QLTRUONGHOC',
                            object_name        => 'NHANSU',
                             policy_name        => 'AUDIT_SELECT_PHUCAP_NHANSU'
                            );
END;
/
BEGIN
  DBMS_FGA.add_policy(
    object_schema   => 'QLTRUONGHOC',
    object_name     => 'NHANSU',
    policy_name     => 'AUDIT_SELECT_PHUCAP_NHANSU',
    audit_condition => 'MANV != SYS_CONTEXT(''USERENV'', ''SESSION_USER'')',
    audit_column    => 'MANV,PHUCAP',
    statement_types => 'SELECT');
END;
/

ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE;
COMMIT;