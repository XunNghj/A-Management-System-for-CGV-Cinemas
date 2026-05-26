
namespace doanPTTK
{
    partial class MovieItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.lblTenPhim = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(47, 71);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(199, 194);
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Location = new System.Drawing.Point(71, 268);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(53, 17);
            this.lblTenPhim.TabIndex = 1;
            this.lblTenPhim.Text = "Thanh ";
            // 
            // MovieItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTenPhim);
            this.Controls.Add(this.picPoster);
            this.Name = "MovieItem";
            this.Size = new System.Drawing.Size(595, 532);
            this.Load += new System.EventHandler(this.MovieItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Label lblTenPhim;
    }
}
