﻿using Oracle.ManagedDataAccess.Client;
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
        private List<DataGridViewRow> modifiedRows = new List<DataGridViewRow>();
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
            label_tabPage.Text = tabPage_userInfo.Text;
            LoadThongTinUser();
            dataGridView_sinhvien.DataSource = giaovu.LoadFullTable(connectionString, query, "SINHVIEN");
            dataGridView_thongtindv.DataSource = giaovu.LoadFullTable(connectionString, query, "DONVI");
            dataGridView_thongtinhp.DataSource = giaovu.LoadFullTable(connectionString, query, "HOCPHAN");
            dataGridView_khmohp.DataSource = giaovu.LoadFullTable(connectionString, query, "KHMO");
            LoadPhanCongWithOldMAGVColumn();
            //dataGridView_phancong.DataSource = giaovu.LoadFullTable(connectionString, query, "V_PHANCONG_GIAOVU");
            LoadDangKyWithCheckboxColumn();
        }

        private void LoadThongTinUser()
        {
            field_manv.Text = giaovu.manv;
            field_name.Text = giaovu.hoten;
            hello_name_label.Text = giaovu.hoten;
            field_gender.Text = giaovu.phai;
            field_birthday.Text = giaovu.ngsinh.ToString();
            field_salary.Text = giaovu.phucap.ToString();
            field_phoneNumber.Text = giaovu.dt;
            field_role.Text = giaovu.vaitro;
            field_madv.Text = giaovu.madv;
        }

        private void LoadPhanCongWithOldMAGVColumn()
        {
            DataTable dataTable = giaovu.LoadFullTable(connectionString, query, "V_PHANCONG_GIAOVU");

            // Thêm cột lưu giá trị ban đầu của MAGV vào DataTable
            if (!dataTable.Columns.Contains("OLD_MAGV"))
            {
                dataTable.Columns.Add("OLD_MAGV", typeof(string));
            }

            // Lưu giá trị ban đầu của MAGV vào cột OLD_MAGV
            foreach (DataRow row in dataTable.Rows)
            {
                row["OLD_MAGV"] = row["MAGV"];
            }

            dataGridView_phancong.DataSource = dataTable;



            // Ẩn cột OLD_MAGV
            if (dataGridView_phancong.Columns.Contains("OLD_MAGV"))
            {
                dataGridView_phancong.Columns["OLD_MAGV"].Visible = false;
            }
        }

        // Load data and add the checkbox column
        private void LoadDangKyWithCheckboxColumn()
        {
            DataTable dataTable = giaovu.LoadFullTable(connectionString, query, "V_DANGKY_GIAOVU");



            dataGridView_dkhp.DataSource = dataTable;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                TrueValue = true,
                FalseValue = false
            };
            dataGridView_dkhp.Columns.Insert(0, checkBoxColumn);
        }


        // Tab Page: ThongTin

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

        // Tab Page: SINHVIEN

        private void dataGridView_sinhvien_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed column is one of the score columns
            if (e.ColumnIndex == dataGridView_sinhvien.Columns["MASV"].Index ||
                e.ColumnIndex == dataGridView_sinhvien.Columns["HOTEN"].Index ||
                e.ColumnIndex == dataGridView_sinhvien.Columns["PHAI"].Index ||
                e.ColumnIndex == dataGridView_sinhvien.Columns["NGSINH"].Index ||
                e.ColumnIndex == dataGridView_sinhvien.Columns["DCHI"].Index ||
                e.ColumnIndex == dataGridView_sinhvien.Columns["DT"].Index ||
                e.ColumnIndex == dataGridView_sinhvien.Columns["MACT"].Index ||
                e.ColumnIndex == dataGridView_sinhvien.Columns["MANGANH"].Index ||
                e.ColumnIndex == dataGridView_sinhvien.Columns["SOTCTL"].Index ||
                e.ColumnIndex == dataGridView_sinhvien.Columns["DTBTL"].Index)
            {
                // Add the modified row to the list if it's not already there
                DataGridViewRow row = dataGridView_sinhvien.Rows[e.RowIndex];
                if (!modifiedRows.Contains(row))
                {
                    modifiedRows.Add(row);
                }
            }
        }

        private void update_sinhvien_btn_Click(object sender, EventArgs e)
        {
            giaovu.updateSinhVienInfo(connectionString, query, modifiedRows);


            // Clear the list of modified rows after updating
            modifiedRows.Clear();
        }

        private void add_sinhvien_btn_Click(object sender, EventArgs e)
        {
            New_SinhVien_Form newSinhVienForm = new New_SinhVien_Form(connectionString);
            newSinhVienForm.ShowDialog();
        }

        private void refresh_sinhvien_btn_Click(object sender, EventArgs e)
        {
            dataGridView_sinhvien.DataSource = giaovu.LoadFullTable(connectionString, query, "SINHVIEN");
        }


        // Tab Page: DONVI
        //private void add_donvi_btn_Click(object sender, EventArgs e)
        //{
        //    New_DonVi_Form newDonViForm = new New_DonVi_Form(connectionString);
        //    newDonViForm.ShowDialog();
        //}

        private void refresh_donvi_btn_Click(object sender, EventArgs e)
        {
            dataGridView_thongtindv.DataSource = giaovu.LoadFullTable(connectionString, query, "DONVI");
        }

        private void dataGridView_thongtindv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed column is one of the score columns
            if (e.ColumnIndex == dataGridView_thongtindv.Columns["MADV"].Index ||
                e.ColumnIndex == dataGridView_thongtindv.Columns["TENDV"].Index ||
                e.ColumnIndex == dataGridView_thongtindv.Columns["TRGDV"].Index)
            {
                // Add the modified row to the list if it's not already there
                DataGridViewRow row = dataGridView_thongtindv.Rows[e.RowIndex];
                if (!modifiedRows.Contains(row))
                {
                    modifiedRows.Add(row);
                }
            }
        }

        private void update_donvi_btn_Click(object sender, EventArgs e)
        {

            giaovu.updateDonViInfo(connectionString, query, modifiedRows);


            // Clear the list of modified rows after updating
            modifiedRows.Clear();
        }

        // Tab Page: HOCPHAN

        private void add_hocphan_btn_Click(object sender, EventArgs e)
        {
            New_HocPhan_Form newHocPhanForm = new New_HocPhan_Form(connectionString);
            newHocPhanForm.ShowDialog();
        }

        private void refresh_hocphan_btn_Click(object sender, EventArgs e)
        {
            dataGridView_thongtinhp.DataSource = giaovu.LoadFullTable(connectionString, query, "HOCPHAN");
        }

        private void dataGridView_thongtinhp_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed column is one of the score columns
            if (e.ColumnIndex == dataGridView_thongtinhp.Columns["MAHP"].Index ||
                e.ColumnIndex == dataGridView_thongtinhp.Columns["TENHP"].Index ||
                e.ColumnIndex == dataGridView_thongtinhp.Columns["SOTC"].Index ||
                e.ColumnIndex == dataGridView_thongtinhp.Columns["STLT"].Index ||
                e.ColumnIndex == dataGridView_thongtinhp.Columns["STTH"].Index ||
                e.ColumnIndex == dataGridView_thongtinhp.Columns["SOSVTD"].Index ||
                e.ColumnIndex == dataGridView_thongtinhp.Columns["MADV"].Index)
            {
                // Add the modified row to the list if it's not already there
                DataGridViewRow row = dataGridView_thongtinhp.Rows[e.RowIndex];
                if (!modifiedRows.Contains(row))
                {
                    modifiedRows.Add(row);
                }
            }
        }


        private void update_hocphan_btn_Click(object sender, EventArgs e)
        {
            giaovu.updateHocPhanInfo(connectionString, query, modifiedRows);


            // Clear the list of modified rows after updating
            modifiedRows.Clear();
        }

        // Tab Page: KHMO
        private void dataGridView_khmohp_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed column is one of the score columns
            if (e.ColumnIndex == dataGridView_khmohp.Columns["MAHP"].Index ||
                e.ColumnIndex == dataGridView_khmohp.Columns["HK"].Index ||
                e.ColumnIndex == dataGridView_khmohp.Columns["NAM"].Index ||
                e.ColumnIndex == dataGridView_khmohp.Columns["MACT"].Index)
            {
                // Add the modified row to the list if it's not already there
                DataGridViewRow row = dataGridView_khmohp.Rows[e.RowIndex];
                if (!modifiedRows.Contains(row))
                {
                    modifiedRows.Add(row);
                }
            }
        }

        private void update_khmo_btn_Click(object sender, EventArgs e)
        {
            giaovu.updateKHMOInfo(connectionString, query, modifiedRows);


            // Clear the list of modified rows after updating
            modifiedRows.Clear();
        }

        private void refresh_khmo_btn_Click(object sender, EventArgs e)
        {
            dataGridView_khmohp.DataSource = giaovu.LoadFullTable(connectionString, query, "KHMO");
        }

        private void add_khmo_btn_Click(object sender, EventArgs e)
        {
            New_KHMO_Form newKHMOForm = new New_KHMO_Form(connectionString);
            newKHMOForm.ShowDialog();
        }


        // Tab Page: PHANCONG

        private void dataGridView_phancong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed column is one of the score columns
            if (e.ColumnIndex == dataGridView_phancong.Columns["MAGV"].Index ||
                e.ColumnIndex == dataGridView_phancong.Columns["MAHP"].Index ||
                e.ColumnIndex == dataGridView_phancong.Columns["HK"].Index ||
                e.ColumnIndex == dataGridView_phancong.Columns["NAM"].Index ||
                e.ColumnIndex == dataGridView_phancong.Columns["MACT"].Index)
            {
                // Add the modified row to the list if it's not already there
                DataGridViewRow row = dataGridView_phancong.Rows[e.RowIndex];
                if (!modifiedRows.Contains(row))
                {
                    modifiedRows.Add(row);
                }
            }
        }

        private void update_phancong_btn_Click(object sender, EventArgs e)
        {
            giaovu.updatePhanCongInfo(connectionString, query, modifiedRows);


            // Clear the list of modified rows after updating
            modifiedRows.Clear();
        }

        private void refresh_phancong_btn_Click(object sender, EventArgs e)
        {
            dataGridView_phancong.DataSource = giaovu.LoadFullTable(connectionString, query, "V_PHANCONG_GIAOVU");
        }

        // Tab Page: DANGKY
        private void add_dangky_btn_Click(object sender, EventArgs e)
        {
            New_DangKy_Form newDangKyForm = new New_DangKy_Form(connectionString);
            newDangKyForm.ShowDialog();
        }

        private void delete_dangky_btn_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();

            // Collect the selected rows
            foreach (DataGridViewRow row in dataGridView_dkhp.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells["Delete"] as DataGridViewCheckBoxCell;
                if (chk != null && chk.Value != null && (bool)chk.Value)
                {
                    rowsToDelete.Add(row);
                }
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xóa những học phần đã đăng ký này không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                giaovu.deleteDangKySelectedRow(connectionString, query, rowsToDelete);
                // Remove the checkbox column if it exists
                if (dataGridView_dkhp.Columns.Contains("Delete"))
                {
                    dataGridView_dkhp.Columns.Remove("Delete");
                }

                // Reload the data
                LoadDangKyWithCheckboxColumn();
            }
            else
            {
                return;
            }



        }



        // Xử lý sự kiện chung
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
            modifiedRows.Clear();
        }

        private void handle_student_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlysv;
            label_tabPage.Text = tabPage_quanlysv.Text;
            modifiedRows.Clear();
        }

        private void handle_info_unit_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlythongtindonvi;
            label_tabPage.Text = tabPage_quanlythongtindonvi.Text;
            modifiedRows.Clear();
        }

        private void handle_course_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlyhp;
            label_tabPage.Text = tabPage_quanlyhp.Text;
            modifiedRows.Clear();
        }

        private void handle_open_course_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlykehoachmohp;
            label_tabPage.Text = tabPage_quanlykehoachmohp.Text;
            modifiedRows.Clear();
        }

        private void handle_register_course_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlydkhp;
            label_tabPage.Text = tabPage_quanlydkhp.Text;
            modifiedRows.Clear();
        }

        private void handle_assignment_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlyphancong;
            label_tabPage.Text = tabPage_quanlyphancong.Text;
            modifiedRows.Clear();
        }

        private void mail_btn_Click(object sender, EventArgs e)
        {
            string mailConnectionString = query.LoginMailString("GVu011", "pwd");
            Mail_Form mailForm = new Mail_Form(mailConnectionString, giaovu.hoten);
            mailForm.ShowDialog();
        }

        private void GiaoVu_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void refresh_dangky_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView_dkhp.Columns.Contains("Delete"))
            {
                dataGridView_dkhp.Columns.Remove("Delete");
            }

            // Reload the data
            LoadDangKyWithCheckboxColumn();
        }
    }
}
