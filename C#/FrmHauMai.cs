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
    public partial class FrmHauMai : Form
    {
        string _cnn =
          @"Data Source=XUAN-NGHI\SQLEXPRESS;Initial Catalog=QuanLyRapChieuPhim;Integrated Security=True";
        public FrmHauMai()
        {
            InitializeComponent();
        }
        private void FormHauMai_Load(object sender, EventArgs e)
        {
            //LoadPhanHoi();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            var maVe = txtMaVe_DT.Text.Trim();
            if (string.IsNullOrEmpty(maVe)) { MessageBox.Show("Nhập mã vé."); return; }

            using (var con = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand(
                "SELECT s.NgayChieu, s.GioBatDau FROM Ve v JOIN SuatChieu s ON v.MaSuat=s.MaSuat WHERE v.MaVe=@v", con))
            {
                cmd.Parameters.AddWithValue("@v", maVe);
                con.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    if (!rd.Read()) { MessageBox.Show("Không tìm thấy vé."); return; }
                    var ngay = rd.GetDateTime(0).Date;
                    var gio = rd.GetTimeSpan(1);
                    var thoiDiemChieu = ngay + gio;
                    // ví dụ: cho đổi/ trả trước giờ chiếu 2 giờ
                    if (DateTime.Now > thoiDiemChieu.AddHours(-2))
                        MessageBox.Show("Đã quá hạn đổi/ trả.");
                    else
                        MessageBox.Show("Vé đủ điều kiện đổi/ trả.");
                }
            }
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            var maVe = txtMaVe_DT.Text.Trim();
            var loai = cboLoaiXuLy.Text; // "Đổi vé" / "Trả vé"
            var lyDo = txtLyDo.Text.Trim();

            if (string.IsNullOrEmpty(maVe) || string.IsNullOrEmpty(loai))
            { MessageBox.Show("Nhập đủ thông tin."); return; }

            using (var con = new SqlConnection(_cnn))
            {
                con.Open();
                using (var tran = con.BeginTransaction())
                {
                    try
                    {
                        // ví dụ cập nhật trạng thái vé
                        using (var cmd = new SqlCommand(
                            "UPDATE Ve SET TrangThaiVe=@tt WHERE MaVe=@v", con, tran))
                        {
                            cmd.Parameters.AddWithValue("@tt", loai == "Trả vé" ? "Đã hoàn" : "Đã đổi");
                            cmd.Parameters.AddWithValue("@v", maVe);
                            cmd.ExecuteNonQuery();
                        }

                        // lưu lịch sử đổi/ trả
                        using (var cmd = new SqlCommand(
                            "INSERT INTO DoiTraVe(MaVe, LoaiXuLy, LyDo, NgayGio) VALUES(@v,@loai,@lydo,GETDATE())", con, tran))
                        {
                            cmd.Parameters.AddWithValue("@v", maVe);
                            cmd.Parameters.AddWithValue("@loai", loai);
                            cmd.Parameters.AddWithValue("@lydo", lyDo);
                            cmd.ExecuteNonQuery();
                        }

                        tran.Commit();
                        MessageBox.Show("Đã xử lý thành công.");
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void tabPhanHoi_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(_cnn))
            using (var da = new SqlDataAdapter(
                "SELECT MaPH, MaKH, NoiDung, TrangThai FROM PhanHoi WHERE TrangThai=N'Chưa xử lý' ORDER BY MaPH DESC", con))
            {
                var dt = new DataTable();
                da.Fill(dt);
                dgvPhanHoi.DataSource = dt;
            }
        }
        private void dgvPhanHoi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhanHoi.CurrentRow == null) return;
            txtNoiDung.Text = Convert.ToString(dgvPhanHoi.CurrentRow.Cells["NoiDung"].Value);
        }

        private void btnGuiTraLoi_Click(object sender, EventArgs e)
        {
            if (dgvPhanHoi.CurrentRow == null) return;
            var maPH = Convert.ToString(dgvPhanHoi.CurrentRow.Cells["MaPH"].Value);
            var traLoi = txtTraLoi.Text.Trim();
            if (string.IsNullOrEmpty(traLoi)) { MessageBox.Show("Nhập nội dung trả lời."); return; }

            using (var con = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand(
                "UPDATE PhanHoi SET TraLoi=@tl, TrangThai=N'Đã trả lời', NgayTL=GETDATE() WHERE MaPH=@id", con))
            {
                cmd.Parameters.AddWithValue("@tl", traLoi);
                cmd.Parameters.AddWithValue("@id", maPH);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            //LoadPhanHoi();
            MessageBox.Show("Đã trả lời phản hồi.");
        }

        private void btnDaXuLy_Click(object sender, EventArgs e)
        {
            if (dgvPhanHoi.CurrentRow == null) return;
            var maPH = Convert.ToString(dgvPhanHoi.CurrentRow.Cells["MaPH"].Value);

            using (var con = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand(
                "UPDATE PhanHoi SET TrangThai=N'Đã xử lý' WHERE MaPH=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", maPH);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            //LoadPhanHoi();
        }
    }

}
