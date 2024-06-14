using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_application_project
{
    public class SinhVien
    {
        public string masv;
        public string hoten;
        public string phai;
        public string ngsinh;
        public string dchi;
        public string dt;
        public string mact;
        public string manganh;
        public int sotctl;
        public int diemtbtl;

        public SinhVien()
        {
            masv = "";
            hoten = "";
            phai = "";
            ngsinh = "";
            dchi = "";
            dt = "";
            mact = "";
            manganh = "";
            sotctl = 0;
            diemtbtl = 0;
        }

        public void LoadThongTinSinhVien(string connectionString, Query query)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    OracleCommand command = new OracleCommand(query.getSinhVienInfo(masv), connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // Duyệt qua từng dòng trong DataTable và thêm vào DataGridView
                    int i = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        
                        hoten = row["HOTEN"].ToString();
                        phai = row["PHAI"].ToString();
                        ngsinh = row["NGSINH"].ToString();
                        dchi = row["DCHI"].ToString();
                        dt = row["DT"].ToString();
                        mact = row["MACT"].ToString();
                        manganh = row["MANGANH"].ToString();
                        sotctl = int.Parse(row["SOTCTL"].ToString());
                        diemtbtl = int.Parse(row["DTBTL"].ToString());
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public DataTable LoadFullTable(string connectionString, Query query, string tableName)
        {


            DataTable dataTable = new DataTable();
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand(query.getFullTableString(tableName), connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    adapter.Fill(dataTable);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dataTable;
        }

        public bool updatePhoneNumber(string connectionString, Query query, string newPhoneNumber)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = query.sinhvienUpdatePhoneNumber();
                    OracleCommand command = new OracleCommand(updateQuery, connection);
                    command.Parameters.Add(new OracleParameter("newPhoneNumber", newPhoneNumber));
                    command.Parameters.Add(new OracleParameter("masv", this.masv));

                    int rowsUpdated = command.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Số điện thoại đã được cập nhật thành công!");
                        return true;

                    }
                    else
                    {
                        MessageBox.Show("Thay đổi thất bại, hãy vui lòng thử lại!");
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }

        public bool updateAddress(string connectionString, Query query, string newAddress)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = query.sinhvienUpdateAddress();
                    OracleCommand command = new OracleCommand(updateQuery, connection);
                    command.Parameters.Add(new OracleParameter("newAddress", newAddress));
                    command.Parameters.Add(new OracleParameter("masv", this.masv));

                    int rowsUpdated = command.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Địa chỉ đã được cập nhật thành công!");
                        return true;

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại, hãy vui lòng thử lại!");
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return false;
        }
    }

    
}
