using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doanPTTK
{
    public partial class Dangki : Form
    {
        public Dangki()
        {
            InitializeComponent();
        }

        private void Dangki_Load(object sender, EventArgs e)
        {
            // Khởi tạo comboBox ngày/tháng/năm
            cbngay.Items.AddRange(Enumerable.Range(1, 31).Select(i => i.ToString()).ToArray());
            cbthang.Items.AddRange(Enumerable.Range(1, 12).Select(i => i.ToString()).ToArray());
            cbnam.Items.AddRange(Enumerable.Range(1950, 80).Select(i => i.ToString()).ToArray());
            // Khởi tạo khu vực
            cbkhuvuc.Items.AddRange(new string[] { "TP.HCM", "Hà Nội", "Đà Nẵng", "Cần Thơ" });
            // Khởi tạo rạp
            cbyeuthich.Items.AddRange(new string[] { "CGV Aeon Bình Tân", "CGV Giga Mall", "CGV Crescent Mall" });
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu
            if (string.IsNullOrWhiteSpace(txtten.Text) ||
                string.IsNullOrWhiteSpace(txtsdt.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text) ||
                string.IsNullOrWhiteSpace(txtmatkhau.Text) ||
                cbngay.SelectedIndex == -1 ||
                cbthang.SelectedIndex == -1 ||
                cbnam.SelectedIndex == -1 ||
                (!rbnam.Checked && !rbnu.Checked) ||
                cbkhuvuc.SelectedIndex == -1 ||
                cbyeuthich.SelectedIndex == -1 ||
                !cbDongY4.Checked)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin và chấp nhận điều khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Đăng ký thành công
            MessageBox.Show("Đăng ký thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
    }
}
