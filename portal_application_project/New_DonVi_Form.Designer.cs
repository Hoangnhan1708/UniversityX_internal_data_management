namespace portal_application_project
{
    partial class New_DonVi_Form
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
            label10 = new Label();
            label2 = new Label();
            field_name_donvi = new TextBox();
            field_madv = new TextBox();
            close_btn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            field_truongdonvi = new TextBox();
            add_donvi_btn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(56, 122);
            label10.Name = "label10";
            label10.Size = new Size(75, 20);
            label10.TabIndex = 83;
            label10.Text = "Mã đơn vị";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(56, 192);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 84;
            label2.Text = "Tên đơn vị";
            // 
            // field_name_donvi
            // 
            field_name_donvi.Anchor = AnchorStyles.Top;
            field_name_donvi.Location = new Point(167, 189);
            field_name_donvi.Name = "field_name_donvi";
            field_name_donvi.Size = new Size(251, 27);
            field_name_donvi.TabIndex = 85;
            // 
            // field_madv
            // 
            field_madv.Anchor = AnchorStyles.Top;
            field_madv.BackColor = Color.White;
            field_madv.Location = new Point(167, 119);
            field_madv.Name = "field_madv";
            field_madv.Size = new Size(251, 27);
            field_madv.TabIndex = 86;
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
            close_btn.Location = new Point(429, 340);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(78, 51);
            close_btn.TabIndex = 89;
            close_btn.Text = "Đóng";
            close_btn.UseVisualStyleBackColor = false;
            close_btn.Click += close_btn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(190, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 41);
            label1.TabIndex = 1;
            label1.Text = "Thêm đơn vị";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 70);
            panel1.TabIndex = 82;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(32, 261);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 91;
            label5.Text = "Trưởng đơn vị";
            // 
            // field_truongdonvi
            // 
            field_truongdonvi.Anchor = AnchorStyles.Top;
            field_truongdonvi.BackColor = Color.White;
            field_truongdonvi.Location = new Point(167, 258);
            field_truongdonvi.Name = "field_truongdonvi";
            field_truongdonvi.Size = new Size(251, 27);
            field_truongdonvi.TabIndex = 97;
            // 
            // add_donvi_btn
            // 
            add_donvi_btn.Anchor = AnchorStyles.Top;
            add_donvi_btn.BackColor = SystemColors.ButtonHighlight;
            add_donvi_btn.FlatAppearance.BorderColor = SystemColors.Highlight;
            add_donvi_btn.FlatAppearance.BorderSize = 3;
            add_donvi_btn.FlatStyle = FlatStyle.Flat;
            add_donvi_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            add_donvi_btn.ForeColor = SystemColors.HotTrack;
            add_donvi_btn.Location = new Point(199, 340);
            add_donvi_btn.Name = "add_donvi_btn";
            add_donvi_btn.Size = new Size(159, 51);
            add_donvi_btn.TabIndex = 88;
            add_donvi_btn.Text = "Thêm";
            add_donvi_btn.UseVisualStyleBackColor = false;
            add_donvi_btn.Click += add_donvi_btn_Click;
            // 
            // New_DonVi_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 436);
            Controls.Add(field_truongdonvi);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(close_btn);
            Controls.Add(add_donvi_btn);
            Controls.Add(field_madv);
            Controls.Add(field_name_donvi);
            Controls.Add(label2);
            Controls.Add(label10);
            Name = "New_DonVi_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm đơn vị";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private Label label2;
        private TextBox field_name_donvi;
        private TextBox field_madv;
        private Button close_btn;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private TextBox field_truongdonvi;
        private Button add_donvi_btn;
    }
}