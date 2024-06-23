using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_application_project
{
    public class TruongKhoa: GiangVien
    {
        public void insertPhanCong(string connectionString, Query query, string magv, string mahp, int hk, int nam, string mact)
        {



            // Validate the inputs (optional)
            if (string.IsNullOrEmpty(magv) || string.IsNullOrEmpty(mahp) || hk == 0 || nam == 0 || string.IsNullOrEmpty(mact))
            {
                MessageBox.Show("Bạn phải điền đầy đủ các trường!");
                return;
            }

            // Create the insert query
            string insertQuery = query.truongkhoaInsertPhanCong();

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
                string oldMagv = row.Cells["OLD_MAGV"].Value.ToString(); // Giá trị MAGV ban đầu
                string mahp = row.Cells["MAHP"].Value.ToString();
                int hk = Convert.ToInt32(row.Cells["HK"].Value);
                int nam = Convert.ToInt32(row.Cells["NAM"].Value);

                string mact = row.Cells["MACT"].Value.ToString();

                // Create the update query

                string updateQuery = query.truongkhoaUpdatePhanCongInfo();
                try
                {
                    // Execute the update query
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        using (OracleCommand command = new OracleCommand(updateQuery, connection))
                        {
                            command.Parameters.Add(new OracleParameter("MAGV", magv));
                            command.Parameters.Add(new OracleParameter("OLD_MAGV", oldMagv)); // Thêm giá trị MAGV ban đầu vào câu lệnh cập nhật
                            command.Parameters.Add(new OracleParameter("MAHP", mahp));
                            command.Parameters.Add(new OracleParameter("HK", hk));
                            command.Parameters.Add(new OracleParameter("NAM", nam));
                            command.Parameters.Add(new OracleParameter("MACT", mact));

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

                string deleteQuery = query.truongkhoaDeletePhanCong();

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

        public void insertNhanSu(string connectionString, Query query, NhanVienCoBan nvcb)
        {
            // Validate the inputs (optional)
            if (string.IsNullOrEmpty(nvcb.manv) || string.IsNullOrEmpty(nvcb.hoten) || string.IsNullOrEmpty(nvcb.phai))
            {
                MessageBox.Show("Bạn hãy phải điền các trường bắt buộc sau  (Mã nhân viên, Họ tên, Phái).");
                return;
            }

            // Create the insert query
            string insertQuery = query.truongkhoaInsertNhanSu();

            // Execute the insert query
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand command = new OracleCommand(insertQuery, connection))
                    {
                        command.Parameters.Add(new OracleParameter("MANV", nvcb.manv));
                        command.Parameters.Add(new OracleParameter("HOTEN", nvcb.hoten));
                        command.Parameters.Add(new OracleParameter("PHAI", nvcb.phai));
                        command.Parameters.Add(new OracleParameter("NGSINH", nvcb.ngsinh));
                        command.Parameters.Add(new OracleParameter("PHUCAP", nvcb.phucap));
                        command.Parameters.Add(new OracleParameter("DT", nvcb.dt));
                        command.Parameters.Add(new OracleParameter("VAITRO", nvcb.vaitro));
                        command.Parameters.Add(new OracleParameter("MADV", nvcb.madv));
                        

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm sinh viên thành công!");
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
            }
        }

        public void updateNhanVienInfo(string connectionString, Query query, List<DataGridViewRow> modifiedRows)
        {
            // Loop through the modified rows and update the database
            foreach (DataGridViewRow row in modifiedRows)
            {
                // Get the values from the row
                string manv = row.Cells["MANV"].Value.ToString();
                string hoten = row.Cells["HOTEN"].Value.ToString();
                string phai = row.Cells["PHAI"].Value.ToString();
                DateTime ngsinh = Convert.ToDateTime(row.Cells["NGSINH"].Value);
                int phucap = Convert.ToInt32(row.Cells["PHUCAP"].Value);
                string dt = row.Cells["DT"].Value.ToString();
                string vaitro = row.Cells["VAITRO"].Value.ToString();
                string madv = row.Cells["MADV"].Value.ToString();
                


                // Create the update query
                string updateQuery = query.truongkhoaUpdateNhanSu();

                try
                {
                    // Execute the update query
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        using (OracleCommand command = new OracleCommand(updateQuery, connection))
                        {
                            
                            command.Parameters.Add(new OracleParameter("HOTEN", hoten));
                            command.Parameters.Add(new OracleParameter("PHAI", phai));
                            command.Parameters.Add(new OracleParameter("NGSINH", ngsinh));
                            command.Parameters.Add(new OracleParameter("PHUCAP", phucap));
                            command.Parameters.Add(new OracleParameter("DT", dt));
                            command.Parameters.Add(new OracleParameter("VAITRO", vaitro));
                            command.Parameters.Add(new OracleParameter("MADV", madv));
                            command.Parameters.Add(new OracleParameter("MANV", manv));

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cập nhật thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Không có hàng nào được cập nhật!");
                            }
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

        public void deleteNhanSuSelectedRow(string connectionString, Query query, List<DataGridViewRow> rowsToDelete)
        {
            // Perform the deletion
            foreach (DataGridViewRow row in rowsToDelete)
            {
                // Get the values from the row
                string manv = row.Cells["MANV"].Value.ToString();
                

                string deleteQuery = query.truongdonviDeleteNhanSu();

                try
                {
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        using (OracleCommand command = new OracleCommand(deleteQuery, connection))
                        {
                            command.Parameters.Add(new OracleParameter("MANV", manv));
                            

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
