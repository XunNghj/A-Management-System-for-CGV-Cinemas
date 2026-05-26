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
    public partial class FormDangxuat : Form
    {
        public FormDangxuat()
        {
            InitializeComponent();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
          // 1. Ẩn form NhanVien đi thay vì Close (để tránh bị tắt luôn cả phần mềm)
    Form frmNhanVien = Application.OpenForms["FormNhanVien"]; 
    if (frmNhanVien != null)
    {
        frmNhanVien.Hide(); 
    }

    // 2. Tìm form PhanQuyen cũ đã mở từ trước
    Form frmPhanQuyenCu = Application.OpenForms["PhanQuyen"];
    
    if (frmPhanQuyenCu != null)
    {
        // Nếu tìm thấy, lôi nó ra hiển thị lại
        frmPhanQuyenCu.Show();
    }
    else
    {
        // Nếu không thấy (chưa từng mở), mới được dùng lệnh new
        PhanQuyen frmPhanQuyenMoi = new PhanQuyen();
        frmPhanQuyenMoi.Show();
    }
    
    // 3. Đóng cái form thông báo Đăng xuất nhỏ xíu này lại
    this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Chỉ cần đóng form thông báo này lại
            this.Close();
        }
    }
}
