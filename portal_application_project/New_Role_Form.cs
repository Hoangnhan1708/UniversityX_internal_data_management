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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace portal_application_project
{
    public partial class New_Role_Form : Form
    {
        private string connectionString;
        public New_Role_Form(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_role_btn_Click(object sender, EventArgs e)
        {
            string newRoleName = textBox_addRole_roleName.Text;

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();

                    using (OracleCommand command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.CommandText = "P_CREATE_ROLE";

                        // Thêm tham số cho procedure
                        command.Parameters.Add("v_rolename", OracleDbType.Varchar2).Value = newRoleName;
                        

                        // Thực thi procedure
                        command.ExecuteNonQuery();

                        MessageBox.Show("Tạo Role thành công!");
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
