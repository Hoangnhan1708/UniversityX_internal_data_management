namespace portal_application_project
{
    partial class NVCB_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NVCB_Form));
            logo = new Panel();
            title = new Label();
            text_hello = new Label();
            hello_name_label = new Label();
            logout_btn = new Button();
            panel3 = new Panel();
            dashboard_label = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            tabControl_nvcb = new TabControl();
            tabPage_userInfo = new TabPage();
            dollar_icon = new Label();
            change_phoneNumber_btn = new Button();
            field_salary = new Label();
            field_phoneNumber = new TextBox();
            field_madv = new Label();
            field_role = new Label();
            field_birthday = new Label();
            field_gender = new Label();
            field_name = new Label();
            field_manv = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label16 = new Label();
            label19 = new Label();
            tabPage_thongtinsv = new TabPage();
            dataGridView_sinhvien = new DataGridView();
            tabPage_thongtindonvi = new TabPage();
            dataGridView_thongtindv = new DataGridView();
            tabPage_thongtinhp = new TabPage();
            dataGridView_thongtinhp = new DataGridView();
            tabPage_kehoachmohp = new TabPage();
            dataGridView_khmohp = new DataGridView();
            panel5 = new Panel();
            kehoachmohp_btn = new Label();
            course_info_btn = new Label();
            donvi_info_btn = new Label();
            student_info_btn = new Label();
            panel7 = new Panel();
            label4 = new Label();
            user_info_btn = new Label();
            panel8 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            label2 = new Label();
            mail_btn = new Panel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tabControl_nvcb.SuspendLayout();
            tabPage_userInfo.SuspendLayout();
            tabPage_thongtinsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_sinhvien).BeginInit();
            tabPage_thongtindonvi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_thongtindv).BeginInit();
            tabPage_thongtinhp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_thongtinhp).BeginInit();
            tabPage_kehoachmohp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_khmohp).BeginInit();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.Location = new Point(62, 12);
            logo.Name = "logo";
            logo.Size = new Size(72, 59);
            logo.TabIndex = 42;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.White;
            title.Location = new Point(140, 31);
            title.Name = "title";
            title.Size = new Size(250, 25);
            title.TabIndex = 43;
            title.Text = "University X Dashboard";
            // 
            // text_hello
            // 
            text_hello.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            text_hello.AutoSize = true;
            text_hello.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text_hello.ForeColor = Color.White;
            text_hello.Location = new Point(738, 31);
            text_hello.Name = "text_hello";
            text_hello.Size = new Size(130, 26);
            text_hello.TabIndex = 44;
            text_hello.Text = "(*) Xin chào";
            // 
            // hello_name_label
            // 
            hello_name_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            hello_name_label.AutoSize = true;
            hello_name_label.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            hello_name_label.ForeColor = Color.White;
            hello_name_label.Location = new Point(861, 31);
            hello_name_label.Name = "hello_name_label";
            hello_name_label.Size = new Size(167, 26);
            hello_name_label.TabIndex = 45;
            hello_name_label.Text = "ShinichiKuNhan";
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
            logout_btn.Location = new Point(1154, 12);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(139, 59);
            logout_btn.TabIndex = 46;
            logout_btn.Text = "Đăng xuất";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(tabControl_nvcb);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(67, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(1276, 690);
            panel2.TabIndex = 48;
            // 
            // tabControl_nvcb
            // 
            tabControl_nvcb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl_nvcb.Controls.Add(tabPage_userInfo);
            tabControl_nvcb.Controls.Add(tabPage_thongtinsv);
            tabControl_nvcb.Controls.Add(tabPage_thongtindonvi);
            tabControl_nvcb.Controls.Add(tabPage_thongtinhp);
            tabControl_nvcb.Controls.Add(tabPage_kehoachmohp);
            tabControl_nvcb.Location = new Point(279, 79);
            tabControl_nvcb.Name = "tabControl_nvcb";
            tabControl_nvcb.SelectedIndex = 0;
            tabControl_nvcb.Size = new Size(994, 594);
            tabControl_nvcb.TabIndex = 3;
            // 
            // tabPage_userInfo
            // 
            tabPage_userInfo.Controls.Add(dollar_icon);
            tabPage_userInfo.Controls.Add(change_phoneNumber_btn);
            tabPage_userInfo.Controls.Add(field_salary);
            tabPage_userInfo.Controls.Add(field_phoneNumber);
            tabPage_userInfo.Controls.Add(field_madv);
            tabPage_userInfo.Controls.Add(field_role);
            tabPage_userInfo.Controls.Add(field_birthday);
            tabPage_userInfo.Controls.Add(field_gender);
            tabPage_userInfo.Controls.Add(field_name);
            tabPage_userInfo.Controls.Add(field_manv);
            tabPage_userInfo.Controls.Add(label13);
            tabPage_userInfo.Controls.Add(label12);
            tabPage_userInfo.Controls.Add(label11);
            tabPage_userInfo.Controls.Add(label10);
            tabPage_userInfo.Controls.Add(label9);
            tabPage_userInfo.Controls.Add(label8);
            tabPage_userInfo.Controls.Add(label16);
            tabPage_userInfo.Controls.Add(label19);
            tabPage_userInfo.Location = new Point(4, 29);
            tabPage_userInfo.Name = "tabPage_userInfo";
            tabPage_userInfo.Padding = new Padding(3);
            tabPage_userInfo.Size = new Size(986, 561);
            tabPage_userInfo.TabIndex = 0;
            tabPage_userInfo.Text = "Thông tin người dùng";
            tabPage_userInfo.UseVisualStyleBackColor = true;
            // 
            // dollar_icon
            // 
            dollar_icon.AutoSize = true;
            dollar_icon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dollar_icon.Location = new Point(372, 236);
            dollar_icon.Name = "dollar_icon";
            dollar_icon.Size = new Size(23, 28);
            dollar_icon.TabIndex = 44;
            dollar_icon.Text = "$";
            // 
            // change_phoneNumber_btn
            // 
            change_phoneNumber_btn.Location = new Point(608, 285);
            change_phoneNumber_btn.Name = "change_phoneNumber_btn";
            change_phoneNumber_btn.Size = new Size(94, 29);
            change_phoneNumber_btn.TabIndex = 43;
            change_phoneNumber_btn.Text = "Thay đổi";
            change_phoneNumber_btn.UseVisualStyleBackColor = true;
            change_phoneNumber_btn.Click += change_phoneNumber_btn_Click;
            // 
            // field_salary
            // 
            field_salary.AutoSize = true;
            field_salary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_salary.Location = new Point(392, 236);
            field_salary.Name = "field_salary";
            field_salary.Size = new Size(180, 28);
            field_salary.TabIndex = 42;
            field_salary.Text = "..........................................";
            // 
            // field_phoneNumber
            // 
            field_phoneNumber.Location = new Point(392, 285);
            field_phoneNumber.Name = "field_phoneNumber";
            field_phoneNumber.Size = new Size(180, 27);
            field_phoneNumber.TabIndex = 41;
            // 
            // field_madv
            // 
            field_madv.AutoSize = true;
            field_madv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_madv.Location = new Point(392, 397);
            field_madv.Name = "field_madv";
            field_madv.Size = new Size(180, 28);
            field_madv.TabIndex = 37;
            field_madv.Text = "..........................................";
            // 
            // field_role
            // 
            field_role.AutoSize = true;
            field_role.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_role.Location = new Point(392, 344);
            field_role.Name = "field_role";
            field_role.Size = new Size(180, 28);
            field_role.TabIndex = 36;
            field_role.Text = "..........................................";
            // 
            // field_birthday
            // 
            field_birthday.AutoSize = true;
            field_birthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_birthday.Location = new Point(392, 185);
            field_birthday.Name = "field_birthday";
            field_birthday.Size = new Size(180, 28);
            field_birthday.TabIndex = 35;
            field_birthday.Text = "..........................................";
            // 
            // field_gender
            // 
            field_gender.AutoSize = true;
            field_gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_gender.Location = new Point(392, 136);
            field_gender.Name = "field_gender";
            field_gender.Size = new Size(180, 28);
            field_gender.TabIndex = 34;
            field_gender.Text = "..........................................";
            // 
            // field_name
            // 
            field_name.AutoSize = true;
            field_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_name.Location = new Point(392, 88);
            field_name.Name = "field_name";
            field_name.Size = new Size(180, 28);
            field_name.TabIndex = 33;
            field_name.Text = "..........................................";
            // 
            // field_manv
            // 
            field_manv.AutoSize = true;
            field_manv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_manv.Location = new Point(392, 46);
            field_manv.Name = "field_manv";
            field_manv.Size = new Size(180, 28);
            field_manv.TabIndex = 32;
            field_manv.Text = "..........................................";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(130, 397);
            label13.Name = "label13";
            label13.Size = new Size(104, 28);
            label13.TabIndex = 29;
            label13.Text = "Mã đơn vị:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(130, 344);
            label12.Name = "label12";
            label12.Size = new Size(73, 28);
            label12.TabIndex = 28;
            label12.Text = "Vai trò:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(130, 281);
            label11.Name = "label11";
            label11.Size = new Size(132, 28);
            label11.TabIndex = 27;
            label11.Text = "Số điện thoại:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(130, 231);
            label10.Name = "label10";
            label10.Size = new Size(85, 28);
            label10.TabIndex = 26;
            label10.Text = "Phụ cấp:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(130, 88);
            label9.Name = "label9";
            label9.Size = new Size(75, 28);
            label9.TabIndex = 25;
            label9.Text = "Họ tên:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(130, 185);
            label8.Name = "label8";
            label8.Size = new Size(103, 28);
            label8.TabIndex = 24;
            label8.Text = "Ngày sinh:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(130, 136);
            label16.Name = "label16";
            label16.Size = new Size(91, 28);
            label16.TabIndex = 23;
            label16.Text = "Giới tính:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(130, 46);
            label19.Name = "label19";
            label19.Size = new Size(133, 28);
            label19.TabIndex = 22;
            label19.Text = "Mã nhân viên:";
            // 
            // tabPage_thongtinsv
            // 
            tabPage_thongtinsv.Controls.Add(dataGridView_sinhvien);
            tabPage_thongtinsv.Location = new Point(4, 29);
            tabPage_thongtinsv.Name = "tabPage_thongtinsv";
            tabPage_thongtinsv.Padding = new Padding(3);
            tabPage_thongtinsv.Size = new Size(986, 561);
            tabPage_thongtinsv.TabIndex = 1;
            tabPage_thongtinsv.Text = "Thông tin sinh viên";
            tabPage_thongtinsv.UseVisualStyleBackColor = true;
            // 
            // dataGridView_sinhvien
            // 
            dataGridView_sinhvien.AllowUserToAddRows = false;
            dataGridView_sinhvien.AllowUserToDeleteRows = false;
            dataGridView_sinhvien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_sinhvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_sinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_sinhvien.Location = new Point(6, 18);
            dataGridView_sinhvien.Name = "dataGridView_sinhvien";
            dataGridView_sinhvien.ReadOnly = true;
            dataGridView_sinhvien.RowHeadersWidth = 51;
            dataGridView_sinhvien.RowTemplate.Height = 29;
            dataGridView_sinhvien.Size = new Size(974, 520);
            dataGridView_sinhvien.TabIndex = 12;
            // 
            // tabPage_thongtindonvi
            // 
            tabPage_thongtindonvi.Controls.Add(dataGridView_thongtindv);
            tabPage_thongtindonvi.Location = new Point(4, 29);
            tabPage_thongtindonvi.Name = "tabPage_thongtindonvi";
            tabPage_thongtindonvi.Size = new Size(986, 561);
            tabPage_thongtindonvi.TabIndex = 2;
            tabPage_thongtindonvi.Text = "Thông tin đơn vị";
            tabPage_thongtindonvi.UseVisualStyleBackColor = true;
            // 
            // dataGridView_thongtindv
            // 
            dataGridView_thongtindv.AllowUserToAddRows = false;
            dataGridView_thongtindv.AllowUserToDeleteRows = false;
            dataGridView_thongtindv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_thongtindv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_thongtindv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_thongtindv.Location = new Point(9, 3);
            dataGridView_thongtindv.Name = "dataGridView_thongtindv";
            dataGridView_thongtindv.ReadOnly = true;
            dataGridView_thongtindv.RowHeadersWidth = 51;
            dataGridView_thongtindv.RowTemplate.Height = 29;
            dataGridView_thongtindv.Size = new Size(974, 551);
            dataGridView_thongtindv.TabIndex = 13;
            // 
            // tabPage_thongtinhp
            // 
            tabPage_thongtinhp.Controls.Add(dataGridView_thongtinhp);
            tabPage_thongtinhp.Location = new Point(4, 29);
            tabPage_thongtinhp.Name = "tabPage_thongtinhp";
            tabPage_thongtinhp.Size = new Size(986, 561);
            tabPage_thongtinhp.TabIndex = 3;
            tabPage_thongtinhp.Text = "Thông tin học phần";
            tabPage_thongtinhp.UseVisualStyleBackColor = true;
            // 
            // dataGridView_thongtinhp
            // 
            dataGridView_thongtinhp.AllowUserToAddRows = false;
            dataGridView_thongtinhp.AllowUserToDeleteRows = false;
            dataGridView_thongtinhp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_thongtinhp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_thongtinhp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_thongtinhp.Location = new Point(6, 21);
            dataGridView_thongtinhp.Name = "dataGridView_thongtinhp";
            dataGridView_thongtinhp.ReadOnly = true;
            dataGridView_thongtinhp.RowHeadersWidth = 51;
            dataGridView_thongtinhp.RowTemplate.Height = 29;
            dataGridView_thongtinhp.Size = new Size(974, 520);
            dataGridView_thongtinhp.TabIndex = 14;
            // 
            // tabPage_kehoachmohp
            // 
            tabPage_kehoachmohp.Controls.Add(dataGridView_khmohp);
            tabPage_kehoachmohp.Location = new Point(4, 29);
            tabPage_kehoachmohp.Name = "tabPage_kehoachmohp";
            tabPage_kehoachmohp.Size = new Size(986, 561);
            tabPage_kehoachmohp.TabIndex = 4;
            tabPage_kehoachmohp.Text = "Kế hoạch mở HP";
            tabPage_kehoachmohp.UseVisualStyleBackColor = true;
            // 
            // dataGridView_khmohp
            // 
            dataGridView_khmohp.AllowUserToAddRows = false;
            dataGridView_khmohp.AllowUserToDeleteRows = false;
            dataGridView_khmohp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_khmohp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_khmohp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_khmohp.Location = new Point(3, 20);
            dataGridView_khmohp.Name = "dataGridView_khmohp";
            dataGridView_khmohp.ReadOnly = true;
            dataGridView_khmohp.RowHeadersWidth = 51;
            dataGridView_khmohp.RowTemplate.Height = 29;
            dataGridView_khmohp.Size = new Size(977, 521);
            dataGridView_khmohp.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel5.BackColor = Color.FromArgb(217, 217, 217);
            panel5.Controls.Add(kehoachmohp_btn);
            panel5.Controls.Add(course_info_btn);
            panel5.Controls.Add(donvi_info_btn);
            panel5.Controls.Add(student_info_btn);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(user_info_btn);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(67, 180);
            panel5.Name = "panel5";
            panel5.Size = new Size(267, 622);
            panel5.TabIndex = 2;
            // 
            // kehoachmohp_btn
            // 
            kehoachmohp_btn.Anchor = AnchorStyles.Left;
            kehoachmohp_btn.AutoSize = true;
            kehoachmohp_btn.Cursor = Cursors.Hand;
            kehoachmohp_btn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            kehoachmohp_btn.ForeColor = Color.FromArgb(0, 35, 73);
            kehoachmohp_btn.Location = new Point(29, 494);
            kehoachmohp_btn.Name = "kehoachmohp_btn";
            kehoachmohp_btn.Size = new Size(170, 26);
            kehoachmohp_btn.TabIndex = 10;
            kehoachmohp_btn.Text = "Kế hoạch mở HP";
            kehoachmohp_btn.Click += kehoachmohp_btn_Click;
            // 
            // course_info_btn
            // 
            course_info_btn.Anchor = AnchorStyles.Left;
            course_info_btn.AutoSize = true;
            course_info_btn.Cursor = Cursors.Hand;
            course_info_btn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            course_info_btn.ForeColor = Color.FromArgb(0, 35, 73);
            course_info_btn.Location = new Point(29, 444);
            course_info_btn.Name = "course_info_btn";
            course_info_btn.Size = new Size(195, 26);
            course_info_btn.TabIndex = 9;
            course_info_btn.Text = "Thông tin học phần";
            course_info_btn.Click += course_info_btn_Click;
            // 
            // donvi_info_btn
            // 
            donvi_info_btn.Anchor = AnchorStyles.Left;
            donvi_info_btn.AutoSize = true;
            donvi_info_btn.Cursor = Cursors.Hand;
            donvi_info_btn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            donvi_info_btn.ForeColor = Color.FromArgb(0, 35, 73);
            donvi_info_btn.Location = new Point(29, 396);
            donvi_info_btn.Name = "donvi_info_btn";
            donvi_info_btn.Size = new Size(169, 26);
            donvi_info_btn.TabIndex = 8;
            donvi_info_btn.Text = "Thông tin đơn vị";
            donvi_info_btn.Click += donvi_info_btn_Click;
            // 
            // student_info_btn
            // 
            student_info_btn.Anchor = AnchorStyles.Left;
            student_info_btn.AutoSize = true;
            student_info_btn.Cursor = Cursors.Hand;
            student_info_btn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            student_info_btn.ForeColor = Color.FromArgb(0, 35, 73);
            student_info_btn.Location = new Point(27, 266);
            student_info_btn.Name = "student_info_btn";
            student_info_btn.Size = new Size(194, 26);
            student_info_btn.TabIndex = 6;
            student_info_btn.Text = "Thông tin sinh viên";
            student_info_btn.Click += student_info_btn_Click;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Left;
            panel7.BackColor = Color.FromArgb(1, 69, 142);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(0, 190);
            panel7.Name = "panel7";
            panel7.Size = new Size(267, 47);
            panel7.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(25, 10);
            label4.Name = "label4";
            label4.Size = new Size(101, 27);
            label4.TabIndex = 3;
            label4.Text = "Sinh viên";
            // 
            // user_info_btn
            // 
            user_info_btn.AutoSize = true;
            user_info_btn.Cursor = Cursors.Hand;
            user_info_btn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            user_info_btn.ForeColor = Color.FromArgb(0, 35, 73);
            user_info_btn.Location = new Point(25, 79);
            user_info_btn.Name = "user_info_btn";
            user_info_btn.Size = new Size(215, 26);
            user_info_btn.TabIndex = 4;
            user_info_btn.Text = "Thông tin người dùng";
            user_info_btn.Click += user_info_btn_Click;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Left;
            panel8.BackColor = Color.FromArgb(1, 69, 142);
            panel8.Controls.Add(label5);
            panel8.Location = new Point(0, 318);
            panel8.Name = "panel8";
            panel8.Size = new Size(267, 49);
            panel8.TabIndex = 7;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 11);
            label5.Name = "label5";
            label5.Size = new Size(78, 27);
            label5.TabIndex = 3;
            label5.Text = "Đơn vị";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 35, 73);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(0, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(267, 52);
            panel6.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 10);
            label2.Name = "label2";
            label2.Size = new Size(182, 27);
            label2.TabIndex = 3;
            label2.Text = "Nhân viên cơ bản";
            // 
            // mail_btn
            // 
            mail_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mail_btn.BackColor = Color.FromArgb(1, 69, 142);
            mail_btn.BackgroundImage = (Image)resources.GetObject("mail_btn.BackgroundImage");
            mail_btn.Cursor = Cursors.Hand;
            mail_btn.Location = new Point(692, 31);
            mail_btn.Name = "mail_btn";
            mail_btn.Size = new Size(40, 37);
            mail_btn.TabIndex = 64;
            mail_btn.Click += mail_btn_Click;
            // 
            // NVCB_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 69, 142);
            ClientSize = new Size(1382, 853);
            Controls.Add(mail_btn);
            Controls.Add(panel5);
            Controls.Add(logout_btn);
            Controls.Add(hello_name_label);
            Controls.Add(text_hello);
            Controls.Add(title);
            Controls.Add(logo);
            Controls.Add(panel2);
            Name = "NVCB_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NVCB_Form";
            Load += NVCB_Form_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl_nvcb.ResumeLayout(false);
            tabPage_userInfo.ResumeLayout(false);
            tabPage_userInfo.PerformLayout();
            tabPage_thongtinsv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_sinhvien).EndInit();
            tabPage_thongtindonvi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_thongtindv).EndInit();
            tabPage_thongtinhp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_thongtinhp).EndInit();
            tabPage_kehoachmohp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_khmohp).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel logo;
        private Label title;
        private Label text_hello;
        private Label hello_name_label;
        private Button logout_btn;
        private Panel panel3;
        private Label dashboard_label;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Label label2;
        private Label user_info_btn;
        private Panel panel7;
        private Label label4;
        private Label student_info_btn;
        private Label kehoachmohp_btn;
        private Label course_info_btn;
        private Label donvi_info_btn;
        private Panel panel8;
        private Label label5;
        private TabControl tabControl_nvcb;
        private TabPage tabPage_userInfo;
        private TabPage tabPage_thongtinsv;
        private TextBox field_phoneNumber;
        private Label field_madv;
        private Label field_role;
        private Label field_birthday;
        private Label field_gender;
        private Label field_name;
        private Label field_manv;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label16;
        private Label label19;
        private Label field_salary;
        private TabPage tabPage_thongtindonvi;
        private TabPage tabPage_thongtinhp;
        private TabPage tabPage_kehoachmohp;
        private DataGridView dataGridView_sinhvien;
        private DataGridView dataGridView_thongtindv;
        private DataGridView dataGridView_thongtinhp;
        private DataGridView dataGridView_khmohp;
        private Button change_phoneNumber_btn;
        private Label dollar_icon;
        private Panel mail_btn;
    }
}