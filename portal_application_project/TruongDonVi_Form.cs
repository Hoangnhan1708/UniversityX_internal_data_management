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

namespace portal_application_project
{
    public partial class TruongDonVi_Form : Form
    {
        private string connectionString;
        private Query query;

        private TruongDonVi truongdonvi = new TruongDonVi();
        public TruongDonVi_Form(string _connectionString, string _manv)
        {
            InitializeComponent();
            this.connectionString = _connectionString;
            truongdonvi.manv = _manv;
            query = new Query();
            truongdonvi.LoadThongTinUser(connectionString, query);
        }

        private void TruongDonVi_Form_Load(object sender, EventArgs e)
        {
            LoadThongTinUser();
            dataGridView_sinhvien.DataSource = truongdonvi.LoadFullTable(connectionString, query, "SINHVIEN");
            dataGridView_thongtindv.DataSource = truongdonvi.LoadFullTable(connectionString, query, "DONVI");
            dataGridView_thongtinhp.DataSource = truongdonvi.LoadFullTable(connectionString, query, "HOCPHAN");
            dataGridView_khmohp.DataSource = truongdonvi.LoadFullTable(connectionString, query, "KHMO");
            dataGridView_dkhp.DataSource = truongdonvi.LoadFullTable(connectionString, query, "DANGKY");
            dataGridView_phancong.DataSource = truongdonvi.LoadFullTable(connectionString, query, "PHANCONG");
        }

        private void LoadThongTinUser()
        {
            field_manv.Text = truongdonvi.manv;
            field_name.Text = truongdonvi.hoten;
            hello_name_label.Text = truongdonvi.hoten;
            field_gender.Text = truongdonvi.phai;
            field_birthday.Text = truongdonvi.ngsinh;
            field_salary.Text = truongdonvi.phucap.ToString();
            field_phoneNumber.Text = truongdonvi.dt;
            field_role.Text = truongdonvi.vaitro;
            field_madv.Text = truongdonvi.madv;
        }



        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void user_info_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_userInfo;
        }

        private void phancong_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_phancong;
        }

        private void thongtinsv_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtinsv;
        }

        private void capnhatsv_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_capnhatsv;
        }

        private void thongtindv_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtindonvi;
        }

        private void thongtinhp_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtinhp;
        }

        private void khmohp_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_kehoachmohp;
        }

        private void thongtin_dkhp_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtindkhp;
        }

        private void quanlyphancong_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlyphancong;
        }

        private void change_phoneNumber_btn_Click(object sender, EventArgs e)
        {
            if (field_phoneNumber.Text == truongdonvi.dt)
            {
                MessageBox.Show("Bạn chưa thay đổi số điện thoại, hãy kiểm tra lại!");
            }
            else
            {
                bool isChanged = truongdonvi.updatePhoneNumber(connectionString, query, field_phoneNumber.Text);
                if (isChanged)
                {
                    truongdonvi.dt = field_phoneNumber.Text;
                }

            }
        }
    }
}
