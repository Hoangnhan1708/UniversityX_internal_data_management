using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portal_application_project
{
    public class GiaoVu : NhanVienCoBan
    {
        public void insertSinhVien(string connectionString, Query query, SinhVien newSinhVien)
        {

            // Validate the inputs (optional)
            if (string.IsNullOrEmpty(newSinhVien.masv) || string.IsNullOrEmpty(newSinhVien.hoten) || string.IsNullOrEmpty(newSinhVien.phai))
            {
                MessageBox.Show("Bạn hãy phải điền các trường bắt buộc sau  (Mã sinh viên, Họ tên, Phái).");
                return;
            }

            // Create the insert query
            string insertQuery = query.giaovuInsertSinhVien();

            // Execute the insert query
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand command = new OracleCommand(insertQuery, connection))
                    {
                        command.Parameters.Add(new OracleParameter("MASV", newSinhVien.masv));
                        command.Parameters.Add(new OracleParameter("HOTEN", newSinhVien.hoten));
                        command.Parameters.Add(new OracleParameter("PHAI", newSinhVien.phai));
                        command.Parameters.Add(new OracleParameter("NGSINH", newSinhVien.ngsinh));
                        command.Parameters.Add(new OracleParameter("DCHI", newSinhVien.dchi));
                        command.Parameters.Add(new OracleParameter("DT", newSinhVien.dt));
                        command.Parameters.Add(new OracleParameter("MACT", newSinhVien.mact));
                        command.Parameters.Add(new OracleParameter("MANGANH", newSinhVien.manganh));
                        command.Parameters.Add(new OracleParameter("SOTCTL", newSinhVien.sotctl));
                        command.Parameters.Add(new OracleParameter("DTBTL", newSinhVien.diemtbtl));

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm sinh viên thành công!");
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        
        public void updateSinhVienInfo(string connectionString, Query query, List<DataGridViewRow> modifiedRows)
        {
            // Loop through the modified rows and update the database
            foreach (DataGridViewRow row in modifiedRows)
            {
                // Get the values from the row
                string masv = row.Cells["MASV"].Value.ToString();
                string hoten = row.Cells["HOTEN"].Value.ToString();
                string phai = row.Cells["PHAI"].Value.ToString();
                DateTime ngsinh = Convert.ToDateTime(row.Cells["NGSINH"].Value);
                string dchi = row.Cells["DCHI"].Value.ToString();
                string dt = row.Cells["DT"].Value.ToString();
                string mact = row.Cells["MACT"].Value.ToString();
                string manganh = row.Cells["MANGANH"].Value.ToString();
                int sotctl = Convert.ToInt32(row.Cells["SOTCTL"].Value);
                float dtbtl = Convert.ToSingle(row.Cells["DTBTL"].Value);


                // Create the update query
                string updateQuery = query.giaovuUpdateSinhVienInfo();

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
                            command.Parameters.Add(new OracleParameter("DCHI", dchi));
                            command.Parameters.Add(new OracleParameter("DT", dt));
                            command.Parameters.Add(new OracleParameter("MACT", mact));
                            command.Parameters.Add(new OracleParameter("MANGANH", manganh));
                            command.Parameters.Add(new OracleParameter("SOTCTL", sotctl));
                            command.Parameters.Add(new OracleParameter("DTBTL", dtbtl));
                            command.Parameters.Add(new OracleParameter("MASV", masv));

                            connection.Open();
                            command.ExecuteNonQuery();
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

        public void insertDonVi(string connectionString, Query query ,string madv, string tendv, string truongdonvi)
        {
           


            // Validate the inputs (optional)
            if (string.IsNullOrEmpty(madv) || string.IsNullOrEmpty(tendv))
            {
                MessageBox.Show("Bạn hãy phải điền các trường bắt buộc sau (Mã đơn vị, tên đơn vị).");
                return;
            }

            // Create the insert query
            string insertQuery = query.giaovuInsertDonVi();

            // Execute the insert query
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand command = new OracleCommand(insertQuery, connection))
                    {
                        command.Parameters.Add(new OracleParameter("MADV", madv));
                        command.Parameters.Add(new OracleParameter("TENDV", tendv));
                        command.Parameters.Add(new OracleParameter("TRGDV", truongdonvi));


                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm đơn vị thành công!");
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                MessageBox.Show("Thêm đơn vị thất bại, hãy thử lại!");
            }
        }

        public void updateDonViInfo(string connectionString, Query query, List<DataGridViewRow> modifiedRows)
        {
            // Loop through the modified rows and update the database
            foreach (DataGridViewRow row in modifiedRows)
            {
                // Get the values from the row
                string madv = row.Cells["MADV"].Value.ToString();
                string tendv = row.Cells["TENDV"].Value.ToString();
                string trgdv = row.Cells["TRGDV"].Value.ToString();
                

                // Create the update query
                string updateQuery = query.giaovuUpdateDonViInfo();

                try
                {
                    // Execute the update query
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        using (OracleCommand command = new OracleCommand(updateQuery, connection))
                        {
                            command.Parameters.Add(new OracleParameter("TENDV", tendv));
                            command.Parameters.Add(new OracleParameter("TRGDV", trgdv));
                            command.Parameters.Add(new OracleParameter("MADV", madv));

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

        public void insertHocPhan(string connectionString, Query query, string mahp, string tenhp, int sotc, int stlt, int stth, int ssvtd, string madv)
        {



            // Validate the inputs (optional)
            if (string.IsNullOrEmpty(mahp) || string.IsNullOrEmpty(tenhp))
            {
                MessageBox.Show("Bạn hãy phải điền các trường bắt buộc sau (Mã học phần, tên học phần).");
                return;
            }

            // Create the insert query
            string insertQuery = query.giaovuInsertHocPhan();

            // Execute the insert query
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand command = new OracleCommand(insertQuery, connection))
                    {
                        command.Parameters.Add(new OracleParameter("MAHP", mahp));
                        command.Parameters.Add(new OracleParameter("TENHP", tenhp));
                        command.Parameters.Add(new OracleParameter("SOTC", sotc));
                        command.Parameters.Add(new OracleParameter("STLT", stlt));
                        command.Parameters.Add(new OracleParameter("STTH", stth));
                        command.Parameters.Add(new OracleParameter("SOSVTD", ssvtd));
                        command.Parameters.Add(new OracleParameter("MADV", madv));

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm học phần thành công!");
                        connection.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                MessageBox.Show("Thêm học phần thất bại, hãy thử lại!");
            }
        }

        public void updateHocPhanInfo(string connectionString, Query query, List<DataGridViewRow> modifiedRows)
        {
            // Loop through the modified rows and update the database
            foreach (DataGridViewRow row in modifiedRows)
            {

                // Get the values from the row
                string mahp = row.Cells["MAHP"].Value.ToString();
                string tenhp = row.Cells["TENHP"].Value.ToString();
                
                int soct = Convert.ToInt32(row.Cells["SOTC"].Value);
                int stlt = Convert.ToInt32(row.Cells["STLT"].Value);
                int stth = Convert.ToInt32(row.Cells["STTH"].Value);
                int sosvtd = Convert.ToInt32(row.Cells["SOSVTD"].Value);
                string madv = row.Cells["MADV"].Value.ToString();

                // Create the update query
                
                string updateQuery = query.giaovuUpdateHocPhanInfo();
                try
                {
                    // Execute the update query
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        using (OracleCommand command = new OracleCommand(updateQuery, connection))
                        {
                            command.Parameters.Add(new OracleParameter("TENHP", tenhp));
                            command.Parameters.Add(new OracleParameter("SOTC", soct));
                            command.Parameters.Add(new OracleParameter("STLT", stlt));
                            command.Parameters.Add(new OracleParameter("STTH", stth));
                            command.Parameters.Add(new OracleParameter("SOSVTD", sosvtd));
                            command.Parameters.Add(new OracleParameter("MADV", madv));
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
                                MessageBox.Show("Không có hàng nào được cập nhật.");
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

        public void insertKHMO(string connectionString, Query query, string mahp, int hk, int nam, string mact)
        {



            // Validate the inputs (optional)
            if (string.IsNullOrEmpty(mahp) || hk == 0 || nam == 0 || string.IsNullOrEmpty(mact))
            {
                MessageBox.Show("Bạn hãy phải điền các trường bắt buộc sau (Mã học phần, học kỳ, năm học, mã chương trình).");
                return;
            }

            // Create the insert query
            string insertQuery = query.giaovuInsertKHMO();

            // Execute the insert query
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand command = new OracleCommand(insertQuery, connection))
                    {
                        command.Parameters.Add(new OracleParameter("MAHP", mahp));
                        command.Parameters.Add(new OracleParameter("HK", hk));
                        command.Parameters.Add(new OracleParameter("NAM", nam));
                        command.Parameters.Add(new OracleParameter("MACT", mact));
                        

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm kế hoạch mở học phần thành công!");
                        connection.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                MessageBox.Show("Thêm học phần thất bại, hãy thử lại!");
            }
        }

        public void updateKHMOInfo(string connectionString, Query query, List<DataGridViewRow> modifiedRows)
        {
            // Loop through the modified rows and update the database
            foreach (DataGridViewRow row in modifiedRows)
            {

                // Get the values from the row
                string mahp = row.Cells["MAHP"].Value.ToString();
                int hk = Convert.ToInt32(row.Cells["HK"].Value);
                int nam = Convert.ToInt32(row.Cells["NAM"].Value);
              
                string mact = row.Cells["MACT"].Value.ToString();

                // Create the update query

                string updateQuery = query.giaovuUpdateKHMOInfo();
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
                                MessageBox.Show("Không có hàng nào được cập nhật.");
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

        // Chưa cập nhật được do vi phạm khóa ngoại của PHANCONG-DANGKY
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

                string updateQuery = query.giaovuUpdatePhanCongInfo();
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
                            command.Parameters.Add(new OracleParameter("MAHP", mahp));
                            command.Parameters.Add(new OracleParameter("MAHP", magv));

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


        public void insertDangKy(string connectionString, Query query, string masv, string magv, string mahp, int hk, int nam, string mact, float diemth, float diemqt, float diemck, float diemtk)
        {



            // Validate the inputs (optional)
            if (string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(magv) || string.IsNullOrEmpty(mahp) || hk == 0 || nam == 0 || string.IsNullOrEmpty(mact))
            {
                MessageBox.Show("Bạn hãy phải điền các trường bắt buộc sau (Mã sinh viên, mã giảng viên, mã học phần, học kỳ, năm học, mã chương trình).");
                return;
            }

            // Create the insert query
            string insertQuery = query.giaovuInsertDangKy();

            // Execute the insert query
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    using (OracleCommand command = new OracleCommand(insertQuery, connection))
                    {
                        command.Parameters.Add(new OracleParameter("MASV", masv));
                        command.Parameters.Add(new OracleParameter("MAGV", magv));
                        command.Parameters.Add(new OracleParameter("MAHP", mahp));
                        command.Parameters.Add(new OracleParameter("HK", hk));
                        command.Parameters.Add(new OracleParameter("NAM", nam));
                        command.Parameters.Add(new OracleParameter("MACT", mact));
                        command.Parameters.Add(new OracleParameter("DIEMTH", diemth));
                        command.Parameters.Add(new OracleParameter("DIEMQT", diemqt));
                        command.Parameters.Add(new OracleParameter("DIEMCK", diemck));
                        command.Parameters.Add(new OracleParameter("DIEMTK", diemtk));
                        


                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm đăng ký thành công!");
                        connection.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                MessageBox.Show("Thêm đăng ký thất bại, hãy thử lại!");
            }
        }

        public void deleteDangKySelectedRow(string connectionString, Query query, List<DataGridViewRow> rowsToDelete)
        {
            // Perform the deletion
            foreach (DataGridViewRow row in rowsToDelete)
            {
                string masv = row.Cells["MASV"].Value.ToString();
                string magv = row.Cells["MAGV"].Value.ToString();
                string mahp = row.Cells["MAHP"].Value.ToString();
                int hk = Convert.ToInt32(row.Cells["HK"].Value);
                int nam = Convert.ToInt32(row.Cells["NAM"].Value);
                string mact = row.Cells["MACT"].Value.ToString();

                string deleteQuery = query.giaovuDeleteDangKy();

                try
                {
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        using (OracleCommand command = new OracleCommand(deleteQuery, connection))
                        {
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
