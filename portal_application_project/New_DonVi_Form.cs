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

namespace portal_application_project
{
    public partial class New_DonVi_Form : Form
    {
        private string connectionString;
        private Query query;
        private GiaoVu giaovu;
        public New_DonVi_Form(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            query = new Query();
            giaovu = new GiaoVu();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_donvi_btn_Click(object sender, EventArgs e)
        {
            // Get values from the controls
            string madv = field_madv.Text;
            string tendv = field_name_donvi.Text;
            string truongdonvi = field_truongdonvi.Text;

            giaovu.insertDonVi(connectionString, query, madv, tendv, truongdonvi);
            this.Close();

        }
    }
}
