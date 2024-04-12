using Oracle.ManagedDataAccess.Client;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace portal_application_project
{
    public partial class Login_Form : Form
    {
        private string connectionString;

        public Login_Form()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_login_username.Text;
            string password = textBox_login_password.Text;

            connectionString = "Data Source=localhost;User Id=" + username + ";Password=" + password + ";DBA Privilege=SYSDBA;";


            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    Home_Form homeForm = new Home_Form(connectionString);
                    homeForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: username/password login denied or username is not dba");
            }


            //// Xác thực tên người dùng và mật khẩu (thay thế phần logic này bằng cơ chế xác thực thực tế)
            //if (username == "sys" && password == "123")
            //{
            //    MessageBox.Show("Đăng nhập thành công!");
            //    // Mở form chính (Home_Form)

            //    Home_Form homeForm = new Home_Form();
            //    homeForm.Show();
            //    // Đóng form đăng nhập
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Tên người dùng hoặc mật khẩu không hợp lệ. Vui lòng thử lại.");
            //}
        }


    }
}