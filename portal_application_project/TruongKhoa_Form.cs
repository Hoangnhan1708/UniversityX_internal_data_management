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
    public partial class TruongKhoa_Form : Form
    {
        private string connectionString;
        private Query query;

        private TruongKhoa truongkhoa = new TruongKhoa();
        public TruongKhoa_Form(string _connectionString, string _manv)
        {
            InitializeComponent();
            this.connectionString = _connectionString;
            truongkhoa.manv = _manv;
            query = new Query();
            truongkhoa.LoadThongTinUser(connectionString, query);
        }

        private void TruongKhoa_Form_Load(object sender, EventArgs e)
        {
            LoadThongTinUser();
            dataGridView_sinhvien.DataSource = truongkhoa.LoadFullTable(connectionString, query, "SINHVIEN");
            dataGridView_thongtindv.DataSource = truongkhoa.LoadFullTable(connectionString, query, "DONVI");
            dataGridView_thongtinhp.DataSource = truongkhoa.LoadFullTable(connectionString, query, "HOCPHAN");
            dataGridView_khmohp.DataSource = truongkhoa.LoadFullTable(connectionString, query, "KHMO");
            dataGridView_dkhp.DataSource = truongkhoa.LoadFullTable(connectionString, query, "DANGKY");
            dataGridView_phancong.DataSource = truongkhoa.LoadFullTable(connectionString, query, "PHANCONG");
        }

        private void LoadThongTinUser()
        {
            field_manv.Text = truongkhoa.manv;
            field_name.Text = truongkhoa.hoten;
            hello_name_label.Text = truongkhoa.hoten;
            field_gender.Text = truongkhoa.phai;
            field_birthday.Text = truongkhoa.ngsinh;
            field_salary.Text = truongkhoa.phucap.ToString();
            field_phoneNumber.Text = truongkhoa.dt;
            field_role.Text = truongkhoa.vaitro;
            field_madv.Text = truongkhoa.madv;
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

        private void quanlynhansu_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlynhansu;
        }

        private void change_phoneNumber_btn_Click(object sender, EventArgs e)
        {
            if (field_phoneNumber.Text == truongkhoa.dt)
            {
                MessageBox.Show("Bạn chưa thay đổi số điện thoại, hãy kiểm tra lại!");
            }
            else
            {
                bool isChanged = truongkhoa.updatePhoneNumber(connectionString, query, field_phoneNumber.Text);
                if (isChanged)
                {
                    truongkhoa.dt = field_phoneNumber.Text;
                }

            }
        }
    }
}
