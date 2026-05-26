using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace doanPTTK
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            cboDiaDiem.Items.AddRange(new string[] { "TP Hồ Chí Minh", "Hà Nội", "Đà Nẵng" });
            cboDiaDiem.SelectedIndex = 0;
            LoadPhim();
            txtTimKiem.ForeColor = Color.Gray;
            txtTimKiem.Text = "Tìm kiếm phim...";
        }
        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm phim...")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }
        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm kiếm phim...";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }
        //    private void LoadPhim()
        //    {
        //        List<Tuple<string, string>> danhSachPhim = new List<Tuple<string, string>>()
        //{
        //    new Tuple<string, string>("Thanh Gươm Diệt Quỷ", "img1.jpg"),
        //    new Tuple<string, string>("Avengers: Endgame", "img2.jpg"),
        //    new Tuple<string, string>("Minions 2", "img3.jpg"),
        //    new Tuple<string, string>("Fast & Furious 9", "img4.jpg"),
        //    new Tuple<string, string>("Mắt Biếc", "img5.jpg")
        //};

        //        foreach (var phim in danhSachPhim)
        //        {
        //            string tenPhim = phim.Item1;
        //            string duongDanAnh = Path.Combine(Application.StartupPath, "Images", phim.Item2);
        //            if (File.Exists(duongDanAnh))
        //            {
        //                Image img = Image.FromFile(duongDanAnh);
        //                MovieItem m = new MovieItem(tenPhim, img);
        //                m.Margin = new Padding(10);
        //                flowDanhSachPhim.Controls.Add(m);
        //            }
        //        }
        //    }
        //    private void LoadPhim()
        //    {
        //        flowDanhSachPhim.Controls.Clear(); // Xoá trước khi load lại

        //        List<Tuple<string, string>> danhSachPhim = new List<Tuple<string, string>>()
        //{
        //    new Tuple<string, string>("Thanh Gươm Diệt Quỷ", "img1.jpg"),
        //    new Tuple<string, string>("Avengers: Endgame", "img2.jpg"),
        //    new Tuple<string, string>("Minions 2", "img3.jpg"),
        //    new Tuple<string, string>("Fast & Furious 9", "img4.jpg"),
        //    new Tuple<string, string>("Mắt Biếc", "img5.jpg")
        //};

        //        //foreach (var phim in danhSachPhim)
        //        //{
        //        //    string tenPhim = phim.Item1;
        //        //    string duongDanAnh = Path.Combine(Application.StartupPath, "Images", phim.Item2);
        //        //    if (File.Exists(duongDanAnh))
        //        //    {
        //        //        Image img = Image.FromFile(duongDanAnh);
        //        //        MovieItem m = new MovieItem(tenPhim, img);
        //        //        m.Margin = new Padding(10);
        //        //        flowDanhSachPhim.Controls.Add(m);
        //        //    }
        //        //}
        //        foreach (var phim in danhSachPhim)
        //        {
        //            string tenPhim = phim.Item1;
        //            string duongDanAnh = Path.Combine(Application.StartupPath, "Images", phim.Item2);
        //            if (File.Exists(duongDanAnh))
        //            {
        //                Image img = Image.FromFile(duongDanAnh);
        //                MovieItem m = new MovieItem(tenPhim, img);
        //                m.Margin = new Padding(5); // giảm khoảng cách giữa các phim
        //                m.Size = new Size(200, 300); // thu nhỏ kích thước để vừa panel hơn
        //                flowDanhSachPhim.Controls.Add(m);
        //            }
        //        }
        //    }
        private void LoadPhim()
        {
            flowDanhSachPhim.Controls.Clear();

//DANH SÁCH PHIM HIỆN TRÊN GIAO DIỆN CHÍNH
            var data = new List<Tuple<string, string>> {
    Tuple.Create("Thanh Gươm Diệt Quỷ","img1.jpg"),
    Tuple.Create("Avengers: Endgame","img2.jpg"),
    Tuple.Create("Minions 2", "img3.jpg"),
    Tuple.Create("Fast & Furious 9", "img4.jpg"),
    Tuple.Create("Mắt Biếc", "img5.jpg"),
    Tuple.Create("Thám Tử Lừng Danh Conan", "img6.jpg"),
    Tuple.Create("Spider-Man: No Way Home", "img7.jpg"),
    Tuple.Create("Black Panther: Wakanda Forever", "img8.jpg"),
    Tuple.Create("Avatar: The Way of Water", "img9.jpg"),
    Tuple.Create("Inside Out 2", "img10.jpg"),
    Tuple.Create("Deadpool & Wolverine", "img11.jpg"),
    Tuple.Create("Despicable Me 4", "img12.jpg"),
    Tuple.Create("The Garfield Movie", "img13.jpg"),
    Tuple.Create("Godzilla x Kong: The New Empire", "img14.jpg"),
        // ...
    };
            //    new Tuple<string, string>("Minions 2", "img3.jpg"),
            //    new Tuple<string, string>("Fast & Furious 9", "img4.jpg"),
            //    new Tuple<string, string>("Mắt Biếc", "img5.jpg")

            foreach (var item in data)
            {
                string tenPhim = item.Item1;
                string path = Path.Combine(Application.StartupPath, "Images", item.Item2);
                if (!File.Exists(path)) continue;

                var poster = Image.FromFile(path);
                var m = new MovieItem(tenPhim, poster);

                // 🔴 QUAN TRỌNG: đăng ký nghe sự kiện OnSelect từ MovieItem
                m.OnSelect += (tenPhimDaChon) =>
                {
                    string khuVuc = cboDiaDiem.SelectedItem?.ToString() ?? "";
                    using (var f = new FormDatVe(tenPhimDaChon, khuVuc))
                    {
                        f.ShowDialog(); // mở form đặt vé
                    }
                };

                m.Margin = new Padding(5);
                m.Size = new Size(150, 230);
                flowDanhSachPhim.Controls.Add(m);
            }
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Dangki f = new Dangki();
            f.ShowDialog();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Dangnhap f = new Dangnhap();
            f.ShowDialog();
        }

        private void flowDanhSachPhim_Paint(object sender, PaintEventArgs e)
        {
            flowDanhSachPhim.WrapContents = true;  // Cho phép xuống dòng
            flowDanhSachPhim.FlowDirection = FlowDirection.LeftToRight; // Xếp ngang từ trái qua
            flowDanhSachPhim.AutoScroll = true; // Có thanh cuộn khi quá nhiều phim
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            using (var f = new FormPhanHoi())
                f.ShowDialog(this);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            using (var f = new FormKhuyenMai())
                f.ShowDialog(this);  // mở modal
        }
    }
       
}
