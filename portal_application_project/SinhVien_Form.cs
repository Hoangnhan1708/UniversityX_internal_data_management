using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace portal_application_project
{
    public partial class SinhVien_Form : Form
    {
        private string connectionString;
        private string mssv;
        private string hoten;
        private string phai;
        private string ngsinh;
        private string dchi;
        private string dt;
        private string mact;
        private string manganh;
        private string sotctl;
        private string dtbtl;
        public SinhVien_Form(string _connectionString, string username)
        {
            InitializeComponent();
            this.connectionString = _connectionString;
            this.mssv = username;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void SinhVien_Form_Load(object sender, EventArgs e)
        {
            LoadThongTinSV();
        }

        private void LoadThongTinSV()
        {
            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    OracleCommand command = new OracleCommand("SELECT * FROM QLTRUONGHOC.SINHVIEN WHERE MASV = '" + mssv + "'", connection);
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // Duyệt qua từng dòng trong DataTable và thêm vào DataGridView
                    int i = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        hoten = row["HOTEN"].ToString();
                        phai = row["PHAI"].ToString();
                        ngsinh = row["PHAI"].ToString();
                        dchi = row["PHAI"].ToString();
                        dt = row["PHAI"].ToString();
                        mact = row["PHAI"].ToString();
                        manganh = row["PHAI"].ToString();
                        sotctl = row["PHAI"].ToString();
                        dtbtl = row["PHAI"].ToString();

                    }
                    field_mssv.Text = mssv;
                    field_name.Text = hoten;
                    hello_name_label.Text = hoten;
                    //label_userID.Text = userID;
                    //label_name.Text = username;
                    //label_status.Text = status;

                    //if (roles == "")
                    //{
                    //    roles = "Have no roles to show";
                    //}

                    //label_Role.Text = roles;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_thongtinsv_Click(object sender, EventArgs e)
        {
            tabControl_sinhvien.SelectedTab = tabPage_thongtinsv;
        }

        private void hpddk_btn_Click(object sender, EventArgs e)
        {
            tabControl_sinhvien.SelectedTab = tabPage_hpdadangky;
        }

        private void btn_kehoachmohp_Click(object sender, EventArgs e)
        {
            tabControl_sinhvien.SelectedTab = tabPage_kehoachmohp;
        }

        private void btn_dkhp_Click(object sender, EventArgs e)
        {
            tabControl_sinhvien.SelectedTab = tabPage_dkhp;
        }


    }
}
