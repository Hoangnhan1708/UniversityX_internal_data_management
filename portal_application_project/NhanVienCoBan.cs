using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace portal_application_project
{
    public class NhanVienCoBan
    {
        public string manv;
        public string hoten;
        public string phai;
        public DateTime ngsinh;
        public int phucap;
        public string dt;
        public string vaitro;
        public string madv;

        public NhanVienCoBan() {
            manv = "";
            hoten = "";
            phai = "";
            ngsinh = DateTime.Now;
            phucap = 0;
            dt = "";
            vaitro = "";
            madv = "";

        }

        public void LoadThongTinUser(string connectionString, Query query)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    
                    OracleCommand command = new OracleCommand(query.getUserInfo(manv), connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // Duyệt qua từng dòng trong DataTable và thêm vào DataGridView
                    int i = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        hoten = row["HOTEN"].ToString();
                        phai = row["PHAI"].ToString();
                        ngsinh = Convert.ToDateTime(row["NGSINH"]);

                        phucap = int.Parse(row["PHUCAP"].ToString());
                        dt = row["DT"].ToString();
                        vaitro = row["VAITRO"].ToString();
                        madv = row["MADV"].ToString();

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

                    string updateQuery = query.nhanvienUpdatePhoneNumber();
                    OracleCommand command = new OracleCommand(updateQuery, connection);
                    command.Parameters.Add(new OracleParameter("newPhoneNumber", newPhoneNumber));
                    command.Parameters.Add(new OracleParameter("manv", this.manv));

                    int rowsUpdated = command.ExecuteNonQuery();

                    if (rowsUpdated > 0)
                    {
                        MessageBox.Show("Số điện thoại đã được cập nhật thành công!");
                        return true;
                        
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên để cập nhật.");
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
