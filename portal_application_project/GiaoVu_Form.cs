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
        private void add_donvi_btn_Click(object sender, EventArgs e)
        {
            New_DonVi_Form newDonViForm = new New_DonVi_Form(connectionString);
            newDonViForm.ShowDialog();
        }

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
            modifiedRows.Clear();
        }

        private void handle_student_btn_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlysv;
            modifiedRows.Clear();
        }

        private void handle_info_unit_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlythongtindonvi;
            modifiedRows.Clear();
        }

        private void handle_course_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlyhp;
            modifiedRows.Clear();
        }

        private void handle_open_course_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlykehoachmohp;
            modifiedRows.Clear();
        }

        private void handle_register_course_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlydkhp;
            modifiedRows.Clear();
        }

        private void handle_assignment_Click(object sender, EventArgs e)
        {
            tabControl_nvcb.SelectedTab = tabPage_quanlyphancong;
            modifiedRows.Clear();
        }

        
    }
}
