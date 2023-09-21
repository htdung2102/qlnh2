
namespace qlnh1
{
    partial class UCviewtableList
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
            this.grdtable = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtsearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.cbtype = new Guna.UI.WinForms.GunaComboBox();
            this.dvgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dvgdel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdtable
            // 
            this.grdtable.AllowUserToAddRows = false;
            this.grdtable.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdtable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdtable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdtable.BackgroundColor = System.Drawing.Color.White;
            this.grdtable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdtable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdtable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdtable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdtable.ColumnHeadersHeight = 32;
            this.grdtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgSno,
            this.dvgid,
            this.dvgName,
            this.dvgstatus,
            this.dvgtype,
            this.dvgedit,
            this.dvgdel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdtable.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdtable.EnableHeadersVisualStyles = false;
            this.grdtable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdtable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdtable.Location = new System.Drawing.Point(16, 64);
            this.grdtable.Name = "grdtable";
            this.grdtable.RowHeadersVisible = false;
            this.grdtable.RowHeadersWidth = 62;
            this.grdtable.RowTemplate.Height = 28;
            this.grdtable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdtable.Size = new System.Drawing.Size(1905, 590);
            this.grdtable.TabIndex = 15;
            this.grdtable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grdtable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdtable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdtable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdtable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdtable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdtable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdtable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdtable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdtable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdtable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdtable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdtable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdtable.ThemeStyle.HeaderStyle.Height = 32;
            this.grdtable.ThemeStyle.ReadOnly = false;
            this.grdtable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdtable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdtable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdtable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdtable.ThemeStyle.RowsStyle.Height = 28;
            this.grdtable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdtable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdtable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdtable_CellClick);
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
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.gunaLabel1.Location = new System.Drawing.Point(171, 8);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(89, 28);
            this.gunaLabel1.TabIndex = 16;
            this.gunaLabel1.Text = "Khu vực";
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
            this.txtsearch.Location = new System.Drawing.Point(486, 3);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.Radius = 8;
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(940, 55);
            this.txtsearch.TabIndex = 18;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.ErrorImage = null;
            this.gunaPictureBox1.Image = global::qlnh1.Properties.Resources.search;
            this.gunaPictureBox1.Location = new System.Drawing.Point(1389, 17);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(37, 26);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 19;
            this.gunaPictureBox1.TabStop = false;
            // 
            // cbtype
            // 
            this.cbtype.BackColor = System.Drawing.Color.Transparent;
            this.cbtype.BaseColor = System.Drawing.Color.White;
            this.cbtype.BorderColor = System.Drawing.Color.Silver;
            this.cbtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtype.FocusedColor = System.Drawing.Color.Empty;
            this.cbtype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbtype.ForeColor = System.Drawing.Color.Black;
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Location = new System.Drawing.Point(266, 8);
            this.cbtype.Name = "cbtype";
            this.cbtype.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbtype.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbtype.Size = new System.Drawing.Size(173, 35);
            this.cbtype.TabIndex = 20;
            this.cbtype.SelectedValueChanged += new System.EventHandler(this.cbtype_SelectedValueChanged);
            // 
            // dvgSno
            // 
            this.dvgSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgSno.HeaderText = "SR#";
            this.dvgSno.MinimumWidth = 100;
            this.dvgSno.Name = "dvgSno";
            this.dvgSno.Width = 200;
            // 
            // dvgid
            // 
            this.dvgid.DataPropertyName = "MABAN";
            this.dvgid.HeaderText = "id";
            this.dvgid.MinimumWidth = 8;
            this.dvgid.Name = "dvgid";
            this.dvgid.Visible = false;
            this.dvgid.Width = 64;
            // 
            // dvgName
            // 
            this.dvgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgName.DataPropertyName = "TENBAN";
            this.dvgName.FillWeight = 300F;
            this.dvgName.HeaderText = "Tên";
            this.dvgName.MinimumWidth = 100;
            this.dvgName.Name = "dvgName";
            this.dvgName.Width = 250;
            // 
            // dvgstatus
            // 
            this.dvgstatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgstatus.FillWeight = 200F;
            this.dvgstatus.HeaderText = "Trạng thái";
            this.dvgstatus.MinimumWidth = 100;
            this.dvgstatus.Name = "dvgstatus";
            this.dvgstatus.Width = 250;
            // 
            // dvgtype
            // 
            this.dvgtype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgtype.HeaderText = "Khu vực";
            this.dvgtype.MinimumWidth = 100;
            this.dvgtype.Name = "dvgtype";
            this.dvgtype.Width = 200;
            // 
            // dvgedit
            // 
            this.dvgedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgedit.HeaderText = "";
            this.dvgedit.Image = global::qlnh1.Properties.Resources.pen;
            this.dvgedit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dvgedit.MinimumWidth = 100;
            this.dvgedit.Name = "dvgedit";
            // 
            // dvgdel
            // 
            this.dvgdel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgdel.HeaderText = "";
            this.dvgdel.Image = global::qlnh1.Properties.Resources.delete;
            this.dvgdel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dvgdel.MinimumWidth = 100;
            this.dvgdel.Name = "dvgdel";
            // 
            // UCviewtableList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.grdtable);
            this.Name = "UCviewtableList";
            this.Size = new System.Drawing.Size(1924, 690);
            this.Load += new System.EventHandler(this.UCviewtableList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaDataGridView grdtable;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtsearch;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaComboBox cbtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgtype;
        private System.Windows.Forms.DataGridViewImageColumn dvgedit;
        private System.Windows.Forms.DataGridViewImageColumn dvgdel;
    }
}
