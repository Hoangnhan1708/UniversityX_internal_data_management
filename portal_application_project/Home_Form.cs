using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace portal_application_project
{
    public partial class Home_Form : Form
    {

        private string connectionString;
        public Home_Form(string _connectionString)
        {

            InitializeComponent();
            this.connectionString = _connectionString;

        }

        private void Home_Form_Load(object sender, EventArgs e)
        {
            LoadDataHomeUsers();
            LoadDataHomeRoles();

        }

        private void LoadDataHomeUsers()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand("SELECT * FROM VIEW_ALL_USERS", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_home_users.DataSource = dataTable;

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
                    OracleCommand command = new OracleCommand("SELECT * FROM all_users", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_home_roles.DataSource = dataTable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void new_user_btn_Click(object sender, EventArgs e)
        {
            New_User_Form newUserForm = new New_User_Form();
            newUserForm.ShowDialog();
        }



        private void new_role_btn_Click(object sender, EventArgs e)
        {
            New_Role_Form newRoleForm = new New_Role_Form();
            newRoleForm.ShowDialog();
        }

        private void viewDetail_user_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_home_users.SelectedCells.Count == 1)
            {

                // Lấy cell hiện tại
                DataGridViewCell selectedCell = dataGridView_home_users.SelectedCells[0];

                if (selectedCell.OwningColumn.Name == "USERNAME")
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

                if (selectedCell.OwningColumn.Name == "USERNAME") // Thay thế thành ROLENAME
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
                    MessageBox.Show("Vui lòng chọn 1 tên user trong cột USERNAME để xem chi tiết!");
                }


            }
            else
            {
                // Không có cell nào được chọn
                MessageBox.Show("Vui lòng chọn 1 tên user trong cột USERNAME để xem chi tiết!");
            }
        }

        private void edit_user_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_home_users.SelectedCells.Count > 0)
            {

                // Lấy cell hiện tại
                DataGridViewCell selectedCell = dataGridView_home_users.SelectedCells[0];

                if (selectedCell.OwningColumn.Name == "USERNAME")
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

                if (selectedCell.OwningColumn.Name == "USERNAME")
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

                // Kiểm tra xem cell hiện tại có giá trị không
                if (selectedCell.Value != null)
                {
                    // Lấy giá trị của cell
                    object usernameSelected = selectedCell.Value;

                    DialogResult result = MessageBox.Show("Bạn có muốn xóa user " + usernameSelected.ToString() + " không?", "Xác nhận", MessageBoxButtons.YesNo);

                    // Kiểm tra kết quả
                    if (result == DialogResult.Yes)
                    {
                        // Người dùng đã chọn Yes
                        MessageBox.Show("Đã xóa thành công!");
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
                        // Người dùng đã chọn Yes
                        MessageBox.Show("Đã xóa thành công!");
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
    }

}
