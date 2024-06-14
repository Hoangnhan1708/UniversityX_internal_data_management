namespace portal_application_project
{
    partial class SinhVien_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinhVien_Form));
            panel1 = new Panel();
            logout_btn = new Button();
            hello_name_label = new Label();
            text_hello = new Label();
            title = new Label();
            logo = new Panel();
            panel2 = new Panel();
            tabControl_sinhvien = new TabControl();
            tabPage_thongtinsv = new TabPage();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label18 = new Label();
            label17 = new Label();
            field_name = new Label();
            field_mssv = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            tabPage_hpdadangky = new TabPage();
            label4 = new Label();
            tabPage_kehoachmohp = new TabPage();
            label5 = new Label();
            tabPage_dkhp = new TabPage();
            label6 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            label2 = new Label();
            btn_kehoachmohp = new Label();
            btn_thongtinsv = new Label();
            btn_dkhp = new Label();
            hpddk_btn = new Label();
            panel3 = new Panel();
            dashboard_label = new Label();
            panel4 = new Panel();
            panel2.SuspendLayout();
            tabControl_sinhvien.SuspendLayout();
            tabPage_thongtinsv.SuspendLayout();
            tabPage_hpdadangky.SuspendLayout();
            tabPage_kehoachmohp.SuspendLayout();
            tabPage_dkhp.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(804, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(41, 41);
            panel1.TabIndex = 67;
            // 
            // logout_btn
            // 
            logout_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logout_btn.BackColor = Color.FromArgb(1, 69, 142);
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatAppearance.BorderColor = Color.FromArgb(1, 69, 142);
            logout_btn.FlatAppearance.BorderSize = 0;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Underline, GraphicsUnit.Point);
            logout_btn.ForeColor = Color.Transparent;
            logout_btn.Location = new Point(1137, 33);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(139, 59);
            logout_btn.TabIndex = 66;
            logout_btn.Text = "Đăng xuất";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // hello_name_label
            // 
            hello_name_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            hello_name_label.AutoSize = true;
            hello_name_label.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            hello_name_label.ForeColor = Color.White;
            hello_name_label.Location = new Point(974, 51);
            hello_name_label.Name = "hello_name_label";
            hello_name_label.Size = new Size(167, 26);
            hello_name_label.TabIndex = 65;
            hello_name_label.Text = "ShinichiKuNhan";
            // 
            // text_hello
            // 
            text_hello.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            text_hello.AutoSize = true;
            text_hello.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text_hello.ForeColor = Color.White;
            text_hello.Location = new Point(851, 51);
            text_hello.Name = "text_hello";
            text_hello.Size = new Size(130, 26);
            text_hello.TabIndex = 64;
            text_hello.Text = "(*) Xin chào";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.White;
            title.Location = new Point(123, 52);
            title.Name = "title";
            title.Size = new Size(250, 25);
            title.TabIndex = 63;
            title.Text = "University X Dashboard";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.Location = new Point(45, 33);
            logo.Name = "logo";
            logo.Size = new Size(72, 59);
            logo.TabIndex = 62;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tabControl_sinhvien);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(45, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(1276, 701);
            panel2.TabIndex = 68;
            // 
            // tabControl_sinhvien
            // 
            tabControl_sinhvien.Controls.Add(tabPage_thongtinsv);
            tabControl_sinhvien.Controls.Add(tabPage_hpdadangky);
            tabControl_sinhvien.Controls.Add(tabPage_kehoachmohp);
            tabControl_sinhvien.Controls.Add(tabPage_dkhp);
            tabControl_sinhvien.Location = new Point(279, 76);
            tabControl_sinhvien.Name = "tabControl_sinhvien";
            tabControl_sinhvien.Padding = new Point(0, 0);
            tabControl_sinhvien.SelectedIndex = 0;
            tabControl_sinhvien.Size = new Size(994, 625);
            tabControl_sinhvien.TabIndex = 28;
            tabControl_sinhvien.TabStop = false;
            // 
            // tabPage_thongtinsv
            // 
            tabPage_thongtinsv.Controls.Add(textBox2);
            tabPage_thongtinsv.Controls.Add(textBox1);
            tabPage_thongtinsv.Controls.Add(label24);
            tabPage_thongtinsv.Controls.Add(label23);
            tabPage_thongtinsv.Controls.Add(label22);
            tabPage_thongtinsv.Controls.Add(label21);
            tabPage_thongtinsv.Controls.Add(label18);
            tabPage_thongtinsv.Controls.Add(label17);
            tabPage_thongtinsv.Controls.Add(field_name);
            tabPage_thongtinsv.Controls.Add(field_mssv);
            tabPage_thongtinsv.Controls.Add(label15);
            tabPage_thongtinsv.Controls.Add(label14);
            tabPage_thongtinsv.Controls.Add(label13);
            tabPage_thongtinsv.Controls.Add(label12);
            tabPage_thongtinsv.Controls.Add(label11);
            tabPage_thongtinsv.Controls.Add(label10);
            tabPage_thongtinsv.Controls.Add(label9);
            tabPage_thongtinsv.Controls.Add(label8);
            tabPage_thongtinsv.Controls.Add(label7);
            tabPage_thongtinsv.Controls.Add(label3);
            tabPage_thongtinsv.Location = new Point(4, 29);
            tabPage_thongtinsv.Name = "tabPage_thongtinsv";
            tabPage_thongtinsv.Size = new Size(986, 592);
            tabPage_thongtinsv.TabIndex = 4;
            tabPage_thongtinsv.Text = "Thông tin sinh viên";
            tabPage_thongtinsv.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(362, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 27);
            textBox2.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(362, 219);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 27);
            textBox1.TabIndex = 20;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(362, 502);
            label24.Name = "label24";
            label24.Size = new Size(180, 28);
            label24.TabIndex = 19;
            label24.Text = "..........................................";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(362, 440);
            label23.Name = "label23";
            label23.Size = new Size(180, 28);
            label23.TabIndex = 18;
            label23.Text = "..........................................";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(362, 381);
            label22.Name = "label22";
            label22.Size = new Size(180, 28);
            label22.TabIndex = 17;
            label22.Text = "..........................................";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(362, 328);
            label21.Name = "label21";
            label21.Size = new Size(180, 28);
            label21.TabIndex = 16;
            label21.Text = "..........................................";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(362, 169);
            label18.Name = "label18";
            label18.Size = new Size(180, 28);
            label18.TabIndex = 13;
            label18.Text = "..........................................";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(362, 120);
            label17.Name = "label17";
            label17.Size = new Size(180, 28);
            label17.TabIndex = 12;
            label17.Text = "..........................................";
            // 
            // field_name
            // 
            field_name.AutoSize = true;
            field_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_name.Location = new Point(362, 72);
            field_name.Name = "field_name";
            field_name.Size = new Size(180, 28);
            field_name.TabIndex = 11;
            field_name.Text = "..........................................";
            // 
            // field_mssv
            // 
            field_mssv.AutoSize = true;
            field_mssv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_mssv.Location = new Point(362, 30);
            field_mssv.Name = "field_mssv";
            field_mssv.Size = new Size(180, 28);
            field_mssv.TabIndex = 10;
            field_mssv.Text = "..........................................";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(100, 502);
            label15.Name = "label15";
            label15.Size = new Size(227, 28);
            label15.TabIndex = 9;
            label15.Text = "Điểm trung bình tích lũy:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(100, 440);
            label14.Name = "label14";
            label14.Size = new Size(165, 28);
            label14.TabIndex = 8;
            label14.Text = "Số tín chỉ tích lũy:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(100, 381);
            label13.Name = "label13";
            label13.Size = new Size(104, 28);
            label13.TabIndex = 7;
            label13.Text = "Mã ngành:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(100, 328);
            label12.Name = "label12";
            label12.Size = new Size(205, 28);
            label12.TabIndex = 6;
            label12.Text = "Chương trình đào tạo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(100, 265);
            label11.Name = "label11";
            label11.Size = new Size(132, 28);
            label11.TabIndex = 5;
            label11.Text = "Số điện thoại:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(100, 215);
            label10.Name = "label10";
            label10.Size = new Size(75, 28);
            label10.TabIndex = 4;
            label10.Text = "Địa chỉ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(100, 72);
            label9.Name = "label9";
            label9.Size = new Size(75, 28);
            label9.TabIndex = 3;
            label9.Text = "Họ tên:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(100, 169);
            label8.Name = "label8";
            label8.Size = new Size(103, 28);
            label8.TabIndex = 2;
            label8.Text = "Ngày sinh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(100, 120);
            label7.Name = "label7";
            label7.Size = new Size(91, 28);
            label7.TabIndex = 1;
            label7.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(100, 30);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 0;
            label3.Text = "Mã số sinh viên:";
            // 
            // tabPage_hpdadangky
            // 
            tabPage_hpdadangky.Controls.Add(label4);
            tabPage_hpdadangky.Location = new Point(4, 29);
            tabPage_hpdadangky.Name = "tabPage_hpdadangky";
            tabPage_hpdadangky.Padding = new Padding(3);
            tabPage_hpdadangky.Size = new Size(986, 592);
            tabPage_hpdadangky.TabIndex = 1;
            tabPage_hpdadangky.Text = "Học phần đã đăng ký";
            tabPage_hpdadangky.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 269);
            label4.Name = "label4";
            label4.Size = new Size(147, 20);
            label4.TabIndex = 1;
            label4.Text = "học phần đã đăng ký";
            // 
            // tabPage_kehoachmohp
            // 
            tabPage_kehoachmohp.Controls.Add(label5);
            tabPage_kehoachmohp.Location = new Point(4, 29);
            tabPage_kehoachmohp.Name = "tabPage_kehoachmohp";
            tabPage_kehoachmohp.Size = new Size(986, 592);
            tabPage_kehoachmohp.TabIndex = 2;
            tabPage_kehoachmohp.Text = "Kế hoạch mở HP";
            tabPage_kehoachmohp.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(420, 286);
            label5.Name = "label5";
            label5.Size = new Size(115, 20);
            label5.TabIndex = 2;
            label5.Text = "kế hoạch mở hp";
            // 
            // tabPage_dkhp
            // 
            tabPage_dkhp.Controls.Add(label6);
            tabPage_dkhp.Location = new Point(4, 29);
            tabPage_dkhp.Name = "tabPage_dkhp";
            tabPage_dkhp.Size = new Size(986, 592);
            tabPage_dkhp.TabIndex = 3;
            tabPage_dkhp.Text = "Đăng ký học phần";
            tabPage_dkhp.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(436, 286);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 3;
            label6.Text = "Đăng ký hp";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel5.BackColor = Color.FromArgb(217, 217, 217);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(btn_kehoachmohp);
            panel5.Controls.Add(btn_thongtinsv);
            panel5.Controls.Add(btn_dkhp);
            panel5.Controls.Add(hpddk_btn);
            panel5.Location = new Point(0, 70);
            panel5.Name = "panel5";
            panel5.Size = new Size(273, 631);
            panel5.TabIndex = 27;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 35, 73);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(273, 58);
            panel6.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 17);
            label2.Name = "label2";
            label2.Size = new Size(101, 27);
            label2.TabIndex = 3;
            label2.Text = "Sinh viên";
            // 
            // btn_kehoachmohp
            // 
            btn_kehoachmohp.Anchor = AnchorStyles.Left;
            btn_kehoachmohp.AutoSize = true;
            btn_kehoachmohp.Cursor = Cursors.Hand;
            btn_kehoachmohp.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_kehoachmohp.ForeColor = Color.FromArgb(0, 35, 73);
            btn_kehoachmohp.Location = new Point(29, 237);
            btn_kehoachmohp.Name = "btn_kehoachmohp";
            btn_kehoachmohp.Size = new Size(228, 26);
            btn_kehoachmohp.TabIndex = 25;
            btn_kehoachmohp.Text = "Kế hoạch mở học phần";
            btn_kehoachmohp.Click += btn_kehoachmohp_Click;
            // 
            // btn_thongtinsv
            // 
            btn_thongtinsv.Anchor = AnchorStyles.Left;
            btn_thongtinsv.AutoSize = true;
            btn_thongtinsv.Cursor = Cursors.Hand;
            btn_thongtinsv.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thongtinsv.ForeColor = Color.FromArgb(0, 35, 73);
            btn_thongtinsv.Location = new Point(29, 122);
            btn_thongtinsv.Name = "btn_thongtinsv";
            btn_thongtinsv.Size = new Size(194, 26);
            btn_thongtinsv.TabIndex = 12;
            btn_thongtinsv.Text = "Thông tin sinh viên";
            btn_thongtinsv.Click += btn_thongtinsv_Click;
            // 
            // btn_dkhp
            // 
            btn_dkhp.Anchor = AnchorStyles.Left;
            btn_dkhp.AutoSize = true;
            btn_dkhp.Cursor = Cursors.Hand;
            btn_dkhp.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dkhp.ForeColor = Color.FromArgb(0, 35, 73);
            btn_dkhp.Location = new Point(29, 296);
            btn_dkhp.Name = "btn_dkhp";
            btn_dkhp.Size = new Size(184, 26);
            btn_dkhp.TabIndex = 26;
            btn_dkhp.Text = "Đăng ký học phần";
            btn_dkhp.Click += btn_dkhp_Click;
            // 
            // hpddk_btn
            // 
            hpddk_btn.Anchor = AnchorStyles.Left;
            hpddk_btn.AutoSize = true;
            hpddk_btn.Cursor = Cursors.Hand;
            hpddk_btn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            hpddk_btn.ForeColor = Color.FromArgb(0, 35, 73);
            hpddk_btn.Location = new Point(29, 181);
            hpddk_btn.Name = "hpddk_btn";
            hpddk_btn.Size = new Size(210, 26);
            hpddk_btn.TabIndex = 13;
            hpddk_btn.Text = "Học phần đã đăng ký";
            hpddk_btn.Click += hpddk_btn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(dashboard_label);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1276, 70);
            panel3.TabIndex = 2;
            // 
            // dashboard_label
            // 
            dashboard_label.AutoSize = true;
            dashboard_label.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dashboard_label.ForeColor = Color.White;
            dashboard_label.Location = new Point(87, 21);
            dashboard_label.Name = "dashboard_label";
            dashboard_label.Size = new Size(154, 35);
            dashboard_label.TabIndex = 1;
            dashboard_label.Text = "Dashboard";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(39, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(42, 42);
            panel4.TabIndex = 2;
            // 
            // SinhVien_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 69, 142);
            ClientSize = new Size(1382, 853);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(logout_btn);
            Controls.Add(hello_name_label);
            Controls.Add(text_hello);
            Controls.Add(title);
            Controls.Add(logo);
            Name = "SinhVien_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SinhVien_Form";
            Load += SinhVien_Form_Load;
            panel2.ResumeLayout(false);
            tabControl_sinhvien.ResumeLayout(false);
            tabPage_thongtinsv.ResumeLayout(false);
            tabPage_thongtinsv.PerformLayout();
            tabPage_hpdadangky.ResumeLayout(false);
            tabPage_hpdadangky.PerformLayout();
            tabPage_kehoachmohp.ResumeLayout(false);
            tabPage_kehoachmohp.PerformLayout();
            tabPage_dkhp.ResumeLayout(false);
            tabPage_dkhp.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button logout_btn;
        private Label hello_name_label;
        private Label text_hello;
        private Label title;
        private Panel logo;
        private Panel panel2;
        private Label hpddk_btn;
        private Label btn_thongtinsv;
        private Panel panel6;
        private Label label2;
        private Panel panel3;
        private Label dashboard_label;
        private Panel panel4;
        private Label btn_dkhp;
        private Label btn_kehoachmohp;
        private Panel panel5;
        private TabControl tabControl_sinhvien;
        private TabPage thongtinsinhvien;
        private TabPage tabPage_hpdadangky;
        private TabPage tabPage_kehoachmohp;
        private TabPage tabPage_dkhp;
        private TabPage tabPage_thongtinsv;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label18;
        private Label label17;
        private Label field_name;
        private Label field_mssv;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}