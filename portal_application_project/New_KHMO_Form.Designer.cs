namespace portal_application_project
{
    partial class New_KHMO_Form
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
            close_btn = new Button();
            field_mahp = new TextBox();
            field_hk = new TextBox();
            label2 = new Label();
            label10 = new Label();
            label1 = new Label();
            field_nam = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            add_khmo_btn = new Button();
            field_mact = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
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
            close_btn.Location = new Point(429, 363);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(78, 51);
            close_btn.TabIndex = 104;
            close_btn.Text = "Đóng";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // field_mahp
            // 
            field_mahp.Anchor = AnchorStyles.Top;
            field_mahp.BackColor = Color.White;
            field_mahp.Location = new Point(199, 93);
            field_mahp.Name = "field_mahp";
            field_mahp.Size = new Size(251, 27);
            field_mahp.TabIndex = 102;
            // 
            // field_hk
            // 
            field_hk.Anchor = AnchorStyles.Top;
            field_hk.Location = new Point(199, 159);
            field_hk.Name = "field_hk";
            field_hk.Size = new Size(251, 27);
            field_hk.TabIndex = 101;
            field_hk.KeyPress += field_hk_KeyPress;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(114, 230);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 100;
            label2.Text = "Năm học";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(88, 96);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 99;
            label10.Text = "Mã học phần";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 9);
            label1.Name = "label1";
            label1.Size = new Size(421, 41);
            label1.TabIndex = 1;
            label1.Text = "Thêm kế hoạch mở học phần";
            // 
            // field_nam
            // 
            field_nam.Anchor = AnchorStyles.Top;
            field_nam.BackColor = Color.White;
            field_nam.Location = new Point(199, 227);
            field_nam.Name = "field_nam";
            field_nam.Size = new Size(251, 27);
            field_nam.TabIndex = 106;
            field_nam.KeyPress += field_nam_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(129, 162);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 105;
            label5.Text = "Học kỳ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 70);
            panel1.TabIndex = 98;
            // 
            // add_khmo_btn
            // 
            add_khmo_btn.Anchor = AnchorStyles.Top;
            add_khmo_btn.BackColor = SystemColors.ButtonHighlight;
            add_khmo_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            add_khmo_btn.FlatAppearance.BorderSize = 3;
            add_khmo_btn.FlatStyle = FlatStyle.Flat;
            add_khmo_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add_khmo_btn.ForeColor = SystemColors.HotTrack;
            add_khmo_btn.Location = new Point(199, 363);
            add_khmo_btn.Name = "add_khmo_btn";
            add_khmo_btn.Size = new Size(159, 51);
            add_khmo_btn.TabIndex = 103;
            add_khmo_btn.Text = "Thêm";
            add_khmo_btn.UseVisualStyleBackColor = false;
            add_khmo_btn.Click += add_khmo_btn_Click;
            // 
            // field_mact
            // 
            field_mact.Anchor = AnchorStyles.Top;
            field_mact.BackColor = Color.White;
            field_mact.Location = new Point(199, 283);
            field_mact.Name = "field_mact";
            field_mact.Size = new Size(251, 27);
            field_mact.TabIndex = 108;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(65, 286);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 107;
            label3.Text = "Mã chương trình";
            // 
            // New_KHMO_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 436);
            Controls.Add(field_mact);
            Controls.Add(label3);
            Controls.Add(close_btn);
            Controls.Add(field_mahp);
            Controls.Add(field_hk);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(field_nam);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(add_khmo_btn);
            Name = "New_KHMO_Form";
            Text = "Thêm kế hoạch mở học phần";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button close_btn;
        private TextBox field_mahp;
        private TextBox field_hk;
        private Label label2;
        private Label label10;
        private Label label1;
        private TextBox field_nam;
        private Label label5;
        private Panel panel1;
        private Button add_khmo_btn;
        private TextBox field_mact;
        private Label label3;
    }
}