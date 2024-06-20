using ExecuteSQLFromFile;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Linq.Expressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace portal_application_project
{
    public partial class Login_Form : Form
    {
        private string connectionString;
        private Query query;
        public Login_Form()
        {
            InitializeComponent();
            user_checkbox.Checked = true;
            query = new Query();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_login_username.Text;
            string password = textBox_login_password.Text;
            string[] roles = new string[10]; // temp

            if (admin_checkbox.Checked)
            {
                connectionString = query.getAdminLoginString(username, password);
                try
                {
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {
                        connection.Open();
                        Home_Form homeForm = new Home_Form(connectionString);
                        homeForm.Show();
                        this.Hide();
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: username/password login denied or username is not dba");
                }
            }

            else
            {
                connectionString = query.getUserLoginString(username, password);
                try
                {
                    using (OracleConnection connection = new OracleConnection(connectionString))
                    {

                        connection.Open();

                        OracleCommand command = new OracleCommand(query.getUserRoles(), connection);
                        OracleDataReader reader = command.ExecuteReader();

                        int role_flag = 0;

                        while (reader.Read())
                        {
                            int i = 0;
                            string role = reader.GetString(0);
                            
                            roles[i] = role;
                            i++;
                        }
                        reader.Close();
                        connection.Close();

                        for (int i = 0; i < roles.Length; i++)
                        {
                            if (roles[i].Equals("SINHVIEN", StringComparison.OrdinalIgnoreCase))
                            {
                                role_flag = 6;
                                break;
                            }

                            if (roles[i].Equals("TRUONGKHOA", StringComparison.OrdinalIgnoreCase))
                            {
                                role_flag = 5;
                                break;
                            }

                            if (roles[i].Equals("TRUONGDONVI", StringComparison.OrdinalIgnoreCase))
                            {
                                role_flag = 4;
                                break;
                            }

                            if (roles[i].Equals("GIAOVU", StringComparison.OrdinalIgnoreCase))
                            {
                                role_flag = 3;
                                break;
                            }

                            if (roles[i].Equals("GIANGVIEN", StringComparison.OrdinalIgnoreCase))
                            {
                                role_flag = 2;
                                break;
                            }

                            if (roles[i].Equals("NHANVIEN", StringComparison.OrdinalIgnoreCase))
                            {
                                
                                role_flag = 1;
                                break;
                            }
                        }

                        switch (role_flag)
                        {
                            case 1:


                                NVCB_Form NVCB_Form = new NVCB_Form(connectionString, username);
                                NVCB_Form.Show();
                                break;
                            case 2:
                                GiangVien_Form GiangVien_Form = new GiangVien_Form(connectionString, username);
                                GiangVien_Form.Show();
                                break;
                            case 3:
                                GiaoVu_Form GiaoVu_Form = new GiaoVu_Form(connectionString, username);
                                GiaoVu_Form.Show();
                                break;
                            case 4:
                                TruongDonVi_Form TruongDonVi_Form = new TruongDonVi_Form(connectionString, username);
                                TruongDonVi_Form.Show();
                                break;
                            case 5:
                                TruongKhoa_Form TruongKhoa_Form = new TruongKhoa_Form(connectionString, username);
                                TruongKhoa_Form.Show();
                                break;
                            case 6:
                                SinhVien_Form SinhVien_Form = new SinhVien_Form(connectionString, username);
                                SinhVien_Form.Show();
                                break;
                            default:
                                MessageBox.Show("Error: User does not have NVCB role");
                                break;
                        }


                        this.Hide();
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: User does not have NVCB role");
                }

            }
        }

        private void admin_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (admin_checkbox.Checked)
            {
                user_checkbox.Checked = false;
            }
        }

        private void user_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (user_checkbox.Checked)
            {
                admin_checkbox.Checked = false;
            }
        }
    }
}