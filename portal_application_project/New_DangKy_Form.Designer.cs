namespace portal_application_project
{
    partial class New_DangKy_Form
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
            field_diemth = new TextBox();
            field_nam = new TextBox();
            field_mact = new TextBox();
            field_hk = new TextBox();
            field_mahp = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            close_btn = new Button();
            add_dangky_btn = new Button();
            field_masv = new TextBox();
            field_magv = new TextBox();
            label2 = new Label();
            label10 = new Label();
            field_diemqt = new TextBox();
            label3 = new Label();
            field_diemck = new TextBox();
            label4 = new Label();
            field_diemtk = new TextBox();
            label11 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // field_diemth
            // 
            field_diemth.Anchor = AnchorStyles.Top;
            field_diemth.Location = new Point(672, 183);
            field_diemth.Name = "field_diemth";
            field_diemth.Size = new Size(251, 27);
            field_diemth.TabIndex = 119;
            field_diemth.KeyPress += field_diemth_KeyPress;
            // 
            // field_nam
            // 
            field_nam.Anchor = AnchorStyles.Top;
            field_nam.Location = new Point(202, 386);
            field_nam.Name = "field_nam";
            field_nam.Size = new Size(251, 27);
            field_nam.TabIndex = 118;
            field_nam.KeyPress += field_nam_KeyPress;
            // 
            // field_mact
            // 
            field_mact.Anchor = AnchorStyles.Top;
            field_mact.Location = new Point(672, 124);
            field_mact.Name = "field_mact";
            field_mact.Size = new Size(251, 27);
            field_mact.TabIndex = 117;
            // 
            // field_hk
            // 
            field_hk.Anchor = AnchorStyles.Top;
            field_hk.BackColor = Color.White;
            field_hk.Location = new Point(202, 319);
            field_hk.Name = "field_hk";
            field_hk.Size = new Size(251, 27);
            field_hk.TabIndex = 116;
            field_hk.KeyPress += field_hk_KeyPress;
            // 
            // field_mahp
            // 
            field_mahp.Anchor = AnchorStyles.Top;
            field_mahp.BackColor = Color.White;
            field_mahp.Location = new Point(202, 254);
            field_mahp.Name = "field_mahp";
            field_mahp.Size = new Size(251, 27);
            field_mahp.TabIndex = 115;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(125, 393);
            label9.Name = "label9";
            label9.Size = new Size(41, 20);
            label9.TabIndex = 114;
            label9.Text = "Năm";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(536, 127);
            label8.Name = "label8";
            label8.Size = new Size(118, 20);
            label8.TabIndex = 113;
            label8.Text = "Mã chương trình";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(112, 322);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 112;
            label7.Text = "Học kỳ";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(540, 186);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 111;
            label6.Text = "Điểm thực hành";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(75, 186);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 110;
            label5.Text = "Mã giảng viên";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(420, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 41);
            label1.TabIndex = 1;
            label1.Text = "Thêm đăng ký";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 70);
            panel1.TabIndex = 103;
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
            close_btn.Location = new Point(703, 464);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(78, 51);
            close_btn.TabIndex = 109;
            close_btn.Text = "Đóng";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // add_dangky_btn
            // 
            add_dangky_btn.Anchor = AnchorStyles.Top;
            add_dangky_btn.BackColor = SystemColors.ButtonHighlight;
            add_dangky_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            add_dangky_btn.FlatAppearance.BorderSize = 3;
            add_dangky_btn.FlatStyle = FlatStyle.Flat;
            add_dangky_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add_dangky_btn.ForeColor = SystemColors.HotTrack;
            add_dangky_btn.Location = new Point(420, 464);
            add_dangky_btn.Name = "add_dangky_btn";
            add_dangky_btn.Size = new Size(159, 51);
            add_dangky_btn.TabIndex = 108;
            add_dangky_btn.Text = "Thêm";
            add_dangky_btn.UseVisualStyleBackColor = false;
            add_dangky_btn.Click += add_dangky_btn_Click;
            // 
            // field_masv
            // 
            field_masv.Anchor = AnchorStyles.Top;
            field_masv.BackColor = Color.White;
            field_masv.Location = new Point(202, 127);
            field_masv.Name = "field_masv";
            field_masv.Size = new Size(251, 27);
            field_masv.TabIndex = 107;
            // 
            // field_magv
            // 
            field_magv.Anchor = AnchorStyles.Top;
            field_magv.Location = new Point(202, 186);
            field_magv.Name = "field_magv";
            field_magv.Size = new Size(251, 27);
            field_magv.TabIndex = 106;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(86, 127);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 105;
            label2.Text = "Mã sinh viên";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(88, 254);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 104;
            label10.Text = "Mã học phần";
            // 
            // field_diemqt
            // 
            field_diemqt.Anchor = AnchorStyles.Top;
            field_diemqt.Location = new Point(672, 244);
            field_diemqt.Name = "field_diemqt";
            field_diemqt.Size = new Size(251, 27);
            field_diemqt.TabIndex = 121;
            field_diemqt.KeyPress += field_diemqt_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(562, 247);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 120;
            label3.Text = "Điểm quá trình";
            // 
            // field_diemck
            // 
            field_diemck.Anchor = AnchorStyles.Top;
            field_diemck.Location = new Point(672, 312);
            field_diemck.Name = "field_diemck";
            field_diemck.Size = new Size(251, 27);
            field_diemck.TabIndex = 123;
            field_diemck.KeyPress += field_diemck_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(562, 315);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 122;
            label4.Text = "Điểm cuối kỳ";
            // 
            // field_diemtk
            // 
            field_diemtk.Anchor = AnchorStyles.Top;
            field_diemtk.Location = new Point(672, 383);
            field_diemtk.Name = "field_diemtk";
            field_diemtk.Size = new Size(251, 27);
            field_diemtk.TabIndex = 125;
            field_diemtk.KeyPress += field_diemtk_KeyPress;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Location = new Point(553, 386);
            label11.Name = "label11";
            label11.Size = new Size(104, 20);
            label11.TabIndex = 124;
            label11.Text = "Điểm tổng kết";
            // 
            // New_DangKy_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 565);
            Controls.Add(field_diemtk);
            Controls.Add(label11);
            Controls.Add(field_diemck);
            Controls.Add(label4);
            Controls.Add(field_diemqt);
            Controls.Add(label3);
            Controls.Add(field_diemth);
            Controls.Add(field_nam);
            Controls.Add(field_mact);
            Controls.Add(field_hk);
            Controls.Add(field_mahp);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(close_btn);
            Controls.Add(add_dangky_btn);
            Controls.Add(field_masv);
            Controls.Add(field_magv);
            Controls.Add(label2);
            Controls.Add(label10);
            Name = "New_DangKy_Form";
            Text = "Thêm đăng ký";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox field_diemth;
        private TextBox field_nam;
        private TextBox field_mact;
        private TextBox field_hk;
        private TextBox field_mahp;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private Panel panel1;
        private Button close_btn;
        private Button add_dangky_btn;
        private TextBox field_masv;
        private TextBox field_magv;
        private Label label2;
        private Label label10;
        private TextBox field_diemqt;
        private Label label3;
        private TextBox field_diemck;
        private Label label4;
        private TextBox field_diemtk;
        private Label label11;
    }
}