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
    public partial class FormPhanHoi : Form
    {
        public FormPhanHoi()
        {
            InitializeComponent();
        }

        private void FormPhanHoi_Load(object sender, EventArgs e)
        {
            cboDanhGia.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cboDanhGia.SelectedIndex = 4; // mặc định 5 sao

            // placeholder cho txtNoiDung
            txtNoiDung.ForeColor = Color.Gray;
            txtNoiDung.Text = "Nhập phản hồi của bạn...";
            txtNoiDung.Enter += (s, ev) =>
            {
                if (txtNoiDung.ForeColor == Color.Gray) { txtNoiDung.Text = ""; txtNoiDung.ForeColor = Color.Black; }
            };
            txtNoiDung.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtNoiDung.Text)) { txtNoiDung.Text = "Nhập phản hồi của bạn..."; txtNoiDung.ForeColor = Color.Gray; }
            };
        }

        private void btnGui_Click(object sender, EventArgs e)
        {
            var nd = txtNoiDung.ForeColor == Color.Gray ? "" : txtNoiDung.Text.Trim();
            if (string.IsNullOrWhiteSpace(nd))
            {
                MessageBox.Show("Vui lòng nhập nội dung phản hồi."); return;
            }

            string email = txtEmail.Text.Trim();
            string rating = cboDanhGia.SelectedItem?.ToString() ?? "5";

            // Lưu file CSV đơn giản
            string dir = Path.Combine(Application.StartupPath, "Data");
            Directory.CreateDirectory(dir);
            string file = Path.Combine(dir, "phanhoi.csv");
            string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss};{rating};{email};{nd.Replace(";", ",")}";
            File.AppendAllLines(file, new[] { line }, Encoding.UTF8);

            MessageBox.Show("Cám ơn bạn đã phản hồi!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}