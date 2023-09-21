
namespace qlnh1
{
    partial class product
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
            this.btnviewcagory = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnadd = new Guna.UI.WinForms.GunaImageButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdproduct)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdproduct
            // 
            this.grdproduct.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grdproduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdproduct.BackgroundColor = System.Drawing.Color.White;
            this.grdproduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdproduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdproduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdproduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdproduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdproduct.EnableHeadersVisualStyles = false;
            this.grdproduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grdproduct.Location = new System.Drawing.Point(79, 142);
            this.grdproduct.Name = "grdproduct";
            this.grdproduct.RowHeadersVisible = false;
            this.grdproduct.RowHeadersWidth = 62;
            this.grdproduct.RowTemplate.Height = 28;
            this.grdproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdproduct.Size = new System.Drawing.Size(1496, 439);
            this.grdproduct.TabIndex = 8;
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
            // btnviewcagory
            // 
            this.btnviewcagory.AnimationHoverSpeed = 0.07F;
            this.btnviewcagory.AnimationSpeed = 0.03F;
            this.btnviewcagory.BaseColor = System.Drawing.Color.DarkCyan;
            this.btnviewcagory.BorderColor = System.Drawing.Color.Black;
            this.btnviewcagory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnviewcagory.FocusedColor = System.Drawing.Color.Empty;
            this.btnviewcagory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnviewcagory.ForeColor = System.Drawing.Color.White;
            this.btnviewcagory.Image = null;
            this.btnviewcagory.ImageSize = new System.Drawing.Size(20, 20);
            this.btnviewcagory.Location = new System.Drawing.Point(152, 3);
            this.btnviewcagory.Name = "btnviewcagory";
            this.btnviewcagory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnviewcagory.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnviewcagory.OnHoverForeColor = System.Drawing.Color.White;
            this.btnviewcagory.OnHoverImage = null;
            this.btnviewcagory.OnPressedColor = System.Drawing.Color.Black;
            this.btnviewcagory.Size = new System.Drawing.Size(163, 87);
            this.btnviewcagory.TabIndex = 9;
            this.btnviewcagory.Text = "View Category";
            this.btnviewcagory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnviewcagory.Click += new System.EventHandler(this.btnviewcagory_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.btnviewcagory);
            this.gunaPanel1.Controls.Add(this.btnadd);
            this.gunaPanel1.Location = new System.Drawing.Point(12, 12);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1654, 93);
            this.gunaPanel1.TabIndex = 11;
            // 
            // btnadd
            // 
            this.btnadd.BackgroundImage = global::qlnh1.Properties.Resources.add;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnadd.Image = null;
            this.btnadd.ImageSize = new System.Drawing.Size(64, 64);
            this.btnadd.Location = new System.Drawing.Point(17, 22);
            this.btnadd.Name = "btnadd";
            this.btnadd.OnHoverImage = null;
            this.btnadd.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnadd.Size = new System.Drawing.Size(55, 55);
            this.btnadd.TabIndex = 7;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::qlnh1.Properties.Resources.pen;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 213;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::qlnh1.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 214;
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1678, 914);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.grdproduct);
            this.Name = "product";
            this.Text = "product";
            this.Load += new System.EventHandler(this.product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdproduct)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI.WinForms.GunaImageButton btnadd;
        private Guna.UI.WinForms.GunaDataGridView grdproduct;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
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
        private Guna.UI.WinForms.GunaButton btnviewcagory;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
    }
}