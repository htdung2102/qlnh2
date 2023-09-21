
namespace qlnh1
{
    partial class UCReservationList
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
            this.btnaddreservation = new Guna.UI.WinForms.GunaButton();
            this.txtsearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.dvgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgtname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgpeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgbookdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgbooktime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgshift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgtableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grdtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dvgphone,
            this.dvgtname,
            this.dvgpeople,
            this.dvgbookdate,
            this.dvgbooktime,
            this.dvgarea,
            this.dvgtype,
            this.dvgshift,
            this.dvgtableID,
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
            this.grdtable.Location = new System.Drawing.Point(0, 56);
            this.grdtable.Name = "grdtable";
            this.grdtable.RowHeadersVisible = false;
            this.grdtable.RowHeadersWidth = 62;
            this.grdtable.RowTemplate.Height = 28;
            this.grdtable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdtable.Size = new System.Drawing.Size(1178, 530);
            this.grdtable.TabIndex = 16;
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
            this.grdtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdtable_CellContentClick);
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
            // btnaddreservation
            // 
            this.btnaddreservation.AnimationHoverSpeed = 0.07F;
            this.btnaddreservation.AnimationSpeed = 0.03F;
            this.btnaddreservation.BackColor = System.Drawing.Color.Transparent;
            this.btnaddreservation.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnaddreservation.BorderColor = System.Drawing.Color.Black;
            this.btnaddreservation.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnaddreservation.FocusedColor = System.Drawing.Color.Empty;
            this.btnaddreservation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnaddreservation.ForeColor = System.Drawing.Color.White;
            this.btnaddreservation.Image = null;
            this.btnaddreservation.ImageSize = new System.Drawing.Size(20, 20);
            this.btnaddreservation.Location = new System.Drawing.Point(0, 0);
            this.btnaddreservation.Name = "btnaddreservation";
            this.btnaddreservation.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnaddreservation.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnaddreservation.OnHoverForeColor = System.Drawing.Color.White;
            this.btnaddreservation.OnHoverImage = null;
            this.btnaddreservation.OnPressedColor = System.Drawing.Color.Black;
            this.btnaddreservation.Radius = 10;
            this.btnaddreservation.Size = new System.Drawing.Size(251, 50);
            this.btnaddreservation.TabIndex = 18;
            this.btnaddreservation.Text = "Tạo bàn đặt";
            this.btnaddreservation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnaddreservation.Click += new System.EventHandler(this.btnaddreservation_Click);
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
            this.txtsearch.Location = new System.Drawing.Point(276, 0);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.Radius = 8;
            this.txtsearch.SelectedText = "";
            this.txtsearch.Size = new System.Drawing.Size(580, 50);
            this.txtsearch.TabIndex = 19;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.ErrorImage = null;
            this.gunaPictureBox1.Image = global::qlnh1.Properties.Resources.search;
            this.gunaPictureBox1.Location = new System.Drawing.Point(819, 14);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(37, 24);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 20;
            this.gunaPictureBox1.TabStop = false;
            // 
            // dvgSno
            // 
            this.dvgSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgSno.FillWeight = 50F;
            this.dvgSno.HeaderText = "SR#";
            this.dvgSno.MinimumWidth = 50;
            this.dvgSno.Name = "dvgSno";
            this.dvgSno.Width = 50;
            // 
            // dvgid
            // 
            this.dvgid.HeaderText = "id";
            this.dvgid.MinimumWidth = 8;
            this.dvgid.Name = "dvgid";
            this.dvgid.Visible = false;
            // 
            // dvgName
            // 
            this.dvgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgName.FillWeight = 200F;
            this.dvgName.HeaderText = "Tên";
            this.dvgName.MinimumWidth = 150;
            this.dvgName.Name = "dvgName";
            this.dvgName.Width = 150;
            // 
            // dvgphone
            // 
            this.dvgphone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgphone.HeaderText = "SDT";
            this.dvgphone.MinimumWidth = 100;
            this.dvgphone.Name = "dvgphone";
            this.dvgphone.Width = 110;
            // 
            // dvgtname
            // 
            this.dvgtname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgtname.HeaderText = "Bàn";
            this.dvgtname.MinimumWidth = 100;
            this.dvgtname.Name = "dvgtname";
            this.dvgtname.Width = 110;
            // 
            // dvgpeople
            // 
            this.dvgpeople.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgpeople.HeaderText = "Số khách";
            this.dvgpeople.MinimumWidth = 50;
            this.dvgpeople.Name = "dvgpeople";
            // 
            // dvgbookdate
            // 
            this.dvgbookdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgbookdate.HeaderText = "Ngày đặt";
            this.dvgbookdate.MinimumWidth = 100;
            this.dvgbookdate.Name = "dvgbookdate";
            this.dvgbookdate.Width = 150;
            // 
            // dvgbooktime
            // 
            this.dvgbooktime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgbooktime.HeaderText = "Giờ đặt";
            this.dvgbooktime.MinimumWidth = 100;
            this.dvgbooktime.Name = "dvgbooktime";
            this.dvgbooktime.Width = 150;
            // 
            // dvgarea
            // 
            this.dvgarea.FillWeight = 8F;
            this.dvgarea.HeaderText = "Khu vực";
            this.dvgarea.MinimumWidth = 8;
            this.dvgarea.Name = "dvgarea";
            this.dvgarea.Visible = false;
            // 
            // dvgtype
            // 
            this.dvgtype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgtype.HeaderText = "Trạng thái";
            this.dvgtype.MinimumWidth = 100;
            this.dvgtype.Name = "dvgtype";
            // 
            // dvgshift
            // 
            this.dvgshift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgshift.HeaderText = "Ca";
            this.dvgshift.MinimumWidth = 8;
            this.dvgshift.Name = "dvgshift";
            this.dvgshift.Width = 50;
            // 
            // dvgtableID
            // 
            this.dvgtableID.HeaderText = "";
            this.dvgtableID.MinimumWidth = 8;
            this.dvgtableID.Name = "dvgtableID";
            this.dvgtableID.Visible = false;
            // 
            // dvgedit
            // 
            this.dvgedit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgedit.HeaderText = "";
            this.dvgedit.Image = global::qlnh1.Properties.Resources.pen;
            this.dvgedit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dvgedit.MinimumWidth = 50;
            this.dvgedit.Name = "dvgedit";
            this.dvgedit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgedit.Width = 80;
            // 
            // dvgdel
            // 
            this.dvgdel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgdel.HeaderText = "";
            this.dvgdel.Image = global::qlnh1.Properties.Resources.delete;
            this.dvgdel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dvgdel.MinimumWidth = 50;
            this.dvgdel.Name = "dvgdel";
            this.dvgdel.Width = 80;
            // 
            // UCReservationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnaddreservation);
            this.Controls.Add(this.grdtable);
            this.Name = "UCReservationList";
            this.Size = new System.Drawing.Size(1178, 586);
            this.Load += new System.EventHandler(this.UCReservationList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaDataGridView grdtable;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI.WinForms.GunaButton btnaddreservation;
        private Guna.UI.WinForms.GunaTextBox txtsearch;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgtname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgpeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgbookdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgbooktime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgshift;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgtableID;
        private System.Windows.Forms.DataGridViewImageColumn dvgedit;
        private System.Windows.Forms.DataGridViewImageColumn dvgdel;
    }
}
