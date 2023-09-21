
namespace qlnh1
{
    partial class ViewProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdproduct = new Guna.UI.WinForms.GunaDataGridView();
            this.dvgNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgIDNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgMAMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgcatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgcat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dvgdel = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtsearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdproduct
            // 
            this.grdproduct.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.grdproduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdproduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdproduct.BackgroundColor = System.Drawing.Color.White;
            this.grdproduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdproduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdproduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdproduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdproduct.ColumnHeadersHeight = 32;
            this.grdproduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgNO,
            this.dvgIDNO,
            this.dvgMAMON,
            this.dvgName,
            this.dvgprice,
            this.dvgcatID,
            this.dvgcat,
            this.dvgDVT,
            this.dvgedit,
            this.dvgdel});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdproduct.DefaultCellStyle = dataGridViewCellStyle9;
            this.grdproduct.EnableHeadersVisualStyles = false;
            this.grdproduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdproduct.Location = new System.Drawing.Point(3, 64);
            this.grdproduct.Name = "grdproduct";
            this.grdproduct.RowHeadersVisible = false;
            this.grdproduct.RowHeadersWidth = 62;
            this.grdproduct.RowTemplate.Height = 28;
            this.grdproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdproduct.Size = new System.Drawing.Size(1642, 696);
            this.grdproduct.TabIndex = 9;
            this.grdproduct.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grdproduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdproduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdproduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdproduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdproduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdproduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdproduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdproduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdproduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdproduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdproduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdproduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdproduct.ThemeStyle.HeaderStyle.Height = 32;
            this.grdproduct.ThemeStyle.ReadOnly = false;
            this.grdproduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdproduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdproduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdproduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdproduct.ThemeStyle.RowsStyle.Height = 28;
            this.grdproduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdproduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdproduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdproduct_CellClick);
            this.grdproduct.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdproduct_CellFormatting);
            // 
            // dvgNO
            // 
            this.dvgNO.HeaderText = "SR#";
            this.dvgNO.MinimumWidth = 8;
            this.dvgNO.Name = "dvgNO";
            // 
            // dvgIDNO
            // 
            this.dvgIDNO.HeaderText = "IDNO";
            this.dvgIDNO.MinimumWidth = 8;
            this.dvgIDNO.Name = "dvgIDNO";
            this.dvgIDNO.Visible = false;
            // 
            // dvgMAMON
            // 
            this.dvgMAMON.HeaderText = "Mã món";
            this.dvgMAMON.MinimumWidth = 8;
            this.dvgMAMON.Name = "dvgMAMON";
            // 
            // dvgName
            // 
            this.dvgName.HeaderText = "Tên món";
            this.dvgName.MinimumWidth = 8;
            this.dvgName.Name = "dvgName";
            // 
            // dvgprice
            // 
            this.dvgprice.HeaderText = "Đơn giá ";
            this.dvgprice.MinimumWidth = 8;
            this.dvgprice.Name = "dvgprice";
            // 
            // dvgcatID
            // 
            this.dvgcatID.HeaderText = "CATID";
            this.dvgcatID.MinimumWidth = 8;
            this.dvgcatID.Name = "dvgcatID";
            this.dvgcatID.Visible = false;
            // 
            // dvgcat
            // 
            this.dvgcat.HeaderText = "Tên nhóm";
            this.dvgcat.MinimumWidth = 8;
            this.dvgcat.Name = "dvgcat";
            // 
            // dvgDVT
            // 
            this.dvgDVT.HeaderText = "DVT";
            this.dvgDVT.MinimumWidth = 8;
            this.dvgDVT.Name = "dvgDVT";
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::qlnh1.Properties.Resources.pen;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 187;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::qlnh1.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 187;
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
            this.txtsearch.Location = new System.Drawing.Point(346, 3);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.Radius = 8;
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(940, 55);
            this.txtsearch.TabIndex = 10;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.ErrorImage = null;
            this.gunaPictureBox1.Image = global::qlnh1.Properties.Resources.search;
            this.gunaPictureBox1.Location = new System.Drawing.Point(1249, 16);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(37, 24);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 21;
            this.gunaPictureBox1.TabStop = false;
            // 
            // ViewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.grdproduct);
            this.Name = "ViewProduct";
            this.Size = new System.Drawing.Size(1648, 777);
            this.Load += new System.EventHandler(this.ViewProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView grdproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgIDNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgMAMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgcatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgcat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgDVT;
        private System.Windows.Forms.DataGridViewImageColumn dvgedit;
        private System.Windows.Forms.DataGridViewImageColumn dvgdel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI.WinForms.GunaTextBox txtsearch;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}
