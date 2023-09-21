
namespace qlnh1
{
    partial class addproduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDVT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbcat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnsave = new Guna.UI.WinForms.GunaButton();
            this.btnbrowse = new Guna.UI.WinForms.GunaButton();
            this.txtimage = new Guna.UI.WinForms.GunaPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txttenmon = new System.Windows.Forms.TextBox();
            this.DVT = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtimage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(367, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Detail";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.DVT);
            this.panel2.Controls.Add(this.cbDVT);
            this.panel2.Controls.Add(this.cbcat);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnbrowse);
            this.panel2.Controls.Add(this.txtimage);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtgia);
            this.panel2.Controls.Add(this.txttenmon);
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 485);
            this.panel2.TabIndex = 1;
            // 
            // cbDVT
            // 
            this.cbDVT.BorderColor = System.Drawing.Color.Empty;
            this.cbDVT.BorderThickness = 0;
            this.cbDVT.FillColor = System.Drawing.Color.Empty;
            this.cbDVT.FocusedColor = System.Drawing.Color.Empty;
            this.cbDVT.Items.AddRange(new object[] {
            "Chiếc ",
            "Lon",
            "Chai",
            "Phần "});
            this.cbDVT.Location = new System.Drawing.Point(326, 202);
            this.cbDVT.Name = "cbDVT";
            this.cbDVT.Size = new System.Drawing.Size(235, 28);
            this.cbDVT.StartIndex = 0;
            this.cbDVT.TabIndex = 19;
            this.cbDVT.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // cbcat
            // 
            this.cbcat.BorderColor = System.Drawing.Color.Empty;
            this.cbcat.BorderThickness = 0;
            this.cbcat.FillColor = System.Drawing.Color.Empty;
            this.cbcat.FocusedColor = System.Drawing.Color.Empty;
            this.cbcat.Location = new System.Drawing.Point(42, 202);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(235, 28);
            this.cbcat.StartIndex = 0;
            this.cbcat.TabIndex = 18;
            this.cbcat.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnsave
            // 
            this.btnsave.AnimationHoverSpeed = 0.07F;
            this.btnsave.AnimationSpeed = 0.03F;
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(64)))), ((int)(((byte)(153)))));
            this.btnsave.BorderColor = System.Drawing.Color.Black;
            this.btnsave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsave.FocusedColor = System.Drawing.Color.Empty;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = null;
            this.btnsave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnsave.Location = new System.Drawing.Point(193, 357);
            this.btnsave.Name = "btnsave";
            this.btnsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.btnsave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsave.OnHoverImage = null;
            this.btnsave.OnPressedColor = System.Drawing.Color.Black;
            this.btnsave.Radius = 25;
            this.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsave.Size = new System.Drawing.Size(200, 55);
            this.btnsave.TabIndex = 16;
            this.btnsave.Text = "Lưu";
            this.btnsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.AnimationHoverSpeed = 0.07F;
            this.btnbrowse.AnimationSpeed = 0.03F;
            this.btnbrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnbrowse.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnbrowse.BorderColor = System.Drawing.Color.Black;
            this.btnbrowse.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnbrowse.FocusedColor = System.Drawing.Color.Empty;
            this.btnbrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnbrowse.ForeColor = System.Drawing.Color.White;
            this.btnbrowse.Image = null;
            this.btnbrowse.ImageSize = new System.Drawing.Size(20, 20);
            this.btnbrowse.Location = new System.Drawing.Point(665, 357);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnbrowse.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnbrowse.OnHoverForeColor = System.Drawing.Color.White;
            this.btnbrowse.OnHoverImage = null;
            this.btnbrowse.OnPressedColor = System.Drawing.Color.Black;
            this.btnbrowse.Radius = 20;
            this.btnbrowse.Size = new System.Drawing.Size(168, 57);
            this.btnbrowse.TabIndex = 15;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // txtimage
            // 
            this.txtimage.BackColor = System.Drawing.Color.Transparent;
            this.txtimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtimage.BaseColor = System.Drawing.Color.White;
            this.txtimage.Image = global::qlnh1.Properties.Resources.burger;
            this.txtimage.Location = new System.Drawing.Point(627, 77);
            this.txtimage.Name = "txtimage";
            this.txtimage.Size = new System.Drawing.Size(252, 228);
            this.txtimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtimage.TabIndex = 14;
            this.txtimage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên nhóm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(322, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên món ";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(324, 60);
            this.txtgia.Multiline = true;
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(235, 45);
            this.txtgia.TabIndex = 4;
            // 
            // txttenmon
            // 
            this.txttenmon.Location = new System.Drawing.Point(42, 60);
            this.txttenmon.Multiline = true;
            this.txttenmon.Name = "txttenmon";
            this.txttenmon.Size = new System.Drawing.Size(235, 45);
            this.txttenmon.TabIndex = 2;
            // 
            // DVT
            // 
            this.DVT.AutoSize = true;
            this.DVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVT.Location = new System.Drawing.Point(322, 169);
            this.DVT.Name = "DVT";
            this.DVT.Size = new System.Drawing.Size(44, 20);
            this.DVT.TabIndex = 20;
            this.DVT.Text = "DVT";
            // 
            // addproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "addproduct";
            this.Text = "addproduct";
            this.Load += new System.EventHandler(this.addproduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaButton btnbrowse;
        private Guna.UI.WinForms.GunaButton btnsave;
        public System.Windows.Forms.TextBox txtgia;
        public System.Windows.Forms.TextBox txttenmon;
        public Guna.UI2.WinForms.Guna2ComboBox cbcat;
        public Guna.UI.WinForms.GunaPictureBox txtimage;
        public Guna.UI2.WinForms.Guna2ComboBox cbDVT;
        private System.Windows.Forms.Label DVT;
    }
}