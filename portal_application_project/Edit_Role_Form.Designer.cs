namespace portal_application_project
{
    partial class Edit_Role_Form
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
            panel1 = new Panel();
            label_roleName_heading = new Label();
            tabControl_edit_role = new TabControl();
            tabPage_systemPrivileges = new TabPage();
            close_btn = new Button();
            apply_editRole_systemPrvs_btn = new Button();
            dataGridView_system_privileges = new DataGridView();
            tabPage_objectPrivileges = new TabPage();
            button1 = new Button();
            apply_edit_objectPrvs_btn = new Button();
            dataGridView_object_privileges = new DataGridView();
            tabPage_ColumnsPrivileges = new TabPage();
            button3 = new Button();
            apply_edit_columnPrvs_btn = new Button();
            dataGridView_column_privileges = new DataGridView();
            panel1.SuspendLayout();
            tabControl_edit_role.SuspendLayout();
            tabPage_systemPrivileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_system_privileges).BeginInit();
            tabPage_objectPrivileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_object_privileges).BeginInit();
            tabPage_ColumnsPrivileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_column_privileges).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label_roleName_heading);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 70);
            panel1.TabIndex = 62;
            // 
            // label_roleName_heading
            // 
            label_roleName_heading.Anchor = AnchorStyles.Top;
            label_roleName_heading.AutoSize = true;
            label_roleName_heading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_roleName_heading.ForeColor = Color.White;
            label_roleName_heading.Location = new Point(482, 9);
            label_roleName_heading.Name = "label_roleName_heading";
            label_roleName_heading.Size = new Size(144, 41);
            label_roleName_heading.TabIndex = 1;
            label_roleName_heading.Text = "Edit Role";
            // 
            // tabControl_edit_role
            // 
            tabControl_edit_role.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl_edit_role.Controls.Add(tabPage_systemPrivileges);
            tabControl_edit_role.Controls.Add(tabPage_objectPrivileges);
            tabControl_edit_role.Controls.Add(tabPage_ColumnsPrivileges);
            tabControl_edit_role.Location = new Point(0, 76);
            tabControl_edit_role.Name = "tabControl_edit_role";
            tabControl_edit_role.Padding = new Point(20, 4);
            tabControl_edit_role.SelectedIndex = 0;
            tabControl_edit_role.Size = new Size(1085, 549);
            tabControl_edit_role.TabIndex = 63;
            tabControl_edit_role.SelectedIndexChanged += tabControl_edit_role_SelectedIndexChanged;
            // 
            // tabPage_systemPrivileges
            // 
            tabPage_systemPrivileges.Controls.Add(close_btn);
            tabPage_systemPrivileges.Controls.Add(apply_editRole_systemPrvs_btn);
            tabPage_systemPrivileges.Controls.Add(dataGridView_system_privileges);
            tabPage_systemPrivileges.Location = new Point(4, 31);
            tabPage_systemPrivileges.Name = "tabPage_systemPrivileges";
            tabPage_systemPrivileges.Padding = new Padding(3, 3, 3, 3);
            tabPage_systemPrivileges.Size = new Size(1077, 514);
            tabPage_systemPrivileges.TabIndex = 1;
            tabPage_systemPrivileges.Text = "System privileges";
            tabPage_systemPrivileges.UseVisualStyleBackColor = true;
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
            close_btn.Location = new Point(991, 454);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(78, 51);
            close_btn.TabIndex = 49;
            close_btn.Text = "Close";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // apply_editRole_systemPrvs_btn
            // 
            apply_editRole_systemPrvs_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            apply_editRole_systemPrvs_btn.BackColor = SystemColors.ButtonHighlight;
            apply_editRole_systemPrvs_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            apply_editRole_systemPrvs_btn.FlatAppearance.BorderSize = 3;
            apply_editRole_systemPrvs_btn.FlatStyle = FlatStyle.Flat;
            apply_editRole_systemPrvs_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            apply_editRole_systemPrvs_btn.ForeColor = SystemColors.HotTrack;
            apply_editRole_systemPrvs_btn.Location = new Point(761, 454);
            apply_editRole_systemPrvs_btn.Name = "apply_editRole_systemPrvs_btn";
            apply_editRole_systemPrvs_btn.Size = new Size(138, 50);
            apply_editRole_systemPrvs_btn.TabIndex = 48;
            apply_editRole_systemPrvs_btn.Text = "Apply";
            apply_editRole_systemPrvs_btn.UseVisualStyleBackColor = false;
            apply_editRole_systemPrvs_btn.Click += apply_editRole_systemPrvs_btn_Click;
            // 
            // dataGridView_system_privileges
            // 
            dataGridView_system_privileges.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_system_privileges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_system_privileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_system_privileges.Location = new Point(3, 3);
            dataGridView_system_privileges.Name = "dataGridView_system_privileges";
            dataGridView_system_privileges.RowHeadersWidth = 51;
            dataGridView_system_privileges.RowTemplate.Height = 29;
            dataGridView_system_privileges.Size = new Size(1071, 433);
            dataGridView_system_privileges.TabIndex = 0;
            // 
            // tabPage_objectPrivileges
            // 
            tabPage_objectPrivileges.Controls.Add(button1);
            tabPage_objectPrivileges.Controls.Add(apply_edit_objectPrvs_btn);
            tabPage_objectPrivileges.Controls.Add(dataGridView_object_privileges);
            tabPage_objectPrivileges.Location = new Point(4, 31);
            tabPage_objectPrivileges.Name = "tabPage_objectPrivileges";
            tabPage_objectPrivileges.Size = new Size(1077, 514);
            tabPage_objectPrivileges.TabIndex = 2;
            tabPage_objectPrivileges.Text = "Object privileges";
            tabPage_objectPrivileges.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.BorderColor = Color.Red;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(982, 454);
            button1.Name = "button1";
            button1.Size = new Size(78, 51);
            button1.TabIndex = 53;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // apply_edit_objectPrvs_btn
            // 
            apply_edit_objectPrvs_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            apply_edit_objectPrvs_btn.BackColor = SystemColors.ButtonHighlight;
            apply_edit_objectPrvs_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            apply_edit_objectPrvs_btn.FlatAppearance.BorderSize = 3;
            apply_edit_objectPrvs_btn.FlatStyle = FlatStyle.Flat;
            apply_edit_objectPrvs_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            apply_edit_objectPrvs_btn.ForeColor = SystemColors.HotTrack;
            apply_edit_objectPrvs_btn.Location = new Point(752, 454);
            apply_edit_objectPrvs_btn.Name = "apply_edit_objectPrvs_btn";
            apply_edit_objectPrvs_btn.Size = new Size(138, 50);
            apply_edit_objectPrvs_btn.TabIndex = 52;
            apply_edit_objectPrvs_btn.Text = "Apply";
            apply_edit_objectPrvs_btn.UseVisualStyleBackColor = false;
            apply_edit_objectPrvs_btn.Click += apply_edit_objectPrvs_btn_Click;
            // 
            // dataGridView_object_privileges
            // 
            dataGridView_object_privileges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_object_privileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_object_privileges.Location = new Point(0, 3);
            dataGridView_object_privileges.Name = "dataGridView_object_privileges";
            dataGridView_object_privileges.RowHeadersWidth = 51;
            dataGridView_object_privileges.RowTemplate.Height = 29;
            dataGridView_object_privileges.Size = new Size(1077, 445);
            dataGridView_object_privileges.TabIndex = 0;
            // 
            // tabPage_ColumnsPrivileges
            // 
            tabPage_ColumnsPrivileges.Controls.Add(button3);
            tabPage_ColumnsPrivileges.Controls.Add(apply_edit_columnPrvs_btn);
            tabPage_ColumnsPrivileges.Controls.Add(dataGridView_column_privileges);
            tabPage_ColumnsPrivileges.Location = new Point(4, 31);
            tabPage_ColumnsPrivileges.Name = "tabPage_ColumnsPrivileges";
            tabPage_ColumnsPrivileges.Size = new Size(1077, 514);
            tabPage_ColumnsPrivileges.TabIndex = 3;
            tabPage_ColumnsPrivileges.Text = "Columns privileges";
            tabPage_ColumnsPrivileges.UseVisualStyleBackColor = true;
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
            button3.Location = new Point(980, 454);
            button3.Name = "button3";
            button3.Size = new Size(78, 51);
            button3.TabIndex = 49;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            apply_edit_columnPrvs_btn.Location = new Point(750, 454);
            apply_edit_columnPrvs_btn.Name = "apply_edit_columnPrvs_btn";
            apply_edit_columnPrvs_btn.Size = new Size(138, 50);
            apply_edit_columnPrvs_btn.TabIndex = 48;
            apply_edit_columnPrvs_btn.Text = "Apply";
            apply_edit_columnPrvs_btn.UseVisualStyleBackColor = false;
            apply_edit_columnPrvs_btn.Click += apply_edit_columnPrvs_btn_Click;
            // 
            // dataGridView_column_privileges
            // 
            dataGridView_column_privileges.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_column_privileges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_column_privileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_column_privileges.Location = new Point(0, 3);
            dataGridView_column_privileges.Name = "dataGridView_column_privileges";
            dataGridView_column_privileges.RowHeadersWidth = 51;
            dataGridView_column_privileges.RowTemplate.Height = 29;
            dataGridView_column_privileges.Size = new Size(1077, 434);
            dataGridView_column_privileges.TabIndex = 0;
            // 
            // Edit_Role_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 624);
            Controls.Add(panel1);
            Controls.Add(tabControl_edit_role);
            ForeColor = SystemColors.ControlLight;
            Name = "Edit_Role_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Role";
            Load += Edit_Role_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl_edit_role.ResumeLayout(false);
            tabPage_systemPrivileges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_system_privileges).EndInit();
            tabPage_objectPrivileges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_object_privileges).EndInit();
            tabPage_ColumnsPrivileges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_column_privileges).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_roleName_heading;
        private TabControl tabControl_edit_role;
        private TabPage tabPage_systemPrivileges;
        private TabPage tabPage_objectPrivileges;
        private TabPage tabPage_ColumnsPrivileges;
        private DataGridView dataGridView_system_privileges;
        private DataGridView dataGridView_object_privileges;
        private DataGridView dataGridView_column_privileges;
        private Button close_btn;
        private Button apply_editRole_systemPrvs_btn;
        private Button button1;
        private Button apply_edit_objectPrvs_btn;
        private Button button3;
        private Button apply_edit_columnPrvs_btn;
    }
}