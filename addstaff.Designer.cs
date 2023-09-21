
namespace qlnh1
{
    partial class addstaff
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
            this.txttennv = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtsdt = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtchucvu = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.btnsave = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtuser = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtpass = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.gunaShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttennv
            // 
            this.txttennv.BackColor = System.Drawing.Color.White;
            this.txttennv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttennv.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttennv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttennv.LineColor = System.Drawing.Color.Gainsboro;
            this.txttennv.Location = new System.Drawing.Point(47, 80);
            this.txttennv.Name = "txttennv";
            this.txttennv.PasswordChar = '\0';
            this.txttennv.SelectedText = "";
            this.txttennv.Size = new System.Drawing.Size(204, 41);
            this.txttennv.TabIndex = 2;
            this.txttennv.TextChanged += new System.EventHandler(this.gunaLineTextBox3_TextChanged);
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.Color.White;
            this.txtsdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsdt.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsdt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsdt.LineColor = System.Drawing.Color.Gainsboro;
            this.txtsdt.Location = new System.Drawing.Point(47, 192);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.PasswordChar = '\0';
            this.txtsdt.SelectedText = "";
            this.txtsdt.Size = new System.Drawing.Size(204, 35);
            this.txtsdt.TabIndex = 3;
            // 
            // txtchucvu
            // 
            this.txtchucvu.BackColor = System.Drawing.Color.Transparent;
            this.txtchucvu.BaseColor = System.Drawing.Color.White;
            this.txtchucvu.BorderColor = System.Drawing.Color.Silver;
            this.txtchucvu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtchucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtchucvu.FocusedColor = System.Drawing.Color.Empty;
            this.txtchucvu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtchucvu.ForeColor = System.Drawing.Color.Black;
            this.txtchucvu.FormattingEnabled = true;
            this.txtchucvu.Items.AddRange(new object[] {
            "Nhân viên thu ngân",
            "Nhân viên Order",
            "Nhân viên quản lý "});
            this.txtchucvu.Location = new System.Drawing.Point(47, 283);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtchucvu.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtchucvu.Size = new System.Drawing.Size(204, 35);
            this.txtchucvu.TabIndex = 4;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.gunaLabel2.Location = new System.Drawing.Point(51, 40);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(69, 25);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Họ tên";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.gunaLabel3.Location = new System.Drawing.Point(51, 255);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(77, 25);
            this.gunaLabel3.TabIndex = 7;
            this.gunaLabel3.Text = "Chức vụ";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.gunaLabel4.Location = new System.Drawing.Point(42, 152);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(122, 25);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Số điện thoại";
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
            this.btnsave.Location = new System.Drawing.Point(240, 379);
            this.btnsave.Name = "btnsave";
            this.btnsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.btnsave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsave.OnHoverImage = null;
            this.btnsave.OnPressedColor = System.Drawing.Color.Black;
            this.btnsave.Radius = 25;
            this.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsave.Size = new System.Drawing.Size(122, 55);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Lưu";
            this.btnsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.gunaLabel1.Location = new System.Drawing.Point(358, 44);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(139, 25);
            this.gunaLabel1.TabIndex = 12;
            this.gunaLabel1.Text = "Tên đăng nhập ";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.White;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtuser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtuser.LineColor = System.Drawing.Color.Gainsboro;
            this.txtuser.Location = new System.Drawing.Point(363, 82);
            this.txtuser.Name = "txtuser";
            this.txtuser.PasswordChar = '\0';
            this.txtuser.SelectedText = "";
            this.txtuser.Size = new System.Drawing.Size(204, 41);
            this.txtuser.TabIndex = 11;
            this.txtuser.TextChanged += new System.EventHandler(this.txtuser_TextChanged);
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.gunaLabel5.Location = new System.Drawing.Point(358, 152);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(89, 25);
            this.gunaLabel5.TabIndex = 14;
            this.gunaLabel5.Text = "Mật khẩu";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.White;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpass.LineColor = System.Drawing.Color.Gainsboro;
            this.txtpass.Location = new System.Drawing.Point(363, 192);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.SelectedText = "";
            this.txtpass.Size = new System.Drawing.Size(204, 35);
            this.txtpass.TabIndex = 13;
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.gunaShadowPanel1.Controls.Add(this.txtuser);
            this.gunaShadowPanel1.Controls.Add(this.btnsave);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel5);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel4);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel1);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel3);
            this.gunaShadowPanel1.Controls.Add(this.txtpass);
            this.gunaShadowPanel1.Controls.Add(this.gunaLabel2);
            this.gunaShadowPanel1.Controls.Add(this.txtsdt);
            this.gunaShadowPanel1.Controls.Add(this.txtchucvu);
            this.gunaShadowPanel1.Controls.Add(this.txttennv);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(49, 35);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(605, 504);
            this.gunaShadowPanel1.TabIndex = 15;
            // 
            // addstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 571);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "addstaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addstaff";
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaButton btnsave;
        public Guna.UI.WinForms.GunaLineTextBox txttennv;
        public Guna.UI.WinForms.GunaLineTextBox txtsdt;
        public Guna.UI.WinForms.GunaComboBox txtchucvu;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaLineTextBox txtuser;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        public Guna.UI.WinForms.GunaLineTextBox txtpass;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
    }
}