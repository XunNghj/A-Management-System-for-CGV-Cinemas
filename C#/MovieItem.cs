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
    public partial class MovieItem : UserControl
    {
        public string TenPhim { get; set; }

        // 1) Khai báo sự kiện: Form cha có thể đăng ký để nhận "tên phim" được chọn
        public event Action<string> OnSelect;

        public MovieItem(string tenPhim, Image poster)
        {
            InitializeComponent();
            //TenPhim = tenPhim;
            //lblTenPhim.Text = tenPhim;
            //picPoster.Image = poster;
            //picPoster.SizeMode = PictureBoxSizeMode.StretchImage;

            // 2) Gắn mọi điểm click về cùng 1 handler
            this.Cursor = Cursors.Hand;
            this.Click += MovieItem_Click;
            picPoster.Click += MovieItem_Click;
            lblTenPhim.Click += MovieItem_Click;
            TenPhim = tenPhim;
            lblTenPhim.Text = tenPhim;
            lblTenPhim.AutoSize = false; // cho label chiếm hết chiều ngang
            lblTenPhim.TextAlign = ContentAlignment.MiddleCenter; // chữ canh giữa
            lblTenPhim.Dock = DockStyle.Bottom; // label nằm dưới cùng

            picPoster.Image = poster;
            picPoster.SizeMode = PictureBoxSizeMode.Zoom; // không bị méo / crop
            picPoster.Dock = DockStyle.Fill; // ảnh chiếm toàn bộ vùng trống
        }

        // 3) Khi click -> phát sự kiện, gửi "TenPhim" ra ngoài cho form cha
        private void MovieItem_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(TenPhim);
        }

        private void MovieItem_Load(object sender, EventArgs e)
        {

        }

    }
}
