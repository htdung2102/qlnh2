
namespace qlnh1
{
    partial class UpdateCustomer
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
            this.txtcusname = new Guna.UI.WinForms.GunaTextBox();
            this.txtcusphone = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // lblclose
            // 
            this.lblclose.AnimationHoverSpeed = 0.07F;
            this.lblclose.AnimationSpeed = 0.03F;
            this.lblclose.BackColor = System.Drawing.Color.Transparent;
            this.lblclose.BaseColor = System.Drawing.Color.SteelBlue;
            this.lblclose.BorderColor = System.Drawing.Color.Black;
            this.lblclose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.lblclose.FocusedColor = System.Drawing.Color.Empty;
            this.lblclose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclose.ForeColor = System.Drawing.Color.White;
            this.lblclose.Image = null;
            this.lblclose.ImageSize = new System.Drawing.Size(20, 20);
            this.lblclose.Location = new System.Drawing.Point(135, 277);
            this.lblclose.Name = "lblclose";
            this.lblclose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.lblclose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lblclose.OnHoverForeColor = System.Drawing.Color.White;
            this.lblclose.OnHoverImage = null;
            this.lblclose.OnPressedColor = System.Drawing.Color.Black;
            this.lblclose.Radius = 8;
            this.lblclose.Size = new System.Drawing.Size(127, 44);
            this.lblclose.TabIndex = 9;
            this.lblclose.Text = "OK";
            this.lblclose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // txtcusname
            // 
            this.txtcusname.BackColor = System.Drawing.Color.Transparent;
            this.txtcusname.BaseColor = System.Drawing.Color.White;
            this.txtcusname.BorderColor = System.Drawing.Color.Silver;
            this.txtcusname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcusname.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcusname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcusname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcusname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcusname.Location = new System.Drawing.Point(65, 87);
            this.txtcusname.Name = "txtcusname";
            this.txtcusname.PasswordChar = '\0';
            this.txtcusname.Radius = 5;
            this.txtcusname.SelectedText = "";
            this.txtcusname.Size = new System.Drawing.Size(290, 46);
            this.txtcusname.TabIndex = 8;
            this.txtcusname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcusphone
            // 
            this.txtcusphone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcusphone.BackColor = System.Drawing.Color.Transparent;
            this.txtcusphone.BaseColor = System.Drawing.Color.White;
            this.txtcusphone.BorderColor = System.Drawing.Color.Silver;
            this.txtcusphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcusphone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcusphone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcusphone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcusphone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcusphone.Location = new System.Drawing.Point(65, 194);
            this.txtcusphone.Name = "txtcusphone";
            this.txtcusphone.PasswordChar = '\0';
            this.txtcusphone.Radius = 5;
            this.txtcusphone.SelectedText = "";
            this.txtcusphone.Size = new System.Drawing.Size(290, 46);
            this.txtcusphone.TabIndex = 7;
            this.txtcusphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcusphone.Enter += new System.EventHandler(this.txtcusphone_Enter);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(60, 50);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(69, 25);
            this.gunaLabel1.TabIndex = 10;
            this.gunaLabel1.Text = "Họ tên";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(60, 157);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(122, 25);
            this.gunaLabel2.TabIndex = 11;
            this.gunaLabel2.Text = "Số điện thoại";
            this.gunaLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 363);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.txtcusname);
            this.Controls.Add(this.txtcusphone);
            this.Name = "UpdateCustomer";
            this.Text = "UpdateCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton lblclose;
        public Guna.UI.WinForms.GunaTextBox txtcusname;
        public Guna.UI.WinForms.GunaTextBox txtcusphone;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}