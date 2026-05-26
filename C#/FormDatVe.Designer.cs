
namespace doanPTTK
{
    partial class FormDatVe
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
            this.lblPhim = new System.Windows.Forms.Label();
            this.tabGhe = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSangGhe = new System.Windows.Forms.Button();
            this.flpSuat = new System.Windows.Forms.FlowLayoutPanel();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.cboRap = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lstGhe = new System.Windows.Forms.ListBox();
            this.tblGhe = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabGhe.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPhim
            // 
            this.lblPhim.AutoSize = true;
            this.lblPhim.Location = new System.Drawing.Point(13, 50);
            this.lblPhim.Name = "lblPhim";
            this.lblPhim.Size = new System.Drawing.Size(72, 17);
            this.lblPhim.TabIndex = 0;
            this.lblPhim.Text = "Tên Phim:";
            // 
            // tabGhe
            // 
            this.tabGhe.Controls.Add(this.tabPage1);
            this.tabGhe.Controls.Add(this.tabPage2);
            this.tabGhe.Controls.Add(this.tabPage3);
            this.tabGhe.Controls.Add(this.tabPage4);
            this.tabGhe.Controls.Add(this.tabPage5);
            this.tabGhe.Location = new System.Drawing.Point(12, 70);
            this.tabGhe.Name = "tabGhe";
            this.tabGhe.SelectedIndex = 0;
            this.tabGhe.Size = new System.Drawing.Size(776, 368);
            this.tabGhe.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSangGhe);
            this.tabPage1.Controls.Add(this.flpSuat);
            this.tabPage1.Controls.Add(this.dtNgay);
            this.tabPage1.Controls.Add(this.cboRap);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Suất";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSangGhe
            // 
            this.btnSangGhe.Location = new System.Drawing.Point(321, 284);
            this.btnSangGhe.Name = "btnSangGhe";
            this.btnSangGhe.Size = new System.Drawing.Size(97, 49);
            this.btnSangGhe.TabIndex = 3;
            this.btnSangGhe.Text = "Xác Nhận";
            this.btnSangGhe.UseVisualStyleBackColor = true;
            // 
            // flpSuat
            // 
            this.flpSuat.Location = new System.Drawing.Point(6, 54);
            this.flpSuat.Name = "flpSuat";
            this.flpSuat.Size = new System.Drawing.Size(756, 151);
            this.flpSuat.TabIndex = 2;
            // 
            // dtNgay
            // 
            this.dtNgay.Location = new System.Drawing.Point(154, 26);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(221, 22);
            this.dtNgay.TabIndex = 1;
            // 
            // cboRap
            // 
            this.cboRap.FormattingEnabled = true;
            this.cboRap.Location = new System.Drawing.Point(6, 24);
            this.cboRap.Name = "cboRap";
            this.cboRap.Size = new System.Drawing.Size(121, 24);
            this.cboRap.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.lstGhe);
            this.tabPage2.Controls.Add(this.tblGhe);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ghế";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstGhe
            // 
            this.lstGhe.FormattingEnabled = true;
            this.lstGhe.ItemHeight = 16;
            this.lstGhe.Location = new System.Drawing.Point(53, 181);
            this.lstGhe.Name = "lstGhe";
            this.lstGhe.Size = new System.Drawing.Size(120, 84);
            this.lstGhe.TabIndex = 1;
            // 
            // tblGhe
            // 
            this.tblGhe.BackColor = System.Drawing.Color.Transparent;
            this.tblGhe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tblGhe.ColumnCount = 23;
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblGhe.Location = new System.Drawing.Point(168, 6);
            this.tblGhe.Name = "tblGhe";
            this.tblGhe.RowCount = 7;
            this.tblGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblGhe.Size = new System.Drawing.Size(457, 134);
            this.tblGhe.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 339);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Combo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 339);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Thanh Toán";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(768, 339);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Xác Nhận";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // FormDatVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabGhe);
            this.Controls.Add(this.lblPhim);
            this.Name = "FormDatVe";
            this.Text = "FormDatVe";
            this.Load += new System.EventHandler(this.FormDatVe_Load);
            this.tabGhe.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhim;
        private System.Windows.Forms.TabControl tabGhe;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox cboRap;
        private System.Windows.Forms.FlowLayoutPanel flpSuat;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Button btnSangGhe;
        private System.Windows.Forms.TableLayoutPanel tblGhe;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstGhe;
    }
}