
namespace qlnh1
{
    partial class UCviewRevenuebyDay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdrevenuebytime = new Guna.UI.WinForms.GunaDataGridView();
            this.dvgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgdiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.enddate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnin = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdrevenuebytime)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdrevenuebytime
            // 
            this.grdrevenuebytime.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.grdrevenuebytime.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdrevenuebytime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdrevenuebytime.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdrevenuebytime.BackgroundColor = System.Drawing.Color.White;
            this.grdrevenuebytime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdrevenuebytime.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdrevenuebytime.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdrevenuebytime.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdrevenuebytime.ColumnHeadersHeight = 32;
            this.grdrevenuebytime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgSno,
            this.dvgdate,
            this.dvgquantity,
            this.dvgtotal,
            this.dvgdiscount,
            this.dvgnet});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdrevenuebytime.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdrevenuebytime.EnableHeadersVisualStyles = false;
            this.grdrevenuebytime.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdrevenuebytime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdrevenuebytime.Location = new System.Drawing.Point(0, 64);
            this.grdrevenuebytime.Name = "grdrevenuebytime";
            this.grdrevenuebytime.RowHeadersVisible = false;
            this.grdrevenuebytime.RowHeadersWidth = 62;
            this.grdrevenuebytime.RowTemplate.Height = 28;
            this.grdrevenuebytime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdrevenuebytime.Size = new System.Drawing.Size(1644, 593);
            this.grdrevenuebytime.TabIndex = 15;
            this.grdrevenuebytime.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grdrevenuebytime.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdrevenuebytime.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdrevenuebytime.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdrevenuebytime.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdrevenuebytime.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdrevenuebytime.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdrevenuebytime.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdrevenuebytime.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdrevenuebytime.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdrevenuebytime.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdrevenuebytime.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdrevenuebytime.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdrevenuebytime.ThemeStyle.HeaderStyle.Height = 32;
            this.grdrevenuebytime.ThemeStyle.ReadOnly = false;
            this.grdrevenuebytime.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdrevenuebytime.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdrevenuebytime.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdrevenuebytime.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdrevenuebytime.ThemeStyle.RowsStyle.Height = 28;
            this.grdrevenuebytime.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdrevenuebytime.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdrevenuebytime.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdrevenuebytime_CellFormatting);
            // 
            // dvgSno
            // 
            this.dvgSno.FillWeight = 50F;
            this.dvgSno.HeaderText = "STT";
            this.dvgSno.MinimumWidth = 50;
            this.dvgSno.Name = "dvgSno";
            // 
            // dvgdate
            // 
            this.dvgdate.HeaderText = "Ngày";
            this.dvgdate.MinimumWidth = 8;
            this.dvgdate.Name = "dvgdate";
            // 
            // dvgquantity
            // 
            this.dvgquantity.HeaderText = "Số hóa đơn";
            this.dvgquantity.MinimumWidth = 8;
            this.dvgquantity.Name = "dvgquantity";
            // 
            // dvgtotal
            // 
            this.dvgtotal.HeaderText = "Tổng tiền";
            this.dvgtotal.MinimumWidth = 8;
            this.dvgtotal.Name = "dvgtotal";
            // 
            // dvgdiscount
            // 
            this.dvgdiscount.HeaderText = "Giảm giá";
            this.dvgdiscount.MinimumWidth = 8;
            this.dvgdiscount.Name = "dvgdiscount";
            // 
            // dvgnet
            // 
            this.dvgnet.HeaderText = "Doanh thu thuần";
            this.dvgnet.MinimumWidth = 8;
            this.dvgnet.Name = "dvgnet";
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
            this.startdate.Location = new System.Drawing.Point(31, 0);
            this.startdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startdate.Name = "startdate";
            this.startdate.OnHoverBaseColor = System.Drawing.Color.White;
            this.startdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.startdate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.startdate.OnPressedColor = System.Drawing.Color.Black;
            this.startdate.Size = new System.Drawing.Size(217, 56);
            this.startdate.TabIndex = 17;
            this.startdate.Text = "10/11/23";
            this.startdate.Value = new System.DateTime(2023, 11, 10, 17, 18, 8, 128);
            this.startdate.ValueChanged += new System.EventHandler(this.startdate_ValueChanged);
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
            this.enddate.Location = new System.Drawing.Point(275, 0);
            this.enddate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.enddate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.enddate.Name = "enddate";
            this.enddate.OnHoverBaseColor = System.Drawing.Color.White;
            this.enddate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.enddate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.enddate.OnPressedColor = System.Drawing.Color.Black;
            this.enddate.Size = new System.Drawing.Size(198, 56);
            this.enddate.TabIndex = 16;
            this.enddate.Text = "10/11/23";
            this.enddate.Value = new System.DateTime(2023, 11, 10, 17, 18, 0, 976);
            this.enddate.ValueChanged += new System.EventHandler(this.enddate_ValueChanged);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.btnin);
            this.gunaPanel1.Controls.Add(this.enddate);
            this.gunaPanel1.Controls.Add(this.startdate);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1644, 58);
            this.gunaPanel1.TabIndex = 18;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // btnin
            // 
            this.btnin.AnimationHoverSpeed = 0.07F;
            this.btnin.AnimationSpeed = 0.03F;
            this.btnin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(53)))), ((int)(((byte)(106)))));
            this.btnin.BorderColor = System.Drawing.Color.Black;
            this.btnin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnin.FocusedColor = System.Drawing.Color.Empty;
            this.btnin.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnin.ForeColor = System.Drawing.Color.White;
            this.btnin.Image = null;
            this.btnin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnin.Location = new System.Drawing.Point(503, 0);
            this.btnin.Name = "btnin";
            this.btnin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnin.OnHoverImage = null;
            this.btnin.OnPressedColor = System.Drawing.Color.Black;
            this.btnin.Size = new System.Drawing.Size(148, 54);
            this.btnin.TabIndex = 21;
            this.btnin.Text = "Xuất báo cáo";
            this.btnin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // UCviewRevenuebyDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.grdrevenuebytime);
            this.Name = "UCviewRevenuebyDay";
            this.Size = new System.Drawing.Size(1644, 680);
            this.Load += new System.EventHandler(this.UCviewRevenuebyDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdrevenuebytime)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaDataGridView grdrevenuebytime;
        private Guna.UI.WinForms.GunaDateTimePicker startdate;
        private Guna.UI.WinForms.GunaDateTimePicker enddate;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgdiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgnet;
        private Guna.UI.WinForms.GunaButton btnin;
    }
}
