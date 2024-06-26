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
            logout_btn = new Button();
            hello_name_label = new Label();
            text_hello = new Label();
            title = new Label();
            logo = new Panel();
            panel2 = new Panel();
            tabControl_sinhvien = new TabControl();
            tabPage_thongtinsv = new TabPage();
            change_address_btn = new Button();
            change_phoneNumber_btn = new Button();
            field_phoneNumber = new TextBox();
            field_address = new TextBox();
            field_dtbtl = new Label();
            field_stctl = new Label();
            field_manganh = new Label();
            field_chuongtrinhdaotao = new Label();
            field_birthday = new Label();
            field_gender = new Label();
            field_name = new Label();
            field_masv = new Label();
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
            tabPage_danhsachhp = new TabPage();
            dataGridView_danhsachhp = new DataGridView();
            tabPage_kehoachmohp = new TabPage();
            dataGridView_khmohp = new DataGridView();
            tabPage_dkhp = new TabPage();
            refresh_dkhp_btn = new Button();
            add_dkhp_btn = new Button();
            dataGridView_dkhp = new DataGridView();
            tabPage_hpdadangky = new TabPage();
            delete_dkhp_btn = new Button();
            refresh_hpdadk_btn = new Button();
            dataGridView_hpdadk = new DataGridView();
            panel5 = new Panel();
            hpdadk_btn = new Label();
            panel6 = new Panel();
            label2 = new Label();
            btn_kehoachmohp = new Label();
            btn_thongtinsv = new Label();
            btn_dkhp = new Label();
            hpddk_btn = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            label_tabPage = new Label();
            dashboard_label = new Label();
            panel4 = new Panel();
            mail_btn = new Panel();
            panel2.SuspendLayout();
            tabControl_sinhvien.SuspendLayout();
            tabPage_thongtinsv.SuspendLayout();
            tabPage_danhsachhp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_danhsachhp).BeginInit();
            tabPage_kehoachmohp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_khmohp).BeginInit();
            tabPage_dkhp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_dkhp).BeginInit();
            tabPage_hpdadangky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_hpdadk).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            hello_name_label.Location = new Point(868, 51);
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
            text_hello.Location = new Point(745, 51);
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
            panel2.Controls.Add(panel1);
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
            tabControl_sinhvien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl_sinhvien.Controls.Add(tabPage_thongtinsv);
            tabControl_sinhvien.Controls.Add(tabPage_danhsachhp);
            tabControl_sinhvien.Controls.Add(tabPage_kehoachmohp);
            tabControl_sinhvien.Controls.Add(tabPage_dkhp);
            tabControl_sinhvien.Controls.Add(tabPage_hpdadangky);
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
            tabPage_thongtinsv.Controls.Add(change_address_btn);
            tabPage_thongtinsv.Controls.Add(change_phoneNumber_btn);
            tabPage_thongtinsv.Controls.Add(field_phoneNumber);
            tabPage_thongtinsv.Controls.Add(field_address);
            tabPage_thongtinsv.Controls.Add(field_dtbtl);
            tabPage_thongtinsv.Controls.Add(field_stctl);
            tabPage_thongtinsv.Controls.Add(field_manganh);
            tabPage_thongtinsv.Controls.Add(field_chuongtrinhdaotao);
            tabPage_thongtinsv.Controls.Add(field_birthday);
            tabPage_thongtinsv.Controls.Add(field_gender);
            tabPage_thongtinsv.Controls.Add(field_name);
            tabPage_thongtinsv.Controls.Add(field_masv);
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
            // change_address_btn
            // 
            change_address_btn.Location = new Point(705, 219);
            change_address_btn.Name = "change_address_btn";
            change_address_btn.Size = new Size(94, 29);
            change_address_btn.TabIndex = 46;
            change_address_btn.Text = "Thay đổi";
            change_address_btn.UseVisualStyleBackColor = true;
            change_address_btn.Click += change_address_btn_Click;
            // 
            // change_phoneNumber_btn
            // 
            change_phoneNumber_btn.Location = new Point(705, 269);
            change_phoneNumber_btn.Name = "change_phoneNumber_btn";
            change_phoneNumber_btn.Size = new Size(94, 29);
            change_phoneNumber_btn.TabIndex = 45;
            change_phoneNumber_btn.Text = "Thay đổi";
            change_phoneNumber_btn.UseVisualStyleBackColor = true;
            change_phoneNumber_btn.Click += change_phoneNumber_btn_Click;
            // 
            // field_phoneNumber
            // 
            field_phoneNumber.Location = new Point(362, 269);
            field_phoneNumber.Name = "field_phoneNumber";
            field_phoneNumber.Size = new Size(296, 27);
            field_phoneNumber.TabIndex = 21;
            // 
            // field_address
            // 
            field_address.Location = new Point(362, 219);
            field_address.Name = "field_address";
            field_address.Size = new Size(296, 27);
            field_address.TabIndex = 20;
            // 
            // field_dtbtl
            // 
            field_dtbtl.AutoSize = true;
            field_dtbtl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_dtbtl.Location = new Point(362, 502);
            field_dtbtl.Name = "field_dtbtl";
            field_dtbtl.Size = new Size(180, 28);
            field_dtbtl.TabIndex = 19;
            field_dtbtl.Text = "..........................................";
            // 
            // field_stctl
            // 
            field_stctl.AutoSize = true;
            field_stctl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_stctl.Location = new Point(362, 440);
            field_stctl.Name = "field_stctl";
            field_stctl.Size = new Size(180, 28);
            field_stctl.TabIndex = 18;
            field_stctl.Text = "..........................................";
            // 
            // field_manganh
            // 
            field_manganh.AutoSize = true;
            field_manganh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_manganh.Location = new Point(362, 381);
            field_manganh.Name = "field_manganh";
            field_manganh.Size = new Size(180, 28);
            field_manganh.TabIndex = 17;
            field_manganh.Text = "..........................................";
            // 
            // field_chuongtrinhdaotao
            // 
            field_chuongtrinhdaotao.AutoSize = true;
            field_chuongtrinhdaotao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_chuongtrinhdaotao.Location = new Point(362, 328);
            field_chuongtrinhdaotao.Name = "field_chuongtrinhdaotao";
            field_chuongtrinhdaotao.Size = new Size(180, 28);
            field_chuongtrinhdaotao.TabIndex = 16;
            field_chuongtrinhdaotao.Text = "..........................................";
            // 
            // field_birthday
            // 
            field_birthday.AutoSize = true;
            field_birthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_birthday.Location = new Point(362, 169);
            field_birthday.Name = "field_birthday";
            field_birthday.Size = new Size(180, 28);
            field_birthday.TabIndex = 13;
            field_birthday.Text = "..........................................";
            // 
            // field_gender
            // 
            field_gender.AutoSize = true;
            field_gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_gender.Location = new Point(362, 120);
            field_gender.Name = "field_gender";
            field_gender.Size = new Size(180, 28);
            field_gender.TabIndex = 12;
            field_gender.Text = "..........................................";
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
            // field_masv
            // 
            field_masv.AutoSize = true;
            field_masv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            field_masv.Location = new Point(362, 30);
            field_masv.Name = "field_masv";
            field_masv.Size = new Size(180, 28);
            field_masv.TabIndex = 10;
            field_masv.Text = "..........................................";
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
            // tabPage_danhsachhp
            // 
            tabPage_danhsachhp.Controls.Add(dataGridView_danhsachhp);
            tabPage_danhsachhp.Location = new Point(4, 29);
            tabPage_danhsachhp.Name = "tabPage_danhsachhp";
            tabPage_danhsachhp.Padding = new Padding(3);
            tabPage_danhsachhp.Size = new Size(986, 592);
            tabPage_danhsachhp.TabIndex = 1;
            tabPage_danhsachhp.Text = "Danh sách học phần";
            tabPage_danhsachhp.UseVisualStyleBackColor = true;
            // 
            // dataGridView_danhsachhp
            // 
            dataGridView_danhsachhp.AllowUserToAddRows = false;
            dataGridView_danhsachhp.AllowUserToDeleteRows = false;
            dataGridView_danhsachhp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_danhsachhp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_danhsachhp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_danhsachhp.Location = new Point(6, 35);
            dataGridView_danhsachhp.Name = "dataGridView_danhsachhp";
            dataGridView_danhsachhp.ReadOnly = true;
            dataGridView_danhsachhp.RowHeadersWidth = 51;
            dataGridView_danhsachhp.RowTemplate.Height = 29;
            dataGridView_danhsachhp.Size = new Size(974, 537);
            dataGridView_danhsachhp.TabIndex = 15;
            // 
            // tabPage_kehoachmohp
            // 
            tabPage_kehoachmohp.Controls.Add(dataGridView_khmohp);
            tabPage_kehoachmohp.Location = new Point(4, 29);
            tabPage_kehoachmohp.Name = "tabPage_kehoachmohp";
            tabPage_kehoachmohp.Size = new Size(986, 592);
            tabPage_kehoachmohp.TabIndex = 2;
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
            dataGridView_khmohp.Location = new Point(6, 33);
            dataGridView_khmohp.Name = "dataGridView_khmohp";
            dataGridView_khmohp.ReadOnly = true;
            dataGridView_khmohp.RowHeadersWidth = 51;
            dataGridView_khmohp.RowTemplate.Height = 29;
            dataGridView_khmohp.Size = new Size(974, 539);
            dataGridView_khmohp.TabIndex = 16;
            // 
            // tabPage_dkhp
            // 
            tabPage_dkhp.Controls.Add(refresh_dkhp_btn);
            tabPage_dkhp.Controls.Add(add_dkhp_btn);
            tabPage_dkhp.Controls.Add(dataGridView_dkhp);
            tabPage_dkhp.Location = new Point(4, 29);
            tabPage_dkhp.Name = "tabPage_dkhp";
            tabPage_dkhp.Size = new Size(986, 592);
            tabPage_dkhp.TabIndex = 3;
            tabPage_dkhp.Text = "Đăng ký học phần";
            tabPage_dkhp.UseVisualStyleBackColor = true;
            // 
            // refresh_dkhp_btn
            // 
            refresh_dkhp_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            refresh_dkhp_btn.BackColor = SystemColors.ButtonHighlight;
            refresh_dkhp_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            refresh_dkhp_btn.FlatAppearance.BorderSize = 3;
            refresh_dkhp_btn.FlatStyle = FlatStyle.Flat;
            refresh_dkhp_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            refresh_dkhp_btn.ForeColor = SystemColors.HotTrack;
            refresh_dkhp_btn.Location = new Point(797, 536);
            refresh_dkhp_btn.Name = "refresh_dkhp_btn";
            refresh_dkhp_btn.Size = new Size(180, 53);
            refresh_dkhp_btn.TabIndex = 35;
            refresh_dkhp_btn.Text = "Refresh";
            refresh_dkhp_btn.UseVisualStyleBackColor = false;
            refresh_dkhp_btn.Click += refresh_dkhp_btn_Click;
            // 
            // add_dkhp_btn
            // 
            add_dkhp_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            add_dkhp_btn.BackColor = SystemColors.ButtonHighlight;
            add_dkhp_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            add_dkhp_btn.FlatAppearance.BorderSize = 3;
            add_dkhp_btn.FlatStyle = FlatStyle.Flat;
            add_dkhp_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add_dkhp_btn.ForeColor = SystemColors.HotTrack;
            add_dkhp_btn.Location = new Point(421, 536);
            add_dkhp_btn.Name = "add_dkhp_btn";
            add_dkhp_btn.Size = new Size(197, 53);
            add_dkhp_btn.TabIndex = 34;
            add_dkhp_btn.Text = "Đăng ký học phần";
            add_dkhp_btn.UseVisualStyleBackColor = false;
            add_dkhp_btn.Click += add_dkhp_btn_Click;
            // 
            // dataGridView_dkhp
            // 
            dataGridView_dkhp.AllowUserToAddRows = false;
            dataGridView_dkhp.AllowUserToDeleteRows = false;
            dataGridView_dkhp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_dkhp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_dkhp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_dkhp.Location = new Point(9, 35);
            dataGridView_dkhp.Name = "dataGridView_dkhp";
            dataGridView_dkhp.RowHeadersWidth = 51;
            dataGridView_dkhp.RowTemplate.Height = 29;
            dataGridView_dkhp.Size = new Size(974, 495);
            dataGridView_dkhp.TabIndex = 15;
            // 
            // tabPage_hpdadangky
            // 
            tabPage_hpdadangky.Controls.Add(delete_dkhp_btn);
            tabPage_hpdadangky.Controls.Add(refresh_hpdadk_btn);
            tabPage_hpdadangky.Controls.Add(dataGridView_hpdadk);
            tabPage_hpdadangky.Location = new Point(4, 29);
            tabPage_hpdadangky.Name = "tabPage_hpdadangky";
            tabPage_hpdadangky.Size = new Size(986, 592);
            tabPage_hpdadangky.TabIndex = 5;
            tabPage_hpdadangky.Text = "Học phần đã đăng ký";
            tabPage_hpdadangky.UseVisualStyleBackColor = true;
            // 
            // delete_dkhp_btn
            // 
            delete_dkhp_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            delete_dkhp_btn.BackColor = SystemColors.ButtonHighlight;
            delete_dkhp_btn.FlatAppearance.BorderColor = Color.Red;
            delete_dkhp_btn.FlatAppearance.BorderSize = 3;
            delete_dkhp_btn.FlatStyle = FlatStyle.Flat;
            delete_dkhp_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            delete_dkhp_btn.ForeColor = Color.Red;
            delete_dkhp_btn.Location = new Point(62, 536);
            delete_dkhp_btn.Name = "delete_dkhp_btn";
            delete_dkhp_btn.Size = new Size(180, 53);
            delete_dkhp_btn.TabIndex = 37;
            delete_dkhp_btn.Text = "Xóa";
            delete_dkhp_btn.UseVisualStyleBackColor = false;
            delete_dkhp_btn.Click += delete_hpdadk_btn_Click;
            // 
            // refresh_hpdadk_btn
            // 
            refresh_hpdadk_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            refresh_hpdadk_btn.BackColor = SystemColors.ButtonHighlight;
            refresh_hpdadk_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            refresh_hpdadk_btn.FlatAppearance.BorderSize = 3;
            refresh_hpdadk_btn.FlatStyle = FlatStyle.Flat;
            refresh_hpdadk_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            refresh_hpdadk_btn.ForeColor = SystemColors.HotTrack;
            refresh_hpdadk_btn.Location = new Point(746, 536);
            refresh_hpdadk_btn.Name = "refresh_hpdadk_btn";
            refresh_hpdadk_btn.Size = new Size(180, 53);
            refresh_hpdadk_btn.TabIndex = 36;
            refresh_hpdadk_btn.Text = "Refresh";
            refresh_hpdadk_btn.UseVisualStyleBackColor = false;
            refresh_hpdadk_btn.Click += refresh_hpdadk_btn_Click;
            // 
            // dataGridView_hpdadk
            // 
            dataGridView_hpdadk.AllowUserToAddRows = false;
            dataGridView_hpdadk.AllowUserToDeleteRows = false;
            dataGridView_hpdadk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_hpdadk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_hpdadk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_hpdadk.Location = new Point(6, 42);
            dataGridView_hpdadk.Name = "dataGridView_hpdadk";
            dataGridView_hpdadk.RowHeadersWidth = 51;
            dataGridView_hpdadk.RowTemplate.Height = 29;
            dataGridView_hpdadk.Size = new Size(974, 488);
            dataGridView_hpdadk.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel5.BackColor = Color.FromArgb(217, 217, 217);
            panel5.Controls.Add(hpdadk_btn);
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
            // hpdadk_btn
            // 
            hpdadk_btn.Anchor = AnchorStyles.Left;
            hpdadk_btn.AutoSize = true;
            hpdadk_btn.Cursor = Cursors.Hand;
            hpdadk_btn.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            hpdadk_btn.ForeColor = Color.FromArgb(0, 35, 73);
            hpdadk_btn.Location = new Point(29, 346);
            hpdadk_btn.Name = "hpdadk_btn";
            hpdadk_btn.Size = new Size(210, 26);
            hpdadk_btn.TabIndex = 27;
            hpdadk_btn.Text = "Học phần đã đăng ký";
            hpdadk_btn.Click += hpdadk_btn_Click;
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
            hpddk_btn.Location = new Point(29, 183);
            hpddk_btn.Name = "hpddk_btn";
            hpddk_btn.Size = new Size(201, 26);
            hpddk_btn.TabIndex = 13;
            hpddk_btn.Text = "Danh sách học phần";
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label_tabPage);
            panel1.Location = new Point(274, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 52);
            panel1.TabIndex = 70;
            // 
            // label_tabPage
            // 
            label_tabPage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_tabPage.AutoSize = true;
            label_tabPage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label_tabPage.ForeColor = SystemColors.HotTrack;
            label_tabPage.Location = new Point(335, 0);
            label_tabPage.Name = "label_tabPage";
            label_tabPage.Size = new Size(97, 41);
            label_tabPage.TabIndex = 0;
            label_tabPage.Text = "label1";
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
            // mail_btn
            // 
            mail_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mail_btn.BackColor = Color.FromArgb(1, 69, 142);
            mail_btn.BackgroundImage = (Image)resources.GetObject("mail_btn.BackgroundImage");
            mail_btn.Cursor = Cursors.Hand;
            mail_btn.Location = new Point(699, 42);
            mail_btn.Name = "mail_btn";
            mail_btn.Size = new Size(40, 37);
            mail_btn.TabIndex = 69;
            mail_btn.Click += mail_btn_Click;
            // 
            // SinhVien_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 69, 142);
            ClientSize = new Size(1382, 853);
            Controls.Add(mail_btn);
            Controls.Add(panel2);
            Controls.Add(logout_btn);
            Controls.Add(hello_name_label);
            Controls.Add(text_hello);
            Controls.Add(title);
            Controls.Add(logo);
            Name = "SinhVien_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sinh viên";
            FormClosing += SinhVien_Form_FormClosing;
            Load += SinhVien_Form_Load;
            panel2.ResumeLayout(false);
            tabControl_sinhvien.ResumeLayout(false);
            tabPage_thongtinsv.ResumeLayout(false);
            tabPage_thongtinsv.PerformLayout();
            tabPage_danhsachhp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_danhsachhp).EndInit();
            tabPage_kehoachmohp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_khmohp).EndInit();
            tabPage_dkhp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_dkhp).EndInit();
            tabPage_hpdadangky.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_hpdadk).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private TabPage tabPage_danhsachhp;
        private TabPage tabPage_kehoachmohp;
        private TabPage tabPage_dkhp;
        private TabPage tabPage_thongtinsv;
        private Label label3;
        private Label field_birthday;
        private Label field_gender;
        private Label field_name;
        private Label field_masv;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label field_dtbtl;
        private Label field_stctl;
        private Label field_manganh;
        private Label field_chuongtrinhdaotao;
        private TextBox field_address;
        private TextBox field_phoneNumber;
        private Button change_address_btn;
        private Button change_phoneNumber_btn;
        private DataGridView dataGridView_khmohp;
        private DataGridView dataGridView_dkhp;
        private DataGridView dataGridView_danhsachhp;
        private Button refresh_dkhp_btn;
        private Button add_dkhp_btn;
        private Panel mail_btn;
        private Panel panel1;
        private Label label_tabPage;
        private TabPage tabPage_hpdadangky;
        private DataGridView dataGridView_hpdadk;
        private Label hpdadk_btn;
        private Button refresh_hpdadk_btn;
        private Button delete_dkhp_btn;
    }
}