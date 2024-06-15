namespace portal_application_project
{
    partial class New_SinhVien_Form
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
            add_sinhvien_btn = new Button();
            label3 = new Label();
            field_manv = new TextBox();
            field_name = new TextBox();
            label2 = new Label();
            label10 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            field_address = new TextBox();
            field_chuongtrinhdaotao = new TextBox();
            field_manganh = new TextBox();
            field_phoneNumber = new TextBox();
            field_stctl = new TextBox();
            field_dtbtl = new TextBox();
            label12 = new Label();
            male_checkbox = new CheckBox();
            female_checkbox = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
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
            panel1.Size = new Size(818, 70);
            panel1.TabIndex = 47;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(325, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 41);
            label1.TabIndex = 1;
            label1.Text = "Thêm sinh viên";
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
            close_btn.Location = new Point(610, 440);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(78, 51);
            close_btn.TabIndex = 55;
            close_btn.Text = "Đóng";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // add_sinhvien_btn
            // 
            add_sinhvien_btn.Anchor = AnchorStyles.Top;
            add_sinhvien_btn.BackColor = SystemColors.ButtonHighlight;
            add_sinhvien_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            add_sinhvien_btn.FlatAppearance.BorderSize = 3;
            add_sinhvien_btn.FlatStyle = FlatStyle.Flat;
            add_sinhvien_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add_sinhvien_btn.ForeColor = SystemColors.HotTrack;
            add_sinhvien_btn.Location = new Point(325, 440);
            add_sinhvien_btn.Name = "add_sinhvien_btn";
            add_sinhvien_btn.Size = new Size(159, 51);
            add_sinhvien_btn.TabIndex = 54;
            add_sinhvien_btn.Text = "Thêm";
            add_sinhvien_btn.UseVisualStyleBackColor = false;
            add_sinhvien_btn.Click += add_sinhvien_btn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(55, 155);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 52;
            label3.Text = "Phái";
            // 
            // field_manv
            // 
            field_manv.Anchor = AnchorStyles.Top;
            field_manv.BackColor = Color.White;
            field_manv.Location = new Point(154, 93);
            field_manv.Name = "field_manv";
            field_manv.Size = new Size(251, 27);
            field_manv.TabIndex = 51;
            // 
            // field_name
            // 
            field_name.Anchor = AnchorStyles.Top;
            field_name.Location = new Point(516, 93);
            field_name.Name = "field_name";
            field_name.Size = new Size(251, 27);
            field_name.TabIndex = 50;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(429, 96);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 49;
            label2.Text = "Họ tên";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(33, 96);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 48;
            label10.Text = "Mã sinh viên";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(420, 158);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 56;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(55, 220);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 58;
            label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(406, 227);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 60;
            label6.Text = "Số điện thoại";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(12, 288);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 62;
            label7.Text = "Mã chương trình";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(420, 288);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 64;
            label8.Text = "Mã ngành";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(12, 359);
            label9.Name = "label9";
            label9.Size = new Size(121, 20);
            label9.TabIndex = 66;
            label9.Text = "Số tín chỉ tích lũy";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Location = new Point(406, 352);
            label11.Name = "label11";
            label11.Size = new Size(117, 20);
            label11.TabIndex = 68;
            label11.Text = "Điểm trung bình";
            // 
            // field_address
            // 
            field_address.Anchor = AnchorStyles.Top;
            field_address.BackColor = Color.White;
            field_address.Location = new Point(151, 220);
            field_address.Name = "field_address";
            field_address.Size = new Size(251, 27);
            field_address.TabIndex = 71;
            // 
            // field_chuongtrinhdaotao
            // 
            field_chuongtrinhdaotao.Anchor = AnchorStyles.Top;
            field_chuongtrinhdaotao.BackColor = Color.White;
            field_chuongtrinhdaotao.Location = new Point(151, 285);
            field_chuongtrinhdaotao.Name = "field_chuongtrinhdaotao";
            field_chuongtrinhdaotao.Size = new Size(251, 27);
            field_chuongtrinhdaotao.TabIndex = 72;
            // 
            // field_manganh
            // 
            field_manganh.Anchor = AnchorStyles.Top;
            field_manganh.BackColor = Color.White;
            field_manganh.Location = new Point(516, 285);
            field_manganh.Name = "field_manganh";
            field_manganh.Size = new Size(251, 27);
            field_manganh.TabIndex = 73;
            // 
            // field_phoneNumber
            // 
            field_phoneNumber.Anchor = AnchorStyles.Top;
            field_phoneNumber.Location = new Point(516, 227);
            field_phoneNumber.Name = "field_phoneNumber";
            field_phoneNumber.Size = new Size(251, 27);
            field_phoneNumber.TabIndex = 74;
            field_phoneNumber.KeyPress += field_phoneNumber_KeyPress;
            // 
            // field_stctl
            // 
            field_stctl.Anchor = AnchorStyles.Top;
            field_stctl.Location = new Point(151, 356);
            field_stctl.Name = "field_stctl";
            field_stctl.Size = new Size(251, 27);
            field_stctl.TabIndex = 75;
            field_stctl.KeyPress += field_stctl_KeyPress;
            // 
            // field_dtbtl
            // 
            field_dtbtl.Anchor = AnchorStyles.Top;
            field_dtbtl.Location = new Point(521, 356);
            field_dtbtl.Name = "field_dtbtl";
            field_dtbtl.Size = new Size(246, 27);
            field_dtbtl.TabIndex = 76;
            field_dtbtl.KeyPress += field_dtbtl_KeyPress;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Location = new Point(429, 372);
            label12.Name = "label12";
            label12.Size = new Size(56, 20);
            label12.TabIndex = 77;
            label12.Text = "tích lũy";
            // 
            // male_checkbox
            // 
            male_checkbox.AutoSize = true;
            male_checkbox.Location = new Point(154, 157);
            male_checkbox.Name = "male_checkbox";
            male_checkbox.Size = new Size(63, 24);
            male_checkbox.TabIndex = 78;
            male_checkbox.Text = "Nam";
            male_checkbox.UseVisualStyleBackColor = true;
            male_checkbox.CheckedChanged += male_checkBox_CheckedChanged;
            // 
            // female_checkbox
            // 
            female_checkbox.AutoSize = true;
            female_checkbox.Location = new Point(248, 157);
            female_checkbox.Name = "female_checkbox";
            female_checkbox.Size = new Size(51, 24);
            female_checkbox.TabIndex = 79;
            female_checkbox.Text = "Nữ";
            female_checkbox.UseVisualStyleBackColor = true;
            female_checkbox.CheckedChanged += female_checkBox_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(516, 155);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(251, 27);
            dateTimePicker2.TabIndex = 80;
            dateTimePicker2.Value = new DateTime(2024, 6, 14, 0, 0, 0, 0);
            // 
            // New_SinhVien_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 537);
            Controls.Add(dateTimePicker2);
            Controls.Add(female_checkbox);
            Controls.Add(male_checkbox);
            Controls.Add(label12);
            Controls.Add(field_dtbtl);
            Controls.Add(field_stctl);
            Controls.Add(field_phoneNumber);
            Controls.Add(field_manganh);
            Controls.Add(field_chuongtrinhdaotao);
            Controls.Add(field_address);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(close_btn);
            Controls.Add(add_sinhvien_btn);
            Controls.Add(label3);
            Controls.Add(field_manv);
            Controls.Add(field_name);
            Controls.Add(label2);
            Controls.Add(label10);
            Name = "New_SinhVien_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm sinh viên";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button close_btn;
        private Button add_sinhvien_btn;
        private Label label3;
        private TextBox field_manv;
        private TextBox field_name;
        private Label label2;
        private Label label10;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private TextBox field_birthday;
        private TextBox field_address;
        private TextBox field_chuongtrinhdaotao;
        private TextBox field_manganh;
        private TextBox field_phoneNumber;
        private TextBox field_stctl;
        private TextBox field_dtbtl;
        private Label label12;
        private CheckBox male_checkbox;
        private CheckBox female_checkbox;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}