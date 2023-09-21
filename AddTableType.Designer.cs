
namespace qlnh1
{
    partial class AddTableType
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
            this.lblclose = new Guna.UI.WinForms.GunaButton();
            this.txttypename = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // lblclose
            // 
            this.lblclose.AnimationHoverSpeed = 0.07F;
            this.lblclose.AnimationSpeed = 0.03F;
            this.lblclose.BaseColor = System.Drawing.Color.SteelBlue;
            this.lblclose.BorderColor = System.Drawing.Color.Black;
            this.lblclose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.lblclose.FocusedColor = System.Drawing.Color.Empty;
            this.lblclose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblclose.ForeColor = System.Drawing.Color.White;
            this.lblclose.Image = null;
            this.lblclose.ImageSize = new System.Drawing.Size(20, 20);
            this.lblclose.Location = new System.Drawing.Point(127, 142);
            this.lblclose.Name = "lblclose";
            this.lblclose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.lblclose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lblclose.OnHoverForeColor = System.Drawing.Color.White;
            this.lblclose.OnHoverImage = null;
            this.lblclose.OnPressedColor = System.Drawing.Color.Black;
            this.lblclose.Size = new System.Drawing.Size(127, 44);
            this.lblclose.TabIndex = 9;
            this.lblclose.Text = "Lưu";
            this.lblclose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // txttypename
            // 
            this.txttypename.BaseColor = System.Drawing.Color.White;
            this.txttypename.BorderColor = System.Drawing.Color.Silver;
            this.txttypename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttypename.FocusedBaseColor = System.Drawing.Color.White;
            this.txttypename.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttypename.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txttypename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttypename.Location = new System.Drawing.Point(49, 60);
            this.txttypename.Name = "txttypename";
            this.txttypename.PasswordChar = '\0';
            this.txttypename.SelectedText = "";
            this.txttypename.Size = new System.Drawing.Size(290, 46);
            this.txttypename.TabIndex = 7;
            this.txttypename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddTableType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 242);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.txttypename);
            this.Name = "AddTableType";
            this.Text = "AddTableType";
            this.Load += new System.EventHandler(this.AddTableType_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton lblclose;
        public Guna.UI.WinForms.GunaTextBox txttypename;
    }
}