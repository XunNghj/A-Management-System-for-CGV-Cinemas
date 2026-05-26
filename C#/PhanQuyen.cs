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
    public partial class PhanQuyen : Form
    {
        public PhanQuyen()
        {
            InitializeComponent();
        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            cboVaiTro.Items.Add("Quản trị viên");
            cboVaiTro.Items.Add("Khách hàng");
            cboVaiTro.Items.Add("Nhân viên");
            cboVaiTro.SelectedIndex = 0;
        }

        private void btnVaoHeThong_Click(object sender, EventArgs e)
        {
            string role = cboVaiTro.SelectedItem.ToString();

            if (role == "Khách hàng")
            {
                FormKhachHang fKH = new FormKhachHang();
                this.Hide();          // Ẩn form phân quyền
                fKH.ShowDialog();     // Show dưới dạng hộp thoại modal
                this.Close();         // Đóng Form phân quyền sau khi form khách hàng đóng
            }
            else if (role == "Nhân viên")
            {
                FormNhanVien fNV = new FormNhanVien();
                this.Hide();
                fNV.ShowDialog();
                this.Close();
            }
            else if (role == "Quản trị viên")
            {
                FormQuanLy fQL = new FormQuanLy();
                this.Hide();
                fQL.ShowDialog();
                this.Close();
            }
        }
    }
}
