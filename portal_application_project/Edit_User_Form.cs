using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace portal_application_project
{
    public partial class Edit_User_Form : Form
    {
        private string username;
        private string connectionString;
        private DataTable dataTableTemp;


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

        private DataTable CreateDataTableFromDataGridView(DataGridView dataGridView)
        {
            DataTable dataTable = new DataTable();

            // Thêm các cột vào DataTable dựa trên cấu trúc của DataGridView
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                dataTable.Columns.Add(column.Name);
            }

            // Thêm dữ liệu từ DataGridView vào DataTable
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                DataRow newRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    newRow[cell.ColumnIndex] = cell.Value;
                }
                dataTable.Rows.Add(newRow);
            }

            return dataTable;
        }

        private void LoadDataGrantedRoles()
        {
            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {

                    string query = "SELECT Role_Name FROM V_ALL_ROLES"; // Thay thế ROLENAME tại đây
                    string sub_query = "SELECT Role FROM V_DETAIL_USER_1 WHERE Name = '" + username + "'";


                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();
                        using (OracleCommand sub_command = new OracleCommand(sub_query, connection))
                        {
                            while (reader.Read())
                            {
                                OracleDataReader sub_reader = sub_command.ExecuteReader();
                                bool HasRole = false;
                                bool adm = false;
                                string roleName = reader["Role_Name"].ToString();


                                while (sub_reader.Read())
                                {
                                    string userRole = sub_reader["Role"].ToString();



                                    if (userRole == roleName)
                                    {
                                        HasRole = true;
                                        string sub2_query = "SELECT ADM FROM V_ADMIN_OPTION WHERE Role = '" + userRole + "' AND UserName = '" + username + "'";
                                        using (OracleCommand sub2_command = new OracleCommand(sub2_query, connection))
                                        {

                                            OracleDataReader sub2_reader = sub2_command.ExecuteReader();
                                            while (sub2_reader.Read())
                                            {
                                                string admin = sub2_reader["ADM"].ToString();

                                                if (admin == "YES")
                                                {
                                                    adm = true;
                                                }
                                            }

                                        }
                                        break;
                                    }

                                }
                                // Thêm dòng mới với roleName và giá trị granted mặc định là false (không được cấp quyền) vào cột "ROLENAME" và "GRANTED" tương ứng,ADMIN ?
                                dataGridView_granted_roles.Rows.Add(roleName, HasRole, adm);

                            }
                        }
                    }
                }
                dataTableTemp = CreateDataTableFromDataGridView(dataGridView_granted_roles);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private DataTable CompareDataTables(DataTable dt1, DataTable dt2)
        {
            DataTable diffTable = new DataTable();
            diffTable.Columns.Add("ROLENAME");
            diffTable.Columns.Add("GRANTED", typeof(bool));
            diffTable.Columns.Add("ADMIN", typeof(bool));

            // Lặp qua từng dòng của dt1
            foreach (DataRow row1 in dt1.Rows)
            {
                string roleName1 = row1["ROLENAME"].ToString();

                // Lấy giá trị của cột "GRANTED" và kiểm tra xem có thể chuyển đổi thành kiểu bool không
                object grantedObj = row1["GRANTED"];
                bool granted1;
                if (grantedObj != null && bool.TryParse(grantedObj.ToString(), out bool grantedValue))
                {
                    granted1 = grantedValue;
                }
                else
                {
                    // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                    continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                }

                // Lấy giá trị của cột "ADMIN" và kiểm tra xem có thể chuyển đổi thành kiểu bool không
                object adminObj = row1["ADMIN"];
                bool admin1;
                if (adminObj != null && bool.TryParse(adminObj.ToString(), out bool adminValue))
                {
                    admin1 = adminValue;
                }
                else
                {
                    // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                    continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                }

                // Tìm dòng tương ứng trong dt2
                DataRow[] foundRows = dt2.Select($"ROLENAME = '{roleName1}'");
                if (foundRows.Length > 0)
                {
                    // Lấy giá trị của cột "GRANTED" và "ADMIN" từ dòng tương ứng trong dt2
                    object grantedObj2 = foundRows[0]["GRANTED"];
                    bool granted2;
                    if (grantedObj2 != null && bool.TryParse(grantedObj2.ToString(), out bool grantedValue2))
                    {
                        granted2 = grantedValue2;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                        continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                    }

                    object adminObj2 = foundRows[0]["ADMIN"];
                    bool admin2;
                    if (adminObj2 != null && bool.TryParse(adminObj2.ToString(), out bool adminValue2))
                    {
                        admin2 = adminValue2;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                        continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                    }

                    // So sánh giá trị của các cột GRANTED và ADMIN
                    if (granted1 != granted2 || admin1 != admin2)
                    {
                        // Nếu có sự thay đổi, thêm dòng vào diffTable
                        DataRow diffRow = diffTable.NewRow();
                        diffRow["ROLENAME"] = roleName1;
                        diffRow["GRANTED"] = granted1;
                        diffRow["ADMIN"] = admin1;
                        diffTable.Rows.Add(diffRow);
                    }
                }
                else
                {
                    // Nếu không tìm thấy dòng trong dt2, thêm vào diffTable
                    DataRow diffRow = diffTable.NewRow();
                    diffRow["ROLENAME"] = roleName1;
                    diffRow["GRANTED"] = granted1;
                    diffRow["ADMIN"] = admin1;
                    diffTable.Rows.Add(diffRow);
                }
            }

            return diffTable;
        }

        private void apply_edit_grantedRoles_btn_Click(object sender, EventArgs e)
        {
            DataTable dataTableCurrent = CreateDataTableFromDataGridView(dataGridView_granted_roles);
            DataTable diffTable = CompareDataTables(dataTableCurrent, dataTableTemp);
            foreach (DataRow row in diffTable.Rows)
            {
                if (row["ADMIN"].ToString() == "True")
                {
                    if (row["GRANTED"].ToString() == "True")
                    {
                        using (OracleConnection connection = new OracleConnection(connectionString))
                        {
                            // Mở kết nối
                            connection.Open();

                            // Tạo đối tượng Command
                            using (OracleCommand command = connection.CreateCommand())
                            {
                                // GRANT quyền SELECT cho người dùng
                                string grantQuery = $"GRANT {row["ROLENAME"].ToString()} TO {username} WITH ADMIN OPTION";
                                command.CommandText = grantQuery;
                                command.ExecuteNonQuery();

                                MessageBox.Show("GRANT ROLE thành công!");
                            }

                            // Đóng kết nối
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phải có ROLE mới được có quyền WITH GRANT OPTION.");
                    }


                }

                else
                {
                    if (row["GRANTED"].ToString() == "True")
                    {
                        using (OracleConnection connection = new OracleConnection(connectionString))
                        {
                            // Mở kết nối
                            connection.Open();

                            // Tạo đối tượng Command
                            using (OracleCommand command = connection.CreateCommand())
                            {
                                string NewRole = row["ROLENAME"].ToString();
                                string check = "False";
                                foreach (DataRow sub_row in dataTableTemp.Rows)
                                {
                                    string Role = sub_row["ROLENAME"].ToString();

                                    if (Role == NewRole)
                                    {
                                        check = sub_row["GRANTED"].ToString();
                                    }
                                }

                                if (check == "True")
                                {
                                    string sub_grantQuery = $"REVOKE {row["ROLENAME"].ToString()} FROM {username}";
                                    command.CommandText = sub_grantQuery;
                                    command.ExecuteNonQuery();
                                }

                                string grantQuery = $"GRANT {row["ROLENAME"].ToString()} TO {username}";
                                command.CommandText = grantQuery;
                                command.ExecuteNonQuery();

                                MessageBox.Show("GRANT ROLE thành công!");
                            }

                            // Đóng kết nối
                            connection.Close();
                        }
                    }

                    else
                    {
                        using (OracleConnection connection = new OracleConnection(connectionString))
                        {
                            // Mở kết nối
                            connection.Open();

                            // Tạo đối tượng Command
                            using (OracleCommand command = connection.CreateCommand())
                            {
                                // GRANT quyền SELECT cho người dùng

                                string grantQuery = $"REVOKE {row["ROLENAME"].ToString()} FROM {username}";
                                command.CommandText = grantQuery;
                                command.ExecuteNonQuery();

                                MessageBox.Show("REVOKE ROLE thành công!");


                            }

                            // Đóng kết nối

                            connection.Close();
                        }
                    }
                }

            }
            dataTableTemp = CreateDataTableFromDataGridView(dataGridView_granted_roles);

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
                    string query = "SELECT Privileges FROM V_ALL_SYS_PRIVS"; // Thay thế PRIVILEGES tại đây

                    // Lấy các privis mà user đang sowe hữu
                    string sub_query = "SELECT Privileges,ADM FROM V_DETAIL_USER_2 WHERE User_Name = '" + username + "'";



                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string privilege = reader["Privileges"].ToString(); // Thay thế PRIVILEGES tại đây

                            bool hasPrivs = false;
                            bool adm = false;
                            using (OracleCommand sub_command = new OracleCommand(sub_query, connection))
                            {
                                OracleDataReader sub_reader = sub_command.ExecuteReader();
                                while (sub_reader.Read())
                                {
                                    string UserPrivs = sub_reader["Privileges"].ToString();
                                    string PrivsAdm = sub_reader["ADM"].ToString();
                                    if (UserPrivs == privilege)
                                    {
                                        hasPrivs = true;
                                        if (PrivsAdm == "YES")
                                        {
                                            adm = true;
                                        }
                                        break;
                                    }
                                }
                            }

                            // Thêm dòng mới với roleName vào cột đầu tiên,hàng 2 là user có sở hữu hay không, hàng ba là có adm hay không
                            dataGridView_system_privileges.Rows.Add(privilege, hasPrivs, adm);







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

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            LoadDataGrantedRoles();
        }
    }
}
