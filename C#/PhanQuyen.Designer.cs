
namespace doanPTTK
{
    partial class PhanQuyen
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
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.btnVaoHeThong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHỌN VAI TRÒ";
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Location = new System.Drawing.Point(185, 63);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Size = new System.Drawing.Size(138, 24);
            this.cboVaiTro.TabIndex = 1;
            // 
            // btnVaoHeThong
            // 
            this.btnVaoHeThong.BackColor = System.Drawing.Color.ForestGreen;
            this.btnVaoHeThong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaoHeThong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVaoHeThong.Location = new System.Drawing.Point(28, 112);
            this.btnVaoHeThong.Name = "btnVaoHeThong";
            this.btnVaoHeThong.Size = new System.Drawing.Size(295, 33);
            this.btnVaoHeThong.TabIndex = 25;
            this.btnVaoHeThong.Text = "VÀO HỆ THỐNG";
            this.btnVaoHeThong.UseVisualStyleBackColor = false;
            this.btnVaoHeThong.Click += new System.EventHandler(this.btnVaoHeThong_Click);
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 183);
            this.Controls.Add(this.btnVaoHeThong);
            this.Controls.Add(this.cboVaiTro);
            this.Controls.Add(this.label1);
            this.Name = "PhanQuyen";
            this.Text = "PhanQuyen";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.Button btnVaoHeThong;
    }
}