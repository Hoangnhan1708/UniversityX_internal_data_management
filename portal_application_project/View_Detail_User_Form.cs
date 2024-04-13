using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class View_Detail_User_Form : Form
    {
        private string username;
        private string connectionString;
        private string userID;
        private string status;
        private string roles;
        
        public View_Detail_User_Form(string username, string connectionString)
        {
            InitializeComponent();
            this.username = username;
            this.connectionString = connectionString;
        }

        private void View_Detail_User_Form_Load(object sender, EventArgs e)
        {
            LoadDataUserInfo();
            LoadDataSystemPrivileges();
            LoadDataObjectsPrivileges();
            LoadDataColumnsPrivileges();

        }

        private void LoadDataUserInfo()
        {

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand("SELECT * FROM V_DETAIL_USER_1 WHERE Name = '" + username + "'", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // Duyệt qua từng dòng trong DataTable và thêm vào DataGridView
                    int i = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        i++;
                        if (i >= 4)
                        {
                            roles = roles + ",...";
                            break;
                        }
                        userID = row["UserID"].ToString();

                        if (roles == null)
                        {
                            roles = roles + row["Role"].ToString();
                        }
                        else
                        {
                            roles = roles + ", " + row["Role"].ToString();
                        }

                        status = row["Status"].ToString();
                    }
                    label_username_heading.Text = username; 
                    label_userID.Text = userID;
                    label_name.Text = username;
                    label_status.Text = status;
                    
                    if (roles == "")
                    {
                        roles = "Have no roles to show";
                    }
                    
                    label_Role.Text = roles;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void LoadDataSystemPrivileges()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand("SELECT Privileges FROM V_DETAIL_USER_2 WHERE User_Name = '" + username + "'", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_user_system_privileges.DataSource = dataTable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadDataObjectsPrivileges()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand("SELECT Privilege,Object_Name,Type FROM V_DETAIL_USER_3 WHERE User_Name = '" + username + "'", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_user_object_privileges.DataSource = dataTable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadDataColumnsPrivileges()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand("SELECT Privilege,Column_Name,Table_Name FROM V_DETAIL_USER_4 WHERE User_Name = '" + username + "'", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_user_columns_privileges.DataSource = dataTable;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
