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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            imageList1 = new ImageList(components);
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            login_with_label = new Label();
            admin_checkbox = new CheckBox();
            user_checkbox = new CheckBox();
            username_label = new Label();
            button_login = new Button();
            textBox_login_username = new TextBox();
            pass_label = new Label();
            textBox_login_password = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "logo-hcmus.png");
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 240);
            label1.Name = "label1";
            label1.Size = new Size(283, 32);
            label1.TabIndex = 47;
            label1.Text = "University X Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.logo_hcmus;
            panel1.Location = new Point(82, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 203);
            panel1.TabIndex = 46;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 217, 217);
            panel2.Controls.Add(login_with_label);
            panel2.Controls.Add(admin_checkbox);
            panel2.Controls.Add(user_checkbox);
            panel2.Controls.Add(username_label);
            panel2.Controls.Add(button_login);
            panel2.Controls.Add(textBox_login_username);
            panel2.Controls.Add(pass_label);
            panel2.Controls.Add(textBox_login_password);
            panel2.Location = new Point(12, 315);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 269);
            panel2.TabIndex = 48;
            // 
            // login_with_label
            // 
            login_with_label.Anchor = AnchorStyles.Top;
            login_with_label.AutoSize = true;
            login_with_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            login_with_label.Location = new Point(34, 182);
            login_with_label.Name = "login_with_label";
            login_with_label.Size = new Size(74, 28);
            login_with_label.TabIndex = 52;
            login_with_label.Text = "Vai trò";
            // 
            // admin_checkbox
            // 
            admin_checkbox.AutoSize = true;
            admin_checkbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            admin_checkbox.Location = new Point(128, 222);
            admin_checkbox.Name = "admin_checkbox";
            admin_checkbox.Size = new Size(89, 32);
            admin_checkbox.TabIndex = 51;
            admin_checkbox.Text = "admin";
            admin_checkbox.UseVisualStyleBackColor = true;
            // 
            // user_checkbox
            // 
            user_checkbox.AutoSize = true;
            user_checkbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            user_checkbox.Location = new Point(38, 222);
            user_checkbox.Name = "user_checkbox";
            user_checkbox.Size = new Size(70, 32);
            user_checkbox.TabIndex = 50;
            user_checkbox.Text = "user";
            user_checkbox.UseVisualStyleBackColor = true;
            // 
            // username_label
            // 
            username_label.Anchor = AnchorStyles.Top;
            username_label.AutoSize = true;
            username_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            username_label.Location = new Point(34, 8);
            username_label.Name = "username_label";
            username_label.Size = new Size(103, 28);
            username_label.TabIndex = 49;
            username_label.Text = "Tài khoản";
            // 
            // button_login
            // 
            button_login.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_login.AutoSize = true;
            button_login.BackColor = Color.FromArgb(1, 69, 142);
            button_login.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(240, 218);
            button_login.Name = "button_login";
            button_login.RightToLeft = RightToLeft.Yes;
            button_login.Size = new Size(116, 43);
            button_login.TabIndex = 45;
            button_login.Text = "Đăng nhập";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // textBox_login_username
            // 
            textBox_login_username.Anchor = AnchorStyles.Top;
            textBox_login_username.BackColor = Color.White;
            textBox_login_username.Location = new Point(34, 52);
            textBox_login_username.Name = "textBox_login_username";
            textBox_login_username.Size = new Size(313, 27);
            textBox_login_username.TabIndex = 47;
            // 
            // pass_label
            // 
            pass_label.Anchor = AnchorStyles.Top;
            pass_label.AutoSize = true;
            pass_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pass_label.Location = new Point(34, 99);
            pass_label.Name = "pass_label";
            pass_label.Size = new Size(102, 28);
            pass_label.TabIndex = 48;
            pass_label.Text = "Mật khẩu";
            // 
            // textBox_login_password
            // 
            textBox_login_password.Anchor = AnchorStyles.Top;
            textBox_login_password.Location = new Point(34, 140);
            textBox_login_password.Name = "textBox_login_password";
            textBox_login_password.Size = new Size(313, 27);
            textBox_login_password.TabIndex = 46;
            textBox_login_password.UseSystemPasswordChar = true;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 613);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public ImageList imageList1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label login_with_label;
        private CheckBox admin_checkbox;
        private CheckBox user_checkbox;
        private Label username_label;
        private Button button_login;
        private TextBox textBox_login_username;
        private Label pass_label;
        private TextBox textBox_login_password;
    }
}