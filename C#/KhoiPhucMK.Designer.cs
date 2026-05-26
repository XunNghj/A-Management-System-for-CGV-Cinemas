
namespace doanPTTK
{
    partial class KhoiPhucMK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserOrEmail = new System.Windows.Forms.TextBox();
            this.btnGuiOTP = new System.Windows.Forms.Button();
            this.lblNote1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.lblDemNguoc = new System.Windows.Forms.Label();
            this.pnl1_GuiOTP = new System.Windows.Forms.Panel();
            this.pnl2_XacThuc = new System.Windows.Forms.Panel();
            this.txtNewPass = new System.Windows.Forms.Panel();
            this.btnXacThucOTP = new System.Windows.Forms.Button();
            this.btnGuiLai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.pnl1_GuiOTP.SuspendLayout();
            this.pnl2_XacThuc.SuspendLayout();
            this.txtNewPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khôi phục mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email hoặc Tên đăng nhập";
            // 
            // txtUserOrEmail
            // 
            this.txtUserOrEmail.Location = new System.Drawing.Point(6, 35);
            this.txtUserOrEmail.Name = "txtUserOrEmail";
            this.txtUserOrEmail.Size = new System.Drawing.Size(175, 22);
            this.txtUserOrEmail.TabIndex = 2;
            // 
            // btnGuiOTP
            // 
            this.btnGuiOTP.BackColor = System.Drawing.Color.White;
            this.btnGuiOTP.Location = new System.Drawing.Point(219, 100);
            this.btnGuiOTP.Name = "btnGuiOTP";
            this.btnGuiOTP.Size = new System.Drawing.Size(71, 26);
            this.btnGuiOTP.TabIndex = 4;
            this.btnGuiOTP.Text = "Gửi OTP";
            this.btnGuiOTP.UseVisualStyleBackColor = false;
            this.btnGuiOTP.Click += new System.EventHandler(this.btnGuiOTP_Click);
            // 
            // lblNote1
            // 
            this.lblNote1.AutoSize = true;
            this.lblNote1.Location = new System.Drawing.Point(18, 100);
            this.lblNote1.Name = "lblNote1";
            this.lblNote1.Size = new System.Drawing.Size(0, 17);
            this.lblNote1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập mã OTP";
            // 
            // txtOTP
            // 
            this.txtOTP.Location = new System.Drawing.Point(6, 38);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(100, 22);
            this.txtOTP.TabIndex = 7;
            // 
            // lblDemNguoc
            // 
            this.lblDemNguoc.Location = new System.Drawing.Point(117, 37);
            this.lblDemNguoc.Name = "lblDemNguoc";
            this.lblDemNguoc.Size = new System.Drawing.Size(146, 23);
            this.lblDemNguoc.TabIndex = 8;
            this.lblDemNguoc.Text = "label4";
            // 
            // pnl1_GuiOTP
            // 
            this.pnl1_GuiOTP.Controls.Add(this.label2);
            this.pnl1_GuiOTP.Controls.Add(this.txtUserOrEmail);
            this.pnl1_GuiOTP.Controls.Add(this.btnGuiOTP);
            this.pnl1_GuiOTP.Location = new System.Drawing.Point(21, 60);
            this.pnl1_GuiOTP.Name = "pnl1_GuiOTP";
            this.pnl1_GuiOTP.Size = new System.Drawing.Size(290, 126);
            this.pnl1_GuiOTP.TabIndex = 9;
            // 
            // pnl2_XacThuc
            // 
            this.pnl2_XacThuc.Controls.Add(this.btnGuiLai);
            this.pnl2_XacThuc.Controls.Add(this.label3);
            this.pnl2_XacThuc.Controls.Add(this.btnXacThucOTP);
            this.pnl2_XacThuc.Controls.Add(this.txtOTP);
            this.pnl2_XacThuc.Controls.Add(this.lblDemNguoc);
            this.pnl2_XacThuc.Location = new System.Drawing.Point(21, 192);
            this.pnl2_XacThuc.Name = "pnl2_XacThuc";
            this.pnl2_XacThuc.Size = new System.Drawing.Size(290, 114);
            this.pnl2_XacThuc.TabIndex = 10;
            this.pnl2_XacThuc.Visible = false;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Controls.Add(this.btnDoiMatKhau);
            this.txtNewPass.Controls.Add(this.txtConfirmPass);
            this.txtNewPass.Controls.Add(this.label5);
            this.txtNewPass.Controls.Add(this.textBox1);
            this.txtNewPass.Controls.Add(this.label4);
            this.txtNewPass.Location = new System.Drawing.Point(21, 312);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(290, 145);
            this.txtNewPass.TabIndex = 11;
            // 
            // btnXacThucOTP
            // 
            this.btnXacThucOTP.BackColor = System.Drawing.Color.White;
            this.btnXacThucOTP.Location = new System.Drawing.Point(180, 85);
            this.btnXacThucOTP.Name = "btnXacThucOTP";
            this.btnXacThucOTP.Size = new System.Drawing.Size(110, 29);
            this.btnXacThucOTP.TabIndex = 12;
            this.btnXacThucOTP.Text = "Xác thực OTP";
            this.btnXacThucOTP.UseVisualStyleBackColor = false;
            this.btnXacThucOTP.Click += new System.EventHandler(this.btnXacThucOTP_Click);
            // 
            // btnGuiLai
            // 
            this.btnGuiLai.BackColor = System.Drawing.Color.White;
            this.btnGuiLai.Location = new System.Drawing.Point(6, 66);
            this.btnGuiLai.Name = "btnGuiLai";
            this.btnGuiLai.Size = new System.Drawing.Size(71, 48);
            this.btnGuiLai.TabIndex = 13;
            this.btnGuiLai.Text = "Gửi lại";
            this.btnGuiLai.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhập mật khẩu mới";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Xác nhận mật khẩu";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(6, 82);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(127, 22);
            this.txtConfirmPass.TabIndex = 7;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.Color.White;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(91, 110);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(116, 33);
            this.btnDoiMatKhau.TabIndex = 14;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // KhoiPhucMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 508);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.pnl2_XacThuc);
            this.Controls.Add(this.pnl1_GuiOTP);
            this.Controls.Add(this.lblNote1);
            this.Controls.Add(this.label1);
            this.Name = "KhoiPhucMK";
            this.Text = "KhoiPhucMK";
            this.Load += new System.EventHandler(this.KhoiPhucMK_Load);
            this.pnl1_GuiOTP.ResumeLayout(false);
            this.pnl1_GuiOTP.PerformLayout();
            this.pnl2_XacThuc.ResumeLayout(false);
            this.pnl2_XacThuc.PerformLayout();
            this.txtNewPass.ResumeLayout(false);
            this.txtNewPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserOrEmail;
        private System.Windows.Forms.Button btnGuiOTP;
        private System.Windows.Forms.Label lblNote1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Label lblDemNguoc;
        private System.Windows.Forms.Panel pnl1_GuiOTP;
        private System.Windows.Forms.Panel pnl2_XacThuc;
        private System.Windows.Forms.Panel txtNewPass;
        private System.Windows.Forms.Button btnGuiLai;
        private System.Windows.Forms.Button btnXacThucOTP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label5;
    }
}