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
    public partial class FormNhanVien : Form
    {

        public FormNhanVien()
        {
            InitializeComponent();

        }

        private void btnHauMai_Click(object sender, EventArgs e)
        {
            FrmHauMai f = new FrmHauMai(); // khởi tạo form
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDangxuat f = new FormDangxuat(); // khởi tạo form
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            FormDichVuNhanVien f = new FormDichVuNhanVien(); // khởi tạo form
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog(this);
        }
    }
}