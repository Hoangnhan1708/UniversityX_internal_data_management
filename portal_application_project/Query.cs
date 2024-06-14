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

        public string getUserLoginString(string username, string password)
        {
            return "Data Source=localhost;User Id=" + username + ";Password=" + password + ";";
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


    }
}
