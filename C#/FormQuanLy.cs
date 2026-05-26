using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace doanPTTK
{
    public partial class FormQuanLy : Form
    {
        private string _connectionString = 
            @"Data Source=XUAN-NGHI\SQLEXPRESS;Initial Catalog=QuanLyRapChieuPhim;Integrated Security=True";
        private BindingSource bs = new BindingSource(); // << CÁI NÀY BẮT BUỘC
        private SqlConnection con;     // 1 kết nối dùng lại
/*        private SqlCommand cmd;*/        // thực thi câu lệnh
        private SqlDataAdapter da;     // fill dữ liệu
        private DataTable dt;          // chứa dữ liệu
        private BindingSource bsNV = new BindingSource();
        private DataTable dtNV;
        private BindingSource bsPhim = new BindingSource();
        private DataTable dtPhim;
        private BindingSource bsSuat = new BindingSource();
        private DataTable dtSuat;
        private BindingSource bsPhongChieu = new BindingSource();
        private DataTable dtPhongChieu;
        private BindingSource bsGhe = new BindingSource();
        private DataTable dtGhe;
        private BindingSource bsKM = new BindingSource();
        private DataTable dtKM;
        private BindingSource bsCTCombo = new BindingSource();
        private DataTable dtCTCombo;
        private BindingSource bsVe = new BindingSource();
        private DataTable dtVe;
        private BindingSource bsNCC = new BindingSource();
        private DataTable dtNCC;
        private BindingSource bsBC = new BindingSource();
        private DataTable dtBC;

        public FormQuanLy()
        {
            InitializeComponent();
            LoadPhim();
            LoadNhanVien();
            LoadSuatChieu();
            LoadPhongChieu();
            LoadGhe();
            LoadKhuyenMai();
            LoadChiTietCombo();
            LoadVe();
            LoadNhaCungCap();
            LoadBaoCao();
        }
        private void LoadBaoCao()
        {
            using (var con = new SqlConnection(_connectionString))
            using (var da = new SqlDataAdapter(
                "SELECT MaBC, TieuDeBC, NoiDungBC, LoaiBC, NgayLapBC, NguoiLapBC, MaNV FROM BaoCao ORDER BY MaBC", con))
            {
                dtBC = new DataTable();
                da.Fill(dtBC);

                bsBC.DataSource = dtBC;
                dgvBaoCao.AutoGenerateColumns = true;
                dgvBaoCao.DataSource = bsBC;

                // Cấu hình DataGridView
                dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvBaoCao.ReadOnly = true;
                dgvBaoCao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvBaoCao.MultiSelect = false;
                dgvBaoCao.AllowUserToAddRows = false;
                dgvBaoCao.AllowUserToDeleteRows = false;
                dgvBaoCao.RowHeadersVisible = false;

                // Clear binding cũ
                txtMaBC.DataBindings.Clear();
                txtTieuDeBC.DataBindings.Clear();
                txtNoiDungBC.DataBindings.Clear();
                txtLoaiBC.DataBindings.Clear();
                dtpNgayLapBC.DataBindings.Clear();
                txtNguoiLapBC.DataBindings.Clear();
                txtMaaNV.DataBindings.Clear();

                // Binding mới
                txtMaBC.DataBindings.Add("Text", bsBC, "MaBC", true, DataSourceUpdateMode.Never);
                txtTieuDeBC.DataBindings.Add("Text", bsBC, "TieuDeBC", true, DataSourceUpdateMode.Never);
                txtNoiDungBC.DataBindings.Add("Text", bsBC, "NoiDungBC", true, DataSourceUpdateMode.Never);
                txtLoaiBC.DataBindings.Add("Text", bsBC, "LoaiBC", true, DataSourceUpdateMode.Never);
                dtpNgayLapBC.DataBindings.Add("Value", bsBC, "NgayLapBC", true, DataSourceUpdateMode.Never);
                txtNguoiLapBC.DataBindings.Add("Text", bsBC, "NguoiLapBC", true, DataSourceUpdateMode.Never);
                txtMaaNV.DataBindings.Add("Text", bsBC, "MaNV", true, DataSourceUpdateMode.Never);
            }
        }
        private void btnLoadBaoCaoC_Click(object sender, EventArgs e) => LoadBaoCao();
        private void LoadNhanVien()
        {
            using (var con = new SqlConnection(_connectionString))
            using (var da = new SqlDataAdapter(
                "SELECT MaNV, TenNV, ViTri FROM NhanVien ORDER BY MaNV", con))
            {
                dtNV = new DataTable();
                da.Fill(dtNV);
                bsNV.DataSource = dtNV;
                dgvNV.DataSource = bsNV;
                // Chỉnh lưới
                dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvNV.ReadOnly = true;
                dgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvNV.MultiSelect = false;
                // Clear rồi bind detail
                txtMaNV.DataBindings.Clear();
                txtTenNV.DataBindings.Clear();
                txtViTri.DataBindings.Clear();
                txtMaNV.DataBindings.Add("Text", bsNV, "MaNV", true, DataSourceUpdateMode.Never);
                txtTenNV.DataBindings.Add("Text", bsNV, "TenNV", true, DataSourceUpdateMode.Never);
                txtViTri.DataBindings.Add("Text", bsNV, "ViTri", true, DataSourceUpdateMode.Never);
            }
        }
        //private void FormQuanLy_Load(object sender, EventArgs e) => LoadNhanVien();
        private void btnLoadNV_Click(object sender, EventArgs e) => LoadNhanVien();
        private void LoadPhim()
        {
            try
            {
                using (var con = new SqlConnection(_connectionString))
                using (var da = new SqlDataAdapter(
                    "SELECT MaPhim, TenPhim, TieuDe, TheLoai, MoTa, ThoiLuong FROM Phim ORDER BY MaPhim", con))
                {
                    dtPhim = new DataTable();
                    da.Fill(dtPhim);

                    bsPhim.DataSource = dtPhim;

                    // QUAN TRỌNG: nếu dgvPhim có cột sẵn trong Designer thì phải bật dòng này
                    dgvPhim.AutoGenerateColumns = true;

                    dgvPhim.DataSource = bsPhim;

                    // Cấu hình cơ bản
                    dgvPhim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvPhim.ReadOnly = true;
                    dgvPhim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvPhim.MultiSelect = false;
                    dgvPhim.AllowUserToAddRows = false;
                    dgvPhim.AllowUserToDeleteRows = false;
                    dgvPhim.RowHeadersVisible = false;

                    // Xóa binding cũ
                    txtMaPhim.DataBindings.Clear();
                    txtphim.DataBindings.Clear();      // hoặc txtTenPhim nếu control của bạn tên vậy
                    txtTieuDe.DataBindings.Clear();
                    txtTheLoai.DataBindings.Clear();
                    txtMoTa.DataBindings.Clear();
                    txtThoiLuong.DataBindings.Clear();

                    // Binding mới
                    txtMaPhim.DataBindings.Add("Text", bsPhim, "MaPhim", true, DataSourceUpdateMode.Never);
                    txtphim.DataBindings.Add("Text", bsPhim, "TenPhim", true, DataSourceUpdateMode.Never);
                    txtTieuDe.DataBindings.Add("Text", bsPhim, "TieuDe", true, DataSourceUpdateMode.Never);
                    txtTheLoai.DataBindings.Add("Text", bsPhim, "TheLoai", true, DataSourceUpdateMode.Never);
                    txtMoTa.DataBindings.Add("Text", bsPhim, "MoTa", true, DataSourceUpdateMode.Never);
                    txtThoiLuong.DataBindings.Add("Text", bsPhim, "ThoiLuong", true, DataSourceUpdateMode.Never);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadPhim lỗi: " + ex.Message);
            }
        }
        //private void FormQuanLy_Load(object sender, EventArgs e) => LoadPhim();
        private void btnLoadPhim_Click(object sender, EventArgs e) => LoadPhim();
        private void LoadSuatChieu()
        {
            using (var con = new SqlConnection(_connectionString))
            using (var da = new SqlDataAdapter(@"
        SELECT 
            MaSuat,
            MaPhim,
            NgayChieu,
            CAST(GioBatDau  AS datetime) AS GioBatDau,   -- time -> datetime để bind DTP
            CAST(GioKetThuc AS datetime) AS GioKetThuc
        FROM SuatChieu
        ORDER BY NgayChieu, GioBatDau", con))
            {
                dtSuat = new DataTable();
                da.Fill(dtSuat);

                bsSuat.DataSource = dtSuat;

                // Nếu lưới có cột sẵn, bật tự sinh cột theo field
                dgvSuatChieu.AutoGenerateColumns = true;
                dgvSuatChieu.DataSource = bsSuat;

                // Cấu hình cơ bản
                dgvSuatChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSuatChieu.ReadOnly = true;
                dgvSuatChieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSuatChieu.MultiSelect = false;
                dgvSuatChieu.AllowUserToAddRows = false;
                dgvSuatChieu.AllowUserToDeleteRows = false;
                dgvSuatChieu.RowHeadersVisible = false;

                // Clear binding cũ
                txtMaSuat.DataBindings.Clear();
                txtmaaphim.DataBindings.Clear();
                dtpNgayChieu.DataBindings.Clear();
                dtpGioBD.DataBindings.Clear();
                dtpGioKT.DataBindings.Clear();

                // Bind mới (TextBox + DTP)
                txtMaSuat.DataBindings.Add("Text", bsSuat, "MaSuat", true, DataSourceUpdateMode.Never);
                txtmaaphim.DataBindings.Add("Text", bsSuat, "MaPhim", true, DataSourceUpdateMode.Never);
                dtpNgayChieu.DataBindings.Add("Value", bsSuat, "NgayChieu", true, DataSourceUpdateMode.Never);
                dtpGioBD.DataBindings.Add("Value", bsSuat, "GioBatDau", true, DataSourceUpdateMode.Never);
                dtpGioKT.DataBindings.Add("Value", bsSuat, "GioKetThuc", true, DataSourceUpdateMode.Never);

                // Định dạng DTP
                dtpNgayChieu.Format = DateTimePickerFormat.Custom;
                dtpNgayChieu.CustomFormat = "dd/MM/yyyy";

                dtpGioBD.Format = DateTimePickerFormat.Time;
                dtpGioBD.ShowUpDown = true;

                dtpGioKT.Format = DateTimePickerFormat.Time;
                dtpGioKT.ShowUpDown = true;
            }
        }
        private void btnLoadSuatChieu_Click(object sender, EventArgs e) => LoadSuatChieu();
        private void LoadPhongChieu()
        {
            using (var con = new SqlConnection(_connectionString))
            using (var da = new SqlDataAdapter(
                "SELECT MaPhong, TenPhong, SoGhe, TrangThaiPhong FROM PhongChieu ORDER BY MaPhong", con))
            {
                dtPhongChieu = new DataTable();
                da.Fill(dtPhongChieu);

                bsPhongChieu.DataSource = dtPhongChieu;
                dgvPhongChieu.AutoGenerateColumns = true;
                dgvPhongChieu.DataSource = bsPhongChieu;

                // Cấu hình DataGridView
                dgvPhongChieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvPhongChieu.ReadOnly = true;
                dgvPhongChieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvPhongChieu.MultiSelect = false;
                dgvPhongChieu.AllowUserToAddRows = false;
                dgvPhongChieu.AllowUserToDeleteRows = false;
                dgvPhongChieu.RowHeadersVisible = false;

                // Clear binding cũ
                txtMaPhong.DataBindings.Clear();
                txtTenPhong.DataBindings.Clear();
                txtSoGhe.DataBindings.Clear();
                txtTrangThaiPhong.DataBindings.Clear();

                // Binding mới
                txtMaPhong.DataBindings.Add("Text", bsPhongChieu, "MaPhong", true, DataSourceUpdateMode.Never);
                txtTenPhong.DataBindings.Add("Text", bsPhongChieu, "TenPhong", true, DataSourceUpdateMode.Never);
                txtSoGhe.DataBindings.Add("Text", bsPhongChieu, "SoGhe", true, DataSourceUpdateMode.Never);
                txtTrangThaiPhong.DataBindings.Add("Text", bsPhongChieu, "TrangThaiPhong", true, DataSourceUpdateMode.Never);
            }
        }
        private void btnLoadPhongChieu_Click(object sender, EventArgs e) => LoadPhongChieu();
        private void LoadGhe()
        {
            using (var con = new SqlConnection(_connectionString))
            using (var da = new SqlDataAdapter(
                "SELECT MaGhe, TenGhe, TrangThai, MaPhong FROM Ghe ORDER BY MaGhe", con))
            {
                dtGhe = new DataTable();
                da.Fill(dtGhe);

                bsGhe.DataSource = dtGhe;
                dgvGhe.AutoGenerateColumns = true;
                dgvGhe.DataSource = bsGhe;

                // Cấu hình DataGridView
                dgvGhe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvGhe.ReadOnly = true;
                dgvGhe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvGhe.MultiSelect = false;
                dgvGhe.AllowUserToAddRows = false;
                dgvGhe.AllowUserToDeleteRows = false;
                dgvGhe.RowHeadersVisible = false;

                // Clear binding cũ
                txtMaGhe.DataBindings.Clear();
                txtTenGhe.DataBindings.Clear();
                txtTrangThai.DataBindings.Clear();
                txtMaaPhong.DataBindings.Clear();

                // Binding mới
                txtMaGhe.DataBindings.Add("Text", bsGhe, "MaGhe", true, DataSourceUpdateMode.Never);
                txtTenGhe.DataBindings.Add("Text", bsGhe, "TenGhe", true, DataSourceUpdateMode.Never);
                txtTrangThai.DataBindings.Add("Text", bsGhe, "TrangThai", true, DataSourceUpdateMode.Never);
                txtMaaPhong.DataBindings.Add("Text", bsGhe, "MaPhong", true, DataSourceUpdateMode.Never);
            }
        }
        private void btnLoadGhe_Click(object sender, EventArgs e) => LoadGhe();
        private void LoadKhuyenMai()
        {
            using (var con = new SqlConnection(_connectionString))
            using (var da = new SqlDataAdapter(
                "SELECT MaKM, NoiDungKM, NgayBD, NgayKT, DoiTuongApDung, TrangThaiKM FROM KhuyenMai ORDER BY MaKM", con))
            {
                dtKM = new DataTable();
                da.Fill(dtKM);

                bsKM.DataSource = dtKM;
                dgvKhuyenMai.AutoGenerateColumns = true;
                dgvKhuyenMai.DataSource = bsKM;

                // Cấu hình DataGridView
                dgvKhuyenMai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvKhuyenMai.ReadOnly = true;
                dgvKhuyenMai.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvKhuyenMai.MultiSelect = false;
                dgvKhuyenMai.AllowUserToAddRows = false;
                dgvKhuyenMai.AllowUserToDeleteRows = false;
                dgvKhuyenMai.RowHeadersVisible = false;

                // Clear binding cũ
                txtMaKM.DataBindings.Clear();
                txtNDKM.DataBindings.Clear();
                dtpNgayBDKM.DataBindings.Clear();
                dtpNgayKTKM.DataBindings.Clear();
                txtDoiTuong.DataBindings.Clear();
                txtTrangThaiKM.DataBindings.Clear();

                // Binding mới
                txtMaKM.DataBindings.Add("Text", bsKM, "MaKM", true, DataSourceUpdateMode.Never);
                txtNDKM.DataBindings.Add("Text", bsKM, "NoiDungKM", true, DataSourceUpdateMode.Never);
                dtpNgayBDKM.DataBindings.Add("Value", bsKM, "NgayBD", true, DataSourceUpdateMode.Never, DateTime.Now);
                dtpNgayKTKM.DataBindings.Add("Value", bsKM, "NgayKT", true, DataSourceUpdateMode.Never, DateTime.Now);
                txtDoiTuong.DataBindings.Add("Text", bsKM, "DoiTuongApDung", true, DataSourceUpdateMode.Never);
                txtTrangThaiKM.DataBindings.Add("Text", bsKM, "TrangThaiKM", true, DataSourceUpdateMode.Never);
            }
        }
        private void btnKhuyenMai_Click(object sender, EventArgs e) => LoadKhuyenMai();
        private void LoadChiTietCombo()
        {
            using (var con = new SqlConnection(_connectionString))
            using (var da = new SqlDataAdapter(
                "SELECT MaCombo, MaDon, SoLuong FROM ChiTietCombo ORDER BY MaCombo, MaDon", con))
            {
                dtCTCombo = new DataTable();
                da.Fill(dtCTCombo);

                bsCTCombo.DataSource = dtCTCombo;
                dgvCTCombo.AutoGenerateColumns = true;
                dgvCTCombo.DataSource = bsCTCombo;

                // Cấu hình DataGridView
                dgvCTCombo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCTCombo.ReadOnly = true;
                dgvCTCombo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCTCombo.MultiSelect = false;
                dgvCTCombo.AllowUserToAddRows = false;
                dgvCTCombo.AllowUserToDeleteRows = false;
                dgvCTCombo.RowHeadersVisible = false;

                // Clear binding cũ
                txtMaCombo.DataBindings.Clear();
                txtMaDon.DataBindings.Clear();
                txtSoLuong.DataBindings.Clear();

                // Binding mới
                txtMaCombo.DataBindings.Add("Text", bsCTCombo, "MaCombo", true, DataSourceUpdateMode.Never);
                txtMaDon.DataBindings.Add("Text", bsCTCombo, "MaDon", true, DataSourceUpdateMode.Never);
                txtSoLuong.DataBindings.Add("Text", bsCTCombo, "SoLuong", true, DataSourceUpdateMode.Never);
            }
        }
        private void btnLoadChiTietCombo_Click(object sender, EventArgs e) => LoadChiTietCombo();
        private void LoadVe()
        {
            using (var con = new SqlConnection(_connectionString))
            using (var da = new SqlDataAdapter(
                "SELECT MaVe, MaQR, TrangThaiVe, MaGhe, MaSuat, MaTT FROM Ve ORDER BY MaVe", con))
            {
                dtVe = new DataTable();
                da.Fill(dtVe);

                bsVe.DataSource = dtVe;
                dgvVe.AutoGenerateColumns = true;
                dgvVe.DataSource = bsVe;

                // Cấu hình DataGridView
                dgvVe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvVe.ReadOnly = true;
                dgvVe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvVe.MultiSelect = false;
                dgvVe.AllowUserToAddRows = false;
                dgvVe.AllowUserToDeleteRows = false;
                dgvVe.RowHeadersVisible = false;

                // Clear binding cũ
                txtMaVe.DataBindings.Clear();
                txtTrangThaiVe.DataBindings.Clear();
                txtMaGheVe.DataBindings.Clear();
                txtMaSuatVe.DataBindings.Clear();
                txtMaTTVe.DataBindings.Clear();
                //picMaQR.DataBindings.Clear();

                // Binding mới
                txtMaVe.DataBindings.Add("Text", bsVe, "MaVe", true, DataSourceUpdateMode.Never);
                txtTrangThaiVe.DataBindings.Add("Text", bsVe, "TrangThaiVe", true, DataSourceUpdateMode.Never);
                txtMaGheVe.DataBindings.Add("Text", bsVe, "MaGhe", true, DataSourceUpdateMode.Never);
                txtMaSuatVe.DataBindings.Add("Text", bsVe, "MaSuat", true, DataSourceUpdateMode.Never);
                txtMaTTVe.DataBindings.Add("Text", bsVe, "MaTT", true, DataSourceUpdateMode.Never);

                // Binding ảnh QR
                //picMaQR.DataBindings.Add("Image", bsVe, "MaQR", true, DataSourceUpdateMode.Never, null, "");
            }
        }
        private void btnLoadVe_Click(object sender, EventArgs e) => LoadVe();
        private void LoadNhaCungCap()
        {
            using (var con = new SqlConnection(_connectionString))
            using (var da = new SqlDataAdapter(
                "SELECT MaNCC, TenNCC, DiaChi, SDT FROM NhaCungCap ORDER BY MaNCC", con))
            {
                dtNCC = new DataTable();
                da.Fill(dtNCC);

                bsNCC.DataSource = dtNCC;
                dgvNCC.AutoGenerateColumns = true;
                dgvNCC.DataSource = bsNCC;

                // Cấu hình DataGridView
                dgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvNCC.ReadOnly = true;
                dgvNCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvNCC.MultiSelect = false;
                dgvNCC.AllowUserToAddRows = false;
                dgvNCC.AllowUserToDeleteRows = false;
                dgvNCC.RowHeadersVisible = false;

                // Clear binding cũ
                txtMaNCC.DataBindings.Clear();
                txtTenNCC.DataBindings.Clear();
                txtDiaChiNCC.DataBindings.Clear();
                txtSDTNCC.DataBindings.Clear();

                // Binding mới
                txtMaNCC.DataBindings.Add("Text", bsNCC, "MaNCC", true, DataSourceUpdateMode.Never);
                txtTenNCC.DataBindings.Add("Text", bsNCC, "TenNCC", true, DataSourceUpdateMode.Never);
                txtDiaChiNCC.DataBindings.Add("Text", bsNCC, "DiaChi", true, DataSourceUpdateMode.Never);
                txtSDTNCC.DataBindings.Add("Text", bsNCC, "SDT", true, DataSourceUpdateMode.Never);
            }
        }
        private void LoadNhaCungCap_Click(object sender, EventArgs e) =>LoadNhaCungCap();

        private void tabPage1_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(_connectionString);
            try
            {
                con.Open(); // test kết nối
                MessageBox.Show("Kết nối SQL thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được SQL:\n" + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }
        private void SetPlaceholder(TextBox tb, string text)
        {
            tb.ForeColor = System.Drawing.Color.Gray;
            tb.Text = text;

            tb.GotFocus += (s, e) => {
                if (tb.ForeColor == System.Drawing.Color.Gray) { tb.Text = ""; tb.ForeColor = System.Drawing.Color.Black; }
            };
            tb.LostFocus += (s, e) => {
                if (string.IsNullOrWhiteSpace(tb.Text)) { tb.Text = text; tb.ForeColor = System.Drawing.Color.Gray; }
            };
        }

        //private void btnLoadPhim_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        using (con = new SqlConnection(_connectionString))
        //        {
        //            con.Open();
        //            da = new SqlDataAdapter("SELECT * FROM Phim", con);
        //            dt = new DataTable();
        //            da.Fill(dt);
        //            dgvPhim.DataSource = dt; // kéo 1 DataGridView tên dataGridView1
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
        //    }
        //}

        private void tabPage2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(_connectionString);
            try
            {
                con.Open(); // test kết nối
                MessageBox.Show("Kết nối SQL thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không kết nối được SQL:\n" + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        //private void btnLoadNV_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        using (con = new SqlConnection(_connectionString))
        //        {
        //            con.Open();
        //            da = new SqlDataAdapter("SELECT * FROM NhanVien", con);
        //            dt = new DataTable();
        //            da.Fill(dt);
        //            dgvNV.DataSource = dt; // kéo 1 DataGridView tên dataGridView1
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
        //    }
        //}

        private void LoadVe_Click(object sender, EventArgs e)
        {
            try
            {
                using (con = new SqlConnection(_connectionString))
                {
                    con.Open();
                    da = new SqlDataAdapter("SELECT * FROM Ve", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dgvVe.DataSource = dt; // kéo 1 DataGridView tên dataGridView1
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (bsNV.Current == null) return;
            var row = ((DataRowView)bsNV.Current).Row;
            string ma = row.Field<string>("MaNV");

            if (MessageBox.Show($"Xóa nhân viên {ma} ?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            using (var con = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand("DELETE FROM NhanVien WHERE MaNV=@Ma", con))
            {
                cmd.Parameters.AddWithValue("@Ma", ma);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            LoadNhanVien();
        }


    }
}
