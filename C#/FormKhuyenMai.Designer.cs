
namespace doanPTTK
{
    partial class FormKhuyenMai
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
            this.flpKM = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpKM
            // 
            this.flpKM.AutoScroll = true;
            this.flpKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKM.Location = new System.Drawing.Point(0, 0);
            this.flpKM.Name = "flpKM";
            this.flpKM.Size = new System.Drawing.Size(800, 450);
            this.flpKM.TabIndex = 0;
            // 
            // FormKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpKM);
            this.Name = "FormKhuyenMai";
            this.Text = "FormKhuyenMai";
            this.Load += new System.EventHandler(this.FormKhuyenMai_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpKM;
    }
}