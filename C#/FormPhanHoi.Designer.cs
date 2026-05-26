
namespace doanPTTK
{
    partial class FormPhanHoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboDanhGia = new System.Windows.Forms.ComboBox();
            this.btnGui = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNoiDung.Location = new System.Drawing.Point(0, 0);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(549, 134);
            this.txtNoiDung.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(153, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // cboDanhGia
            // 
            this.cboDanhGia.FormattingEnabled = true;
            this.cboDanhGia.Location = new System.Drawing.Point(182, 180);
            this.cboDanhGia.Name = "cboDanhGia";
            this.cboDanhGia.Size = new System.Drawing.Size(121, 24);
            this.cboDanhGia.TabIndex = 2;
            // 
            // btnGui
            // 
            this.btnGui.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGui.Location = new System.Drawing.Point(484, 245);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(65, 34);
            this.btnGui.TabIndex = 3;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = false;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập Email của bạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nhập Đánh Giá Của Bạn";
            // 
            // FormPhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.cboDanhGia);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNoiDung);
            this.Name = "FormPhanHoi";
            this.Text = "FormPhanHoi";
            this.Load += new System.EventHandler(this.FormPhanHoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboDanhGia;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}