
namespace qlnh1
{
    partial class ViewInvoice
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
            this.grdinvoice = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.enddate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.startdate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dvgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgInvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgtname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgcompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgtaxcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdinvoice)).BeginInit();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdinvoice
            // 
            this.grdinvoice.AllowUserToAddRows = false;
            this.grdinvoice.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdinvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdinvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdinvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grdinvoice.BackgroundColor = System.Drawing.Color.White;
            this.grdinvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdinvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdinvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdinvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdinvoice.ColumnHeadersHeight = 32;
            this.grdinvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgSno,
            this.dvgid,
            this.dvgdate,
            this.dvgInvoiceID,
            this.dvgtname,
            this.dvgcompany,
            this.dvgtaxcode,
            this.dvgaddress,
            this.dvgnet});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdinvoice.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdinvoice.EnableHeadersVisualStyles = false;
            this.grdinvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdinvoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdinvoice.Location = new System.Drawing.Point(3, 103);
            this.grdinvoice.Name = "grdinvoice";
            this.grdinvoice.RowHeadersVisible = false;
            this.grdinvoice.RowHeadersWidth = 62;
            this.grdinvoice.RowTemplate.Height = 28;
            this.grdinvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdinvoice.Size = new System.Drawing.Size(1642, 660);
            this.grdinvoice.TabIndex = 17;
            this.grdinvoice.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grdinvoice.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdinvoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdinvoice.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdinvoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdinvoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdinvoice.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdinvoice.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdinvoice.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdinvoice.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdinvoice.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdinvoice.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdinvoice.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdinvoice.ThemeStyle.HeaderStyle.Height = 32;
            this.grdinvoice.ThemeStyle.ReadOnly = false;
            this.grdinvoice.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdinvoice.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdinvoice.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdinvoice.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdinvoice.ThemeStyle.RowsStyle.Height = 28;
            this.grdinvoice.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdinvoice.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdinvoice.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdinvoice_CellFormatting);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.enddate);
            this.gunaPanel2.Controls.Add(this.startdate);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1648, 97);
            this.gunaPanel2.TabIndex = 18;
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
            this.dvgid.Width = 64;
            // 
            // dvgdate
            // 
            this.dvgdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgdate.HeaderText = "Ngày xuất ";
            this.dvgdate.MinimumWidth = 8;
            this.dvgdate.Name = "dvgdate";
            // 
            // dvgInvoiceID
            // 
            this.dvgInvoiceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgInvoiceID.FillWeight = 250F;
            this.dvgInvoiceID.HeaderText = "Số hóa đơn";
            this.dvgInvoiceID.MinimumWidth = 100;
            this.dvgInvoiceID.Name = "dvgInvoiceID";
            // 
            // dvgtname
            // 
            this.dvgtname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgtname.FillWeight = 200F;
            this.dvgtname.HeaderText = "Tên khách hàng";
            this.dvgtname.MinimumWidth = 100;
            this.dvgtname.Name = "dvgtname";
            this.dvgtname.Width = 200;
            // 
            // dvgcompany
            // 
            this.dvgcompany.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgcompany.HeaderText = "Tên đơn vị ";
            this.dvgcompany.MinimumWidth = 100;
            this.dvgcompany.Name = "dvgcompany";
            this.dvgcompany.Width = 150;
            // 
            // dvgtaxcode
            // 
            this.dvgtaxcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgtaxcode.HeaderText = "Mã số thuế";
            this.dvgtaxcode.MinimumWidth = 100;
            this.dvgtaxcode.Name = "dvgtaxcode";
            this.dvgtaxcode.Width = 150;
            // 
            // dvgaddress
            // 
            this.dvgaddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgaddress.HeaderText = "Địa chỉ";
            this.dvgaddress.MinimumWidth = 100;
            this.dvgaddress.Name = "dvgaddress";
            this.dvgaddress.Width = 300;
            // 
            // dvgnet
            // 
            this.dvgnet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dvgnet.HeaderText = "Tổng tiền";
            this.dvgnet.MinimumWidth = 100;
            this.dvgnet.Name = "dvgnet";
            // 
            // ViewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.grdinvoice);
            this.Name = "ViewInvoice";
            this.Size = new System.Drawing.Size(1648, 777);
            this.Load += new System.EventHandler(this.ViewInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdinvoice)).EndInit();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaDataGridView grdinvoice;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaDateTimePicker enddate;
        private Guna.UI.WinForms.GunaDateTimePicker startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgInvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgtname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgcompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgtaxcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgnet;
    }
}
