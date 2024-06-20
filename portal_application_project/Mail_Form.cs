using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace portal_application_project
{
    public partial class Mail_Form : Form
    {
        private List<Mail> emails = new List<Mail>();
        public Mail_Form()
        {
            InitializeComponent();
            LoadEmails();
        }

        private void LoadEmails()
        {
            // Add sample emails
            emails.Add(new Mail("Meeting Reminder", "boss@example.com", "Don't forget the meeting at 3 PM."));
            emails.Add(new Mail("Project Update", "colleague@example.com", "Here is the latest update on the project."));
            emails.Add(new Mail("Party Invitation", "friend@example.com", "You are invited to a party this weekend."));

            foreach (var email in emails)
            {
                var item = new ListViewItem(email.title + " - From: " + email.sender);
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

            // Alternate background color
            if (e.ItemIndex % 2 == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            }

            // Draw text
            e.Graphics.DrawString(e.Item.Text, emailListView.Font, Brushes.Black, e.Bounds.Location);

            e.DrawFocusRectangle();
        }

        private void emailListView_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(e.Header.Text, emailListView.Font, Brushes.Black, e.Bounds);
        }
    }
}
