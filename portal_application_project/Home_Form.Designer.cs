namespace portal_application_project
{
    partial class Home_Form
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
            label1 = new Label();
            tabControl_Home = new TabControl();
            tabPage_users = new TabPage();
            dataGridView_home_users = new DataGridView();
            refresh_user_btn = new Button();
            drop_user_btn = new Button();
            edit_user_btn = new Button();
            viewDetail_user_btn = new Button();
            new_user_btn = new Button();
            tabPage_roles = new TabPage();
            dataGridView_home_roles = new DataGridView();
            refresh_role_btn = new Button();
            drop_role_btn = new Button();
            edit_role_btn = new Button();
            viewDetail_role_btn = new Button();
            new_role_btn = new Button();
            tabPage_standard_audit = new TabPage();
            find_btn = new Button();
            filer_textBox = new TextBox();
            dataGridView_audit = new DataGridView();
            panel1.SuspendLayout();
            tabControl_Home.SuspendLayout();
            tabPage_users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_home_users).BeginInit();
            tabPage_roles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_home_roles).BeginInit();
            tabPage_standard_audit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_audit).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1382, 70);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 11);
            label1.Name = "label1";
            label1.Size = new Size(273, 41);
            label1.TabIndex = 1;
            label1.Text = "Admin Dashboard";
            // 
            // tabControl_Home
            // 
            tabControl_Home.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl_Home.Controls.Add(tabPage_users);
            tabControl_Home.Controls.Add(tabPage_roles);
            tabControl_Home.Controls.Add(tabPage_standard_audit);
            tabControl_Home.Location = new Point(42, 115);
            tabControl_Home.Name = "tabControl_Home";
            tabControl_Home.Padding = new Point(50, 10);
            tabControl_Home.SelectedIndex = 0;
            tabControl_Home.Size = new Size(1328, 526);
            tabControl_Home.TabIndex = 1;
            // 
            // tabPage_users
            // 
            tabPage_users.Controls.Add(dataGridView_home_users);
            tabPage_users.Controls.Add(refresh_user_btn);
            tabPage_users.Controls.Add(drop_user_btn);
            tabPage_users.Controls.Add(edit_user_btn);
            tabPage_users.Controls.Add(viewDetail_user_btn);
            tabPage_users.Controls.Add(new_user_btn);
            tabPage_users.Location = new Point(4, 43);
            tabPage_users.Name = "tabPage_users";
            tabPage_users.Padding = new Padding(3);
            tabPage_users.Size = new Size(1320, 479);
            tabPage_users.TabIndex = 0;
            tabPage_users.Text = "Users";
            tabPage_users.UseVisualStyleBackColor = true;
            // 
            // dataGridView_home_users
            // 
            dataGridView_home_users.AllowUserToAddRows = false;
            dataGridView_home_users.AllowUserToDeleteRows = false;
            dataGridView_home_users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_home_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_home_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_home_users.Location = new Point(30, 35);
            dataGridView_home_users.Name = "dataGridView_home_users";
            dataGridView_home_users.ReadOnly = true;
            dataGridView_home_users.RowHeadersWidth = 51;
            dataGridView_home_users.RowTemplate.Height = 29;
            dataGridView_home_users.Size = new Size(1075, 421);
            dataGridView_home_users.TabIndex = 11;
            // 
            // refresh_user_btn
            // 
            refresh_user_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refresh_user_btn.BackColor = SystemColors.ButtonHighlight;
            refresh_user_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            refresh_user_btn.FlatAppearance.BorderSize = 3;
            refresh_user_btn.FlatStyle = FlatStyle.Flat;
            refresh_user_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            refresh_user_btn.ForeColor = SystemColors.HotTrack;
            refresh_user_btn.Location = new Point(1133, 358);
            refresh_user_btn.Name = "refresh_user_btn";
            refresh_user_btn.Size = new Size(159, 51);
            refresh_user_btn.TabIndex = 4;
            refresh_user_btn.Text = "Refresh";
            refresh_user_btn.UseVisualStyleBackColor = false;
            refresh_user_btn.Click += refresh_user_btn_Click;
            // 
            // drop_user_btn
            // 
            drop_user_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            drop_user_btn.BackColor = SystemColors.ButtonHighlight;
            drop_user_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            drop_user_btn.FlatAppearance.BorderSize = 3;
            drop_user_btn.FlatStyle = FlatStyle.Flat;
            drop_user_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            drop_user_btn.ForeColor = SystemColors.HotTrack;
            drop_user_btn.Location = new Point(1133, 277);
            drop_user_btn.Name = "drop_user_btn";
            drop_user_btn.Size = new Size(159, 51);
            drop_user_btn.TabIndex = 3;
            drop_user_btn.Text = "Drop User";
            drop_user_btn.UseVisualStyleBackColor = false;
            drop_user_btn.Click += drop_user_btn_Click;
            // 
            // edit_user_btn
            // 
            edit_user_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            edit_user_btn.BackColor = SystemColors.ButtonHighlight;
            edit_user_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            edit_user_btn.FlatAppearance.BorderSize = 3;
            edit_user_btn.FlatStyle = FlatStyle.Flat;
            edit_user_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            edit_user_btn.ForeColor = SystemColors.HotTrack;
            edit_user_btn.Location = new Point(1133, 191);
            edit_user_btn.Name = "edit_user_btn";
            edit_user_btn.Size = new Size(159, 51);
            edit_user_btn.TabIndex = 2;
            edit_user_btn.Text = "Edit User";
            edit_user_btn.UseVisualStyleBackColor = false;
            edit_user_btn.Click += edit_user_btn_Click;
            // 
            // viewDetail_user_btn
            // 
            viewDetail_user_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            viewDetail_user_btn.BackColor = SystemColors.ButtonHighlight;
            viewDetail_user_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            viewDetail_user_btn.FlatAppearance.BorderSize = 3;
            viewDetail_user_btn.FlatStyle = FlatStyle.Flat;
            viewDetail_user_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            viewDetail_user_btn.ForeColor = SystemColors.HotTrack;
            viewDetail_user_btn.Location = new Point(1133, 104);
            viewDetail_user_btn.Name = "viewDetail_user_btn";
            viewDetail_user_btn.Size = new Size(159, 51);
            viewDetail_user_btn.TabIndex = 1;
            viewDetail_user_btn.Text = "View Detail";
            viewDetail_user_btn.UseVisualStyleBackColor = false;
            viewDetail_user_btn.Click += viewDetail_user_btn_Click;
            // 
            // new_user_btn
            // 
            new_user_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            new_user_btn.BackColor = SystemColors.ButtonHighlight;
            new_user_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            new_user_btn.FlatAppearance.BorderSize = 3;
            new_user_btn.FlatStyle = FlatStyle.Flat;
            new_user_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            new_user_btn.ForeColor = SystemColors.HotTrack;
            new_user_btn.Location = new Point(1133, 21);
            new_user_btn.Name = "new_user_btn";
            new_user_btn.Size = new Size(159, 51);
            new_user_btn.TabIndex = 0;
            new_user_btn.Text = "New User";
            new_user_btn.UseVisualStyleBackColor = false;
            new_user_btn.Click += new_user_btn_Click;
            // 
            // tabPage_roles
            // 
            tabPage_roles.Controls.Add(dataGridView_home_roles);
            tabPage_roles.Controls.Add(refresh_role_btn);
            tabPage_roles.Controls.Add(drop_role_btn);
            tabPage_roles.Controls.Add(edit_role_btn);
            tabPage_roles.Controls.Add(viewDetail_role_btn);
            tabPage_roles.Controls.Add(new_role_btn);
            tabPage_roles.Location = new Point(4, 43);
            tabPage_roles.Name = "tabPage_roles";
            tabPage_roles.Padding = new Padding(3);
            tabPage_roles.Size = new Size(1320, 479);
            tabPage_roles.TabIndex = 1;
            tabPage_roles.Text = "Roles";
            tabPage_roles.UseVisualStyleBackColor = true;
            // 
            // dataGridView_home_roles
            // 
            dataGridView_home_roles.AllowUserToAddRows = false;
            dataGridView_home_roles.AllowUserToDeleteRows = false;
            dataGridView_home_roles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_home_roles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_home_roles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_home_roles.Location = new Point(30, 35);
            dataGridView_home_roles.Name = "dataGridView_home_roles";
            dataGridView_home_roles.ReadOnly = true;
            dataGridView_home_roles.RowHeadersWidth = 51;
            dataGridView_home_roles.RowTemplate.Height = 29;
            dataGridView_home_roles.Size = new Size(1075, 421);
            dataGridView_home_roles.TabIndex = 12;
            // 
            // refresh_role_btn
            // 
            refresh_role_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refresh_role_btn.BackColor = SystemColors.ButtonHighlight;
            refresh_role_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            refresh_role_btn.FlatAppearance.BorderSize = 3;
            refresh_role_btn.FlatStyle = FlatStyle.Flat;
            refresh_role_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            refresh_role_btn.ForeColor = SystemColors.HotTrack;
            refresh_role_btn.Location = new Point(1133, 358);
            refresh_role_btn.Name = "refresh_role_btn";
            refresh_role_btn.Size = new Size(159, 51);
            refresh_role_btn.TabIndex = 9;
            refresh_role_btn.Text = "Refresh";
            refresh_role_btn.UseVisualStyleBackColor = false;
            refresh_role_btn.Click += refresh_role_btn_Click;
            // 
            // drop_role_btn
            // 
            drop_role_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            drop_role_btn.BackColor = SystemColors.ButtonHighlight;
            drop_role_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            drop_role_btn.FlatAppearance.BorderSize = 3;
            drop_role_btn.FlatStyle = FlatStyle.Flat;
            drop_role_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            drop_role_btn.ForeColor = SystemColors.HotTrack;
            drop_role_btn.Location = new Point(1133, 277);
            drop_role_btn.Name = "drop_role_btn";
            drop_role_btn.Size = new Size(159, 51);
            drop_role_btn.TabIndex = 8;
            drop_role_btn.Text = "Drop Role";
            drop_role_btn.UseVisualStyleBackColor = false;
            drop_role_btn.Click += drop_role_btn_Click;
            // 
            // edit_role_btn
            // 
            edit_role_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            edit_role_btn.BackColor = SystemColors.ButtonHighlight;
            edit_role_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            edit_role_btn.FlatAppearance.BorderSize = 3;
            edit_role_btn.FlatStyle = FlatStyle.Flat;
            edit_role_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            edit_role_btn.ForeColor = SystemColors.HotTrack;
            edit_role_btn.Location = new Point(1133, 191);
            edit_role_btn.Name = "edit_role_btn";
            edit_role_btn.Size = new Size(159, 51);
            edit_role_btn.TabIndex = 7;
            edit_role_btn.Text = "Edit Role";
            edit_role_btn.UseVisualStyleBackColor = false;
            edit_role_btn.Click += edit_role_btn_Click;
            // 
            // viewDetail_role_btn
            // 
            viewDetail_role_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            viewDetail_role_btn.BackColor = SystemColors.ButtonHighlight;
            viewDetail_role_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            viewDetail_role_btn.FlatAppearance.BorderSize = 3;
            viewDetail_role_btn.FlatStyle = FlatStyle.Flat;
            viewDetail_role_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            viewDetail_role_btn.ForeColor = SystemColors.HotTrack;
            viewDetail_role_btn.Location = new Point(1133, 104);
            viewDetail_role_btn.Name = "viewDetail_role_btn";
            viewDetail_role_btn.Size = new Size(159, 51);
            viewDetail_role_btn.TabIndex = 6;
            viewDetail_role_btn.Text = "View Detail";
            viewDetail_role_btn.UseVisualStyleBackColor = false;
            viewDetail_role_btn.Click += viewDetail_role_btn_Click;
            // 
            // new_role_btn
            // 
            new_role_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            new_role_btn.BackColor = SystemColors.ButtonHighlight;
            new_role_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            new_role_btn.FlatAppearance.BorderSize = 3;
            new_role_btn.FlatStyle = FlatStyle.Flat;
            new_role_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            new_role_btn.ForeColor = SystemColors.HotTrack;
            new_role_btn.Location = new Point(1133, 21);
            new_role_btn.Name = "new_role_btn";
            new_role_btn.Size = new Size(159, 51);
            new_role_btn.TabIndex = 5;
            new_role_btn.Text = "New Role";
            new_role_btn.UseVisualStyleBackColor = false;
            new_role_btn.Click += new_role_btn_Click;
            // 
            // tabPage_standard_audit
            // 
            tabPage_standard_audit.Controls.Add(find_btn);
            tabPage_standard_audit.Controls.Add(filer_textBox);
            tabPage_standard_audit.Controls.Add(dataGridView_audit);
            tabPage_standard_audit.Location = new Point(4, 43);
            tabPage_standard_audit.Name = "tabPage_standard_audit";
            tabPage_standard_audit.Size = new Size(1320, 479);
            tabPage_standard_audit.TabIndex = 2;
            tabPage_standard_audit.Text = "Standard Audit";
            tabPage_standard_audit.UseVisualStyleBackColor = true;
            // 
            // find_btn
            // 
            find_btn.BackColor = SystemColors.ButtonHighlight;
            find_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            find_btn.FlatAppearance.BorderSize = 3;
            find_btn.FlatStyle = FlatStyle.Flat;
            find_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            find_btn.ForeColor = SystemColors.HotTrack;
            find_btn.Location = new Point(312, 14);
            find_btn.Name = "find_btn";
            find_btn.Size = new Size(92, 42);
            find_btn.TabIndex = 15;
            find_btn.Text = "Tìm";
            find_btn.UseVisualStyleBackColor = false;
            find_btn.Click += find_btn_Click;
            // 
            // filer_textBox
            // 
            filer_textBox.Location = new Point(22, 20);
            filer_textBox.Name = "filer_textBox";
            filer_textBox.Size = new Size(260, 27);
            filer_textBox.TabIndex = 14;
            filer_textBox.Text = "Nhập tên người dùng...";
            filer_textBox.Enter += filer_textBox_Enter;
            filer_textBox.Leave += filer_textBox_Leave;
            // 
            // dataGridView_audit
            // 
            dataGridView_audit.AllowUserToAddRows = false;
            dataGridView_audit.AllowUserToDeleteRows = false;
            dataGridView_audit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_audit.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_audit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_audit.Location = new Point(22, 68);
            dataGridView_audit.Name = "dataGridView_audit";
            dataGridView_audit.ReadOnly = true;
            dataGridView_audit.RowHeadersWidth = 51;
            dataGridView_audit.RowTemplate.Height = 29;
            dataGridView_audit.Size = new Size(1265, 388);
            dataGridView_audit.TabIndex = 13;
            // 
            // Home_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1382, 653);
            Controls.Add(tabControl_Home);
            Controls.Add(panel1);
            Name = "Home_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            FormClosing += Home_Form_FormClosing;
            Load += Home_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl_Home.ResumeLayout(false);
            tabPage_users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_home_users).EndInit();
            tabPage_roles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_home_roles).EndInit();
            tabPage_standard_audit.ResumeLayout(false);
            tabPage_standard_audit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_audit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl_Home;
        private TabPage tabPage_users;
        private TabPage tabPage_roles;
        private Button new_user_btn;
        private Button refresh_user_btn;
        private Button drop_user_btn;
        private Button edit_user_btn;
        private Button viewDetail_user_btn;
        private Button refresh_role_btn;
        private Button drop_role_btn;
        private Button edit_role_btn;
        private Button viewDetail_role_btn;
        private Button new_role_btn;
        private DataGridView dataGridView_home_users;
        private DataGridView dataGridView_home_roles;
        private TabPage tabPage_standard_audit;
        private DataGridView dataGridView_audit;
        private TextBox filer_textBox;
        private Button find_btn;
    }
}