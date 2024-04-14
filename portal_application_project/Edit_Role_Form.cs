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
    public partial class Edit_Role_Form : Form
    {
        string rolename;
        string connectionString;
        private DataTable dataTableTempSystemPrivileges;
        private DataTable dataTableTempObjectPrivileges;
        public Edit_Role_Form(string rolename, string connectionString)
        {
            InitializeComponent();
            this.rolename = rolename;
            this.connectionString = connectionString;
            label_roleName_heading.Text = "Edit Role " + this.rolename;
        }

        private void tabControl_edit_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_edit_role.SelectedTab == tabPage_systemPrivileges)
            {
                LoadDataSystemPrivileges();
            }

            if (tabControl_edit_role.SelectedTab == tabPage_objectPrivileges)
            {
                LoadDataObjectPrivileges();
            }

            if (tabControl_edit_role.SelectedTab == tabPage_ColumnsPrivileges)
            {
                LoadDataColumnPrivileges();
            }


        }

        private void Edit_Role_Form_Load(object sender, EventArgs e)
        {
            // System Privileges
            InitializeDataGridViewSystemPrivileges();
            LoadDataSystemPrivileges();

            // Object Privileges
            InitializeDataGridViewObjectPrivileges();


            // Column privileges
            InitializeDataGridViewColumnPrivileges();

        }

        private void InitializeDataGridViewSystemPrivileges()
        {
            // Tạo cột đầu tiên với tên "PRIVILEGES"
            DataGridViewTextBoxColumn privilegesColumn = new DataGridViewTextBoxColumn();
            privilegesColumn.HeaderText = "PRIVILEGES";
            privilegesColumn.Name = "PRIVILEGES";
            dataGridView_system_privileges.Columns.Add(privilegesColumn);
            dataGridView_system_privileges.ForeColor = SystemColors.ControlText;

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
            dataGridView_system_privileges.Rows.Clear();
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    string query = "SELECT Privileges FROM V_ALL_SYS_PRIVS"; // Thay thế PRIVILEGES tại đây



                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string privilege = reader["Privileges"].ToString(); // Thay thế PRIVILEGES tại đây

                            string sub_query = "SELECT Privileges,ADM FROM V_DETAIL_ROLES_2 WHERE Role_Name = '" + rolename + "'";
                            bool hasPrivs = false;
                            bool hasADM = false;

                            using (OracleCommand sub_command = new OracleCommand(sub_query, connection))
                            {
                                OracleDataReader sub_reader = sub_command.ExecuteReader();
                                while (sub_reader.Read())
                                {
                                    string RolePrivs = sub_reader["Privileges"].ToString();
                                    string RoleADM = sub_reader["ADM"].ToString();
                                    if (RolePrivs == privilege)
                                    {
                                        hasPrivs = true;
                                        if (RoleADM == "YES")
                                        {
                                            hasADM = true;
                                        }
                                        break;
                                    }
                                }
                            }
                            // Thêm dòng mới với roleName
                            dataGridView_system_privileges.Rows.Add(privilege, hasPrivs, hasADM);
                        }
                        connection.Close();
                    }


                }
                dataTableTempSystemPrivileges = CreateDataTableFromDataGridView(dataGridView_system_privileges);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private DataTable CompareDataTablesSystemPrivileges(DataTable dt1, DataTable dt2)
        {
            DataTable diffTable = new DataTable();
            diffTable.Columns.Add("PRIVILEGES");
            diffTable.Columns.Add("GRANTED", typeof(bool));
            diffTable.Columns.Add("WITH_GRANT_OPTION_SYSTEM", typeof(bool));

            // Lặp qua từng dòng của dt1
            foreach (DataRow row1 in dt1.Rows)
            {
                string privilege1 = row1["PRIVILEGES"].ToString();

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
                object adminObj = row1["WITH_GRANT_OPTION_SYSTEM"];
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
                DataRow[] foundRows = dt2.Select($"PRIVILEGES = '{privilege1}'");
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

                    object adminObj2 = foundRows[0]["WITH_GRANT_OPTION_SYSTEM"];
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
                        diffRow["PRIVILEGES"] = privilege1;
                        diffRow["GRANTED"] = granted1;
                        diffRow["WITH_GRANT_OPTION_SYSTEM"] = admin1;
                        diffTable.Rows.Add(diffRow);
                    }
                }
                else
                {
                    // Nếu không tìm thấy dòng trong dt2, thêm vào diffTable
                    DataRow diffRow = diffTable.NewRow();
                    diffRow["PRIVILEGES"] = privilege1;
                    diffRow["GRANTED"] = granted1;
                    diffRow["WITH_GRANT_OPTION_SYSTEM"] = admin1;
                    diffTable.Rows.Add(diffRow);
                }
            }

            return diffTable;
        }

        private void apply_editRole_systemPrvs_btn_Click(object sender, EventArgs e)
        {
            DataTable dataTableCurrent = CreateDataTableFromDataGridView(dataGridView_system_privileges);
            DataTable diffTable = CompareDataTablesSystemPrivileges(dataTableCurrent, dataTableTempSystemPrivileges);

            foreach (DataRow row in diffTable.Rows)
            {
                if (row["WITH_GRANT_OPTION_SYSTEM"].ToString() == "True")
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
                                string grantQuery = $"GRANT {row["PRIVILEGES"].ToString()} TO {rolename} WITH GRANT OPTION";
                                command.CommandText = grantQuery;
                                command.ExecuteNonQuery();

                                MessageBox.Show("GRANT PRIVILEGES thành công!");
                            }

                            // Đóng kết nối
                            connection.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phải có PRIVILEGES mới được có quyền WITH GRANT OPTION.");
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
                                string NewRole = row["PRIVILEGES"].ToString();
                                string check = "False";
                                foreach (DataRow sub_row in dataTableTempSystemPrivileges.Rows)
                                {
                                    string Role = sub_row["PRIVILEGES"].ToString();

                                    if (Role == NewRole)
                                    {
                                        check = sub_row["GRANTED"].ToString();
                                    }
                                }

                                if (check == "True")
                                {
                                    string sub_grantQuery = $"REVOKE {row["PRIVILEGES"].ToString()} FROM {rolename}";
                                    command.CommandText = sub_grantQuery;
                                    command.ExecuteNonQuery();
                                }

                                string grantQuery = $"GRANT {row["PRIVILEGES"].ToString()} TO {rolename}";
                                command.CommandText = grantQuery;
                                command.ExecuteNonQuery();

                                MessageBox.Show("GRANT PRIVILEGES thành công!");
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

                                string grantQuery = $"REVOKE {row["PRIVILEGES"].ToString()} FROM {rolename}";
                                command.CommandText = grantQuery;
                                command.ExecuteNonQuery();

                                MessageBox.Show("REVOKE PRIVILEGES thành công!");


                            }

                            // Đóng kết nối

                            connection.Close();
                        }
                    }
                }

            }
            dataTableTempSystemPrivileges = CreateDataTableFromDataGridView(dataGridView_system_privileges);
            LoadDataSystemPrivileges();
        }

        private void InitializeDataGridViewObjectPrivileges()
        {
            // Tạo cột đầu tiên với tên "PRIVILEGES"
            DataGridViewTextBoxColumn objectColumn = new DataGridViewTextBoxColumn();
            objectColumn.HeaderText = "OBJECT";
            objectColumn.Name = "OBJECT";
            dataGridView_object_privileges.Columns.Add(objectColumn);
            dataGridView_object_privileges.ForeColor = SystemColors.ControlText;

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
            dataGridView_object_privileges.Rows.Clear();
            try
            {

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    // load cột Object
                    string query = "SELECT Object_Name,Type FROM V_ALL_OBJECT"; // Thay thế OBJECT tại đây
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string _object = reader["Object_Name"].ToString(); // Thay thế OBJECT tại đây
                            string type = reader["Type"].ToString(); // Thay thế OBJECT tại đây
                                                                     // Thêm dòng mới với roleName vào cột đầu tiên

                            string sub_query = "SELECT Privilege,Object_Name, ADM FROM V_DETAIL_ROLES_3 WHERE Role_Name = '" + rolename + "'";
                            bool[] hasPrivs = new bool[6];
                            int i = 0;
                            bool hasADM = false;

                            using (OracleCommand sub_command = new OracleCommand(sub_query, connection))
                            {
                                OracleDataReader sub_reader = sub_command.ExecuteReader();
                                while (sub_reader.Read())
                                {
                                    string RolePrivs = sub_reader["Privilege"].ToString();
                                    string RoleADM = sub_reader["ADM"].ToString();
                                    string obj = sub_reader["Object_Name"].ToString();


                                    if (obj == _object)
                                    {
                                        if (RoleADM == "YES")
                                        {
                                            hasADM = true;
                                        }
                                        switch (RolePrivs)
                                        {
                                            case "INDEX":
                                                i = 5;
                                                break;
                                            case "EXECUTE":
                                                i = 4;
                                                break;
                                            case "INSERT":
                                                i = 3;
                                                break;
                                            case "DELETE":
                                                i = 2;
                                                break;
                                            case "UPDATE":
                                                i = 1;
                                                break;
                                            case "SELECT":
                                                i = 0;
                                                break;
                                        }
                                        hasPrivs[i] = true;
                                    }
                                }
                            }
                            dataGridView_object_privileges.Rows.Add(_object, type, hasPrivs[0], hasPrivs[1], hasPrivs[2], hasPrivs[3], hasPrivs[4], hasPrivs[5], hasADM);
                        }
                        connection.Close();
                    }
                }
                dataTableTempObjectPrivileges = CreateDataTableFromDataGridView(dataGridView_object_privileges);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private DataTable CompareDataTablesObjectPrivileges(DataTable dt1, DataTable dt2)
        {
            DataTable diffTable = new DataTable();
            diffTable.Columns.Add("OBJECT");
            diffTable.Columns.Add("TYPE");
            diffTable.Columns.Add("SELECT", typeof(bool));
            diffTable.Columns.Add("UPDATE", typeof(bool));
            diffTable.Columns.Add("DELETE", typeof(bool));
            diffTable.Columns.Add("INSERT", typeof(bool));
            diffTable.Columns.Add("EXECUTE", typeof(bool));
            diffTable.Columns.Add("INDEX", typeof(bool));
            diffTable.Columns.Add("WITH_GRANT_OPTION_OBJECT", typeof(bool));

            // Lặp qua từng dòng của dt1
            foreach (DataRow row1 in dt1.Rows)
            {
                string object1 = row1["OBJECT"].ToString();

                string type1 = row1["TYPE"].ToString();

                // Lấy giá trị của cột "SELECT" và kiểm tra xem có thể chuyển đổi thành kiểu bool không
                object selectObj = row1["SELECT"];
                bool select1;
                if (selectObj != null && bool.TryParse(selectObj.ToString(), out bool selectValue))
                {
                    select1 = selectValue;

                }
                else
                {
                    // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                    continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                }

                // Lấy giá trị của cột "UPDATE" và kiểm tra xem có thể chuyển đổi thành kiểu bool không
                object updateObj = row1["UPDATE"];
                bool update1;
                if (updateObj != null && bool.TryParse(updateObj.ToString(), out bool updateValue))
                {
                    update1 = updateValue;
                }
                else
                {
                    // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                    continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                }

                // Lấy giá trị của cột "INSERT" và kiểm tra xem có thể chuyển đổi thành kiểu bool không
                object insertObj = row1["INSERT"];
                bool insert1;
                if (insertObj != null && bool.TryParse(insertObj.ToString(), out bool insertValue))
                {
                    insert1 = insertValue;
                }
                else
                {
                    // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                    continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                }

                // Lấy giá trị của cột "DELETE" và kiểm tra xem có thể chuyển đổi thành kiểu bool không
                object deleteObj = row1["DELETE"];
                bool delete1;
                if (deleteObj != null && bool.TryParse(deleteObj.ToString(), out bool deleteValue))
                {
                    delete1 = deleteValue;
                }
                else
                {
                    // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                    continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                }

                // Lấy giá trị của cột "EXECUTE" và kiểm tra xem có thể chuyển đổi thành kiểu bool không
                object executeObj = row1["EXECUTE"];
                bool execute1;
                if (executeObj != null && bool.TryParse(executeObj.ToString(), out bool executeValue))
                {
                    execute1 = executeValue;
                }
                else
                {
                    // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                    continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                }

                // Lấy giá trị của cột "INDEX" và kiểm tra xem có thể chuyển đổi thành kiểu bool không
                object indexObj = row1["INDEX"];
                bool index1;
                if (indexObj != null && bool.TryParse(indexObj.ToString(), out bool indexValue))
                {
                    index1 = indexValue;
                }
                else
                {
                    // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                    continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                }

                // Lấy giá trị của cột "ADMIN" và kiểm tra xem có thể chuyển đổi thành kiểu bool không
                object adminObj = row1["WITH_GRANT_OPTION_OBJECT"];
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

                DataRow[] foundRows = dt2.Select($"OBJECT = '{object1}'");

                if (foundRows.Length > 0)
                {
                    // Lấy giá trị của cột "GRANTED" và "ADMIN" từ dòng tương ứng trong dt2
                    object selectObj2 = foundRows[0]["SELECT"];
                    bool select2;
                    if (selectObj2 != null && bool.TryParse(selectObj2.ToString(), out bool selectValue2))
                    {
                        select2 = selectValue2;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                        continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                    }


                    object updateObj2 = foundRows[0]["UPDATE"];
                    bool update2;
                    if (updateObj2 != null && bool.TryParse(updateObj2.ToString(), out bool updateValue2))
                    {
                        update2 = updateValue2;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                        continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                    }

                    object deleteObj2 = foundRows[0]["DELETE"];
                    bool delete2;
                    if (deleteObj2 != null && bool.TryParse(deleteObj2.ToString(), out bool deleteValue2))
                    {
                        delete2 = deleteValue2;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                        continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                    }

                    object insertObj2 = foundRows[0]["INSERT"];
                    bool insert2;
                    if (insertObj2 != null && bool.TryParse(insertObj2.ToString(), out bool insertValue2))
                    {
                        insert2 = insertValue2;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                        continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                    }

                    object executeObj2 = foundRows[0]["EXECUTE"];
                    bool execute2;
                    if (executeObj2 != null && bool.TryParse(executeObj2.ToString(), out bool executeValue2))
                    {
                        execute2 = executeValue2;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                        continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                    }


                    object indexObj2 = foundRows[0]["INDEX"];
                    bool index2;
                    if (indexObj2 != null && bool.TryParse(indexObj2.ToString(), out bool indexValue2))
                    {
                        index2 = indexValue2;
                    }
                    else
                    {
                        // Xử lý khi không thể chuyển đổi giá trị thành kiểu bool
                        continue; // Bỏ qua dòng này và đi tiếp sang dòng khác
                    }


                    object adminObj2 = foundRows[0]["WITH_GRANT_OPTION_OBJECT"];
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
                    if (select1 != select2 || update1 != update2 || insert1 != insert2 || delete1 != delete2 || execute1 != execute2 || index1 != index2 || admin1 != admin2)
                    {
                        // Nếu có sự thay đổi, thêm dòng vào diffTable
                        DataRow diffRow = diffTable.NewRow();
                        diffRow["OBJECT"] = object1;
                        diffRow["TYPE"] = type1;
                        diffRow["SELECT"] = select1;
                        diffRow["UPDATE"] = update1;
                        diffRow["INSERT"] = insert1;
                        diffRow["DELETE"] = delete1;
                        diffRow["INDEX"] = index1;
                        diffRow["EXECUTE"] = execute1;
                        diffRow["WITH_GRANT_OPTION_OBJECT"] = admin1;
                        diffTable.Rows.Add(diffRow);
                    }
                }
                else
                {
                    // Nếu không tìm thấy dòng trong dt2, thêm vào diffTable
                    DataRow diffRow = diffTable.NewRow();
                    diffRow["OBJECT"] = object1;
                    diffRow["TYPE"] = type1;
                    diffRow["SELECT"] = select1;
                    diffRow["UPDATE"] = update1;
                    diffRow["INSERT"] = insert1;
                    diffRow["DELETE"] = delete1;
                    diffRow["INDEX"] = index1;
                    diffRow["EXECUTE"] = execute1;
                    diffRow["WITH_GRANT_OPTION_OBJECT"] = admin1;
                    diffTable.Rows.Add(diffRow);
                }
            }

            return diffTable;
        }



        private void apply_edit_objectPrvs_btn_Click(object sender, EventArgs e)
        {
            DataTable dataTableCurrent = CreateDataTableFromDataGridView(dataGridView_object_privileges);
            DataTable diffTable = CompareDataTablesObjectPrivileges(dataTableCurrent, dataTableTempObjectPrivileges);


            string[] check = new string[5];
            string[] privs = new string[] { "SELECT", "UPDATE", "INSERT", "DELETE", "EXECUTE" };
            string grant, revoke;

            foreach (DataRow row in diffTable.Rows)
            {
                grant = "";
                revoke = "";

                for (int i = 0; i < 5; i++)
                {
                    check[i] = row[privs[i]].ToString();
                }




                for (int i = 0; i < 5; i++)
                {
                    if (check[i] == "True")
                    {
                        if (grant != "")
                        {
                            grant += ",";
                        }
                        grant += privs[i];
                    }
                    else
                    {
                        foreach (DataRow sub_row in dataTableTempObjectPrivileges.Rows)
                        {
                            if (sub_row["OBJECT"].ToString() != row["OBJECT"].ToString())
                            {
                                continue;
                            }
                            if (sub_row[privs[i]].ToString() == "True")
                            {
                                if (revoke != "")
                                {
                                    revoke += ",";
                                }
                                revoke += privs[i];
                            }
                        }
                    }

                }

                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand command = connection.CreateCommand())
                    {
                        try
                        {
                            if (grant != "")
                            {
                                grant = "GRANT " + grant + " ON " + row["OBJECT"].ToString() + " TO " + rolename;
                                command.CommandText = grant;
                                command.ExecuteNonQuery();
                            }
                            if (revoke != "")
                            {
                                revoke = "REVOKE " + revoke + " ON " + row["OBJECT"].ToString() + " FROM " + rolename;
                                command.CommandText = revoke;
                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }


                    }
                    connection.Close();
                }


            }

            dataTableTempObjectPrivileges = CreateDataTableFromDataGridView(dataGridView_object_privileges);
            LoadDataObjectPrivileges();
        }

        private void InitializeDataGridViewColumnPrivileges()
        {
            dataGridView_column_privileges.ForeColor = SystemColors.ControlText;
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
                        connection.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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


    }
}
