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

    public partial class New_DangKy_Form : Form
    {
        private string connectionString;
        private GiaoVu giaovu;
        private Query query;
        public New_DangKy_Form(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;

            giaovu = new GiaoVu();
            query = new Query();
        }

        // Còn vướng khóa ngoại DANGKY-PHANCONG
        private void add_dangky_btn_Click(object sender, EventArgs e)
        {
            // Get values from the controls

            string masv = field_mahp.Text;
            string magv = field_magv.Text;
            string mahp = field_mahp.Text;
            int hk = Convert.ToInt32(field_hk.Text);
            int nam = Convert.ToInt32(field_nam.Text);
            string mact = field_mact.Text;
            float diemth = Convert.ToSingle(field_diemth.Text);
            float diemqt = Convert.ToSingle(field_diemqt.Text);
            float diemck = Convert.ToSingle(field_diemck.Text);
            float diemtk = Convert.ToSingle(field_diemtk.Text);


            giaovu.insertDangKy(connectionString, query, masv, magv, mahp, hk, nam, mact, diemth, diemqt, diemck, diemtk);
            this.Close();
        }

        private void field_hk_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số thì không cho nhập
            }
        }

        private void field_nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Nếu không phải số thì không cho nhập
            }
        }

        private void field_diemth_KeyPress(object sender, KeyPressEventArgs e)
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

        private void field_diemqt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void field_diemck_KeyPress(object sender, KeyPressEventArgs e)
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

        private void field_diemtk_KeyPress(object sender, KeyPressEventArgs e)
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

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
