namespace portal_application_project
{
    partial class View_Detail_Role_Form
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
            dataGridView_role_columns_privileges = new DataGridView();
            tabControl_detailRole_privileges = new TabControl();
            user_system_privileges = new TabPage();
            dataGridView_role_system_privileges = new DataGridView();
            user_object_privileges = new TabPage();
            dataGridView_role_object_privileges = new DataGridView();
            user_column_privileges = new TabPage();
            label_inherited = new Label();
            label_passwordRequired = new Label();
            label_roleName = new Label();
            label_roleID = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label10 = new Label();
            label_roleName_heading = new Label();
            panel1 = new Panel();
            close_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_role_columns_privileges).BeginInit();
            tabControl_detailRole_privileges.SuspendLayout();
            user_system_privileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_role_system_privileges).BeginInit();
            user_object_privileges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_role_object_privileges).BeginInit();
            user_column_privileges.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_role_columns_privileges
            // 
            dataGridView_role_columns_privileges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_role_columns_privileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_role_columns_privileges.Dock = DockStyle.Fill;
            dataGridView_role_columns_privileges.Location = new Point(0, 0);
            dataGridView_role_columns_privileges.Name = "dataGridView_role_columns_privileges";
            dataGridView_role_columns_privileges.RowHeadersWidth = 51;
            dataGridView_role_columns_privileges.RowTemplate.Height = 29;
            dataGridView_role_columns_privileges.Size = new Size(869, 149);
            dataGridView_role_columns_privileges.TabIndex = 0;
            // 
            // tabControl_detailRole_privileges
            // 
            tabControl_detailRole_privileges.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl_detailRole_privileges.Controls.Add(user_system_privileges);
            tabControl_detailRole_privileges.Controls.Add(user_object_privileges);
            tabControl_detailRole_privileges.Controls.Add(user_column_privileges);
            tabControl_detailRole_privileges.Location = new Point(74, 324);
            tabControl_detailRole_privileges.Name = "tabControl_detailRole_privileges";
            tabControl_detailRole_privileges.Padding = new Point(13, 6);
            tabControl_detailRole_privileges.SelectedIndex = 0;
            tabControl_detailRole_privileges.Size = new Size(877, 188);
            tabControl_detailRole_privileges.TabIndex = 69;
            // 
            // user_system_privileges
            // 
            user_system_privileges.Controls.Add(dataGridView_role_system_privileges);
            user_system_privileges.Location = new Point(4, 35);
            user_system_privileges.Name = "user_system_privileges";
            user_system_privileges.Padding = new Padding(3);
            user_system_privileges.Size = new Size(869, 149);
            user_system_privileges.TabIndex = 0;
            user_system_privileges.Text = "System";
            user_system_privileges.UseVisualStyleBackColor = true;
            // 
            // dataGridView_role_system_privileges
            // 
            dataGridView_role_system_privileges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_role_system_privileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_role_system_privileges.Dock = DockStyle.Fill;
            dataGridView_role_system_privileges.Location = new Point(3, 3);
            dataGridView_role_system_privileges.Name = "dataGridView_role_system_privileges";
            dataGridView_role_system_privileges.RowHeadersWidth = 51;
            dataGridView_role_system_privileges.RowTemplate.Height = 29;
            dataGridView_role_system_privileges.Size = new Size(863, 143);
            dataGridView_role_system_privileges.TabIndex = 0;
            // 
            // user_object_privileges
            // 
            user_object_privileges.Controls.Add(dataGridView_role_object_privileges);
            user_object_privileges.Location = new Point(4, 35);
            user_object_privileges.Name = "user_object_privileges";
            user_object_privileges.Padding = new Padding(3);
            user_object_privileges.Size = new Size(869, 149);
            user_object_privileges.TabIndex = 1;
            user_object_privileges.Text = "Object";
            user_object_privileges.UseVisualStyleBackColor = true;
            // 
            // dataGridView_role_object_privileges
            // 
            dataGridView_role_object_privileges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_role_object_privileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_role_object_privileges.Dock = DockStyle.Fill;
            dataGridView_role_object_privileges.Location = new Point(3, 3);
            dataGridView_role_object_privileges.Name = "dataGridView_role_object_privileges";
            dataGridView_role_object_privileges.RowHeadersWidth = 51;
            dataGridView_role_object_privileges.RowTemplate.Height = 29;
            dataGridView_role_object_privileges.Size = new Size(863, 143);
            dataGridView_role_object_privileges.TabIndex = 0;
            // 
            // user_column_privileges
            // 
            user_column_privileges.Controls.Add(dataGridView_role_columns_privileges);
            user_column_privileges.Location = new Point(4, 35);
            user_column_privileges.Name = "user_column_privileges";
            user_column_privileges.Size = new Size(869, 149);
            user_column_privileges.TabIndex = 2;
            user_column_privileges.Text = "Columns";
            user_column_privileges.UseVisualStyleBackColor = true;
            // 
            // label_inherited
            // 
            label_inherited.Anchor = AnchorStyles.Top;
            label_inherited.AutoSize = true;
            label_inherited.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_inherited.Location = new Point(279, 231);
            label_inherited.Name = "label_inherited";
            label_inherited.Size = new Size(87, 28);
            label_inherited.TabIndex = 68;
            label_inherited.Text = "...............";
            // 
            // label_passwordRequired
            // 
            label_passwordRequired.Anchor = AnchorStyles.Top;
            label_passwordRequired.AutoSize = true;
            label_passwordRequired.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_passwordRequired.Location = new Point(279, 178);
            label_passwordRequired.Name = "label_passwordRequired";
            label_passwordRequired.Size = new Size(87, 28);
            label_passwordRequired.TabIndex = 67;
            label_passwordRequired.Text = "...............";
            // 
            // label_roleName
            // 
            label_roleName.Anchor = AnchorStyles.Top;
            label_roleName.AutoSize = true;
            label_roleName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_roleName.Location = new Point(279, 131);
            label_roleName.Name = "label_roleName";
            label_roleName.Size = new Size(87, 28);
            label_roleName.TabIndex = 66;
            label_roleName.Text = "...............";
            // 
            // label_roleID
            // 
            label_roleID.Anchor = AnchorStyles.Top;
            label_roleID.AutoSize = true;
            label_roleID.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label_roleID.Location = new Point(279, 83);
            label_roleID.Name = "label_roleID";
            label_roleID.Size = new Size(87, 28);
            label_roleID.TabIndex = 65;
            label_roleID.Text = "...............";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(81, 279);
            label5.Name = "label5";
            label5.Size = new Size(109, 28);
            label5.TabIndex = 64;
            label5.Text = "Privileges:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(81, 231);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 63;
            label4.Text = "Inherited:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(81, 178);
            label3.Name = "label3";
            label3.Size = new Size(192, 28);
            label3.TabIndex = 62;
            label3.Text = "Password required:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(81, 131);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 61;
            label2.Text = "Role name:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(81, 83);
            label10.Name = "label10";
            label10.Size = new Size(86, 28);
            label10.TabIndex = 60;
            label10.Text = "Role ID:";
            // 
            // label_roleName_heading
            // 
            label_roleName_heading.Anchor = AnchorStyles.Top;
            label_roleName_heading.AutoSize = true;
            label_roleName_heading.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_roleName_heading.ForeColor = Color.White;
            label_roleName_heading.Location = new Point(436, 9);
            label_roleName_heading.Name = "label_roleName_heading";
            label_roleName_heading.Size = new Size(178, 41);
            label_roleName_heading.TabIndex = 1;
            label_roleName_heading.Text = "[roleName]";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label_roleName_heading);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 70);
            panel1.TabIndex = 59;
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
            close_btn.Location = new Point(982, 454);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(78, 51);
            close_btn.TabIndex = 70;
            close_btn.Text = "Close";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // View_Detail_Role_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 524);
            Controls.Add(close_btn);
            Controls.Add(tabControl_detailRole_privileges);
            Controls.Add(label_inherited);
            Controls.Add(label_passwordRequired);
            Controls.Add(label_roleName);
            Controls.Add(label_roleID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(panel1);
            Name = "View_Detail_Role_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Detail Role";
            Load += View_Detail_Role_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_role_columns_privileges).EndInit();
            tabControl_detailRole_privileges.ResumeLayout(false);
            user_system_privileges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_role_system_privileges).EndInit();
            user_object_privileges.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_role_object_privileges).EndInit();
            user_column_privileges.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_role_columns_privileges;
        private TabControl tabControl_detailRole_privileges;
        private TabPage user_system_privileges;
        private DataGridView dataGridView_role_system_privileges;
        private TabPage user_object_privileges;
        private DataGridView dataGridView_role_object_privileges;
        private TabPage user_column_privileges;
        private Label label_inherited;
        private Label label_passwordRequired;
        private Label label_roleName;
        private Label label_roleID;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private Label label_roleName_heading;
        private Panel panel1;
        private Button close_btn;
    }
}