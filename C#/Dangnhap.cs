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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string emailSdt = txtEmailSdt.Text.Trim();
            string matkhau = txtMatKhau.Text;

            // Kiểm tra nhập liệu
            if (string.IsNullOrWhiteSpace(emailSdt) || string.IsNullOrWhiteSpace(matkhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Kiểm tra tài khoản (giả lập - có thể thay bằng đọc file/database)
            if ((emailSdt == "xuannghi9979@gmail.com" || emailSdt == "0123456789") && matkhau == "123456")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Mở form chính / ẩn form đăng nhập
                this.Hide();



                //FormMain formMain = new FormMain();
                //formMain.Show();        ĐỔI FORM NEEEE



            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KhoiPhucMK f = new KhoiPhucMK();
            f.ShowDialog();
        }
    }
}