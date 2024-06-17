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
    public partial class New_PhanCong_Form : Form
    {
        private string connectionString;
        private string role;
        private Query query;
        public New_PhanCong_Form(string connectionString, string role)
        {
            InitializeComponent();
            this.connectionString = connectionString;

            
            query = new Query();
            this.role = role;
        }

        private void add_phancong_btn_Click(object sender, EventArgs e)
        {
            // Get values from the controls

            string magv = field_magv.Text;
            string mahp = field_mahp.Text;
            int hk = Convert.ToInt32(field_hk.Text);
            int nam = Convert.ToInt32(field_nam.Text);

            string mact = field_mact.Text;

            if(role == "TRUONGKHOA")
            {
                TruongKhoa truongkhoa = new TruongKhoa();
                truongkhoa.insertPhanCong(connectionString, query, magv, mahp, hk, nam, mact);
            }
            else
            {
                TruongDonVi truongdonvi = new TruongDonVi();
                truongdonvi.insertPhanCong(connectionString, query, magv, mahp, hk, nam, mact);
            }
            
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
