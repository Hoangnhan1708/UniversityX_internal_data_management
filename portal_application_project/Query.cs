using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace portal_application_project
{
    public class Query
    {
        public Query()
        {
        }

        // Login
        public string getAdminLoginString(string username, string password)
        {
            return "Data Source=localhost;User Id=" + username + ";Password=" + password + ";DBA Privilege=SYSDBA;";
        }

        //public string getUserLoginString(string username, string password)
        //{
        //    return "Data Source=localhost;User Id=" + username + ";Password=" + password + ";";
        //}
        public string getUserLoginString(string username, string password)
        {
            //return "Data Source=localhost:1521/XEPDB1;User Id=" + username + ";Password=" + password + ";";
            return "Data Source=0.tcp.ap.ngrok.io:16088/XE;User Id=" + username + ";Password=" + password + ";";
        }


        public string getUserRoles()
        {
            return "SELECT ROLE FROM SESSION_ROLES";
        }

        // NVCB
        public string getUserInfo(string manv)
        {
            return "SELECT * FROM QLTRUONGHOC.NHANSU WHERE MANV = '" + manv + "'";
        }

        public string getSinhVienInfo(string masv)
        {
            return "SELECT * FROM QLTRUONGHOC.SINHVIEN WHERE MASV = '" + masv + "'";
        }

        public string getFullTableString(string tableName)
        {
            return "SELECT * FROM QLTRUONGHOC." + tableName;
        }

        // SINHVIEN
        public string sinhvienUpdateAddress()
        {
            return "UPDATE QLTRUONGHOC.SINHVIEN SET DCHI = :newAddress WHERE MASV = :masv";
        }

        public string sinhvienUpdatePhoneNumber()
        {
            return "UPDATE QLTRUONGHOC.SINHVIEN SET DT = :newPhoneNumber WHERE MASV = :masv";
        }

        // GIANGVIEN
        public string giangvienUpdateScore()
        {
            return "UPDATE QLTRUONGHOC.DANGKY SET DIEMTH = :DIEMTH, DIEMQT = :DIEMQT, DIEMCK = :DIEMCK, DIEMTK = :DIEMTK " +
                                     "WHERE MASV = :MASV AND MAGV = :MAGV AND MAHP = :MAHP AND HK = :HK AND NAM = :NAM AND MACT = :MACT";
        }

        // GIAOVU

        // GIAOVU -> SINHVIEN
        public string giaovuInsertSinhVien()
        {
            return "INSERT INTO QLTRUONGHOC.SINHVIEN (MASV, HOTEN, PHAI, NGSINH, DCHI, DT, MACT, MANGANH, SOTCTL, DTBTL) " +
                                 "VALUES (:MASV, :HOTEN, :PHAI, :NGSINH, :DCHI, :DT, :MACT, :MANGANH, :SOTCTL, :DTBTL)";
        }
        public string giaovuUpdateSinhVienInfo()
        {
            return "UPDATE QLTRUONGHOC.SINHVIEN SET HOTEN = :HOTEN, PHAI = :PHAI, NGSINH = :NGSINH, DCHI = :DCHI, DT = :DT, MACT = :MACT, MANGANH = :MANGANH, SOTCTL = :SOTCTL, DTBTL = :DTBTL " +
                                     "WHERE MASV = :MASV";
        }

        // GIAOVU -> DONVI

        public string giaovuInsertDonVi()
        {
            return "INSERT INTO QLTRUONGHOC.DONVI (MADV, TENDV, TRGDV) " +
                                 "VALUES (:MADV, :TENDV, :TRGDV)";
        }

        public string giaovuUpdateDonViInfo()
        {
            return "UPDATE QLTRUONGHOC.DONVI SET TENDV = :TENDV, TRGDV = :TRGDV " +
                                     "WHERE MADV = :MADV";
        }

        // GIAOVU -> HOCPHAN

        public string giaovuInsertHocPhan()
        {
            return "INSERT INTO QLTRUONGHOC.HOCPHAN (MAHP, TENHP, SOTC ,STLT,STTH, SOSVTD,MADV) " +
                                 "VALUES (:MAHP, :TENHP, :SOTC,:STLT, :STTH, :SOSVTD, :MADV)";
        }

        public string giaovuUpdateHocPhanInfo()
        {
            return "UPDATE QLTRUONGHOC.HOCPHAN SET TENHP = :TENHP, SOTC = :SOTC, STLT = :STLT, STTH = :STTH, SOSVTD = :SOSVTD, MADV = :MADV " +
                            "WHERE MAHP = :MAHP";
        }


        // GIAOVU -> KHMO
        public string giaovuInsertKHMO()
        {
            return "INSERT INTO QLTRUONGHOC.KHMO (MAHP, HK, NAM ,MACT) " +
                                 "VALUES (:MAHP, :HK, :NAM,:MACT)";
        }

        public string giaovuUpdateKHMOInfo()
        {
            return "UPDATE QLTRUONGHOC.KHMO SET HK = :HK, NAM = :NAM, MACT = :MACT " +
                            "WHERE MAHP = :MAHP";
        }

        // GIAOVU -> PHANCONG
        public string giaovuUpdatePhanCongInfo()
        {
            return "UPDATE QLTRUONGHOC.PHANCONG SET HK = :HK, NAM = :NAM, MACT = :MACT " +
                            "WHERE MAGV = :MAGV AND MAHP = :MAHP";
        }

        // GIAOVU -> DANGKY

        // INSERT
        public string giaovuInsertDangKy()
        {
            return "INSERT INTO QLTRUONGHOC.DANGKY (MASV, MAGV, MAHP, HK, NAM ,MACT, DIEMTH,DIEMQT,DIEMCK,DIEMTK) " +
                                 "VALUES (:MASV, :MAGV, :MAHP,:HK,:NAM, :MACT, :DIEMTH, :DIEMQT, :DIEMCK, :DIEMTK)";
        }
        // DELETE
        public string giaovuDeleteDangKy()
        {
            return "DELETE FROM QLTRUONGHOC.DANGKY WHERE MASV = :MASV AND MAGV = :MAGV AND MAHP = :MAHP AND HK = :HK AND NAM = :NAM AND MACT = :MACT";
        }


        // TRUONGDONVI -> PHANCONG

        public string truongdonviInsertPhanCong()
        {
            return "INSERT INTO QLTRUONGHOC.PHANCONG (MAGV, MAHP, HK, NAM ,MACT) " +
                                 "VALUES (:MAGV, :MAHP,:HK,:NAM, :MACT)";
        }

        public string truongdonviUpdatePhanCongInfo()
        {
            return "UPDATE QLTRUONGHOC.PHANCONG SET HK = :HK, NAM = :NAM, MACT = :MACT " +
                            "WHERE MAGV = :MAGV AND MAHP = :MAHP";
        }

        // DELETE
        public string truongdonviDeletePhanCong()
        {
            return "DELETE FROM QLTRUONGHOC.PHANCONG WHERE MAGV = :MAGV AND MAHP = :MAHP AND HK = :HK AND NAM = :NAM AND MACT = :MACT";
        }


        // TRUONGKHOA -> PHANCONG

        // INSERT
        public string truongkhoaInsertPhanCong()
        {
            return "INSERT INTO QLTRUONGHOC.PHANCONG (MAGV, MAHP, HK, NAM ,MACT) " +
                                 "VALUES (:MAGV, :MAHP,:HK,:NAM, :MACT)";
        }

        // UPDATE
        public string truongkhoaUpdatePhanCongInfo()
        {
            return "UPDATE QLTRUONGHOC.PHANCONG SET HK = :HK, NAM = :NAM, MACT = :MACT " +
                            "WHERE MAGV = :MAGV AND MAHP = :MAHP";
        }

        // TRUONGKHOA -> NHANSU

        // INSERT
        public string truongkhoaInsertNhanSu()
        {
            return "INSERT INTO QLTRUONGHOC.NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP,DT, VAITRO, MADV) " +
                                 "VALUES (:MANV, :HOTEN,:PHAI,:NGSINH, :PHUCAP, :DT, :VAITRO,:MADV)";
        }

        // UPDATE
        public string truongkhoaUpdateNhanSu()
        {
            return "UPDATE QLTRUONGHOC.NHANSU SET HOTEN = :HOTEN, PHAI = :PHAI, NGSINH = :NGSINH, PHUCAP = :PHUCAP, DT = :DT, VAITRO = :VAITRO, MADV = :MADV " +
                                     "WHERE MANV = :MANV";
        }

        // DELETE
        public string truongdonviDeleteNhanSu()
        {
            return "DELETE FROM QLTRUONGHOC.NHANSU WHERE MANV = :MANV";
        }

        // SINHVIEN -> DANGKY

        // INSERT
        public string sinhvienInsertDKHP()
        {
            //return "INSERT INTO QLTRUONGHOC.NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP,DT, VAITRO, MADV) " +
            //                     "VALUES (:MANV, :HOTEN,:PHAI,:NGSINH, :PHUCAP, :DT, :VAITRO,:MADV)";
            return "INSERT INTO QLTRUONGHOC.DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT) VALUES ";
        }

        // DELETE
        public string sinhvienDeleteDKHP()
        {
            return "DELETE FROM QLTRUONGHOC.DANGKY WHERE MASV = :MASV AND MAGV = :MAGV AND MAHP = :MAHP AND HK = :HK AND NAM = :NAM AND MACT = :MACT";
        }

    }
}
