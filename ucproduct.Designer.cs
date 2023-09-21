
namespace qlnh1
{
    partial class ucproduct
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
            this.lblname = new Guna.UI.WinForms.GunaLabel();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.txtimage = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtimage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(-1, 97);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(159, 37);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Product Name";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(13, 85);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(130, 10);
            this.gunaSeparator1.TabIndex = 1;
            // 
            // txtimage
            // 
            this.txtimage.BaseColor = System.Drawing.Color.White;
            this.txtimage.Image = global::qlnh1.Properties.Resources.tải_xuống;
            this.txtimage.Location = new System.Drawing.Point(-1, -1);
            this.txtimage.Name = "txtimage";
            this.txtimage.Size = new System.Drawing.Size(154, 80);
            this.txtimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtimage.TabIndex = 0;
            this.txtimage.TabStop = false;
            this.txtimage.Click += new System.EventHandler(this.txtimage_Click);
            // 
            // ucproduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.txtimage);
            this.Name = "ucproduct";
            this.Size = new System.Drawing.Size(157, 134);
            this.Load += new System.EventHandler(this.ucproduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaLabel lblname;
        private Guna.UI.WinForms.GunaPictureBox txtimage;
    }
}
