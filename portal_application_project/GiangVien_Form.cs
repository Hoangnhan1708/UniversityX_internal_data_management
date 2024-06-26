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
        // Declare a list to keep track of modified rows
        private List<DataGridViewRow> modifiedRows = new List<DataGridViewRow>();

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
            label.Text = tabPage_userInfo.Text;
            LoadThongTinUser();
            dataGridView_sinhvien.DataSource = giangvien.LoadFullTable(connectionString, query, "SINHVIEN");
            dataGridView_thongtindv.DataSource = giangvien.LoadFullTable(connectionString, query, "DONVI");
            dataGridView_thongtinhp.DataSource = giangvien.LoadFullTable(connectionString, query, "HOCPHAN");
            dataGridView_khmohp.DataSource = giangvien.LoadFullTable(connectionString, query, "KHMO");
            dataGridView_phanconggiangday.DataSource = giangvien.LoadFullTable(connectionString, query, "V_INFO_PHANCONG");
            dataGridView_xemlopgiangday.DataSource = giangvien.LoadFullTable(connectionString, query, "V_INFO_LOPPHANCONG");

            dataGridView_capnhatdiem.DataSource = giangvien.LoadFullTable(connectionString, query, "V_INFO_LOPPHANCONG");
        }

        private void LoadThongTinUser()
        {
            field_manv.Text = giangvien.manv;
            field_name.Text = giangvien.hoten;
            hello_name_label.Text = giangvien.hoten;
            field_gender.Text = giangvien.phai;
            field_birthday.Text = giangvien.ngsinh.ToString();
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
            label.Text = tabPage_userInfo.Text;
        }

        private void student_info_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtinsv;
            label.Text = tabPage_thongtinsv.Text;
        }

        private void donvi_info_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtindonvi;
            label.Text = tabPage_thongtindonvi.Text;

        }

        private void course_info_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtinhp;
            label.Text = tabPage_thongtinhp.Text;

        }

        private void kehoachmohp_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_kehoachmohp;
            label.Text = tabPage_kehoachmohp.Text;
        }

        private void xemphanconggiangday_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_phanconggiangday;
            label.Text = tabPage_phanconggiangday.Text;
        }

        private void xemlopgiangday_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_lopgiangday;
            label.Text = tabPage_lopgiangday.Text;
        }

        private void capnhatdiem_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_capnhatdiem;
            label.Text = tabPage_capnhatdiem.Text;
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

        private void dataGridView_capnhatdiem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed column is one of the score columns
            if (e.ColumnIndex == dataGridView_capnhatdiem.Columns["DIEMTH"].Index ||
                e.ColumnIndex == dataGridView_capnhatdiem.Columns["DIEMQT"].Index ||
                e.ColumnIndex == dataGridView_capnhatdiem.Columns["DIEMCK"].Index ||
                e.ColumnIndex == dataGridView_capnhatdiem.Columns["DIEMTK"].Index)
            {
                // Add the modified row to the list if it's not already there
                DataGridViewRow row = dataGridView_capnhatdiem.Rows[e.RowIndex];
                if (!modifiedRows.Contains(row))
                {
                    modifiedRows.Add(row);
                }
            }
        }

        private void update_score_btn_Click(object sender, EventArgs e)
        {
            giangvien.updateScore(connectionString, query, modifiedRows);


            // Clear the list of modified rows after updating
            modifiedRows.Clear();
        }

        private void mail_btn_Click(object sender, EventArgs e)
        {
            string mailConnectionString = query.LoginMailString("GVien401", "pwd");
            Mail_Form mailForm = new Mail_Form(mailConnectionString, giangvien.hoten);
            mailForm.ShowDialog();
        }

        private void GiangVien_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void refresh_capnhatdiem_btn_Click(object sender, EventArgs e)
        {
            dataGridView_capnhatdiem.DataSource = giangvien.LoadFullTable(connectionString, query, "V_INFO_LOPPHANCONG");
        }
    }
}
