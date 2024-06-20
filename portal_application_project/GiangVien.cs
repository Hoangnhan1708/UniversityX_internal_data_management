using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_application_project
{
    public class GiangVien : NhanVienCoBan
    {

        public void updateScore(string connectionString, Query query, List<DataGridViewRow> modifiedRows)
        {
            // Loop through the modified rows and update the database
            foreach (DataGridViewRow row in modifiedRows)
            {
                // Get the values from the row
                string masv = row.Cells["MASV"].Value.ToString();
                string magv = row.Cells["MAGV"].Value.ToString();
                string mahp = row.Cells["MAHP"].Value.ToString();
                int hk = Convert.ToInt32(row.Cells["HK"].Value);
                int nam = Convert.ToInt32(row.Cells["NAM"].Value);
                string mact = row.Cells["MACT"].Value.ToString();
                decimal diemth = Convert.ToDecimal(row.Cells["DIEMTH"].Value);
                decimal diemqt = Convert.ToDecimal(row.Cells["DIEMQT"].Value);
                decimal diemck = Convert.ToDecimal(row.Cells["DIEMCK"].Value);
                decimal diemtK = Convert.ToDecimal(row.Cells["DIEMTK"].Value);

                // Create the update query
                string updateQuery = query.giangvienUpdateScore();

                // Execute the update query
                try
                {
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        using (OracleCommand command = new OracleCommand(updateQuery, connection))
                        {
                            command.Parameters.Add(new OracleParameter("DIEMTH", diemth));
                            command.Parameters.Add(new OracleParameter("DIEMQT", diemqt));
                            command.Parameters.Add(new OracleParameter("DIEMCK", diemck));
                            command.Parameters.Add(new OracleParameter("DIEMTK", diemtK));
                            command.Parameters.Add(new OracleParameter("MASV", masv));
                            command.Parameters.Add(new OracleParameter("MAGV", magv));
                            command.Parameters.Add(new OracleParameter("MAHP", mahp));
                            command.Parameters.Add(new OracleParameter("HK", hk));
                            command.Parameters.Add(new OracleParameter("NAM", nam));
                            command.Parameters.Add(new OracleParameter("MACT", mact));

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                    }
                    MessageBox.Show("Đã cập nhật thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
        }
    }
}
