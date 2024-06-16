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
        private TruongDonVi truongdonvi;
        private Query query;
        public New_PhanCong_Form(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;

            truongdonvi = new TruongDonVi();
            query = new Query();
        }

        private void add_phancong_btn_Click(object sender, EventArgs e)
        {
            // Get values from the controls

            string magv = field_magv.Text;
            string mahp = field_mahp.Text;
            int hk = Convert.ToInt32(field_hk.Text);
            int nam = Convert.ToInt32(field_nam.Text);

            string mact = field_mact.Text;


            truongdonvi.insertPhanCong(connectionString, query, magv, mahp, hk, nam, mact);
            
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
