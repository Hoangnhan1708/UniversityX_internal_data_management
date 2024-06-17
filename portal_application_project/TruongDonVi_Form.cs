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
        // Declare a list to keep track of modified rows
        private List<DataGridViewRow> modifiedRows = new List<DataGridViewRow>();

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

            //dataGridView_quanlyphancong.DataSource = truongdonvi.LoadFullTable(connectionString, query, "PHANCONG");
            LoadQuanLyPhanCongWithCheckboxColumn();

            // Cần viết lại hàm cho load những phân công giảng dạy liên quan đến bản thân
            dataGridView_xemphanconggiangday.DataSource = truongdonvi.LoadFullTable(connectionString, query, "PHANCONG");

            // Cần viết lại hàm cho load lớp mà giảng viên dạy
            dataGridView_capnhatdiem.DataSource = truongdonvi.LoadFullTable(connectionString, query, "DANGKY");

            // Cần viết lại hàm cho load những phân công giảng dạy liên quan đến bản thân
            dataGridView_xemphanconggv.DataSource = truongdonvi.LoadFullTable(connectionString, query, "PHANCONG");
        }

        private void LoadThongTinUser()
        {
            field_manv.Text = truongdonvi.manv;
            field_name.Text = truongdonvi.hoten;
            hello_name_label.Text = truongdonvi.hoten;
            field_gender.Text = truongdonvi.phai;
            field_birthday.Text = truongdonvi.ngsinh.ToString();
            field_salary.Text = truongdonvi.phucap.ToString();
            field_phoneNumber.Text = truongdonvi.dt;
            field_role.Text = truongdonvi.vaitro;
            field_madv.Text = truongdonvi.madv;
        }

        private void LoadQuanLyPhanCongWithCheckboxColumn()
        {
            DataTable dataTable = truongdonvi.LoadFullTable(connectionString, query, "PHANCONG");
            dataGridView_quanlyphancong.DataSource = dataTable;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                TrueValue = true,
                FalseValue = false
            };
            dataGridView_quanlyphancong.Columns.Insert(0, checkBoxColumn);
        }



        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void user_info_btn_Click(object sender, EventArgs e)
        {
            tabControl_truongdonvi.SelectedTab = tabPage_userInfo;
            modifiedRows.Clear();
        }

        private void phancong_btn_Click(object sender, EventArgs e)
        {
            tabControl_truongdonvi.SelectedTab = tabPage_phancong;
        }

        private void thongtinsv_btn_Click(object sender, EventArgs e)
        {
            tabControl_truongdonvi.SelectedTab = tabPage_thongtinsv;
            modifiedRows.Clear();
        }

        private void capnhatsv_btn_Click(object sender, EventArgs e)
        {
            tabControl_truongdonvi.SelectedTab = tabPage_capnhatsv;
            modifiedRows.Clear();
        }

        private void thongtindv_btn_Click(object sender, EventArgs e)
        {
            tabControl_truongdonvi.SelectedTab = tabPage_thongtindonvi;
            modifiedRows.Clear();
        }

        private void thongtinhp_btn_Click(object sender, EventArgs e)
        {
            tabControl_truongdonvi.SelectedTab = tabPage_thongtinhp;
            modifiedRows.Clear();
        }

        private void khmohp_btn_Click(object sender, EventArgs e)
        {
            tabControl_truongdonvi.SelectedTab = tabPage_kehoachmohp;
            modifiedRows.Clear();
        }

        private void thongtin_dkhp_btn_Click(object sender, EventArgs e)
        {
            tabControl_truongdonvi.SelectedTab = tabPage_thongtindkhp;
            modifiedRows.Clear();
        }

        private void quanlyphancong_btn_Click(object sender, EventArgs e)
        {
            tabControl_truongdonvi.SelectedTab = tabPage_quanlyphancong;
            modifiedRows.Clear();
        }

        private void xemphanconggv_btn_Click(object sender, EventArgs e)
        {
            tabControl_truongdonvi.SelectedTab = tabPage_xemphanconggv;
            modifiedRows.Clear();
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
            truongdonvi.updateScore(connectionString, query, modifiedRows);


            // Clear the list of modified rows after updating
            modifiedRows.Clear();
        }

        private void refresh_capnhatdiem_btn_Click(object sender, EventArgs e)
        {
            dataGridView_capnhatdiem.DataSource = truongdonvi.LoadFullTable(connectionString, query, "DANGKY");
        }

        private void dataGridView_quanlyphancong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed column is one of the score columns
            if (e.ColumnIndex == dataGridView_quanlyphancong.Columns["MAGV"].Index ||
                e.ColumnIndex == dataGridView_quanlyphancong.Columns["MAHP"].Index ||
                e.ColumnIndex == dataGridView_quanlyphancong.Columns["HK"].Index ||
                e.ColumnIndex == dataGridView_quanlyphancong.Columns["NAM"].Index ||
                e.ColumnIndex == dataGridView_quanlyphancong.Columns["MACT"].Index)
            {
                // Add the modified row to the list if it's not already there
                DataGridViewRow row = dataGridView_quanlyphancong.Rows[e.RowIndex];
                if (!modifiedRows.Contains(row))
                {
                    modifiedRows.Add(row);
                }
            }
        }

        private void update_quanlyphancong_btn_Click(object sender, EventArgs e)
        {
            truongdonvi.updatePhanCongInfo(connectionString, query, modifiedRows);


            // Clear the list of modified rows after updating
            modifiedRows.Clear();
        }

        private void refresh_quanlyphancong_btn_Click(object sender, EventArgs e)
        {
            // Cần viết lại hàm cho load những phân công giảng dạy liên quan đến bản thân
            dataGridView_quanlyphancong.DataSource = truongdonvi.LoadFullTable(connectionString, query, "PHANCONG");
        }

        private void add_quanlyphancong_btn_Click(object sender, EventArgs e)
        {
            New_PhanCong_Form newPhanCongForm = new New_PhanCong_Form(connectionString, "TRUONGDONVI");
            newPhanCongForm.ShowDialog();
        }

        private void delete_quanlyphancong_btn_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();

            // Collect the selected rows
            foreach (DataGridViewRow row in dataGridView_quanlyphancong.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells["Delete"] as DataGridViewCheckBoxCell;
                if (chk != null && chk.Value != null && (bool)chk.Value)
                {
                    rowsToDelete.Add(row);
                }
            }

            DialogResult result = MessageBox.Show("Bạn có muốn xóa những học phần đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                truongdonvi.deletePhanCongSelectedRow(connectionString, query, rowsToDelete);
                // Remove the checkbox column if it exists
                if (dataGridView_quanlyphancong.Columns.Contains("Delete"))
                {
                    dataGridView_quanlyphancong.Columns.Remove("Delete");
                }

                // Reload the data
                LoadQuanLyPhanCongWithCheckboxColumn();
            }
            else
            {
                return;
            }
        }


    }
}
