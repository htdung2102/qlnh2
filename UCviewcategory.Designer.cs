
namespace qlnh1
{
    partial class UCviewcategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdcategory = new Guna.UI.WinForms.GunaDataGridView();
            this.dvgNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgpart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dvgdel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdcategory)).BeginInit();
            this.SuspendLayout();
            // 
            // grdcategory
            // 
            this.grdcategory.AllowUserToAddRows = false;
            this.grdcategory.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdcategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdcategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdcategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdcategory.BackgroundColor = System.Drawing.Color.White;
            this.grdcategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdcategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdcategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdcategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdcategory.ColumnHeadersHeight = 40;
            this.grdcategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgNo,
            this.dvgid,
            this.dvgName,
            this.dvgpart,
            this.dvgedit,
            this.dvgdel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdcategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdcategory.EnableHeadersVisualStyles = false;
            this.grdcategory.GridColor = System.Drawing.Color.WhiteSmoke;
            this.grdcategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdcategory.Location = new System.Drawing.Point(3, 26);
            this.grdcategory.Name = "grdcategory";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(217)))), ((int)(((byte)(218)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdcategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdcategory.RowHeadersVisible = false;
            this.grdcategory.RowHeadersWidth = 62;
            this.grdcategory.RowTemplate.Height = 28;
            this.grdcategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdcategory.Size = new System.Drawing.Size(1617, 689);
            this.grdcategory.TabIndex = 3;
            this.grdcategory.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grdcategory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdcategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdcategory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdcategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdcategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdcategory.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdcategory.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke;
            this.grdcategory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdcategory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdcategory.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdcategory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdcategory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdcategory.ThemeStyle.HeaderStyle.Height = 40;
            this.grdcategory.ThemeStyle.ReadOnly = false;
            this.grdcategory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdcategory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdcategory.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdcategory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdcategory.ThemeStyle.RowsStyle.Height = 28;
            this.grdcategory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdcategory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdcategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdcategory_CellClick);
            // 
            // dvgNo
            // 
            this.dvgNo.FillWeight = 150F;
            this.dvgNo.HeaderText = "SR#";
            this.dvgNo.MinimumWidth = 150;
            this.dvgNo.Name = "dvgNo";
            // 
            // dvgid
            // 
            this.dvgid.HeaderText = "ID";
            this.dvgid.MinimumWidth = 8;
            this.dvgid.Name = "dvgid";
            this.dvgid.Visible = false;
            // 
            // dvgName
            // 
            this.dvgName.FillWeight = 500F;
            this.dvgName.HeaderText = "Tên nhóm";
            this.dvgName.MinimumWidth = 500;
            this.dvgName.Name = "dvgName";
            // 
            // dvgpart
            // 
            this.dvgpart.FillWeight = 250F;
            this.dvgpart.HeaderText = "Khu vực";
            this.dvgpart.MinimumWidth = 250;
            this.dvgpart.Name = "dvgpart";
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
            // UCviewcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdcategory);
            this.Name = "UCviewcategory";
            this.Size = new System.Drawing.Size(1620, 732);
            this.Load += new System.EventHandler(this.UCviewcategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdcategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaDataGridView grdcategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgpart;
        private System.Windows.Forms.DataGridViewImageColumn dvgedit;
        private System.Windows.Forms.DataGridViewImageColumn dvgdel;
    }
}
