
namespace qlnh1
{
    partial class UCViewVoucher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdvoucher = new Guna.UI.WinForms.GunaDataGridView();
            this.dvgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgdes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgtypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgstart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgpoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dvgdel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdvoucher)).BeginInit();
            this.SuspendLayout();
            // 
            // grdvoucher
            // 
            this.grdvoucher.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdvoucher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdvoucher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdvoucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdvoucher.BackgroundColor = System.Drawing.Color.White;
            this.grdvoucher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdvoucher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdvoucher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdvoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdvoucher.ColumnHeadersHeight = 32;
            this.grdvoucher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgSno,
            this.dvgid,
            this.dvgcode,
            this.dvgdes,
            this.dvgvalue,
            this.dvgtypeID,
            this.dvgstart,
            this.dvgend,
            this.dvgpoint,
            this.dvgedit,
            this.dvgdel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdvoucher.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdvoucher.EnableHeadersVisualStyles = false;
            this.grdvoucher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdvoucher.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdvoucher.Location = new System.Drawing.Point(3, 16);
            this.grdvoucher.Name = "grdvoucher";
            this.grdvoucher.RowHeadersVisible = false;
            this.grdvoucher.RowHeadersWidth = 62;
            this.grdvoucher.RowTemplate.Height = 28;
            this.grdvoucher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdvoucher.Size = new System.Drawing.Size(1582, 650);
            this.grdvoucher.TabIndex = 16;
            this.grdvoucher.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grdvoucher.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdvoucher.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdvoucher.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdvoucher.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdvoucher.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdvoucher.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdvoucher.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdvoucher.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdvoucher.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdvoucher.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdvoucher.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdvoucher.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdvoucher.ThemeStyle.HeaderStyle.Height = 32;
            this.grdvoucher.ThemeStyle.ReadOnly = false;
            this.grdvoucher.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdvoucher.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdvoucher.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdvoucher.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdvoucher.ThemeStyle.RowsStyle.Height = 28;
            this.grdvoucher.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdvoucher.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdvoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdvoucher_CellClick);
            // 
            // dvgSno
            // 
            this.dvgSno.FillWeight = 50F;
            this.dvgSno.HeaderText = "STT";
            this.dvgSno.MinimumWidth = 50;
            this.dvgSno.Name = "dvgSno";
            // 
            // dvgid
            // 
            this.dvgid.HeaderText = "ID";
            this.dvgid.MinimumWidth = 8;
            this.dvgid.Name = "dvgid";
            this.dvgid.Visible = false;
            // 
            // dvgcode
            // 
            this.dvgcode.HeaderText = "Mã giảm giá";
            this.dvgcode.MinimumWidth = 8;
            this.dvgcode.Name = "dvgcode";
            // 
            // dvgdes
            // 
            this.dvgdes.HeaderText = "Mô tả";
            this.dvgdes.MinimumWidth = 8;
            this.dvgdes.Name = "dvgdes";
            // 
            // dvgvalue
            // 
            this.dvgvalue.HeaderText = "Giá trị";
            this.dvgvalue.MinimumWidth = 8;
            this.dvgvalue.Name = "dvgvalue";
            // 
            // dvgtypeID
            // 
            this.dvgtypeID.HeaderText = "Nhóm";
            this.dvgtypeID.MinimumWidth = 8;
            this.dvgtypeID.Name = "dvgtypeID";
            this.dvgtypeID.Visible = false;
            // 
            // dvgstart
            // 
            this.dvgstart.HeaderText = "Ngày bắt đầu";
            this.dvgstart.MinimumWidth = 8;
            this.dvgstart.Name = "dvgstart";
            // 
            // dvgend
            // 
            this.dvgend.HeaderText = "Ngày kết thúc";
            this.dvgend.MinimumWidth = 8;
            this.dvgend.Name = "dvgend";
            // 
            // dvgpoint
            // 
            this.dvgpoint.HeaderText = "Điểm";
            this.dvgpoint.MinimumWidth = 8;
            this.dvgpoint.Name = "dvgpoint";
            // 
            // dvgedit
            // 
            this.dvgedit.HeaderText = "";
            this.dvgedit.Image = global::qlnh1.Properties.Resources.pen;
            this.dvgedit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dvgedit.MinimumWidth = 8;
            this.dvgedit.Name = "dvgedit";
            // 
            // dvgdel
            // 
            this.dvgdel.HeaderText = "";
            this.dvgdel.Image = global::qlnh1.Properties.Resources.delete;
            this.dvgdel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dvgdel.MinimumWidth = 8;
            this.dvgdel.Name = "dvgdel";
            // 
            // UCViewVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdvoucher);
            this.Name = "UCViewVoucher";
            this.Size = new System.Drawing.Size(1588, 666);
            this.Load += new System.EventHandler(this.UCViewVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdvoucher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaDataGridView grdvoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgdes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgtypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgstart;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgend;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgpoint;
        private System.Windows.Forms.DataGridViewImageColumn dvgedit;
        private System.Windows.Forms.DataGridViewImageColumn dvgdel;
    }
}
