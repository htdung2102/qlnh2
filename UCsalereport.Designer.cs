
namespace qlnh1
{
    partial class UCsalereport
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
            this.grdsalereport = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.startdate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.enddate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.depart = new Guna.UI.WinForms.GunaShadowPanel();
            this.cbdepart = new Guna.UI.WinForms.GunaComboBox();
            this.btnin = new Guna.UI.WinForms.GunaButton();
            this.dvgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgquantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdsalereport)).BeginInit();
            this.gunaShadowPanel1.SuspendLayout();
            this.depart.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdsalereport
            // 
            this.grdsalereport.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdsalereport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdsalereport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdsalereport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdsalereport.BackgroundColor = System.Drawing.Color.White;
            this.grdsalereport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdsalereport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdsalereport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdsalereport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdsalereport.ColumnHeadersHeight = 32;
            this.grdsalereport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgSno,
            this.dvgname,
            this.dvgquantity});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdsalereport.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdsalereport.EnableHeadersVisualStyles = false;
            this.grdsalereport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdsalereport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.grdsalereport.Location = new System.Drawing.Point(3, 139);
            this.grdsalereport.Name = "grdsalereport";
            this.grdsalereport.RowHeadersVisible = false;
            this.grdsalereport.RowHeadersWidth = 62;
            this.grdsalereport.RowTemplate.Height = 28;
            this.grdsalereport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdsalereport.Size = new System.Drawing.Size(1642, 600);
            this.grdsalereport.TabIndex = 16;
            this.grdsalereport.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.grdsalereport.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grdsalereport.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grdsalereport.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grdsalereport.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grdsalereport.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grdsalereport.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grdsalereport.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdsalereport.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grdsalereport.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdsalereport.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdsalereport.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grdsalereport.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grdsalereport.ThemeStyle.HeaderStyle.Height = 32;
            this.grdsalereport.ThemeStyle.ReadOnly = false;
            this.grdsalereport.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grdsalereport.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdsalereport.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.grdsalereport.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grdsalereport.ThemeStyle.RowsStyle.Height = 28;
            this.grdsalereport.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdsalereport.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.startdate);
            this.gunaShadowPanel1.Controls.Add(this.enddate);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(53, 19);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 8;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Gray;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(595, 97);
            this.gunaShadowPanel1.TabIndex = 15;
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
            this.startdate.Location = new System.Drawing.Point(45, 24);
            this.startdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startdate.Name = "startdate";
            this.startdate.OnHoverBaseColor = System.Drawing.Color.White;
            this.startdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.startdate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.startdate.OnPressedColor = System.Drawing.Color.Black;
            this.startdate.Size = new System.Drawing.Size(217, 56);
            this.startdate.TabIndex = 1;
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
            this.enddate.Location = new System.Drawing.Point(325, 24);
            this.enddate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.enddate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.enddate.Name = "enddate";
            this.enddate.OnHoverBaseColor = System.Drawing.Color.White;
            this.enddate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.enddate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.enddate.OnPressedColor = System.Drawing.Color.Black;
            this.enddate.Size = new System.Drawing.Size(198, 56);
            this.enddate.TabIndex = 0;
            this.enddate.Text = "10/11/23";
            this.enddate.Value = new System.DateTime(2023, 11, 10, 17, 18, 0, 976);
            this.enddate.ValueChanged += new System.EventHandler(this.enddate_ValueChanged);
            // 
            // depart
            // 
            this.depart.BackColor = System.Drawing.Color.Transparent;
            this.depart.BaseColor = System.Drawing.Color.White;
            this.depart.Controls.Add(this.cbdepart);
            this.depart.Location = new System.Drawing.Point(693, 19);
            this.depart.Name = "depart";
            this.depart.Radius = 8;
            this.depart.ShadowColor = System.Drawing.Color.Gray;
            this.depart.Size = new System.Drawing.Size(299, 97);
            this.depart.TabIndex = 16;
            // 
            // cbdepart
            // 
            this.cbdepart.BackColor = System.Drawing.Color.Transparent;
            this.cbdepart.BaseColor = System.Drawing.Color.White;
            this.cbdepart.BorderColor = System.Drawing.Color.Silver;
            this.cbdepart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbdepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdepart.FocusedColor = System.Drawing.Color.Empty;
            this.cbdepart.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbdepart.ForeColor = System.Drawing.Color.Black;
            this.cbdepart.FormattingEnabled = true;
            this.cbdepart.Location = new System.Drawing.Point(52, 35);
            this.cbdepart.Name = "cbdepart";
            this.cbdepart.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbdepart.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbdepart.Size = new System.Drawing.Size(196, 35);
            this.cbdepart.TabIndex = 0;
            this.cbdepart.SelectedValueChanged += new System.EventHandler(this.cbdepart_SelectedValueChanged);
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
            this.btnin.Location = new System.Drawing.Point(1052, 39);
            this.btnin.Name = "btnin";
            this.btnin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnin.OnHoverImage = null;
            this.btnin.OnPressedColor = System.Drawing.Color.Black;
            this.btnin.Size = new System.Drawing.Size(148, 77);
            this.btnin.TabIndex = 18;
            this.btnin.Text = "Xuất báo cáo";
            this.btnin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnin.Click += new System.EventHandler(this.btnin_Click_1);
            // 
            // dvgSno
            // 
            this.dvgSno.FillWeight = 50F;
            this.dvgSno.HeaderText = "SR#";
            this.dvgSno.MinimumWidth = 50;
            this.dvgSno.Name = "dvgSno";
            // 
            // dvgname
            // 
            this.dvgname.HeaderText = "Tên món";
            this.dvgname.MinimumWidth = 8;
            this.dvgname.Name = "dvgname";
            // 
            // dvgquantity
            // 
            this.dvgquantity.HeaderText = "Số lượng";
            this.dvgquantity.MinimumWidth = 8;
            this.dvgquantity.Name = "dvgquantity";
            // 
            // UCsalereport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.depart);
            this.Controls.Add(this.grdsalereport);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "UCsalereport";
            this.Size = new System.Drawing.Size(1648, 757);
            this.Load += new System.EventHandler(this.UCsalereport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdsalereport)).EndInit();
            this.gunaShadowPanel1.ResumeLayout(false);
            this.depart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaDataGridView grdsalereport;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaDateTimePicker startdate;
        private Guna.UI.WinForms.GunaDateTimePicker enddate;
        private Guna.UI.WinForms.GunaShadowPanel depart;
        private Guna.UI.WinForms.GunaComboBox cbdepart;
        private Guna.UI.WinForms.GunaButton btnin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgquantity;
    }
}
