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
    public partial class New_HocPhan_Form : Form
    {
        private string connectionString;
        private GiaoVu giaovu;
        private Query query;
        public New_HocPhan_Form(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;

            giaovu = new GiaoVu();
            query = new Query();
        }

        private void add_hocphan_btn_Click(object sender, EventArgs e)
        {
            // Get values from the controls

            string mahp = field_mahp.Text;
            string tenhp = field_tenhp.Text;
            int sotc = Convert.ToInt32(field_sotc.Text);
            int stlt = Convert.ToInt32(field_stlt.Text);
            int stth = Convert.ToInt32(field_stth.Text);
            int ssvtd = Convert.ToInt32(field_ssvtd.Text);
            string madv = field_madv.Text;


            giaovu.insertHocPhan(connectionString, query, mahp, tenhp, sotc, stlt, stth, ssvtd, madv);
            this.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void field_sotc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số thì không cho nhập
            }
        }

        private void field_stlt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số thì không cho nhập
            }
        }

        private void field_stth_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số thì không cho nhập
            }
        }

        private void field_ssvtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số thì không cho nhập
            }
        }
    }
}
