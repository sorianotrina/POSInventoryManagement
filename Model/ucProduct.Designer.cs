using System.Drawing;
using System.Windows.Forms;

namespace Restaurant_Management.Model
{
    partial class ucProduct
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productName = new System.Windows.Forms.Label();
            this.productPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator1);
            this.guna2ShadowPanel1.Controls.Add(this.panel1);
            this.guna2ShadowPanel1.Controls.Add(this.productPic);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(164, 177);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 90);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(164, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.productName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 87);
            this.panel1.TabIndex = 1;
            // 
            // productName
            // 
            this.productName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(0, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(164, 87);
            this.productName.TabIndex = 0;
            this.productName.Text = "Product Name";
            this.productName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productPic
            // 
            this.productPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.productPic.Image = global::Restaurant_Management.Properties.Resources.pork_sinigang_removebg_preview1;
            this.productPic.ImageRotate = 0F;
            this.productPic.Location = new System.Drawing.Point(0, 10);
            this.productPic.Name = "productPic";
            this.productPic.Size = new System.Drawing.Size(164, 80);
            this.productPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPic.TabIndex = 0;
            this.productPic.TabStop = false;
            this.productPic.UseTransparentBackground = true;
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(164, 177);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label productName;
        private Guna.UI2.WinForms.Guna2PictureBox productPic;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
