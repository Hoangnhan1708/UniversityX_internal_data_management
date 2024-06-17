namespace portal_application_project
{
    partial class New_NhanVien_Form
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
            dateTimePicker2 = new DateTimePicker();
            female_checkbox = new CheckBox();
            male_checkbox = new CheckBox();
            field_phoneNumber = new TextBox();
            field_madv = new TextBox();
            field_phucap = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            close_btn = new Button();
            add_nhanvien_btn = new Button();
            label3 = new Label();
            field_manv = new TextBox();
            field_name = new TextBox();
            label2 = new Label();
            label10 = new Label();
            label1 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            field_role = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(516, 178);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(251, 27);
            dateTimePicker2.TabIndex = 106;
            dateTimePicker2.Value = new DateTime(2024, 6, 14, 0, 0, 0, 0);
            // 
            // female_checkbox
            // 
            female_checkbox.AutoSize = true;
            female_checkbox.Location = new Point(248, 180);
            female_checkbox.Name = "female_checkbox";
            female_checkbox.Size = new Size(51, 24);
            female_checkbox.TabIndex = 105;
            female_checkbox.Text = "Nữ";
            female_checkbox.UseVisualStyleBackColor = true;
            female_checkbox.CheckedChanged += female_checkbox_CheckedChanged;
            // 
            // male_checkbox
            // 
            male_checkbox.AutoSize = true;
            male_checkbox.Location = new Point(154, 180);
            male_checkbox.Name = "male_checkbox";
            male_checkbox.Size = new Size(63, 24);
            male_checkbox.TabIndex = 104;
            male_checkbox.Text = "Nam";
            male_checkbox.UseVisualStyleBackColor = true;
            male_checkbox.CheckedChanged += male_checkbox_CheckedChanged;
            // 
            // field_phoneNumber
            // 
            field_phoneNumber.Anchor = AnchorStyles.Top;
            field_phoneNumber.Location = new Point(516, 250);
            field_phoneNumber.Name = "field_phoneNumber";
            field_phoneNumber.Size = new Size(251, 27);
            field_phoneNumber.TabIndex = 100;
            field_phoneNumber.KeyPress += field_phoneNumber_KeyPress;
            // 
            // field_madv
            // 
            field_madv.Anchor = AnchorStyles.Top;
            field_madv.BackColor = Color.White;
            field_madv.Location = new Point(516, 308);
            field_madv.Name = "field_madv";
            field_madv.Size = new Size(251, 27);
            field_madv.TabIndex = 99;
            // 
            // field_phucap
            // 
            field_phucap.Anchor = AnchorStyles.Top;
            field_phucap.BackColor = Color.White;
            field_phucap.Location = new Point(151, 243);
            field_phucap.Name = "field_phucap";
            field_phucap.Size = new Size(251, 27);
            field_phucap.TabIndex = 97;
            field_phucap.KeyPress += field_phucap_KeyPress;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(420, 311);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 94;
            label8.Text = "Mã đơn vị";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(406, 250);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 92;
            label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(55, 243);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 91;
            label5.Text = "Phụ cấp";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(420, 181);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 90;
            label4.Text = "Ngày sinh";
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
            close_btn.Location = new Point(606, 394);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(86, 51);
            close_btn.TabIndex = 89;
            close_btn.Text = "Đóng";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // add_nhanvien_btn
            // 
            add_nhanvien_btn.Anchor = AnchorStyles.Top;
            add_nhanvien_btn.BackColor = SystemColors.ButtonHighlight;
            add_nhanvien_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            add_nhanvien_btn.FlatAppearance.BorderSize = 3;
            add_nhanvien_btn.FlatStyle = FlatStyle.Flat;
            add_nhanvien_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add_nhanvien_btn.ForeColor = SystemColors.HotTrack;
            add_nhanvien_btn.Location = new Point(322, 394);
            add_nhanvien_btn.Name = "add_nhanvien_btn";
            add_nhanvien_btn.Size = new Size(159, 51);
            add_nhanvien_btn.TabIndex = 88;
            add_nhanvien_btn.Text = "Thêm";
            add_nhanvien_btn.UseVisualStyleBackColor = false;
            add_nhanvien_btn.Click += add_nhanvien_btn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(55, 178);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 87;
            label3.Text = "Phái";
            // 
            // field_manv
            // 
            field_manv.Anchor = AnchorStyles.Top;
            field_manv.BackColor = Color.White;
            field_manv.Location = new Point(154, 116);
            field_manv.Name = "field_manv";
            field_manv.Size = new Size(251, 27);
            field_manv.TabIndex = 86;
            // 
            // field_name
            // 
            field_name.Anchor = AnchorStyles.Top;
            field_name.Location = new Point(516, 116);
            field_name.Name = "field_name";
            field_name.Size = new Size(251, 27);
            field_name.TabIndex = 85;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(429, 119);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 84;
            label2.Text = "Họ tên";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(33, 119);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 83;
            label10.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(310, 9);
            label1.Name = "label1";
            label1.Size = new Size(242, 41);
            label1.TabIndex = 1;
            label1.Text = "Thêm nhân viên";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(64, 311);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 93;
            label7.Text = "Vai trò";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 70);
            panel1.TabIndex = 82;
            // 
            // field_role
            // 
            field_role.FormattingEnabled = true;
            field_role.Location = new Point(154, 311);
            field_role.Name = "field_role";
            field_role.Size = new Size(248, 28);
            field_role.TabIndex = 107;
            // 
            // New_NhanVien_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 480);
            Controls.Add(field_role);
            Controls.Add(dateTimePicker2);
            Controls.Add(female_checkbox);
            Controls.Add(male_checkbox);
            Controls.Add(field_phoneNumber);
            Controls.Add(field_madv);
            Controls.Add(field_phucap);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(close_btn);
            Controls.Add(add_nhanvien_btn);
            Controls.Add(label3);
            Controls.Add(field_manv);
            Controls.Add(field_name);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(panel1);
            Name = "New_NhanVien_Form";
            Text = "Thêm nhân viên";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker2;
        private CheckBox female_checkbox;
        private CheckBox male_checkbox;
        private TextBox field_phoneNumber;
        private TextBox field_madv;
        private TextBox field_phucap;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button close_btn;
        private Button add_nhanvien_btn;
        private Label label3;
        private TextBox field_manv;
        private TextBox field_name;
        private Label label2;
        private Label label10;
        private Label label1;
        private Label label7;
        private Panel panel1;
        private ComboBox field_role;
    }
}