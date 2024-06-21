using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace portal_application_project
{
    public partial class Mail_Form : Form
    {
        private List<Mail> emails = new List<Mail>();
        private string connectionString;
        private string fullname;
        private Query query = new Query();

        public Mail_Form(string connectionString, string fullname)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            hello_name_label.Text = fullname;
            LoadEmails();
        }


        private void LoadEmails()
        {

            string query = "SELECT NOIDUNG FROM QLTRUONGHOC.THONGBAO";

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    OracleCommand command = new OracleCommand(query, connection);
                    connection.Open();
                    OracleDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        string content = reader["NOIDUNG"].ToString();

                        Mail email = new Mail(content);
                        emails.Add(email);
                        
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading emails: " + ex.Message);
            }

            // Bind emails to ListView
            foreach (var email in emails)
            {

                var item = new ListViewItem(email.content);
                item.Tag = email; // Store the Mail object in the Tag property
                emailListView.Items.Add(item);
            }

        }

        private void emailListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (emailListView.SelectedItems.Count > 0)
            {
                var selectedMail = emailListView.SelectedItems[0].Tag as Mail;
                if (selectedMail != null)
                {
                    emailContentTextBox.Text = selectedMail.content;
                }
            }
        }

        private void emailListView_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            // Set the bounds to the full width of the emailListView
            Rectangle bounds = new Rectangle(e.Bounds.Left, e.Bounds.Top, emailListView.ClientSize.Width, e.Bounds.Height);

            // Alternate background color
            if (e.ItemIndex % 2 == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, bounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, bounds);
            }

            // Draw text
            e.Graphics.DrawString(e.Item.Text, emailListView.Font, Brushes.Black, bounds.Left, bounds.Top);

            // Draw focus rectangle
            if (e.State.HasFlag(ListViewItemStates.Selected))
            {
                Pen focusPen = new Pen(Color.Black) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dot };
                Rectangle focusBounds = new Rectangle(bounds.Left, bounds.Top, emailListView.ClientSize.Width - 1, bounds.Height - 1);
                e.Graphics.DrawRectangle(focusPen, focusBounds);
            }
            

        }

        private void emailListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(e.Header.Text, emailListView.Font, Brushes.Black, e.Bounds);
        }
    }
}
