using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace doanPTTK
{
    public partial class KhoiPhucMK : Form
    {
        private readonly System.Windows.Forms.Timer timerOtp = new System.Windows.Forms.Timer();
        string _otp;               // mã đang có
        DateTime _otpExpire;       // hết hạn (5 phút)
        int _count = 0;            // đếm ngược gửi lại
        readonly Random _rnd = new Random();
        public KhoiPhucMK()
        {
            InitializeComponent();
            timerOtp.Interval = 1000;           // 1 giây
            timerOtp.Tick += timerOtp_Tick;     // gán handler Tick
            ShowStep(1);
        }
        void ShowStep(int step)
        {
            pnl1_GuiOTP.Visible = (step == 1);
            pnl2_XacThuc.Visible = (step == 2);
            txtNewPass.Visible = (step == 3);
        }

        private void btnGuiOTP_Click(object sender, EventArgs e)
        {
            var input = txtUserOrEmail.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Nhập email hoặc tên đăng nhập.");
                return;
            }
            // Tạo mã OTP 6 số (demo)
            _otp = string.Concat(Enumerable.Range(0, 6).Select(_ => _rnd.Next(0, 10)));
            _otpExpire = DateTime.Now.AddMinutes(5);

            // DEMO: hiển thị OTP bằng MessageBox (khi deploy thì gửi email/sms thật)
            MessageBox.Show($"[DEMO] Mã OTP: {_otp}");

            // bật đếm ngược 60s cho nút Gửi lại
            _count = 60;
            btnGuiLai.Enabled = false;
            lblDemNguoc.Text = "Gửi lại sau 60s";
            timerOtp.Start();

            ShowStep(2);
            txtOTP.Focus();
        }
        private void timerOtp_Tick(object sender, EventArgs e)
        {
            if (_count > 0)
            {
                _count--;
                lblDemNguoc.Text = $"Gửi lại sau {_count}s";
                if (_count == 0) btnGuiLai.Enabled = true;
            }
        }
        private void btnGuiLai_Click(object sender, EventArgs e)
        {
            _otp = string.Concat(Enumerable.Range(0, 6).Select(_ => _rnd.Next(0, 10)));
            _otpExpire = DateTime.Now.AddMinutes(5);
            MessageBox.Show($"[DEMO] OTP mới: {_otp}");

            _count = 60;
            btnGuiLai.Enabled = false;
        }
        private void btnXacThucOTP_Click(object sender, EventArgs e)
        {
            var code = txtOTP.Text.Trim();

            if (!Regex.IsMatch(code, @"^\d{6}$"))
            {
                MessageBox.Show("OTP phải gồm 6 số.");
                return;
            }
            if (DateTime.Now > _otpExpire)
            {
                MessageBox.Show("OTP đã hết hạn, hãy gửi lại.");
                return;
            }
            if (code != _otp)
            {
                MessageBox.Show("OTP không đúng.");
                return;
            }

            timerOtp.Stop();
            ShowStep(3);
            txtNewPass.Focus();
        }

        private void KhoiPhucMK_Load(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            var p1 = txtNewPass.Text;
            var p2 = txtConfirmPass.Text;

            // Kiểm tra đơn giản: >=8 ký tự và trùng nhau
            if (p1.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải từ 8 ký tự.");
                return;
            }
            if (p1 != p2)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp.");
                return;
            }

            // TODO: lưu mật khẩu mới vào DB (nên hash trước khi lưu)
            MessageBox.Show("Đổi mật khẩu thành công!");
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
