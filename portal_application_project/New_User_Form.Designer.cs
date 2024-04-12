namespace portal_application_project
{
    partial class New_User_Form
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
            textBox_addUser_username = new TextBox();
            textBox_addUser_password = new TextBox();
            label2 = new Label();
            label10 = new Label();
            label3 = new Label();
            textBox_addUser_confirmPassword = new TextBox();
            label4 = new Label();
            checkBox1 = new CheckBox();
            add_user_btn = new Button();
            close_btn = new Button();
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
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(307, 11);
            label1.Name = "label1";
            label1.Size = new Size(210, 41);
            label1.TabIndex = 1;
            label1.Text = "Add new user";
            // 
            // textBox_addUser_username
            // 
            textBox_addUser_username.Anchor = AnchorStyles.Top;
            textBox_addUser_username.BackColor = Color.White;
            textBox_addUser_username.Location = new Point(262, 156);
            textBox_addUser_username.Name = "textBox_addUser_username";
            textBox_addUser_username.Size = new Size(392, 27);
            textBox_addUser_username.TabIndex = 40;
            // 
            // textBox_addUser_password
            // 
            textBox_addUser_password.Anchor = AnchorStyles.Top;
            textBox_addUser_password.Location = new Point(262, 213);
            textBox_addUser_password.Name = "textBox_addUser_password";
            textBox_addUser_password.Size = new Size(392, 27);
            textBox_addUser_password.TabIndex = 39;
            textBox_addUser_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(166, 216);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 37;
            label2.Text = "Password";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(161, 156);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 36;
            label10.Text = "Username";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(116, 274);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 41;
            label3.Text = "Confirm password";
            // 
            // textBox_addUser_confirmPassword
            // 
            textBox_addUser_confirmPassword.Anchor = AnchorStyles.Top;
            textBox_addUser_confirmPassword.Location = new Point(262, 271);
            textBox_addUser_confirmPassword.Name = "textBox_addUser_confirmPassword";
            textBox_addUser_confirmPassword.Size = new Size(392, 27);
            textBox_addUser_confirmPassword.TabIndex = 42;
            textBox_addUser_confirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(197, 332);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 43;
            label4.Text = "Lock";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(262, 335);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 44;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // add_user_btn
            // 
            add_user_btn.Anchor = AnchorStyles.Top;
            add_user_btn.BackColor = SystemColors.ButtonHighlight;
            add_user_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            add_user_btn.FlatAppearance.BorderSize = 3;
            add_user_btn.FlatStyle = FlatStyle.Flat;
            add_user_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add_user_btn.ForeColor = SystemColors.HotTrack;
            add_user_btn.Location = new Point(335, 375);
            add_user_btn.Name = "add_user_btn";
            add_user_btn.Size = new Size(159, 51);
            add_user_btn.TabIndex = 45;
            add_user_btn.Text = "Add";
            add_user_btn.UseVisualStyleBackColor = false;
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
            close_btn.Location = new Point(608, 375);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(78, 51);
            close_btn.TabIndex = 46;
            close_btn.Text = "Close";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // New_User_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(close_btn);
            Controls.Add(add_user_btn);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(textBox_addUser_confirmPassword);
            Controls.Add(label3);
            Controls.Add(textBox_addUser_username);
            Controls.Add(textBox_addUser_password);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(panel1);
            Name = "New_User_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New User";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox_addUser_username;
        private TextBox textBox_addUser_password;
        private Label label2;
        private Label label10;
        private Label label3;
        private TextBox textBox_addUser_confirmPassword;
        private Label label4;
        private CheckBox checkBox1;
        private Button add_user_btn;
        private Button close_btn;
    }
}