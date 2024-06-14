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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace portal_application_project
{
    public partial class View_Detail_Role_Form : Form
    {
        private string roleName;
        private string connectionString;
        private string roleID;
        private string passwordRequired;
        private string inherited;
        public View_Detail_Role_Form(string roleName, string connectionString)
        {
            InitializeComponent();
            this.roleName = roleName;
            this.connectionString = connectionString;
        }

        private void View_Detail_Role_Form_Load(object sender, EventArgs e)
        {
            LoadDataRoleInfo();
            LoadDataSystemPrivileges();
            LoadDataObjectsPrivileges();
            LoadDataColumnsPrivileges();
        }

        private void LoadDataRoleInfo()
        {

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand("SELECT * FROM V_DETAIL_ROLES_1 WHERE Role = '" + roleName + "'", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // Duyệt qua từng dòng trong DataTable và thêm vào DataGridView

                    label_roleName_heading.Text = roleName;
                    label_roleID.Text = dataTable.Rows[0]["RoleID"].ToString();
                    label_roleName.Text = roleName;
                    label_passwordRequired.Text = dataTable.Rows[0]["Password"].ToString();
                    label_inherited.Text = dataTable.Rows[0]["Inherited"].ToString();

                    connection.Close();
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
                    OracleCommand command = new OracleCommand($"SELECT PRIVILEGES FROM V_DETAIL_ROLES_2 WHERE Role_Name = '{roleName}'", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_role_system_privileges.DataSource = dataTable;
                    connection.Close();
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
                    OracleCommand command = new OracleCommand($"SELECT Privilege,Object_Name,Type FROM V_DETAIL_ROLES_3 WHERE Role_Name = '{roleName}'", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_role_object_privileges.DataSource = dataTable;
                    connection.Close();
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
                    OracleCommand command = new OracleCommand($"SELECT Privilege,Column_Name,Table_Name FROM V_DETAIL_ROLES_4 WHERE Role_Name = '{roleName}'", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_role_columns_privileges.DataSource = dataTable;
                    connection.Close();
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
