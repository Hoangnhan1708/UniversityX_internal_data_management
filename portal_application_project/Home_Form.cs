﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExecuteSQLFromFile;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace portal_application_project
{
    public partial class Home_Form : Form
    {

        private string connectionString;
        public Home_Form(string _connectionString)
        {

            InitializeComponent();
            this.connectionString = _connectionString;

            //string directoryPath = AppDomain.CurrentDomain.BaseDirectory;

            //// Lùi lại 3 thư mục cha từ đường dẫn thư mục hiện tại
            //for (int i = 0; i < 5; i++)
            //{
            //    directoryPath = Directory.GetParent(directoryPath).FullName;
            //}
            //MessageBox.Show(directoryPath);
            //// Kết hợp đường dẫn thư mục với tên file
            //string filePath = Path.Combine(directoryPath, "ora", "set_up.sql");
            //SQLFileExecutor executor = new SQLFileExecutor(this.connectionString);
            //executor.ExecuteSQLFromFile(filePath);


        }

        private void Home_Form_Load(object sender, EventArgs e)
        {
            LoadDataHomeUsers();
            LoadDataHomeRoles();
            LoadDataAuditTable();
            LoadDataFGATable();

        }

        private void LoadDataHomeUsers()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand("SELECT * FROM V_ALL_USERS", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_home_users.DataSource = dataTable;
                    connection.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        // Thiếu query
        private void LoadDataHomeRoles()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand("SELECT * FROM V_ALL_ROLES", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_home_roles.DataSource = dataTable;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadDataAuditTable()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand("SELECT USERNAME, OBJ_NAME, ACTION_NAME, SQL_TEXT, EXTENDED_TIMESTAMP FROM DBA_AUDIT_TRAIL", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    
                    dataGridView_audit.DataSource = dataTable;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadDataFGATable()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand("SELECT DB_USER, OBJECT_NAME, STATEMENT_TYPE, SQL_TEXT, EXTENDED_TIMESTAMP FROM DBA_FGA_AUDIT_TRAIL", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_fga.DataSource = dataTable;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void new_user_btn_Click(object sender, EventArgs e)
        {
            New_User_Form newUserForm = new New_User_Form(connectionString);
            newUserForm.ShowDialog();
        }


        private void new_role_btn_Click(object sender, EventArgs e)
        {
            New_Role_Form newRoleForm = new New_Role_Form(connectionString);
            newRoleForm.ShowDialog();
        }

        private void viewDetail_user_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_home_users.SelectedCells.Count == 1)
            {

                // Lấy cell hiện tại
                DataGridViewCell selectedCell = dataGridView_home_users.SelectedCells[0];


                if (selectedCell.OwningColumn.Name == "NAME")
                {
                    if (selectedCell.Value != null)
                    {
                        // Lấy giá trị của cell
                        object cellValue = selectedCell.Value;

                        View_Detail_User_Form viewDetailUserForm = new View_Detail_User_Form(cellValue.ToString(), connectionString);
                        viewDetailUserForm.ShowDialog();

                        // Sử dụng giá trị của cell
                        // Ví dụ: hiển thị giá trị trong một MessageBox
                        //MessageBox.Show("Giá trị của ô được chọn là: " + cellValue.ToString());
                    }
                    else
                    {
                        // Cell không có giá trị
                        MessageBox.Show("Ô được chọn không có giá trị.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 tên user trong cột USERNAME để xem chi tiết!");
                }


            }
            else
            {
                // Không có cell nào được chọn
                MessageBox.Show("Vui lòng chọn 1 tên user trong cột USERNAME để xem chi tiết!");
            }
        }

        private void viewDetail_role_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_home_roles.SelectedCells.Count == 1)
            {

                // Lấy cell hiện tại
                DataGridViewCell selectedCell = dataGridView_home_roles.SelectedCells[0];

                if (selectedCell.OwningColumn.Name == "ROLE_NAME") // Thay thế thành ROLENAME
                {
                    if (selectedCell.Value != null)
                    {
                        // Lấy giá trị của cell
                        object cellValue = selectedCell.Value;

                        View_Detail_Role_Form viewDetailRoleForm = new View_Detail_Role_Form(cellValue.ToString(), connectionString);
                        viewDetailRoleForm.ShowDialog();

                        // Sử dụng giá trị của cell
                        // Ví dụ: hiển thị giá trị trong một MessageBox
                        //MessageBox.Show("Giá trị của ô được chọn là: " + cellValue.ToString());
                    }
                    else
                    {
                        // Cell không có giá trị
                        MessageBox.Show("Ô được chọn không có giá trị.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 tên role trong cột ROLE_NAME để xem chi tiết!");
                }


            }
            else
            {
                // Không có cell nào được chọn
                MessageBox.Show("Vui lòng chọn 1 tên role trong cột ROLE_NAME để xem chi tiết!");
            }
        }

        private void edit_user_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_home_users.SelectedCells.Count > 0)
            {

                // Lấy cell hiện tại
                DataGridViewCell selectedCell = dataGridView_home_users.SelectedCells[0];

                if (selectedCell.OwningColumn.Name == "NAME")
                {
                    if (selectedCell.Value != null)
                    {
                        // Lấy giá trị của cell
                        object cellValue = selectedCell.Value;

                        Edit_User_Form editUserForm = new Edit_User_Form(cellValue.ToString(), connectionString);
                        editUserForm.ShowDialog();

                        // Sử dụng giá trị của cell
                        // Ví dụ: hiển thị giá trị trong một MessageBox
                        //MessageBox.Show("Giá trị của ô được chọn là: " + cellValue.ToString());
                    }
                    else
                    {
                        // Cell không có giá trị
                        MessageBox.Show("Ô được chọn không có giá trị.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 tên user trong cột USERNAME để chỉnh sửa user!");
                }


            }
            else
            {
                // Không có cell nào được chọn
                MessageBox.Show("Vui lòng chọn 1 tên user trong cột USERNAME để chỉnh sửa user!");
            }
        }

        private void edit_role_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_home_roles.SelectedCells.Count == 1)
            {

                // Lấy cell hiện tại
                DataGridViewCell selectedCell = dataGridView_home_roles.SelectedCells[0];

                if (selectedCell.OwningColumn.Name == "ROLE_NAME")
                {
                    if (selectedCell.Value != null)
                    {
                        // Lấy giá trị của cell
                        object cellValue = selectedCell.Value;

                        Edit_Role_Form editUserForm = new Edit_Role_Form(cellValue.ToString(), connectionString);
                        editUserForm.ShowDialog();

                        // Sử dụng giá trị của cell
                        // Ví dụ: hiển thị giá trị trong một MessageBox
                        //MessageBox.Show("Giá trị của ô được chọn là: " + cellValue.ToString());
                    }
                    else
                    {
                        // Cell không có giá trị
                        MessageBox.Show("Ô được chọn không có giá trị.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn 1 tên user trong cột USERNAME để chỉnh sửa user!");
                }


            }
            else
            {
                // Không có cell nào được chọn
                MessageBox.Show("Vui lòng chọn 1 tên user trong cột USERNAME để chỉnh sửa user!");
            }
        }

        private void drop_user_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_home_users.SelectedCells.Count > 0)
            {
                // Lấy cell hiện tại
                DataGridViewCell selectedCell = dataGridView_home_users.SelectedCells[0];

                if (selectedCell.OwningColumn.Name == "NAME")
                {
                    if (selectedCell.Value != null)
                    {
                        // Lấy giá trị của cell
                        object usernameSelected = selectedCell.Value;

                        DialogResult result = MessageBox.Show("Bạn có muốn xóa user " + usernameSelected.ToString() + " không?", "Xác nhận", MessageBoxButtons.YesNo);

                        // Kiểm tra kết quả
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                using (OracleConnection connection = new OracleConnection(connectionString))
                                {
                                    connection.Open();

                                    using (OracleCommand command = connection.CreateCommand())
                                    {
                                        command.CommandType = CommandType.StoredProcedure;
                                        command.CommandText = "P_DROP_USER";

                                        // Thêm tham số cho procedure
                                        command.Parameters.Add("v_uname", OracleDbType.Varchar2).Value = usernameSelected.ToString();


                                        // Thực thi procedure
                                        command.ExecuteNonQuery();

                                        MessageBox.Show("Xóa user thành công!");

                                    }
                                    connection.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                        }
                        else
                        {
                            // Người dùng đã chọn No hoặc đóng hộp thoại
                            MessageBox.Show("Xóa user " + usernameSelected.ToString() + " thất bại.");
                        }
                    }
                    else
                    {
                        // Cell không có giá trị
                        MessageBox.Show("Ô được chọn không có giá trị.");
                    }
                }


            }
            else
            {
                // Không có cell nào được chọn
                MessageBox.Show("Vui lòng chọn 1 tên user trong cột USERNAME để xóa user");
            }


        }

        private void drop_role_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_home_roles.SelectedCells.Count > 0)
            {
                // Lấy cell hiện tại
                DataGridViewCell selectedCell = dataGridView_home_roles.SelectedCells[0];

                // Kiểm tra xem cell hiện tại có giá trị không
                if (selectedCell.Value != null)
                {
                    // Lấy giá trị của cell
                    object rolenameSelected = selectedCell.Value;

                    DialogResult result = MessageBox.Show("Bạn có muốn xóa role " + rolenameSelected.ToString() + " không?", "Xác nhận", MessageBoxButtons.YesNo);

                    // Kiểm tra kết quả
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (OracleConnection connection = new OracleConnection(connectionString))
                            {
                                connection.Open();

                                using (OracleCommand command = connection.CreateCommand())
                                {
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.CommandText = "P_DROP_ROLE";

                                    // Thêm tham số cho procedure
                                    command.Parameters.Add("v_rolename", OracleDbType.Varchar2).Value = rolenameSelected.ToString();


                                    // Thực thi procedure
                                    command.ExecuteNonQuery();

                                    MessageBox.Show("Xóa role thành công!");
                                }
                                connection.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }

                    }
                    else
                    {
                        // Người dùng đã chọn No hoặc đóng hộp thoại
                        MessageBox.Show("Bạn đã hủy bỏ");
                    }
                }
                else
                {
                    // Cell không có giá trị
                    MessageBox.Show("Ô được chọn không có giá trị.");
                }
            }
            else
            {
                // Không có cell nào được chọn
                MessageBox.Show("Vui lòng chọn 1 tên user trong cột ROLENAME để xóa user");
            }
        }

        private void refresh_user_btn_Click(object sender, EventArgs e)
        {
            LoadDataHomeUsers();
        }

        private void refresh_role_btn_Click(object sender, EventArgs e)
        {
            LoadDataHomeRoles();
        }




        private void filer_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(filer_textBox.Text))
            {
                filer_textBox.Text = "Nhập tên người dùng...";
                filer_textBox.ForeColor = Color.Gray;
            }
        }

        private void filer_textBox_Enter(object sender, EventArgs e)
        {
            if (filer_textBox.Text == "Nhập tên người dùng...")
            {
                filer_textBox.Text = "";
                filer_textBox.ForeColor = Color.Black;
            }
        }

        private void Home_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand($"SELECT USERNAME, OBJ_NAME, ACTION_NAME, SQL_TEXT, EXTENDED_TIMESTAMP FROM DBA_AUDIT_TRAIL WHERE USERNAME = '{filer_textBox.Text.ToString()}'", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_audit.DataSource = dataTable;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void find_fga_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand($"SELECT DB_USER, OBJECT_NAME, STATEMENT_TYPE, SQL_TEXT, EXTENDED_TIMESTAMP FROM DBA_FGA_AUDIT_TRAIL WHERE DB_USER = '{filer_fga_textBox.Text.ToString()}'", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_fga.DataSource = dataTable;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void filer_fga_textBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(filer_fga_textBox.Text))
            {
                filer_fga_textBox.Text = "Nhập tên người dùng...";
                filer_fga_textBox.ForeColor = Color.Gray;
            }
        }

        private void filer_fga_textBox_Enter(object sender, EventArgs e)
        {
            if (filer_fga_textBox.Text == "Nhập tên người dùng...")
            {
                filer_fga_textBox.Text = "";
                filer_fga_textBox.ForeColor = Color.Black;
            }
        }
    }

}
