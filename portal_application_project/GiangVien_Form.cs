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
    public partial class GiangVien_Form : Form
    {
        private string connectionString;
        private Query query;

        private GiangVien giangvien = new GiangVien();
        //private string manv;
        //private string hoten;
        //private string phai;
        //private string ngsinh;
        //private string phucap;
        //private string dt;
        //private string vaitro;
        //private string madv;

        public GiangVien_Form(string _connectionString, string _manv)
        {
            InitializeComponent();
            this.connectionString = _connectionString;
            giangvien.manv = _manv;
            query = new Query();
            giangvien.LoadThongTinUser(connectionString, query);
        }

        private void GiangVien_Form_Load(object sender, EventArgs e)
        {
            LoadThongTinUser();
            dataGridView_sinhvien.DataSource = giangvien.LoadFullTable(connectionString, query, "SINHVIEN");
            dataGridView_thongtindv.DataSource = giangvien.LoadFullTable(connectionString, query, "DONVI");
            dataGridView_thongtinhp.DataSource = giangvien.LoadFullTable(connectionString, query, "HOCPHAN");
            dataGridView_khmohp.DataSource = giangvien.LoadFullTable(connectionString, query, "KHMO");
        }

        private void LoadThongTinUser()
        {
            field_manv.Text = giangvien.manv;
            field_name.Text = giangvien.hoten;
            hello_name_label.Text = giangvien.hoten;
            field_gender.Text = giangvien.phai;
            field_birthday.Text = giangvien.ngsinh;
            field_salary.Text = giangvien.phucap.ToString();
            field_phoneNumber.Text = giangvien.dt;
            field_role.Text = giangvien.vaitro;
            field_madv.Text = giangvien.madv;
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

        private void student_info_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtinsv;
        }

        private void donvi_info_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtindonvi;

        }

        private void course_info_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtinhp;

        }

        private void kehoachmohp_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_kehoachmohp;

        }

        private void xemphanconggiangday_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_phanconggiangday;
        }

        private void xemlopgiangday_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_lopgiangday;
        }

        private void capnhatdiem_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_capnhatdiem;
        }

        private void change_phoneNumber_btn_Click(object sender, EventArgs e)
        {
            if (field_phoneNumber.Text == giangvien.dt)
            {
                MessageBox.Show("Bạn chưa thay đổi số điện thoại, hãy kiểm tra lại!");
            }
            else
            {
                bool isChanged = giangvien.updatePhoneNumber(connectionString, query, field_phoneNumber.Text);
                if (isChanged)
                {
                    giangvien.dt = field_phoneNumber.Text;
                }

            }
        }
    }
}
