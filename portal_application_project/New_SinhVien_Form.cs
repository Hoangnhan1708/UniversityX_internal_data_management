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
    public partial class New_SinhVien_Form : Form
    {
        private string connectionString;
        private SinhVien newSinhVien;
        private GiaoVu giaovu;
        private Query query;
        public New_SinhVien_Form(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            newSinhVien = new SinhVien();
            giaovu = new GiaoVu();
            query = new Query();
        }

        private void male_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (male_checkbox.Checked)
            {
                female_checkbox.Checked = false;
            }
        }

        private void female_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (female_checkbox.Checked)
            {
                male_checkbox.Checked = false;
            }
        }

        private void add_sinhvien_btn_Click(object sender, EventArgs e)
        {
            // Get values from the controls
            newSinhVien.masv = field_manv.Text;
            newSinhVien.hoten = field_name.Text;
            newSinhVien.phai = male_checkbox.Checked ? "Nam" : (female_checkbox.Checked ? "Nữ" : null);
            newSinhVien.ngsinh = dateTimePicker2.Value;
            newSinhVien.dchi = field_address.Text;
            newSinhVien.dt = field_phoneNumber.Text;
            newSinhVien.mact = field_chuongtrinhdaotao.Text;
            newSinhVien.manganh = field_manganh.Text;
            newSinhVien.sotctl = int.TryParse(field_stctl.Text, out int stctl) ? stctl : 0;
            newSinhVien.diemtbtl = float.TryParse(field_dtbtl.Text, out float dtbtlValue) ? dtbtlValue : 0;

            giaovu.insertSinhVien(connectionString, query, newSinhVien);
            
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void field_phoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số thì không cho nhập
            }
        }

        private void field_dtbtl_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số, dấu chấm hoặc ký tự điều khiển (như Backspace) không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Nếu không phải số hoặc dấu chấm thì không cho nhập
            }

            // Nếu ký tự là dấu chấm, kiểm tra xem đã có dấu chấm trong TextBox chưa
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true; // Nếu đã có dấu chấm thì không cho nhập thêm
            }
        }

        private void field_stctl_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số thì không cho nhập
            }
        }
    }
}
