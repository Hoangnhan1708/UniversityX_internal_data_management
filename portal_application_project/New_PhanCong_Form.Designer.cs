namespace portal_application_project
{
    partial class New_PhanCong_Form
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
            field_mact = new TextBox();
            field_nam = new TextBox();
            field_hk = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            close_btn = new Button();
            add_phancong_btn = new Button();
            field_magv = new TextBox();
            field_mahp = new TextBox();
            label2 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // field_mact
            // 
            field_mact.Anchor = AnchorStyles.Top;
            field_mact.Location = new Point(235, 377);
            field_mact.Name = "field_mact";
            field_mact.Size = new Size(251, 27);
            field_mact.TabIndex = 118;
            // 
            // field_nam
            // 
            field_nam.Anchor = AnchorStyles.Top;
            field_nam.BackColor = Color.White;
            field_nam.Location = new Point(235, 319);
            field_nam.Name = "field_nam";
            field_nam.Size = new Size(251, 27);
            field_nam.TabIndex = 116;
            // 
            // field_hk
            // 
            field_hk.Anchor = AnchorStyles.Top;
            field_hk.BackColor = Color.White;
            field_hk.Location = new Point(235, 254);
            field_hk.Name = "field_hk";
            field_hk.Size = new Size(251, 27);
            field_hk.TabIndex = 115;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(93, 380);
            label9.Name = "label9";
            label9.Size = new Size(118, 20);
            label9.TabIndex = 114;
            label9.Text = "Mã chương trình";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(170, 322);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 112;
            label7.Text = "Năm";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(160, 254);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 110;
            label5.Text = "Học kỳ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(235, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 41);
            label1.TabIndex = 1;
            label1.Text = "Thêm phân công";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(638, 70);
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
            close_btn.Location = new Point(488, 459);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(78, 51);
            close_btn.TabIndex = 109;
            close_btn.Text = "Đóng";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // add_phancong_btn
            // 
            add_phancong_btn.Anchor = AnchorStyles.Top;
            add_phancong_btn.BackColor = SystemColors.ButtonHighlight;
            add_phancong_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            add_phancong_btn.FlatAppearance.BorderSize = 3;
            add_phancong_btn.FlatStyle = FlatStyle.Flat;
            add_phancong_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add_phancong_btn.ForeColor = SystemColors.HotTrack;
            add_phancong_btn.Location = new Point(235, 459);
            add_phancong_btn.Name = "add_phancong_btn";
            add_phancong_btn.Size = new Size(159, 51);
            add_phancong_btn.TabIndex = 108;
            add_phancong_btn.Text = "Thêm";
            add_phancong_btn.UseVisualStyleBackColor = false;
            add_phancong_btn.Click += add_phancong_btn_Click;
            // 
            // field_magv
            // 
            field_magv.Anchor = AnchorStyles.Top;
            field_magv.BackColor = Color.White;
            field_magv.Location = new Point(235, 127);
            field_magv.Name = "field_magv";
            field_magv.Size = new Size(251, 27);
            field_magv.TabIndex = 107;
            // 
            // field_mahp
            // 
            field_mahp.Anchor = AnchorStyles.Top;
            field_mahp.Location = new Point(235, 186);
            field_mahp.Name = "field_mahp";
            field_mahp.Size = new Size(251, 27);
            field_mahp.TabIndex = 106;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(117, 186);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 105;
            label2.Text = "Mã học phần";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(114, 130);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 104;
            label10.Text = "Mã giảng viên";
            // 
            // New_PhanCong_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 555);
            Controls.Add(field_mact);
            Controls.Add(field_nam);
            Controls.Add(field_hk);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(close_btn);
            Controls.Add(add_phancong_btn);
            Controls.Add(field_magv);
            Controls.Add(field_mahp);
            Controls.Add(label2);
            Controls.Add(label10);
            Name = "New_PhanCong_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm phân công";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox field_mact;
        private TextBox field_nam;
        private TextBox field_hk;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label1;
        private Panel panel1;
        private Button close_btn;
        private Button add_phancong_btn;
        private TextBox field_magv;
        private TextBox field_mahp;
        private Label label2;
        private Label label10;
    }
}