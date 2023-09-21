
namespace qlnh1
{
    partial class UCBillList
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
            this.enddate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.startdate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.grdbillList = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.dvgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgorderdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgtname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgpeople = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgdiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dvgprint = new System.Windows.Forms.DataGridViewImageColumn();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdbillList)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // enddate
            // 
            this.enddate.BaseColor = System.Drawing.Color.White;
            this.enddate.BorderColor = System.Drawing.Color.Silver;
            this.enddate.CustomFormat = null;
            this.enddate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.enddate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.enddate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.enddate.ForeColor = System.Drawing.Color.Black;
            this.enddate.Location = new System.Drawing.Point(203, 22);
            this.enddate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.enddate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.enddate.Name = "enddate";
            this.enddate.OnHoverBaseColor = System.Drawing.Color.White;
            this.enddate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.enddate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.enddate.OnPressedColor = System.Drawing.Color.Black;
            this.enddate.Size = new System.Drawing.Size(161, 57);
            this.enddate.TabIndex = 6;
            this.enddate.Text = "19/11/23";
            this.enddate.Value = new System.DateTime(2023, 11, 19, 15, 47, 19, 559);
            this.enddate.ValueChanged += new System.EventHandler(this.enddate_ValueChanged);
            // 
            // startdate
            // 
            this.startdate.BaseColor = System.Drawing.Color.White;
            this.startdate.BorderColor = System.Drawing.Color.Silver;
            this.startdate.CustomFormat = null;
            this.startdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.startdate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.startdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startdate.ForeColor = System.Drawing.Color.Black;
            this.startdate.Location = new System.Drawing.Point(20, 22);
            this.startdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startdate.Name = "startdate";
            this.startdate.OnHoverBaseColor = System.Drawing.Color.White;
            this.startdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.startdate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.startdate.OnPressedColor = System.Drawing.Color.Black;
            this.startdate.Size = new System.Drawing.Size(163, 57);
            this.startdate.TabIndex = 5;
            this.startdate.Text = "19/11/23";
            this.startdate.Value = new System.DateTime(2023, 11, 19, 15, 47, 19, 559);
            this.startdate.ValueChanged += new System.EventHandler(this.startdate_ValueChanged);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel1.Controls.Add(this.grdbillList);
            this.gunaPanel1.Location = new System.Drawing.Point(3, 103);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1273, 482);
            this.gunaPanel1.TabIndex = 7;
            // 
            // grdbillList
            // 
            this.grdbillList.AllowUserToAddRows = false;
            this.grdbillList.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdbillList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdbillList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdbillList.BackgroundColor = System.Drawing.Color.White;
            this.grdbillList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdbillList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdbillList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdbillList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdbillList.ColumnHeadersHeight = 32;
            this.grdbillList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgSno,
            this.dvgid,
            this.dvgorderdate,
            this.dvgtname,
            this.dvgpeople,
            this.dvgtotal,
            this.dvgdiscount,
            this.dvgnet,
            this.dvgprint});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdbillList.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdbillList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdbillList.EnableHeadersVisualStyles = false;
            this.grdbillList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdbillList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdbillList.Location = new System.Drawing.Point(0, 0);
            this.grdbillList.Name = "grdbillList";
            this.grdbillList.RowHeadersVisible = false;
            this.grdbillList.RowHeadersWidth = 62;
            this.grdbillList.RowTemplate.Height = 28;
            this.grdbillList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdbillList.Size = new System.Drawing.Size(1273, 482);
            this.grdbillList.TabIndex = 16;
            this.grdbillList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grdbillList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdbillList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdbillList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdbillList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdbillList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdbillList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdbillList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdbillList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdbillList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdbillList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdbillList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdbillList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdbillList.ThemeStyle.HeaderStyle.Height = 32;
            this.grdbillList.ThemeStyle.ReadOnly = false;
            this.grdbillList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdbillList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdbillList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdbillList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdbillList.ThemeStyle.RowsStyle.Height = 28;
            this.grdbillList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdbillList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdbillList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdbillList_CellClick);
            this.grdbillList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdbillList_CellFormatting);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.enddate);
            this.gunaPanel2.Controls.Add(this.startdate);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1277, 97);
            this.gunaPanel2.TabIndex = 8;
            // 
            // dvgSno
            // 
            this.dvgSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgSno.HeaderText = "SR#";
            this.dvgSno.MinimumWidth = 50;
            this.dvgSno.Name = "dvgSno";
            this.dvgSno.Width = 50;
            // 
            // dvgid
            // 
            this.dvgid.DataPropertyName = "MABAN";
            this.dvgid.HeaderText = "id";
            this.dvgid.MinimumWidth = 8;
            this.dvgid.Name = "dvgid";
            this.dvgid.Visible = false;
            // 
            // dvgorderdate
            // 
            this.dvgorderdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgorderdate.FillWeight = 250F;
            this.dvgorderdate.HeaderText = "Ngày";
            this.dvgorderdate.MinimumWidth = 200;
            this.dvgorderdate.Name = "dvgorderdate";
            this.dvgorderdate.Width = 200;
            // 
            // dvgtname
            // 
            this.dvgtname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgtname.FillWeight = 200F;
            this.dvgtname.HeaderText = "Bàn";
            this.dvgtname.MinimumWidth = 100;
            this.dvgtname.Name = "dvgtname";
            this.dvgtname.Width = 150;
            // 
            // dvgpeople
            // 
            this.dvgpeople.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgpeople.HeaderText = "Số khách";
            this.dvgpeople.MinimumWidth = 100;
            this.dvgpeople.Name = "dvgpeople";
            this.dvgpeople.Width = 150;
            // 
            // dvgtotal
            // 
            this.dvgtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgtotal.HeaderText = "Tổng tiền";
            this.dvgtotal.MinimumWidth = 100;
            this.dvgtotal.Name = "dvgtotal";
            this.dvgtotal.Width = 130;
            // 
            // dvgdiscount
            // 
            this.dvgdiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgdiscount.HeaderText = "Giảm giá";
            this.dvgdiscount.MinimumWidth = 100;
            this.dvgdiscount.Name = "dvgdiscount";
            this.dvgdiscount.Width = 130;
            // 
            // dvgnet
            // 
            this.dvgnet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgnet.HeaderText = "Sau giảm giá";
            this.dvgnet.MinimumWidth = 100;
            this.dvgnet.Name = "dvgnet";
            this.dvgnet.Width = 160;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::qlnh1.Properties.Resources.printer__1_;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 303;
            // 
            // dvgprint
            // 
            this.dvgprint.HeaderText = "";
            this.dvgprint.Image = global::qlnh1.Properties.Resources.printer__1_;
            this.dvgprint.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dvgprint.MinimumWidth = 8;
            this.dvgprint.Name = "dvgprint";
            this.dvgprint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgprint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // UCBillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "UCBillList";
            this.Size = new System.Drawing.Size(1277, 585);
            this.Load += new System.EventHandler(this.UCBillList_Load);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdbillList)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDateTimePicker enddate;
        private Guna.UI.WinForms.GunaDateTimePicker startdate;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        public Guna.UI.WinForms.GunaDataGridView grdbillList;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgorderdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgtname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgpeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgdiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgnet;
        private System.Windows.Forms.DataGridViewImageColumn dvgprint;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}
