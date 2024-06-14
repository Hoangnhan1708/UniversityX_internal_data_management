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
            textBox_login_password = new TextBox();
            button_login = new Button();
            label2 = new Label();
            label10 = new Label();
            textBox_login_username = new TextBox();
            pass_label = new Label();
            username_label = new Label();
            mini_background_login = new Panel();
            login_with_label = new Label();
            admin_checkbox = new CheckBox();
            user_checkbox = new CheckBox();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            label1 = new Label();
            mini_background_login.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_login_password
            // 
            textBox_login_password.Anchor = AnchorStyles.Top;
            textBox_login_password.Location = new Point(36, 150);
            textBox_login_password.Name = "textBox_login_password";
            textBox_login_password.Size = new Size(313, 27);
            textBox_login_password.TabIndex = 34;
            textBox_login_password.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            button_login.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_login.AutoSize = true;
            button_login.BackColor = Color.FromArgb(1, 69, 142);
            button_login.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button_login.ForeColor = Color.White;
            button_login.Location = new Point(242, 228);
            button_login.Name = "button_login";
            button_login.RightToLeft = RightToLeft.Yes;
            button_login.Size = new Size(116, 43);
            button_login.TabIndex = 32;
            button_login.Text = "Đăng nhập";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(-82, 213);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 31;
            label2.Text = "Password";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(-82, 156);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 29;
            label10.Text = "Username";
            // 
            // textBox_login_username
            // 
            textBox_login_username.Anchor = AnchorStyles.Top;
            textBox_login_username.BackColor = Color.White;
            textBox_login_username.Location = new Point(36, 62);
            textBox_login_username.Name = "textBox_login_username";
            textBox_login_username.Size = new Size(313, 27);
            textBox_login_username.TabIndex = 35;
            // 
            // pass_label
            // 
            pass_label.Anchor = AnchorStyles.Top;
            pass_label.AutoSize = true;
            pass_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pass_label.Location = new Point(36, 109);
            pass_label.Name = "pass_label";
            pass_label.Size = new Size(102, 28);
            pass_label.TabIndex = 36;
            pass_label.Text = "Mật khẩu";
            // 
            // username_label
            // 
            username_label.Anchor = AnchorStyles.Top;
            username_label.AutoSize = true;
            username_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            username_label.Location = new Point(36, 18);
            username_label.Name = "username_label";
            username_label.Size = new Size(103, 28);
            username_label.TabIndex = 37;
            username_label.Text = "Tài khoản";
            // 
            // mini_background_login
            // 
            mini_background_login.BackColor = Color.FromArgb(217, 217, 217);
            mini_background_login.Controls.Add(login_with_label);
            mini_background_login.Controls.Add(admin_checkbox);
            mini_background_login.Controls.Add(user_checkbox);
            mini_background_login.Controls.Add(username_label);
            mini_background_login.Controls.Add(button_login);
            mini_background_login.Controls.Add(textBox_login_username);
            mini_background_login.Controls.Add(pass_label);
            mini_background_login.Controls.Add(textBox_login_password);
            mini_background_login.Location = new Point(12, 318);
            mini_background_login.Name = "mini_background_login";
            mini_background_login.Size = new Size(390, 283);
            mini_background_login.TabIndex = 40;
            // 
            // login_with_label
            // 
            login_with_label.Anchor = AnchorStyles.Top;
            login_with_label.AutoSize = true;
            login_with_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            login_with_label.Location = new Point(36, 192);
            login_with_label.Name = "login_with_label";
            login_with_label.Size = new Size(74, 28);
            login_with_label.TabIndex = 44;
            login_with_label.Text = "Vai trò";
            // 
            // admin_checkbox
            // 
            admin_checkbox.AutoSize = true;
            admin_checkbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            admin_checkbox.Location = new Point(130, 232);
            admin_checkbox.Name = "admin_checkbox";
            admin_checkbox.Size = new Size(89, 32);
            admin_checkbox.TabIndex = 43;
            admin_checkbox.Text = "admin";
            admin_checkbox.UseVisualStyleBackColor = true;
            admin_checkbox.CheckedChanged += admin_checkbox_CheckedChanged;
            // 
            // user_checkbox
            // 
            user_checkbox.AutoSize = true;
            user_checkbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            user_checkbox.Location = new Point(40, 232);
            user_checkbox.Name = "user_checkbox";
            user_checkbox.Size = new Size(70, 32);
            user_checkbox.TabIndex = 38;
            user_checkbox.Text = "user";
            user_checkbox.UseVisualStyleBackColor = true;
            user_checkbox.CheckedChanged += user_checkbox_CheckedChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "logo-hcmus.png");
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.logo_hcmus;
            panel1.Location = new Point(79, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 203);
            panel1.TabIndex = 41;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(67, 272);
            label1.Name = "label1";
            label1.Size = new Size(283, 32);
            label1.TabIndex = 42;
            label1.Text = "University X Dashboard";
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(414, 613);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(mini_background_login);
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            mini_background_login.ResumeLayout(false);
            mini_background_login.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_login_password;
        private Button button_login;
        private Label label2;
        private Label label10;
        private TextBox textBox_login_username;
        private Label pass_label;
        private Label username_label;
        private Panel mini_background_login;
        public ImageList imageList1;
        private Panel panel1;
        private Label label1;
        private Label login_with_label;
        private CheckBox admin_checkbox;
        private CheckBox user_checkbox;
    }
}