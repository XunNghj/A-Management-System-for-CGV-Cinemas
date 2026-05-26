//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace doanPTTK
//{
//    public partial class FormDatVe : Form
//    {
//        private readonly string _tenPhim;
//        private readonly string _khuVuc;
//        private string _suat, _rap;
//        private DateTime _ngay;
//        private readonly HashSet<string> _gheChon = new HashSet<string>();
//        private decimal _tienVe = 0;
//        private readonly HashSet<string> _gheChon = new HashSet<string>();
//        private readonly HashSet<string> _gheDaDat = new HashSet<string>(); // lưu ghế đã hết
//        private decimal _tienVe = 0;

//        public FormDatVe(string tenPhim) { InitializeComponent(); /* ... */ }
//        public FormDatVe(string tenPhim, string khuVuc)
//        {
//            InitializeComponent();
//            InitializeComponent();
//            _tenPhim = tenPhim;
//            _khuVuc = khuVuc;

//        }

//        private void FormDatVe_Load(object sender, EventArgs e)
//        {
//            // Giả sử có 2 label: lblPhim, lblKhuVuc (kéo từ Designer)
//            lblPhim.Text = "Phim:                  " + _tenPhim;
//            LoadBuocSuat();
//            // TODO: ở đây bạn load Rạp/Ngày/Suất, Ghế, Combo...

//        }
//        //private void LoadBuocSuat()
//        //{
//        //    // danh sách rạp mẫu (không phân khu vực)
//        //    cboRap.Items.Clear();
//        //    cboRap.Items.AddRange(new[] { "CGV Nguyễn Du", "CGV Vincom", "CGV Tân Bình" });
//        //    cboRap.SelectedIndex = 0;

//        //    dtNgay.Value = DateTime.Today;
//        //    TaoNutSuat();

//        //    dtNgay.ValueChanged += (s, e) => TaoNutSuat();
//        //    cboRap.SelectedIndexChanged += (s, e) => TaoNutSuat();
//        //}
//        //private void TaoNutSuat()
//        //{
//        //    flpSuat.Controls.Clear();

//        //    var gioChieu = new[] { "09:00", "11:30", "14:00", "16:30", "19:00", "21:30" };
//        //    foreach (var g in gioChieu)
//        //    {
//        //        var b = new Button
//        //        {
//        //            Text = g,
//        //            Width = 70,
//        //            Height = 36,
//        //            Margin = new Padding(6)
//        //        };

//        //        b.Click += (s, e) =>
//        //        {
//        //            _suat = g;
//        //            _rap = cboRap.Text;
//        //            _ngay = dtNgay.Value.Date;

//        //            // Chuyển thẳng qua tab Ghế luôn
//        //            tabControl1.SelectedTab = tabGhe;
//        //            RenderSoDoGhe(10, 12);
//        //        };

//        //        flpSuat.Controls.Add(b);
//        //    }
//        //}
//        private void LoadBuocSuat()
//        {
//            // rạp mẫu theo khu vực (bạn thay bằng dữ liệu thật)
//            cboRap.Items.Clear();
//            if (_khuVuc == "TP Hồ Chí Minh")
//                cboRap.Items.AddRange(new[] { "CGV Nguyễn Du", "CGV Sala", "CGV Tân Bình" });
//            else if (_khuVuc == "Hà Nội")
//                cboRap.Items.AddRange(new[] { "CGV Vincom Bà Triệu", "CGV Tràng Tiền" });
//            else
//                cboRap.Items.AddRange(new[] { "CGV Đà Nẵng", "CGV Vincom Ngô Quyền" });

//            cboRap.SelectedIndex = 0;
//            dtNgay.Value = DateTime.Today;
//            TaoNutSuat();
//        }

//        private void TaoNutSuat()
//        {
//            flpSuat.Controls.Clear();
//            var gioChieu = new[] { "09:00", "11:30", "14:00", "16:30", "19:00", "21:30" };
//            foreach (var g in gioChieu)
//            {
//                var b = new Button { Text = g, Width = 70, Height = 36, Margin = new Padding(6) };
//                b.Click += (s, e) => { _suat = g; _rap = cboRap.Text; _ngay = dtNgay.Value.Date; btnSangGhe.Enabled = true; };
//                flpSuat.Controls.Add(b);
//            }
//        }
//        private void dtNgay_ValueChanged(object sender, EventArgs e) => TaoNutSuat();
//        private void cboRap_SelectedIndexChanged(object sender, EventArgs e) => TaoNutSuat();

//        private void btnSangGhe_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrEmpty(_suat)) { MessageBox.Show("Chọn suất trước nhé!"); return; }
//            //tabGhe.SelectedTab = tabGhe;
//            RenderSoDoGhe(10, 12); // 10 hàng, 12 cột
//        }
//        private void RenderSoDoGhe(int rows, int cols)
//        {
//            tblGhe.Controls.Clear();
//            tblGhe.RowCount = rows; tblGhe.ColumnCount = cols;
//            tblGhe.ColumnStyles.Clear(); tblGhe.RowStyles.Clear();

//            for (int c = 0; c < cols; c++)
//                tblGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / cols));
//            for (int r = 0; r < rows; r++)
//                tblGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));

