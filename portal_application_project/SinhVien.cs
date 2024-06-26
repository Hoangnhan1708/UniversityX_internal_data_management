﻿using Oracle.ManagedDataAccess.Client;
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
        public DateTime ngsinh;
        public string dchi;
        public string dt;
        public string mact;
        public string manganh;
        public int sotctl;
        public float diemtbtl;

        public SinhVien()
        {
            masv = "";
            hoten = "";
            phai = "";
            ngsinh = DateTime.Now;
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
                        ngsinh = Convert.ToDateTime(row["NGSINH"]);
                        dchi = row["DCHI"].ToString();
                        dt = row["DT"].ToString();
                        mact = row["MACT"].ToString();
                        manganh = row["MANGANH"].ToString();
                        sotctl = Convert.ToInt32(row["SOTCTL"].ToString());
                        diemtbtl = Convert.ToSingle(row["DTBTL"].ToString());
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

        public void insertDangKySelectedRow(string connectionString, Query query, List<DataGridViewRow> rowsToHandle)
        {
            string insertQuery = query.sinhvienInsertDKHP();

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(insertQuery, connection))
                    {
                        command.ArrayBindCount = rowsToHandle.Count;

                        // Prepare parameters
                        command.Parameters.Add(":MASV", OracleDbType.Varchar2);
                        command.Parameters.Add(":MAGV", OracleDbType.Varchar2);
                        command.Parameters.Add(":MAHP", OracleDbType.Varchar2);
                        command.Parameters.Add(":HK", OracleDbType.Int32);
                        command.Parameters.Add(":NAM", OracleDbType.Int32);
                        command.Parameters.Add(":MACT", OracleDbType.Varchar2);

                        // Populate parameter values
                        string[] masvArray = new string[rowsToHandle.Count];
                        string[] magvArray = new string[rowsToHandle.Count];
                        string[] mahpArray = new string[rowsToHandle.Count];
                        int[] hkArray = new int[rowsToHandle.Count];
                        int[] namArray = new int[rowsToHandle.Count];
                        string[] mactArray = new string[rowsToHandle.Count];

                        for (int i = 0; i < rowsToHandle.Count; i++)
                        {
                            DataGridViewRow row = rowsToHandle[i];
                            masvArray[i] = this.masv;
                            magvArray[i] = row.Cells["MAGV"].Value.ToString();
                            mahpArray[i] = row.Cells["MAHP"].Value.ToString();
                            hkArray[i] = Convert.ToInt32(row.Cells["HK"].Value);
                            namArray[i] = Convert.ToInt32(row.Cells["NAM"].Value);
                            mactArray[i] = row.Cells["MACT"].Value.ToString();
                        }

                        command.Parameters[":MASV"].Value = masvArray;
                        command.Parameters[":MAGV"].Value = magvArray;
                        command.Parameters[":MAHP"].Value = mahpArray;
                        command.Parameters[":HK"].Value = hkArray;
                        command.Parameters[":NAM"].Value = namArray;
                        command.Parameters[":MACT"].Value = mactArray;

                        int rowsAffected = command.ExecuteNonQuery();

                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm thành công!");
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
                MessageBox.Show("Error: " + ex.Message);
            }
            

        }

        public void deleteDangKySelectedRow(string connectionString, Query query, List<DataGridViewRow> rowsToDelete)
        {
            // Perform the deletion
            foreach (DataGridViewRow row in rowsToDelete)
            {
                string masv = row.Cells["MASV"].Value.ToString();
                //string masv = this.masv;
                string magv = row.Cells["MAGV"].Value.ToString();
                string mahp = row.Cells["MAHP"].Value.ToString();
                int hk = Convert.ToInt32(row.Cells["HK"].Value);
                int nam = Convert.ToInt32(row.Cells["NAM"].Value);
                string mact = row.Cells["MACT"].Value.ToString();

                string deleteQuery = query.sinhvienDeleteDKHP();

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
