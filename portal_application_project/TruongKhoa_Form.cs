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
        private List<DataGridViewRow> modifiedRows = new List<DataGridViewRow>();
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
            dataGridView_xemphanconggiangday.DataSource = truongkhoa.LoadFullTable(connectionString, query, "PHANCONG");

            dataGridView_sinhvien.DataSource = truongkhoa.LoadFullTable(connectionString, query, "SINHVIEN");
            dataGridView_thongtindv.DataSource = truongkhoa.LoadFullTable(connectionString, query, "DONVI");
            dataGridView_thongtinhp.DataSource = truongkhoa.LoadFullTable(connectionString, query, "HOCPHAN");
            dataGridView_khmohp.DataSource = truongkhoa.LoadFullTable(connectionString, query, "KHMO");
            dataGridView_dkhp.DataSource = truongkhoa.LoadFullTable(connectionString, query, "DANGKY");

            LoadQuanLyPhanCongWithCheckboxColumn();

            dataGridView_capnhatdiem.DataSource = truongkhoa.LoadFullTable(connectionString, query, "DANGKY");

            LoadQuanLyNhanSuWithCheckboxColumn();
        }

        private void LoadThongTinUser()
        {
            field_manv.Text = truongkhoa.manv;
            field_name.Text = truongkhoa.hoten;
            hello_name_label.Text = truongkhoa.hoten;
            field_gender.Text = truongkhoa.phai;
            field_birthday.Text = truongkhoa.ngsinh.ToString();
            field_salary.Text = truongkhoa.phucap.ToString();
            field_phoneNumber.Text = truongkhoa.dt;
            field_role.Text = truongkhoa.vaitro;
            field_madv.Text = truongkhoa.madv;
        }

        private void LoadQuanLyPhanCongWithCheckboxColumn()
        {
            DataTable dataTable = truongkhoa.LoadFullTable(connectionString, query, "PHANCONG");
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

        private void LoadQuanLyNhanSuWithCheckboxColumn()
        {
            DataTable dataTable = truongkhoa.LoadFullTable(connectionString, query, "NHANSU");
            dataGridView_quanlynhansu.DataSource = dataTable;

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "Delete",
                HeaderText = "Delete",
                TrueValue = true,
                FalseValue = false
            };
            dataGridView_quanlynhansu.Columns.Insert(0, checkBoxColumn);
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
            modifiedRows.Clear();
        }

        private void phancong_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_phancong;
            modifiedRows.Clear();
        }

        private void thongtinsv_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtinsv;
            modifiedRows.Clear();
        }

        private void capnhatsv_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_capnhatsv;
            modifiedRows.Clear();
        }

        private void thongtindv_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtindonvi;
            modifiedRows.Clear();
        }

        private void thongtinhp_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtinhp;
            modifiedRows.Clear();
        }

        private void khmohp_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_kehoachmohp;
            modifiedRows.Clear();
        }

        private void thongtin_dkhp_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_thongtindkhp;
            modifiedRows.Clear();
        }

        private void quanlyphancong_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlyphancong;
            modifiedRows.Clear();
        }

        private void quanlynhansu_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlynhansu;
            modifiedRows.Clear();
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
            truongkhoa.updateScore(connectionString, query, modifiedRows);


            // Clear the list of modified rows after updating
            modifiedRows.Clear();
        }

        private void refresh_capnhatdiem_btn_Click(object sender, EventArgs e)
        {
            dataGridView_capnhatdiem.DataSource = truongkhoa.LoadFullTable(connectionString, query, "DANGKY");
        }


        // Tab page: Quản lý phân công

        private void add_quanlyphancong_btn_Click(object sender, EventArgs e)
        {
            New_PhanCong_Form newPhanCongForm = new New_PhanCong_Form(connectionString, "TRUONGKHOA");
            newPhanCongForm.ShowDialog();
        }

        private void dataGridView_phancong_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
            truongkhoa.updatePhanCongInfo(connectionString, query, modifiedRows);


            // Clear the list of modified rows after updating
            modifiedRows.Clear();
        }

        private void refresh_quanlyphancong_btn_Click(object sender, EventArgs e)
        {
            dataGridView_quanlyphancong.DataSource = truongkhoa.LoadFullTable(connectionString, query, "PHANCONG");
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
                truongkhoa.deletePhanCongSelectedRow(connectionString, query, rowsToDelete);
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

        // Tab page: Quản lý nhân sự
        private void add_nhanvien_btn_Click(object sender, EventArgs e)
        {
            New_NhanVien_Form newNhanVienForm = new New_NhanVien_Form(connectionString);
            newNhanVienForm.ShowDialog();
        }

        private void refresh_nhansu_btn_Click(object sender, EventArgs e)
        {
            dataGridView_quanlynhansu.DataSource = truongkhoa.LoadFullTable(connectionString, query, "NHANSU");
        }

        private void dataGridView_quanlynhansu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the changed column is one of the score columns
            if (e.ColumnIndex == dataGridView_quanlynhansu.Columns["MANV"].Index ||
                e.ColumnIndex == dataGridView_quanlynhansu.Columns["HOTEN"].Index ||
                e.ColumnIndex == dataGridView_quanlynhansu.Columns["PHAI"].Index ||
                e.ColumnIndex == dataGridView_quanlynhansu.Columns["NGSINH"].Index ||
                e.ColumnIndex == dataGridView_quanlynhansu.Columns["PHUCAP"].Index ||
                e.ColumnIndex == dataGridView_quanlynhansu.Columns["DT"].Index ||
                e.ColumnIndex == dataGridView_quanlynhansu.Columns["VAITRO"].Index ||
                e.ColumnIndex == dataGridView_quanlynhansu.Columns["MADV"].Index)
            {
                // Add the modified row to the list if it's not already there
                DataGridViewRow row = dataGridView_quanlynhansu.Rows[e.RowIndex];
                if (!modifiedRows.Contains(row))
                {
                    modifiedRows.Add(row);
                }
            }
        }

        private void update_nhansu_btn_Click(object sender, EventArgs e)
        {
            truongkhoa.updateNhanVienInfo(connectionString, query, modifiedRows);


            // Clear the list of modified rows after updating
            modifiedRows.Clear();
        }

        private void delete_nhansu_btn_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();

            // Collect the selected rows
            foreach (DataGridViewRow row in dataGridView_quanlynhansu.Rows)
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
                truongkhoa.deleteNhanSuSelectedRow(connectionString, query, rowsToDelete);
                // Remove the checkbox column if it exists
                if (dataGridView_quanlynhansu.Columns.Contains("Delete"))
                {
                    dataGridView_quanlynhansu.Columns.Remove("Delete");
                }

                // Reload the data
                LoadQuanLyNhanSuWithCheckboxColumn();
            }
            else
            {
                return;
            }
        }
    }
}
