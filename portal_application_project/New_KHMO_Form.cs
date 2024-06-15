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
    public partial class New_KHMO_Form : Form
    {
        private string connectionString;
        private GiaoVu giaovu;
        private Query query;
        public New_KHMO_Form(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;

            giaovu = new GiaoVu();
            query = new Query();
        }




        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void field_hk_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số thì không cho nhập
            }
        }

        private void field_nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số thì không cho nhập
            }
        }

        private void add_khmo_btn_Click(object sender, EventArgs e)
        {
            // Get values from the controls

            string mahp = field_mahp.Text;
            int hk = Convert.ToInt32(field_hk.Text);
            int nam = Convert.ToInt32(field_nam.Text);
            string mact = field_mact.Text;


            giaovu.insertKHMO(connectionString, query, mahp, hk, nam, mact);
            this.Close();
        }
    }
}
