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
        private Query query;

        private SinhVien sinhvien = new SinhVien();
        public SinhVien_Form(string _connectionString, string _masv)
        {
            InitializeComponent();
            this.connectionString = _connectionString;
            query = new Query();
            sinhvien.masv = _masv;
            sinhvien.LoadThongTinSinhVien(connectionString, query);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void SinhVien_Form_Load(object sender, EventArgs e)
        {
            LoadThongTinUser();

            dataGridView_hpdadangky.DataSource = sinhvien.LoadFullTable(connectionString, query, "HOCPHAN");
            //dataGridView_dkhp.DataSource = sinhvien.LoadFullTable(connectionString, query, "DANGKY");
            dataGridView_khmohp.DataSource = sinhvien.LoadFullTable(connectionString, query, "KHMO");

            LoadDKHPWithCheckboxColumn();
        }

        private void LoadThongTinUser()
        {
            field_masv.Text = sinhvien.masv;
            field_name.Text = sinhvien.hoten;
            hello_name_label.Text = sinhvien.hoten;
            field_gender.Text = sinhvien.phai;
            field_birthday.Text = sinhvien.ngsinh.ToString();
            field_phoneNumber.Text = sinhvien.dt;
            field_address.Text = sinhvien.dchi;
            field_chuongtrinhdaotao.Text = sinhvien.mact;
            field_manganh.Text = sinhvien.manganh;
            field_stctl.Text = sinhvien.sotctl.ToString();
            field_dtbtl.Text = sinhvien.diemtbtl.ToString();
        }

        private void LoadDKHPWithCheckboxColumn()
        {
            DataTable dataTable = sinhvien.LoadFullTable(connectionString, query, "DANGKY");
            dataGridView_dkhp.DataSource = dataTable;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "Select",
                HeaderText = "Select",
                TrueValue = true,
                FalseValue = false
            };
            dataGridView_dkhp.Columns.Insert(0, checkBoxColumn);
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

        private void change_address_btn_Click(object sender, EventArgs e)
        {
            if (field_address.Text == sinhvien.dchi)
            {
                MessageBox.Show("Bạn chưa thay đổi địa chỉ, hãy kiểm tra lại!");
            }
            else
            {
                bool isChanged = sinhvien.updateAddress(connectionString, query, field_address.Text);
                if (isChanged)
                {
                    sinhvien.dchi = field_address.Text;
                }

            }
        }

        private void change_phoneNumber_btn_Click(object sender, EventArgs e)
        {
            if (field_phoneNumber.Text == sinhvien.dt)
            {
                MessageBox.Show("Bạn chưa thay đổi số điện thoại, hãy kiểm tra lại!");
            }
            else
            {
                bool isChanged = sinhvien.updatePhoneNumber(connectionString, query, field_phoneNumber.Text);
                if (isChanged)
                {
                    sinhvien.dt = field_phoneNumber.Text;
                }

            }
        }

        // Chưa xonggg!
        private void add_dkhp_btn_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToHandle = new List<DataGridViewRow>();

            // Collect the selected rows
            foreach (DataGridViewRow row in dataGridView_dkhp.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (chk != null && chk.Value != null && (bool)chk.Value)
                {
                    rowsToHandle.Add(row);
                }
            }

            DialogResult result = MessageBox.Show("Bạn có muốn đăng ký những học phần đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sinhvien.insertDangKySelectedRow(connectionString, query, rowsToHandle);
                // Remove the checkbox column if it exists
                if (dataGridView_dkhp.Columns.Contains("Select"))
                {
                    dataGridView_dkhp.Columns.Remove("Select");
                }

                // Reload the data
                LoadDKHPWithCheckboxColumn();
            }
            else
            {
                return;
            }
            //List<DataGridViewRow> rowsToHandle = new List<DataGridViewRow>();

            //// Collect the selected rows
            //foreach (DataGridViewRow row in dataGridView_dkhp.Rows)
            //{
            //    DataGridViewCheckBoxCell chk = row.Cells["Select"] as DataGridViewCheckBoxCell;
            //    if (chk != null && chk.Value != null && (bool)chk.Value)
            //    {
            //        rowsToHandle.Add(row);
            //    }
            //}

            //DialogResult result = MessageBox.Show("Bạn có muốn xóa những học phần đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //    sinhvien.insertDangKySelectedRow(connectionString, query, rowsToHandle);
            //    // Remove the checkbox column if it exists
            //    if (dataGridView_dkhp.Columns.Contains("Select"))
            //    {
            //        dataGridView_dkhp.Columns.Remove("Select");
            //    }

            //    // Reload the data
            //    LoadDKHPWithCheckboxColumn();
            //}
            //else
            //{
            //    return;
            //}
        }

        private void refresh_nhansu_btn_Click(object sender, EventArgs e)
        {

        }

        private void delete_dkhp_btn_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToHandle = new List<DataGridViewRow>();

            // Collect the selected rows
            foreach (DataGridViewRow row in dataGridView_dkhp.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells["Select"] as DataGridViewCheckBoxCell;
                if (chk != null && chk.Value != null && (bool)chk.Value)
                {
                    rowsToHandle.Add(row);
                }
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xóa những học phần đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                sinhvien.deleteDangKySelectedRow(connectionString, query, rowsToHandle);
                // Remove the checkbox column if it exists
                if (dataGridView_dkhp.Columns.Contains("Select"))
                {
                    dataGridView_dkhp.Columns.Remove("Select");
                }

                // Reload the data
                LoadDKHPWithCheckboxColumn();
            }
            else
            {
                return;
            }
        }

        

        private void mail_btn_Click(object sender, EventArgs e)
        {
            Mail_Form mailForm = new Mail_Form(connectionString,sinhvien.hoten);
            mailForm.ShowDialog();
        }
    }
}
