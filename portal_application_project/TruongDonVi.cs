using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_application_project
{
    public class TruongDonVi : GiangVien
    {
        public void insertPhanCong(string connectionString, Query query, string magv, string mahp, int hk, int nam, string mact)
        {



            // Validate the inputs (optional)
            if (string.IsNullOrEmpty(magv) || string.IsNullOrEmpty(mahp) || hk == 0 || nam ==0 || string.IsNullOrEmpty(mact))
            {
                MessageBox.Show("Bạn phải điền đầy đủ các trường!");
                return;
            }

            // Create the insert query
            string insertQuery = query.truongdonviInsertPhanCong();

            // Execute the insert query
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand command = new OracleCommand(insertQuery, connection))
                    {
                        command.Parameters.Add(new OracleParameter("MAGV", magv));
                        command.Parameters.Add(new OracleParameter("MAHP", mahp));
                        command.Parameters.Add(new OracleParameter("HK", hk));
                        command.Parameters.Add(new OracleParameter("NAM", nam));
                        command.Parameters.Add(new OracleParameter("MACT", mact));

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm phân công thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không có hàng nào được thêm!");
                        }
                        
                        

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                MessageBox.Show("Thêm phân công thất bại, hãy thử lại!");
            }
        }

        public void updatePhanCongInfo(string connectionString, Query query, List<DataGridViewRow> modifiedRows)
        {
            // Loop through the modified rows and update the database
            foreach (DataGridViewRow row in modifiedRows)
            {

                // Get the values from the row
                string magv = row.Cells["MAGV"].Value.ToString();
                string mahp = row.Cells["MAHP"].Value.ToString();
                int hk = Convert.ToInt32(row.Cells["HK"].Value);
                int nam = Convert.ToInt32(row.Cells["NAM"].Value);

                string mact = row.Cells["MACT"].Value.ToString();

                // Create the update query

                string updateQuery = query.truongdonviUpdatePhanCongInfo();
                try
                {
                    // Execute the update query
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        using (OracleCommand command = new OracleCommand(updateQuery, connection))
                        {
                            command.Parameters.Add(new OracleParameter("HK", hk));
                            command.Parameters.Add(new OracleParameter("NAM", nam));
                            command.Parameters.Add(new OracleParameter("MACT", mact));
                            command.Parameters.Add(new OracleParameter("MAGV", magv));
                            command.Parameters.Add(new OracleParameter("MAHP", mahp));

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Đã cập nhật thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Không có hàng nào được cập nhật!");
                            }
                            connection.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }

        }

        public void deletePhanCongSelectedRow(string connectionString, Query query, List<DataGridViewRow> rowsToDelete)
        {
            // Perform the deletion
            foreach (DataGridViewRow row in rowsToDelete)
            {
                // Get the values from the row
                string magv = row.Cells["MAGV"].Value.ToString();
                string mahp = row.Cells["MAHP"].Value.ToString();
                int hk = Convert.ToInt32(row.Cells["HK"].Value);
                int nam = Convert.ToInt32(row.Cells["NAM"].Value);

                string mact = row.Cells["MACT"].Value.ToString();

                string deleteQuery = query.truongdonviDeletePhanCong();

                try
                {
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        using (OracleCommand command = new OracleCommand(deleteQuery, connection))
                        {
                            command.Parameters.Add(new OracleParameter("MAGV", magv));
                            command.Parameters.Add(new OracleParameter("MAHP", mahp));
                            command.Parameters.Add(new OracleParameter("HK", hk));
                            command.Parameters.Add(new OracleParameter("NAM", nam));
                            command.Parameters.Add(new OracleParameter("MACT", mact));

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Không có hàng nào được xóa!");
                            }
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