//            for (int r = 0; r < rows; r++)
//                for (int c = 0; c < cols; c++)
//                {
//                    string code = $"{(char)('A' + r)}{c + 1}";
//                    var btn = new Button
//                    {
//                        Text = code,
//                        Dock = DockStyle.Fill,
//                        Margin = new Padding(2),
//                        BackColor = Color.Gainsboro
//                    };
//                    //btn.Click += (s, e) => ToggleSeat(btn, code);
//                    tblGhe.Controls.Add(btn, c, r);
//                }
//        }
//        private void RenderSoDoGhe(int rows, int cols)
//        {
//            tblGhe.Controls.Clear();
//            tblGhe.RowCount = rows;
//            tblGhe.ColumnCount = cols;
//            tblGhe.ColumnStyles.Clear();
//            tblGhe.RowStyles.Clear();

//            for (int c = 0; c < cols; c++)
//                tblGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / cols));
//            for (int r = 0; r < rows; r++)
//                tblGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));

//            for (int r = 0; r < rows; r++)
//            {
//                for (int c = 0; c < cols; c++)
//                {
//                    string code = $"{(char)('A' + r)}{c + 1}";
//                    var btn = new Button
//                    {
//                        Text = code,
//                        Dock = DockStyle.Fill,
//                        Margin = new Padding(2),
//                        BackColor = _gheDaDat.Contains(code) ? Color.Red : Color.Gainsboro,
//                        Enabled = !_gheDaDat.Contains(code) // ghế hết thì disable
//                    };
//                    btn.Click += (s, e) => ToggleSeat(btn, code);
//                    tblGhe.Controls.Add(btn, c, r);
//                }
//            }
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace doanPTTK
{
    public partial class FormDatVe : Form
    {
        private readonly string _tenPhim;

        private string _suat, _rap;
        private DateTime _ngay;

        private readonly HashSet<string> _gheChon = new HashSet<string>();
        private readonly HashSet<string> _gheDaDat = new HashSet<string>(); // ghế đã hết (đỏ)
        private decimal _tienVe = 0;

        public FormDatVe(string tenPhim, string khuVuc)
        {
            InitializeComponent();
            _tenPhim = tenPhim;
        }

        private void FormDatVe_Load(object sender, EventArgs e)
        {
            lblPhim.Text = "Phim: " + _tenPhim;

            // ví dụ: vài ghế đã bán sẵn
            _gheDaDat.Clear();
            _gheDaDat.Add("B5");
            _gheDaDat.Add("C7");

            LoadBuocSuat();
        }

        // ===== BƯỚC 1: SUẤT =====
        private void LoadBuocSuat()
        {
            cboRap.Items.Clear();
            cboRap.Items.AddRange(new[] { "CGV Nguyễn Du", "CGV Vincom", "CGV Tân Bình" });
            cboRap.SelectedIndex = 0;

            dtNgay.Value = DateTime.Today;
            TaoNutSuat();

            dtNgay.ValueChanged += (s, e) => TaoNutSuat();
            cboRap.SelectedIndexChanged += (s, e) => TaoNutSuat();
        }

        private void TaoNutSuat()
        {
            flpSuat.Controls.Clear();
            btnSangGhe.Enabled = false;

            var gioChieu = new[] { "09:00", "11:30", "14:00", "16:30", "19:00", "21:30" };
            foreach (var g in gioChieu)
            {
                var b = new Button { Text = g, Width = 70, Height = 36, Margin = new Padding(6) };
                b.Click += (s, e) =>
                {
                    _suat = g;
                    _rap = cboRap.Text;
                    _ngay = dtNgay.Value.Date;
                    btnSangGhe.Enabled = true;
                };
                flpSuat.Controls.Add(b);
            }
        }

        private void btnSangGhe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_suat))
            {
                MessageBox.Show("Chọn suất trước nhé!");
                return;
            }
            RenderSoDoGhe(10, 12); // 10 hàng x 12 cột
        }

        // ===== BƯỚC 2: GHẾ =====
        private void RenderSoDoGhe(int rows, int cols)
        {
            tblGhe.Controls.Clear();
            tblGhe.RowCount = rows;
            tblGhe.ColumnCount = cols;
            tblGhe.ColumnStyles.Clear();
            tblGhe.RowStyles.Clear();

            for (int c = 0; c < cols; c++)
                tblGhe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / cols));
            for (int r = 0; r < rows; r++)
                tblGhe.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    string code = $"{(char)('A' + r)}{c + 1}";
                    var btn = new Button
                    {
                        Text = code,
                        Dock = DockStyle.Fill,
                        Margin = new Padding(2),
                        BackColor = _gheDaDat.Contains(code) ? Color.Red : Color.Gainsboro,
                        Enabled = !_gheDaDat.Contains(code)
                    };
                    btn.Click += (s, e) => ToggleSeat(btn, code);
                    tblGhe.Controls.Add(btn, c, r);
                }
            }

            // đồng bộ danh sách đang chọn
            lstGhe.Items.Clear();
            foreach (var g in _gheChon) lstGhe.Items.Add(g);
        }

        private void ToggleSeat(Button btn, string code)
        {
            if (_gheChon.Contains(code))
            {
                _gheChon.Remove(code);
                btn.BackColor = Color.Gainsboro;
                lstGhe.Items.Remove(code);
            }
            else
            {
                _gheChon.Add(code);
                btn.BackColor = Color.LightGreen;
                lstGhe.Items.Add(code);
            }

            _tienVe = _gheChon.Count * 90000m; // ví dụ 90k/ghế
        }
    }
}