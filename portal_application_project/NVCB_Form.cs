﻿using Oracle.ManagedDataAccess.Client;
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
    public partial class NVCB_Form : Form
    {
        private string connectionString;
        private Query query;

        private NhanVienCoBan nvcb = new NhanVienCoBan();

        public NVCB_Form(string _connectionString, string _manv)
        {
            InitializeComponent();
            this.connectionString = _connectionString;
            nvcb.manv = _manv;
            query = new Query();
            nvcb.LoadThongTinUser(connectionString, query);
        }

        private void NVCB_Form_Load(object sender, EventArgs e)
        {
            label_tabPage.Text = tabPage_userInfo.Text;
            LoadThongTinUser();
            dataGridView_sinhvien.DataSource = nvcb.LoadFullTable(connectionString, query, "SINHVIEN");
            dataGridView_thongtindv.DataSource = nvcb.LoadFullTable(connectionString, query, "DONVI");
            dataGridView_thongtinhp.DataSource = nvcb.LoadFullTable(connectionString, query, "HOCPHAN");
            dataGridView_khmohp.DataSource = nvcb.LoadFullTable(connectionString, query, "KHMO");

        }


        private void LoadThongTinUser()
        {
            field_manv.Text = nvcb.manv;
            field_name.Text = nvcb.hoten;
            hello_name_label.Text = nvcb.hoten;
            field_gender.Text = nvcb.phai;
            field_birthday.Text = nvcb.ngsinh.ToString();
            field_salary.Text = nvcb.phucap.ToString();
            field_phoneNumber.Text = nvcb.dt;
            field_role.Text = nvcb.vaitro;
            field_madv.Text = nvcb.madv;
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
            label_tabPage.Text = tabPage_userInfo.Text;
        }

        private void student_info_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtinsv;
            label_tabPage.Text = tabPage_thongtinsv.Text;
        }

        private void donvi_info_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtindonvi;
            label_tabPage.Text = tabPage_thongtindonvi.Text;

        }

        private void course_info_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtinhp;
            label_tabPage.Text = tabPage_thongtinhp.Text;

        }

        private void kehoachmohp_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_kehoachmohp;
            label_tabPage.Text = tabPage_kehoachmohp.Text;

        }

        private void change_phoneNumber_btn_Click(object sender, EventArgs e)
        {
            if (field_phoneNumber.Text == nvcb.dt)
            {
                MessageBox.Show("Bạn chưa thay đổi số điện thoại, hãy kiểm tra lại!");
            }
            else
            {
                bool isChanged = nvcb.updatePhoneNumber(connectionString, query, field_phoneNumber.Text);
                if (isChanged)
                {
                    nvcb.dt = field_phoneNumber.Text;
                }

            }
        }


        private void mail_btn_Click(object sender, EventArgs e)
        {
            string mailConnectionString = query.LoginMailString("NVien082", "pwd");
            Mail_Form mailForm = new Mail_Form(mailConnectionString, nvcb.hoten);
            mailForm.ShowDialog();
        }

        private void NVCB_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
