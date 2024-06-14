namespace portal_application_project
{
    partial class Edit_User_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_roleName_heading = new Label();
            panel1 = new Panel();
            tabControl_edit_user = new TabControl();
            tabPage_grantedRoles = new TabPage();
            close_btn = new Button();
            apply_edit_grantedRoles_btn = new Button();
            dataGridView_granted_roles = new DataGridView();
            tabPage_systemPrivileges = new TabPage();
            close_btn_systemPrivs = new Button();
            apply_edit_systemPrivileges_btn = new Button();
            dataGridView_system_privileges = new DataGridView();
            tabPage_objectPrivileges = new TabPage();
            button3 = new Button();
            edit_object_prvs_btn = new Button();
            dataGridView_object_privileges = new DataGridView();
            tabPage_ColumnsPrivileges = new TabPage();
            button5 = new Button();
            apply_edit_columnPrvs_btn = new Button();
            dataGridView_column_privileges = new DataGridView();
            panel1.SuspendLayout();
            tabControl_edit_user.SuspendLayout();
            tabPage_grantedRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_granted_roles).BeginInit();
            tabPage_systemPrivileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_system_privileges).BeginInit();
            tabPage_objectPrivileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_object_privileges).BeginInit();
            tabPage_ColumnsPrivileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_column_privileges).BeginInit();
            SuspendLayout();
            // 
            // label_roleName_heading
            // 
            label_roleName_heading.Anchor = AnchorStyles.Top;
            label_roleName_heading.AutoSize = true;
            label_roleName_heading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_roleName_heading.ForeColor = Color.White;
            label_roleName_heading.Location = new Point(455, 14);
            label_roleName_heading.Name = "label_roleName_heading";
            label_roleName_heading.Size = new Size(145, 41);
            label_roleName_heading.TabIndex = 1;
            label_roleName_heading.Text = "Edit User";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label_roleName_heading);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 70);
            panel1.TabIndex = 60;
            // 
            // tabControl_edit_user
            // 
            tabControl_edit_user.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl_edit_user.Controls.Add(tabPage_grantedRoles);
            tabControl_edit_user.Controls.Add(tabPage_systemPrivileges);
            tabControl_edit_user.Controls.Add(tabPage_objectPrivileges);
            tabControl_edit_user.Controls.Add(tabPage_ColumnsPrivileges);
            tabControl_edit_user.Location = new Point(0, 76);
            tabControl_edit_user.Name = "tabControl_edit_user";
            tabControl_edit_user.Padding = new Point(20, 4);
            tabControl_edit_user.SelectedIndex = 0;
            tabControl_edit_user.Size = new Size(1085, 547);
            tabControl_edit_user.TabIndex = 61;
            tabControl_edit_user.SelectedIndexChanged += tabControl_edit_user_SelectedIndexChanged;
            // 
            // tabPage_grantedRoles
            // 
            tabPage_grantedRoles.Controls.Add(close_btn);
            tabPage_grantedRoles.Controls.Add(apply_edit_grantedRoles_btn);
            tabPage_grantedRoles.Controls.Add(dataGridView_granted_roles);
            tabPage_grantedRoles.Location = new Point(4, 31);
            tabPage_grantedRoles.Name = "tabPage_grantedRoles";
            tabPage_grantedRoles.Padding = new Padding(3);
            tabPage_grantedRoles.Size = new Size(1077, 512);
            tabPage_grantedRoles.TabIndex = 0;
            tabPage_grantedRoles.Text = "Granted roles";
            tabPage_grantedRoles.UseVisualStyleBackColor = true;
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            close_btn.BackColor = SystemColors.ButtonHighlight;
            close_btn.FlatAppearance.BorderColor = Color.Red;
            close_btn.FlatAppearance.BorderSize = 3;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            close_btn.ForeColor = Color.Red;
            close_btn.Location = new Point(939, 455);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(78, 51);
            close_btn.TabIndex = 47;
            close_btn.Text = "Close";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // apply_edit_grantedRoles_btn
            // 
            apply_edit_grantedRoles_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            apply_edit_grantedRoles_btn.BackColor = SystemColors.ButtonHighlight;
            apply_edit_grantedRoles_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            apply_edit_grantedRoles_btn.FlatAppearance.BorderSize = 3;
            apply_edit_grantedRoles_btn.FlatStyle = FlatStyle.Flat;
            apply_edit_grantedRoles_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            apply_edit_grantedRoles_btn.ForeColor = SystemColors.HotTrack;
            apply_edit_grantedRoles_btn.Location = new Point(709, 455);
            apply_edit_grantedRoles_btn.Name = "apply_edit_grantedRoles_btn";
            apply_edit_grantedRoles_btn.Size = new Size(138, 50);
            apply_edit_grantedRoles_btn.TabIndex = 1;
            apply_edit_grantedRoles_btn.Text = "Apply";
            apply_edit_grantedRoles_btn.UseVisualStyleBackColor = false;
            apply_edit_grantedRoles_btn.Click += apply_edit_grantedRoles_btn_Click;
            // 
            // dataGridView_granted_roles
            // 
            dataGridView_granted_roles.AllowUserToAddRows = false;
            dataGridView_granted_roles.AllowUserToDeleteRows = false;
            dataGridView_granted_roles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_granted_roles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_granted_roles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_granted_roles.Location = new Point(3, 3);
            dataGridView_granted_roles.Name = "dataGridView_granted_roles";
            dataGridView_granted_roles.RowHeadersWidth = 51;
            dataGridView_granted_roles.RowTemplate.Height = 29;
            dataGridView_granted_roles.Size = new Size(1068, 440);
            dataGridView_granted_roles.TabIndex = 0;
            // 
            // tabPage_systemPrivileges
            // 
            tabPage_systemPrivileges.Controls.Add(close_btn_systemPrivs);
            tabPage_systemPrivileges.Controls.Add(apply_edit_systemPrivileges_btn);
            tabPage_systemPrivileges.Controls.Add(dataGridView_system_privileges);
            tabPage_systemPrivileges.Location = new Point(4, 31);
            tabPage_systemPrivileges.Name = "tabPage_systemPrivileges";
            tabPage_systemPrivileges.Padding = new Padding(3);
            tabPage_systemPrivileges.Size = new Size(1077, 512);
            tabPage_systemPrivileges.TabIndex = 1;
            tabPage_systemPrivileges.Text = "System privileges";
            tabPage_systemPrivileges.UseVisualStyleBackColor = true;
            // 
            // close_btn_systemPrivs
            // 
            close_btn_systemPrivs.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            close_btn_systemPrivs.BackColor = SystemColors.ButtonHighlight;
            close_btn_systemPrivs.FlatAppearance.BorderColor = Color.Red;
            close_btn_systemPrivs.FlatAppearance.BorderSize = 3;
            close_btn_systemPrivs.FlatStyle = FlatStyle.Flat;
            close_btn_systemPrivs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            close_btn_systemPrivs.ForeColor = Color.Red;
            close_btn_systemPrivs.Location = new Point(991, 454);
            close_btn_systemPrivs.Name = "close_btn_systemPrivs";
            close_btn_systemPrivs.Size = new Size(78, 51);
            close_btn_systemPrivs.TabIndex = 49;
            close_btn_systemPrivs.Text = "Close";
            close_btn_systemPrivs.UseVisualStyleBackColor = false;
            close_btn_systemPrivs.Click += close_btn_systemPrivs_Click;
            // 
            // apply_edit_systemPrivileges_btn
            // 
            apply_edit_systemPrivileges_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            apply_edit_systemPrivileges_btn.BackColor = SystemColors.ButtonHighlight;
            apply_edit_systemPrivileges_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            apply_edit_systemPrivileges_btn.FlatAppearance.BorderSize = 3;
            apply_edit_systemPrivileges_btn.FlatStyle = FlatStyle.Flat;
            apply_edit_systemPrivileges_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            apply_edit_systemPrivileges_btn.ForeColor = SystemColors.HotTrack;
            apply_edit_systemPrivileges_btn.Location = new Point(777, 454);
            apply_edit_systemPrivileges_btn.Name = "apply_edit_systemPrivileges_btn";
            apply_edit_systemPrivileges_btn.Size = new Size(138, 51);
            apply_edit_systemPrivileges_btn.TabIndex = 48;
            apply_edit_systemPrivileges_btn.Text = "Apply";
            apply_edit_systemPrivileges_btn.UseVisualStyleBackColor = false;
            apply_edit_systemPrivileges_btn.Click += apply_edit_systemPrivileges_btn_Click;
            // 
            // dataGridView_system_privileges
            // 
            dataGridView_system_privileges.AllowUserToAddRows = false;
            dataGridView_system_privileges.AllowUserToDeleteRows = false;
            dataGridView_system_privileges.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_system_privileges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_system_privileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_system_privileges.Location = new Point(3, 3);
            dataGridView_system_privileges.Name = "dataGridView_system_privileges";
            dataGridView_system_privileges.RowHeadersWidth = 51;
            dataGridView_system_privileges.RowTemplate.Height = 29;
            dataGridView_system_privileges.Size = new Size(1066, 427);
            dataGridView_system_privileges.TabIndex = 1;
            // 
            // tabPage_objectPrivileges
            // 
            tabPage_objectPrivileges.Controls.Add(button3);
            tabPage_objectPrivileges.Controls.Add(edit_object_prvs_btn);
            tabPage_objectPrivileges.Controls.Add(dataGridView_object_privileges);
            tabPage_objectPrivileges.Location = new Point(4, 31);
            tabPage_objectPrivileges.Name = "tabPage_objectPrivileges";
            tabPage_objectPrivileges.Size = new Size(1077, 512);
            tabPage_objectPrivileges.TabIndex = 2;
            tabPage_objectPrivileges.Text = "Object privileges";
            tabPage_objectPrivileges.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.FlatAppearance.BorderColor = Color.Red;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(991, 454);
            button3.Name = "button3";
            button3.Size = new Size(78, 51);
            button3.TabIndex = 53;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // edit_object_prvs_btn
            // 
            edit_object_prvs_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            edit_object_prvs_btn.BackColor = SystemColors.ButtonHighlight;
            edit_object_prvs_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            edit_object_prvs_btn.FlatAppearance.BorderSize = 3;
            edit_object_prvs_btn.FlatStyle = FlatStyle.Flat;
            edit_object_prvs_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            edit_object_prvs_btn.ForeColor = SystemColors.HotTrack;
            edit_object_prvs_btn.Location = new Point(760, 454);
            edit_object_prvs_btn.Name = "edit_object_prvs_btn";
            edit_object_prvs_btn.Size = new Size(138, 51);
            edit_object_prvs_btn.TabIndex = 52;
            edit_object_prvs_btn.Text = "Apply";
            edit_object_prvs_btn.UseVisualStyleBackColor = false;
            edit_object_prvs_btn.Click += edit_object_prvs_btn_Click;
            // 
            // dataGridView_object_privileges
            // 
            dataGridView_object_privileges.AllowUserToAddRows = false;
            dataGridView_object_privileges.AllowUserToDeleteRows = false;
            dataGridView_object_privileges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_object_privileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_object_privileges.Location = new Point(0, 0);
            dataGridView_object_privileges.Name = "dataGridView_object_privileges";
            dataGridView_object_privileges.RowHeadersWidth = 51;
            dataGridView_object_privileges.RowTemplate.Height = 29;
            dataGridView_object_privileges.Size = new Size(1077, 437);
            dataGridView_object_privileges.TabIndex = 51;
            // 
            // tabPage_ColumnsPrivileges
            // 
            tabPage_ColumnsPrivileges.Controls.Add(button5);
            tabPage_ColumnsPrivileges.Controls.Add(apply_edit_columnPrvs_btn);
            tabPage_ColumnsPrivileges.Controls.Add(dataGridView_column_privileges);
            tabPage_ColumnsPrivileges.Location = new Point(4, 31);
            tabPage_ColumnsPrivileges.Name = "tabPage_ColumnsPrivileges";
            tabPage_ColumnsPrivileges.Size = new Size(1077, 512);
            tabPage_ColumnsPrivileges.TabIndex = 3;
            tabPage_ColumnsPrivileges.Text = "Columns privileges";
            tabPage_ColumnsPrivileges.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.FlatAppearance.BorderColor = Color.Red;
            button5.FlatAppearance.BorderSize = 3;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Red;
            button5.Location = new Point(991, 454);
            button5.Name = "button5";
            button5.Size = new Size(78, 51);
            button5.TabIndex = 57;
            button5.Text = "Close";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // apply_edit_columnPrvs_btn
            // 
            apply_edit_columnPrvs_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            apply_edit_columnPrvs_btn.BackColor = SystemColors.ButtonHighlight;
            apply_edit_columnPrvs_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            apply_edit_columnPrvs_btn.FlatAppearance.BorderSize = 3;
            apply_edit_columnPrvs_btn.FlatStyle = FlatStyle.Flat;
            apply_edit_columnPrvs_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            apply_edit_columnPrvs_btn.ForeColor = SystemColors.HotTrack;
            apply_edit_columnPrvs_btn.Location = new Point(757, 454);
            apply_edit_columnPrvs_btn.Name = "apply_edit_columnPrvs_btn";
            apply_edit_columnPrvs_btn.Size = new Size(138, 51);
            apply_edit_columnPrvs_btn.TabIndex = 56;
            apply_edit_columnPrvs_btn.Text = "Apply";
            apply_edit_columnPrvs_btn.UseVisualStyleBackColor = false;
            apply_edit_columnPrvs_btn.Click += apply_edit_columnPrvs_btn_Click;
            // 
            // dataGridView_column_privileges
            // 
            dataGridView_column_privileges.AllowUserToAddRows = false;
            dataGridView_column_privileges.AllowUserToDeleteRows = false;
            dataGridView_column_privileges.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_column_privileges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_column_privileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_column_privileges.Location = new Point(0, 0);
            dataGridView_column_privileges.Name = "dataGridView_column_privileges";
            dataGridView_column_privileges.RowHeadersWidth = 51;
            dataGridView_column_privileges.RowTemplate.Height = 29;
            dataGridView_column_privileges.Size = new Size(1077, 433);
            dataGridView_column_privileges.TabIndex = 0;
            // 
            // Edit_User_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 624);
            Controls.Add(tabControl_edit_user);
            Controls.Add(panel1);
            Name = "Edit_User_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit User";
            Load += Edit_User_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl_edit_user.ResumeLayout(false);
            tabPage_grantedRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_granted_roles).EndInit();
            tabPage_systemPrivileges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_system_privileges).EndInit();
            tabPage_objectPrivileges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_object_privileges).EndInit();
            tabPage_ColumnsPrivileges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_column_privileges).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_roleName_heading;
        private Panel panel1;
        private TabControl tabControl_edit_user;
        private TabPage tabPage_grantedRoles;
        private TabPage tabPage_systemPrivileges;
        private TabPage tabPage_objectPrivileges;
        private TabPage tabPage_ColumnsPrivileges;
        private DataGridView dataGridView_granted_roles;
        private DataGridView dataGridView_system_privileges;
        private DataGridView dataGridView_object_privileges;
        private DataGridView dataGridView_column_privileges;
        private Button apply_edit_grantedRoles_btn;
        private Button close_btn;
        private Button close_btn_systemPrivs;
        private Button apply_edit_systemPrivileges_btn;
        private Button button3;
        private Button edit_object_prvs_btn;
        private Button button5;
        private Button apply_edit_columnPrvs_btn;
    }
}