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
    public partial class Edit_User_Form : Form
    {
        string username;
        string connectionString;
        public Edit_User_Form(string username, string connectionString)
        {
            InitializeComponent();
            this.username = username;
            this.connectionString = connectionString;
            label_roleName_heading.Text = "Edit User " + this.username;
        }

        private void Edit_User_Form_Load(object sender, EventArgs e)
        {
            // Granted roles tab
            InitializeDataGridViewGrantedRoles();
            LoadDataGrantedRoles();

            // System Privileges
            InitializeDataGridViewSystemPrivileges();
            LoadDataSystemPrivileges();

            // Object Privileges
            InitializeDataGridViewObjectPrivileges();
            LoadDataObjectPrivileges();

            // Column privileges
            InitializeDataGridViewColumnPrivileges();
            LoadDataColumnPrivileges();
        }

        private void InitializeDataGridViewGrantedRoles()
        {
            // Tạo cột đầu tiên với tên "RoleName"
            DataGridViewTextBoxColumn roleNameColumn = new DataGridViewTextBoxColumn();
            roleNameColumn.HeaderText = "ROLENAME";
            roleNameColumn.Name = "ROLENAME";
            dataGridView_granted_roles.Columns.Add(roleNameColumn);

            // Tạo cột thứ hai và thứ ba là checkbox
            DataGridViewCheckBoxColumn grantedColumn = new DataGridViewCheckBoxColumn();
            grantedColumn.HeaderText = "GRANTED";
            grantedColumn.Name = "GRANTED";
            dataGridView_granted_roles.Columns.Add(grantedColumn);

            DataGridViewCheckBoxColumn adminColumn = new DataGridViewCheckBoxColumn();
            adminColumn.HeaderText = "ADMIN";
            adminColumn.Name = "ADMIN";
            dataGridView_granted_roles.Columns.Add(adminColumn);
        }

        private void LoadDataGrantedRoles()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    string query = "SELECT role FROM V_DETAIL_USER_1"; // Thay thế ROLENAME tại đây
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string roleName = reader["role"].ToString(); // Thay thế ROLENAME tại đây
                            // Thêm dòng mới với roleName vào cột đầu tiên
                            dataGridView_granted_roles.Rows.Add(roleName);
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InitializeDataGridViewSystemPrivileges()
        {
            // Tạo cột đầu tiên với tên "PRIVILEGES"
            DataGridViewTextBoxColumn privilegesColumn = new DataGridViewTextBoxColumn();
            privilegesColumn.HeaderText = "PRIVILEGES";
            privilegesColumn.Name = "PRIVILEGES";
            dataGridView_system_privileges.Columns.Add(privilegesColumn);

            // Tạo cột thứ hai và thứ ba là checkbox
            DataGridViewCheckBoxColumn grantedColumn = new DataGridViewCheckBoxColumn();
            grantedColumn.HeaderText = "GRANTED";
            grantedColumn.Name = "GRANTED";
            dataGridView_system_privileges.Columns.Add(grantedColumn);

            DataGridViewCheckBoxColumn withGrantOptionColumn = new DataGridViewCheckBoxColumn();
            withGrantOptionColumn.HeaderText = "WITH GRANT OPTION";
            withGrantOptionColumn.Name = "WITH_GRANT_OPTION_SYSTEM";
            dataGridView_system_privileges.Columns.Add(withGrantOptionColumn);
        }

        private void LoadDataSystemPrivileges()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    string query = "SELECT username FROM all_users"; // Thay thế PRIVILEGES tại đây
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string privilege = reader["username"].ToString(); // Thay thế PRIVILEGES tại đây
                            // Thêm dòng mới với roleName vào cột đầu tiên
                            dataGridView_system_privileges.Rows.Add(privilege);
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InitializeDataGridViewObjectPrivileges()
        {
            // Tạo cột đầu tiên với tên "PRIVILEGES"
            DataGridViewTextBoxColumn objectColumn = new DataGridViewTextBoxColumn();
            objectColumn.HeaderText = "OBJECT";
            objectColumn.Name = "OBJECT";
            dataGridView_object_privileges.Columns.Add(objectColumn);

            // Tạo cột 2 với tên "TYPE"
            DataGridViewTextBoxColumn typeColumn = new DataGridViewTextBoxColumn();
            typeColumn.HeaderText = "TYPE";
            typeColumn.Name = "TYPE";
            dataGridView_object_privileges.Columns.Add(typeColumn);

            // Tạo các cột còn lại là checkbox
            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "SELECT";
            selectColumn.Name = "SELECT";
            dataGridView_object_privileges.Columns.Add(selectColumn);

            DataGridViewCheckBoxColumn updateColumn = new DataGridViewCheckBoxColumn();
            updateColumn.HeaderText = "UPDATE";
            updateColumn.Name = "UPDATE";
            dataGridView_object_privileges.Columns.Add(updateColumn);

            DataGridViewCheckBoxColumn deleteColumn = new DataGridViewCheckBoxColumn();
            deleteColumn.HeaderText = "DELETE";
            deleteColumn.Name = "DELETE";
            dataGridView_object_privileges.Columns.Add(deleteColumn);

            DataGridViewCheckBoxColumn insertColumn = new DataGridViewCheckBoxColumn();
            insertColumn.HeaderText = "INSERT";
            insertColumn.Name = "INSERT";
            dataGridView_object_privileges.Columns.Add(insertColumn);

            DataGridViewCheckBoxColumn executeColumn = new DataGridViewCheckBoxColumn();
            executeColumn.HeaderText = "EXECUTE";
            executeColumn.Name = "EXECUTE";
            dataGridView_object_privileges.Columns.Add(executeColumn);

            DataGridViewCheckBoxColumn indexColumn = new DataGridViewCheckBoxColumn();
            indexColumn.HeaderText = "INDEX";
            indexColumn.Name = "INDEX";
            dataGridView_object_privileges.Columns.Add(indexColumn);

            DataGridViewCheckBoxColumn withGrantOptionColumn = new DataGridViewCheckBoxColumn();
            withGrantOptionColumn.HeaderText = "WITH GRANT OPTION";
            withGrantOptionColumn.Name = "WITH_GRANT_OPTION_OBJECT";
            dataGridView_object_privileges.Columns.Add(withGrantOptionColumn);
        }

        private void LoadDataObjectPrivileges()
        {
            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    // load cột Object
                    string query = "SELECT username,user_id FROM all_users"; // Thay thế OBJECT tại đây
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string _object = reader["username"].ToString(); // Thay thế OBJECT tại đây
                            string type = reader["user_id"].ToString(); // Thay thế OBJECT tại đây
                            // Thêm dòng mới với roleName vào cột đầu tiên
                            dataGridView_object_privileges.Rows.Add(_object, type);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InitializeDataGridViewColumnPrivileges()
        {
            // Tạo cột TABLENAME
            DataGridViewTextBoxColumn tableColumn = new DataGridViewTextBoxColumn();
            tableColumn.HeaderText = "TABLE";
            tableColumn.Name = "TABLE";
            dataGridView_column_privileges.Columns.Add(tableColumn);

            // Tạo cột COLUMN
            DataGridViewTextBoxColumn columnColumn = new DataGridViewTextBoxColumn();
            columnColumn.HeaderText = "COLUMN";
            columnColumn.Name = "COLUMN";
            dataGridView_column_privileges.Columns.Add(columnColumn);

            // Tạo cột SELECT (Checkbox)
            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "SELECT";
            selectColumn.Name = "SELECT";
            dataGridView_column_privileges.Columns.Add(selectColumn);

            DataGridViewCheckBoxColumn updateColumn = new DataGridViewCheckBoxColumn();
            updateColumn.HeaderText = "UPDATE";
            updateColumn.Name = "UPDATE";
            dataGridView_column_privileges.Columns.Add(updateColumn);

            DataGridViewCheckBoxColumn withGrantOptionColumn = new DataGridViewCheckBoxColumn();
            withGrantOptionColumn.HeaderText = "WITH GRANT OPTION";
            withGrantOptionColumn.Name = "WITH_GRANT_OPTION_COLUMN";
            dataGridView_column_privileges.Columns.Add(withGrantOptionColumn);
        }

        private void LoadDataColumnPrivileges()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    // Load dữ liệu từ truy vấn SQL
                    string query = "SELECT username,user_id FROM all_users"; // Thay thế TABLENAME, COLUMN tại đây
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open();
                        OracleDataAdapter adapter = new OracleDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Duyệt qua từng dòng trong DataTable và thêm vào DataGridView
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string tableName = row["username"].ToString(); // Thay thế TABLENAME tại đây
                            string columnName = row["user_id"].ToString(); // Thay thế COLUMN tại đây
                            dataGridView_column_privileges.Rows.Add(tableName, columnName);
                        }
                    }
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

        private void close_btn_systemPrivs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
