
namespace qlnh1
{
    partial class staff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdstaff = new Guna.UI.WinForms.GunaDataGridView();
            this.txtsearch = new Guna.UI.WinForms.GunaTextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnaddstaff = new Guna.UI.WinForms.GunaImageButton();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.dvgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgIDNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgrole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvguser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgpass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dvgdel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdstaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grdstaff
            // 
            this.grdstaff.AllowUserToAddRows = false;
            this.grdstaff.AllowUserToResizeColumns = false;
            this.grdstaff.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdstaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdstaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdstaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdstaff.BackgroundColor = System.Drawing.Color.White;
            this.grdstaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdstaff.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdstaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdstaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdstaff.ColumnHeadersHeight = 32;
            this.grdstaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgSno,
            this.dvgIDNO,
            this.dvgName,
            this.dvgphone,
            this.dvgrole,
            this.dvguser,
            this.dvgpass,
            this.dvgedit,
            this.dvgdel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdstaff.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdstaff.EnableHeadersVisualStyles = false;
            this.grdstaff.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdstaff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdstaff.Location = new System.Drawing.Point(25, 125);
            this.grdstaff.Name = "grdstaff";
            this.grdstaff.RowHeadersVisible = false;
            this.grdstaff.RowHeadersWidth = 62;
            this.grdstaff.RowTemplate.Height = 28;
            this.grdstaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdstaff.Size = new System.Drawing.Size(1022, 439);
            this.grdstaff.TabIndex = 13;
            this.grdstaff.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grdstaff.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdstaff.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdstaff.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdstaff.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdstaff.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdstaff.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdstaff.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdstaff.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdstaff.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdstaff.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdstaff.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdstaff.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdstaff.ThemeStyle.HeaderStyle.Height = 32;
            this.grdstaff.ThemeStyle.ReadOnly = false;
            this.grdstaff.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdstaff.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdstaff.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdstaff.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdstaff.ThemeStyle.RowsStyle.Height = 28;
            this.grdstaff.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdstaff.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdstaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdstaff_CellClick_1);
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.Transparent;
            this.txtsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtsearch.BaseColor = System.Drawing.Color.White;
            this.txtsearch.BorderColor = System.Drawing.Color.Silver;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtsearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsearch.Location = new System.Drawing.Point(132, 27);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.Radius = 8;
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(811, 55);
            this.txtsearch.TabIndex = 7;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::qlnh1.Properties.Resources.pen;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::qlnh1.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // btnaddstaff
            // 
            this.btnaddstaff.BackgroundImage = global::qlnh1.Properties.Resources.add;
            this.btnaddstaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddstaff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnaddstaff.Image = null;
            this.btnaddstaff.ImageSize = new System.Drawing.Size(64, 64);
            this.btnaddstaff.Location = new System.Drawing.Point(36, 27);
            this.btnaddstaff.Name = "btnaddstaff";
            this.btnaddstaff.OnHoverImage = null;
            this.btnaddstaff.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnaddstaff.Size = new System.Drawing.Size(55, 55);
            this.btnaddstaff.TabIndex = 9;
            this.btnaddstaff.Click += new System.EventHandler(this.btnaddstaff_Click);
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox2.ErrorImage = null;
            this.gunaPictureBox2.Image = global::qlnh1.Properties.Resources.search;
            this.gunaPictureBox2.Location = new System.Drawing.Point(916, 42);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(27, 25);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 17;
            this.gunaPictureBox2.TabStop = false;
            // 
            // dvgSno
            // 
            this.dvgSno.FillWeight = 50F;
            this.dvgSno.HeaderText = "SR#";
            this.dvgSno.MinimumWidth = 50;
            this.dvgSno.Name = "dvgSno";
            // 
            // dvgIDNO
            // 
            this.dvgIDNO.HeaderText = "id";
            this.dvgIDNO.MinimumWidth = 8;
            this.dvgIDNO.Name = "dvgIDNO";
            this.dvgIDNO.Visible = false;
            // 
            // dvgName
            // 
            this.dvgName.FillWeight = 250F;
            this.dvgName.HeaderText = "Tên nhân viên";
            this.dvgName.MinimumWidth = 250;
            this.dvgName.Name = "dvgName";
            // 
            // dvgphone
            // 
            this.dvgphone.FillWeight = 150F;
            this.dvgphone.HeaderText = "Số điện thoại";
            this.dvgphone.MinimumWidth = 150;
            this.dvgphone.Name = "dvgphone";
            // 
            // dvgrole
            // 
            this.dvgrole.FillWeight = 200F;
            this.dvgrole.HeaderText = "Chức vụ";
            this.dvgrole.MinimumWidth = 200;
            this.dvgrole.Name = "dvgrole";
            // 
            // dvguser
            // 
            this.dvguser.FillWeight = 200F;
            this.dvguser.HeaderText = "Tên đăng nhập";
            this.dvguser.MinimumWidth = 200;
            this.dvguser.Name = "dvguser";
            // 
            // dvgpass
            // 
            this.dvgpass.HeaderText = "Mật khẩu";
            this.dvgpass.MinimumWidth = 100;
            this.dvgpass.Name = "dvgpass";
            // 
            // dvgedit
            // 
            this.dvgedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgedit.FillWeight = 50F;
            this.dvgedit.HeaderText = "";
            this.dvgedit.Image = global::qlnh1.Properties.Resources.pen;
            this.dvgedit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dvgedit.MinimumWidth = 50;
            this.dvgedit.Name = "dvgedit";
            this.dvgedit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgedit.Width = 50;
            // 
            // dvgdel
            // 
            this.dvgdel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgdel.FillWeight = 50F;
            this.dvgdel.HeaderText = "";
            this.dvgdel.Image = global::qlnh1.Properties.Resources.delete;
            this.dvgdel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dvgdel.MinimumWidth = 50;
            this.dvgdel.Name = "dvgdel";
            this.dvgdel.Width = 50;
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1076, 576);
            this.Controls.Add(this.gunaPictureBox2);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.grdstaff);
            this.Controls.Add(this.btnaddstaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staff";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "staff";
            this.Load += new System.EventHandler(this.staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdstaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI.WinForms.GunaImageButton btnaddstaff;
        public Guna.UI.WinForms.GunaDataGridView grdstaff;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI.WinForms.GunaTextBox txtsearch;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgIDNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgrole;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvguser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgpass;
        private System.Windows.Forms.DataGridViewImageColumn dvgedit;
        private System.Windows.Forms.DataGridViewImageColumn dvgdel;
    }
}