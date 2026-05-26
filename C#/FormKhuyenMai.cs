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
    public partial class FormKhuyenMai : Form
    {
        public string TieuDe { get; set; }
        public string Anh { get; set; }
        public string MoTa { get; set; }
        public FormKhuyenMai()
        {
            InitializeComponent();
        }

        private void FormKhuyenMai_Load(object sender, EventArgs e)
        {
            var items = new List<FormKhuyenMai>
    {
        new FormKhuyenMai { TieuDe = "Mua 2 tặng 1 bắp nước", Anh = "km1.png", MoTa = "Áp dụng từ 01-15/08" },
        new FormKhuyenMai { TieuDe = "Giảm 50% vé thứ 3",     Anh = "km2.png", MoTa = "Áp dụng toàn hệ thống" },
        new FormKhuyenMai { TieuDe = "Combo đôi 99k",         Anh = "km3.png", MoTa = "Chỉ cuối tuần" },
                new FormKhuyenMai { TieuDe = "Combo 3 vé kèm bắp ngô",         Anh = "km4.png", MoTa = "Áp dụng toàn hệ thống" }
    };
            // flpKM là FlowLayoutPanel trên form (Dock=Fill, AutoScroll=True)
            flpKM.Controls.Clear();

            foreach (var km in items)
            {
                var p = new Panel { Width = 280, Height = 120, Margin = new Padding(10) };

                var pic = new PictureBox
                {
                    Width = 100,
                    Height = 100,
                    Left = 10,
                    Top = 10,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle
                };

                var lbl = new Label
                {
                    Left = 120,
                    Top = 10,
                    Width = 150,
                    Height = 40,
                    Text = km.TieuDe,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };

                var des = new Label
                {
                    Left = 120,
                    Top = 55,
                    Width = 150,
                    Height = 50,
                    Text = km.MoTa
                };

                string path = Path.Combine(Application.StartupPath, "Images", km.Anh);
                if (File.Exists(path)) pic.Image = Image.FromFile(path);

                p.Controls.Add(pic); p.Controls.Add(lbl); p.Controls.Add(des);
                flpKM.Controls.Add(p);
            }
        }
    }
}
