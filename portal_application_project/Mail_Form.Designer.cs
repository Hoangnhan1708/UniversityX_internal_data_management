namespace portal_application_project
{
    partial class Mail_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail_Form));
            emailListView = new ListView();
            emailContentTextBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            hello_name_label = new Label();
            text_hello = new Label();
            title = new Label();
            logo = new Panel();
            panel3 = new Panel();
            dashboard_label = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // emailListView
            // 
            emailListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            emailListView.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            emailListView.Location = new Point(55, 233);
            emailListView.Name = "emailListView";
            emailListView.OwnerDraw = true;
            emailListView.Size = new Size(392, 586);
            emailListView.TabIndex = 0;
            emailListView.UseCompatibleStateImageBehavior = false;
            emailListView.View = View.Tile;
            emailListView.DrawColumnHeader += emailListView_DrawColumnHeader;
            emailListView.DrawItem += emailListView_DrawItem;
            emailListView.SelectedIndexChanged += emailListView_SelectedIndexChanged;
            // 
            // emailContentTextBox
            // 
            emailContentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emailContentTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            emailContentTextBox.Location = new Point(467, 233);
            emailContentTextBox.Name = "emailContentTextBox";
            emailContentTextBox.Size = new Size(841, 586);
            emailContentTextBox.TabIndex = 1;
            emailContentTextBox.Text = "";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(396, 16);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 2;
            label1.Text = "Nội dung";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(109, 16);
            label2.Name = "label2";
            label2.Size = new Size(132, 28);
            label2.TabIndex = 3;
            label2.Text = "Hộp thư đến";
            // 
            // hello_name_label
            // 
            hello_name_label.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            hello_name_label.AutoSize = true;
            hello_name_label.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            hello_name_label.ForeColor = Color.White;
            hello_name_label.Location = new Point(929, 42);
            hello_name_label.Name = "hello_name_label";
            hello_name_label.Size = new Size(167, 26);
            hello_name_label.TabIndex = 70;
            hello_name_label.Text = "ShinichiKuNhan";
            // 
            // text_hello
            // 
            text_hello.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            text_hello.AutoSize = true;
            text_hello.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text_hello.ForeColor = Color.White;
            text_hello.Location = new Point(806, 42);
            text_hello.Name = "text_hello";
            text_hello.Size = new Size(130, 26);
            text_hello.TabIndex = 69;
            text_hello.Text = "(*) Xin chào";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.White;
            title.Location = new Point(133, 42);
            title.Name = "title";
            title.Size = new Size(250, 25);
            title.TabIndex = 68;
            title.Text = "University X Dashboard";
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
            logo.Location = new Point(55, 23);
            logo.Name = "logo";
            logo.Size = new Size(72, 59);
            logo.TabIndex = 67;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.Highlight;
            panel3.Controls.Add(dashboard_label);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(55, 106);
            panel3.Name = "panel3";
            panel3.Size = new Size(1253, 70);
            panel3.TabIndex = 72;
            // 
            // dashboard_label
            // 
            dashboard_label.AutoSize = true;
            dashboard_label.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            dashboard_label.ForeColor = Color.White;
            dashboard_label.Location = new Point(98, 21);
            dashboard_label.Name = "dashboard_label";
            dashboard_label.Size = new Size(108, 35);
            dashboard_label.TabIndex = 1;
            dashboard_label.Text = "USmail";
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(39, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(42, 42);
            panel4.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.FromArgb(0, 35, 73);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(467, 176);
            panel6.Name = "panel6";
            panel6.Size = new Size(841, 59);
            panel6.TabIndex = 74;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 35, 73);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(55, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 62);
            panel2.TabIndex = 75;
            // 
            // Mail_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 69, 142);
            ClientSize = new Size(1382, 853);
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(hello_name_label);
            Controls.Add(text_hello);
            Controls.Add(title);
            Controls.Add(logo);
            Controls.Add(emailContentTextBox);
            Controls.Add(emailListView);
            Name = "Mail_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "USmail";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView emailListView;
        private RichTextBox emailContentTextBox;
        private Label label1;
        private Label label2;
        private Label hello_name_label;
        private Label text_hello;
        private Label title;
        private Panel logo;
        private Panel panel3;
        private Label dashboard_label;
        private Panel panel4;
        private Panel panel6;
        private Panel panel2;
    }
}