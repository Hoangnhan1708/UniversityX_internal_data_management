using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace portal_application_project
{
    public partial class New_User_Form : Form
    {
        private string connectionString;
        public New_User_Form(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_user_btn_Click(object sender, EventArgs e)
        {
            string username = textBox_addUser_username.Text;
            string password = textBox_addUser_password.Text;
            string confirmPassword = textBox_addUser_confirmPassword.Text;

            if (password == confirmPassword)
            {
                try
                {
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        connection.Open();

                        using (OracleCommand command = connection.CreateCommand())
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.CommandText = "P_CREATE_USER";

                            // Thêm tham số cho procedure
                            command.Parameters.Add("v_uname", OracleDbType.Varchar2).Value = username;
                            command.Parameters.Add("v_pass", OracleDbType.Varchar2).Value = password;

                            // Thực thi procedure
                            command.ExecuteNonQuery();

                            MessageBox.Show("Tạo user thành công!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp, vui lòng kiểm tra lại!");
            }
        }
    }
}
