namespace portal_application_project
{
    partial class Login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_login_password = new TextBox();
            button_login = new Button();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            textBox_login_username = new TextBox();
            SuspendLayout();
            // 
            // textBox_login_password
            // 
            textBox_login_password.Anchor = AnchorStyles.Top;
            textBox_login_password.Location = new Point(233, 213);
            textBox_login_password.Name = "textBox_login_password";
            textBox_login_password.Size = new Size(392, 27);
            textBox_login_password.TabIndex = 34;
            textBox_login_password.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            button_login.Anchor = AnchorStyles.Top;
            button_login.AutoSize = true;
            button_login.Location = new Point(531, 290);
            button_login.Name = "button_login";
            button_login.RightToLeft = RightToLeft.Yes;
            button_login.Size = new Size(94, 30);
            button_login.TabIndex = 32;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(87, 213);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 31;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(327, 49);
            label1.Name = "label1";
            label1.Size = new Size(124, 46);
            label1.TabIndex = 30;
            label1.Text = "LOGIN";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(87, 156);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 29;
            label10.Text = "Username";
            // 
            // textBox_login_username
            // 
            textBox_login_username.Anchor = AnchorStyles.Top;
            textBox_login_username.BackColor = Color.White;
            textBox_login_username.Location = new Point(233, 156);
            textBox_login_username.Name = "textBox_login_username";
            textBox_login_username.Size = new Size(392, 27);
            textBox_login_username.TabIndex = 35;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(753, 393);
            Controls.Add(textBox_login_username);
            Controls.Add(textBox_login_password);
            Controls.Add(button_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_login_password;
        private Button button_login;
        private Label label2;
        private Label label1;
        private Label label10;
        private TextBox textBox_login_username;
    }
}