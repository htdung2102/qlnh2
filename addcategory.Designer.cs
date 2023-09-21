
namespace qlnh1
{
    partial class addcategory
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
            this.btnsave = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txttennhom = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.btnclose = new Guna.UI.WinForms.GunaButton();
            this.cbdepart = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.SuspendLayout();
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
            this.btnsave.Location = new System.Drawing.Point(80, 14);
            this.btnsave.Name = "btnsave";
            this.btnsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.btnsave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsave.OnHoverImage = null;
            this.btnsave.OnPressedColor = System.Drawing.Color.Black;
            this.btnsave.Radius = 25;
            this.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnsave.Size = new System.Drawing.Size(122, 55);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Lưu";
            this.btnsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.cbdepart);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.txttennhom);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(519, 490);
            this.gunaPanel1.TabIndex = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(74, 152);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(90, 25);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Tên nhóm";
            // 
            // txttennhom
            // 
            this.txttennhom.BaseColor = System.Drawing.Color.White;
            this.txttennhom.BorderColor = System.Drawing.Color.Silver;
            this.txttennhom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttennhom.FocusedBaseColor = System.Drawing.Color.White;
            this.txttennhom.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttennhom.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txttennhom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttennhom.Location = new System.Drawing.Point(79, 180);
            this.txttennhom.Name = "txttennhom";
            this.txttennhom.PasswordChar = '\0';
            this.txttennhom.SelectedText = "";
            this.txttennhom.Size = new System.Drawing.Size(344, 40);
            this.txttennhom.TabIndex = 2;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(20)))), ((int)(((byte)(104)))));
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(519, 84);
            this.gunaPanel2.TabIndex = 5;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.btnclose);
            this.gunaPanel3.Controls.Add(this.btnsave);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 409);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(519, 81);
            this.gunaPanel3.TabIndex = 6;
            // 
            // btnclose
            // 
            this.btnclose.AnimationHoverSpeed = 0.07F;
            this.btnclose.AnimationSpeed = 0.03F;
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(169)))));
            this.btnclose.BorderColor = System.Drawing.Color.Black;
            this.btnclose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnclose.FocusedColor = System.Drawing.Color.Empty;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Image = null;
            this.btnclose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnclose.Location = new System.Drawing.Point(301, 14);
            this.btnclose.Name = "btnclose";
            this.btnclose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(173)))), ((int)(((byte)(250)))));
            this.btnclose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnclose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnclose.OnHoverImage = null;
            this.btnclose.OnPressedColor = System.Drawing.Color.Black;
            this.btnclose.Radius = 25;
            this.btnclose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnclose.Size = new System.Drawing.Size(122, 55);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Đóng";
            this.btnclose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // cbdepart
            // 
            this.cbdepart.BackColor = System.Drawing.Color.Transparent;
            this.cbdepart.BaseColor = System.Drawing.Color.White;
            this.cbdepart.BorderColor = System.Drawing.Color.Silver;
            this.cbdepart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbdepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdepart.FocusedColor = System.Drawing.Color.Empty;
            this.cbdepart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbdepart.ForeColor = System.Drawing.Color.Black;
            this.cbdepart.FormattingEnabled = true;
            this.cbdepart.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbdepart.Location = new System.Drawing.Point(80, 278);
            this.cbdepart.Name = "cbdepart";
            this.cbdepart.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbdepart.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbdepart.Size = new System.Drawing.Size(343, 35);
            this.cbdepart.TabIndex = 5;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(75, 250);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(75, 25);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Khu vực";
            // 
            // addcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 490);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "addcategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addcategory";
            this.Load += new System.EventHandler(this.addcategory_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnsave;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaButton btnclose;
        public Guna.UI.WinForms.GunaTextBox txttennhom;
        public Guna.UI.WinForms.GunaPanel gunaPanel1;
        public Guna.UI.WinForms.GunaPanel gunaPanel3;
        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaComboBox cbdepart;
    }
}