using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace portal_application_project
{
    public partial class New_NhanVien_Form : Form
    {
        private string connectionString;
        private NhanVienCoBan newNhanVien;
        private TruongKhoa truongkhoa;
        private Query query;
        public New_NhanVien_Form(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            newNhanVien = new NhanVienCoBan();
            truongkhoa = new TruongKhoa();
            query = new Query();
            field_role.Items.Add("Nhân viên cơ bản");
            field_role.Items.Add("Giảng viên");
            field_role.Items.Add("Giáo vụ");
            field_role.Items.Add("Trưởng đơn vị");
            field_role.Items.Add("Trưởng khoa");
            
        }

        private void add_nhanvien_btn_Click(object sender, EventArgs e)
        {
            // Get values from the controls
            newNhanVien.manv = field_manv.Text;
            newNhanVien.hoten = field_name.Text;
            newNhanVien.phai = male_checkbox.Checked ? "Nam" : (female_checkbox.Checked ? "Nữ" : null);
            newNhanVien.ngsinh = dateTimePicker2.Value;
            newNhanVien.phucap = int.TryParse(field_phucap.Text, out int phucap) ? phucap : 0;
            newNhanVien.dt = field_phoneNumber.Text;
            newNhanVien.vaitro = field_role.Text;
            newNhanVien.madv = field_madv.Text;


            truongkhoa.insertNhanSu(connectionString, query, newNhanVien);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void female_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (female_checkbox.Checked)
            {
                male_checkbox.Checked = false;
            }
        }

        private void male_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (male_checkbox.Checked)
            {
                female_checkbox.Checked = false;
            }
        }

        private void field_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số thì không cho nhập
            }
        }


        private void field_phucap_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số thì không cho nhập
            }
        }
    }
}
