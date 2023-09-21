
namespace qlnh1
{
    partial class ViewCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdcustomer = new Guna.UI.WinForms.GunaDataGridView();
            this.txtsearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.dvgNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgSpent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvglevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgscore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgedit = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdcustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdcustomer
            // 
            this.grdcustomer.AllowUserToAddRows = false;
            this.grdcustomer.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdcustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdcustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdcustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdcustomer.BackgroundColor = System.Drawing.Color.White;
            this.grdcustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdcustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdcustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdcustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdcustomer.ColumnHeadersHeight = 40;
            this.grdcustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgNo,
            this.dvgid,
            this.dvgName,
            this.dvgphone,
            this.dvgCount,
            this.dvgSpent,
            this.dvglevel,
            this.dvgscore,
            this.dvgedit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdcustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdcustomer.EnableHeadersVisualStyles = false;
            this.grdcustomer.GridColor = System.Drawing.Color.WhiteSmoke;
            this.grdcustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdcustomer.Location = new System.Drawing.Point(0, 130);
            this.grdcustomer.Name = "grdcustomer";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdcustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdcustomer.RowHeadersVisible = false;
            this.grdcustomer.RowHeadersWidth = 62;
            this.grdcustomer.RowTemplate.Height = 28;
            this.grdcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdcustomer.Size = new System.Drawing.Size(1649, 746);
            this.grdcustomer.TabIndex = 3;
            this.grdcustomer.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grdcustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdcustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdcustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdcustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdcustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdcustomer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdcustomer.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.grdcustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdcustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdcustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdcustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdcustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdcustomer.ThemeStyle.HeaderStyle.Height = 40;
            this.grdcustomer.ThemeStyle.ReadOnly = false;
            this.grdcustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdcustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdcustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdcustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdcustomer.ThemeStyle.RowsStyle.Height = 28;
            this.grdcustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdcustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdcustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdcustomer_CellContentClick);
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
            this.txtsearch.Location = new System.Drawing.Point(268, 34);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.Radius = 8;
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(940, 55);
            this.txtsearch.TabIndex = 7;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.ErrorImage = null;
            this.gunaPictureBox1.Image = global::qlnh1.Properties.Resources.search;
            this.gunaPictureBox1.Location = new System.Drawing.Point(1171, 49);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(37, 26);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 8;
            this.gunaPictureBox1.TabStop = false;
            // 
            // dvgNo
            // 
            this.dvgNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgNo.FillWeight = 30F;
            this.dvgNo.HeaderText = "SR#";
            this.dvgNo.MinimumWidth = 30;
            this.dvgNo.Name = "dvgNo";
            this.dvgNo.Width = 50;
            // 
            // dvgid
            // 
            this.dvgid.FillWeight = 30F;
            this.dvgid.HeaderText = "ID";
            this.dvgid.MinimumWidth = 30;
            this.dvgid.Name = "dvgid";
            this.dvgid.Visible = false;
            this.dvgid.Width = 68;
            // 
            // dvgName
            // 
            this.dvgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgName.FillWeight = 150F;
            this.dvgName.HeaderText = "Tên khách hàng";
            this.dvgName.MinimumWidth = 150;
            this.dvgName.Name = "dvgName";
            this.dvgName.Width = 200;
            // 
            // dvgphone
            // 
            this.dvgphone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgphone.HeaderText = "Số điện thoại";
            this.dvgphone.MinimumWidth = 100;
            this.dvgphone.Name = "dvgphone";
            this.dvgphone.Width = 170;
            // 
            // dvgCount
            // 
            this.dvgCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgCount.HeaderText = "Lần chi tiêu";
            this.dvgCount.MinimumWidth = 100;
            this.dvgCount.Name = "dvgCount";
            this.dvgCount.Width = 150;
            // 
            // dvgSpent
            // 
            this.dvgSpent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgSpent.HeaderText = "Tổng chi tiêu";
            this.dvgSpent.MinimumWidth = 100;
            this.dvgSpent.Name = "dvgSpent";
            this.dvgSpent.Width = 150;
            // 
            // dvglevel
            // 
            this.dvglevel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvglevel.HeaderText = "Hạng hội viên";
            this.dvglevel.MinimumWidth = 100;
            this.dvglevel.Name = "dvglevel";
            this.dvglevel.Width = 150;
            // 
            // dvgscore
            // 
            this.dvgscore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgscore.FillWeight = 50F;
            this.dvgscore.HeaderText = "Điểm tích lũy";
            this.dvgscore.MinimumWidth = 50;
            this.dvgscore.Name = "dvgscore";
            this.dvgscore.Width = 150;
            // 
            // dvgedit
            // 
            this.dvgedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgedit.HeaderText = "";
            this.dvgedit.Image = global::qlnh1.Properties.Resources.pen;
            this.dvgedit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dvgedit.MinimumWidth = 8;
            this.dvgedit.Name = "dvgedit";
            this.dvgedit.Width = 150;
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 888);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.grdcustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCustomer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ViewCustomer";
            this.Load += new System.EventHandler(this.ViewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdcustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaDataGridView grdcustomer;
        private Guna.UI.WinForms.GunaTextBox txtsearch;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSpent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvglevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgscore;
        private System.Windows.Forms.DataGridViewImageColumn dvgedit;
    }
}