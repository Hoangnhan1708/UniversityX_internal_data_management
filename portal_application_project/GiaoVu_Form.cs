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
    public partial class GiaoVu_Form : Form
    {
        private string connectionString;
        private Query query;
        private GiaoVu giaovu = new GiaoVu();
        public GiaoVu_Form(string _connectionString, string _manv)
        {
            InitializeComponent();
            this.connectionString = _connectionString;
            giaovu.manv = _manv;
            query = new Query();
            giaovu.LoadThongTinUser(connectionString, query);
        }

        private void GiaoVu_Form_Load(object sender, EventArgs e)
        {
            LoadThongTinUser();
            dataGridView_sinhvien.DataSource = giaovu.LoadFullTable(connectionString, query, "SINHVIEN");
            dataGridView_thongtindv.DataSource = giaovu.LoadFullTable(connectionString, query, "DONVI");
            dataGridView_thongtinhp.DataSource = giaovu.LoadFullTable(connectionString, query, "HOCPHAN");
            dataGridView_khmohp.DataSource = giaovu.LoadFullTable(connectionString, query, "KHMO");
            dataGridView_dkhp.DataSource = giaovu.LoadFullTable(connectionString, query, "DANGKY");
            dataGridView_phancong.DataSource = giaovu.LoadFullTable(connectionString, query, "PHANCONG");
        }

        private void LoadThongTinUser()
        {
            field_manv.Text = giaovu.manv;
            field_name.Text = giaovu.hoten;
            hello_name_label.Text = giaovu.hoten;
            field_gender.Text = giaovu.phai;
            field_birthday.Text = giaovu.ngsinh;
            field_salary.Text = giaovu.phucap.ToString();
            field_phoneNumber.Text = giaovu.dt;
            field_role.Text = giaovu.vaitro;
            field_madv.Text = giaovu.madv;
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

        private void handle_student_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlysv;
        }

        private void handle_info_unit_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlythongtindonvi;
        }

        private void handle_course_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlyhp;
        }

        private void handle_open_course_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlykehoachmohp;
        }

        private void handle_register_course_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlydkhp;
        }

        private void handle_assignment_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlyphancong;
        }

        private void change_phoneNumber_btn_Click(object sender, EventArgs e)
        {
            if (field_phoneNumber.Text == giaovu.dt)
            {
                MessageBox.Show("Bạn chưa thay đổi số điện thoại, hãy kiểm tra lại!");
            }
            else
            {
                bool isChanged = giaovu.updatePhoneNumber(connectionString, query, field_phoneNumber.Text);
                if (isChanged)
                {
                    giaovu.dt = field_phoneNumber.Text;
                }

            }
        }
    }
}
