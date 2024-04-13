namespace portal_application_project
{
    partial class New_Role_Form
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
            close_btn = new Button();
            add_role_btn = new Button();
            textBox_addRole_roleName = new TextBox();
            label10 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 47;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(335, 11);
            label1.Name = "label1";
            label1.Size = new Size(206, 41);
            label1.TabIndex = 1;
            label1.Text = "Add new role";
            // 
            // close_btn
            // 
            close_btn.Anchor = AnchorStyles.Top;
            close_btn.BackColor = SystemColors.ButtonHighlight;
            close_btn.FlatAppearance.BorderColor = Color.Red;
            close_btn.FlatAppearance.BorderSize = 3;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            close_btn.ForeColor = Color.Red;
            close_btn.Location = new Point(608, 387);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(78, 51);
            close_btn.TabIndex = 57;
            close_btn.Text = "Close";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // add_role_btn
            // 
            add_role_btn.Anchor = AnchorStyles.Top;
            add_role_btn.BackColor = SystemColors.ButtonHighlight;
            add_role_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            add_role_btn.FlatAppearance.BorderSize = 3;
            add_role_btn.FlatStyle = FlatStyle.Flat;
            add_role_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add_role_btn.ForeColor = SystemColors.HotTrack;
            add_role_btn.Location = new Point(335, 387);
            add_role_btn.Name = "add_role_btn";
            add_role_btn.Size = new Size(159, 51);
            add_role_btn.TabIndex = 56;
            add_role_btn.Text = "Add";
            add_role_btn.UseVisualStyleBackColor = false;
            add_role_btn.Click += add_role_btn_Click;
            // 
            // textBox_addRole_roleName
            // 
            textBox_addRole_roleName.Anchor = AnchorStyles.Top;
            textBox_addRole_roleName.BackColor = Color.White;
            textBox_addRole_roleName.Location = new Point(263, 202);
            textBox_addRole_roleName.Name = "textBox_addRole_roleName";
            textBox_addRole_roleName.Size = new Size(392, 27);
            textBox_addRole_roleName.TabIndex = 51;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(152, 205);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 48;
            label10.Text = "Role name";
            // 
            // New_Role_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(close_btn);
            Controls.Add(add_role_btn);
            Controls.Add(textBox_addRole_roleName);
            Controls.Add(label10);
            Name = "New_Role_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Role";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button close_btn;
        private Button add_role_btn;
        private TextBox textBox_addRole_roleName;
        private Label label10;
    }
}