
namespace qlnh1
{
    partial class category
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdcategory = new Guna.UI.WinForms.GunaDataGridView();
            this.message1 = new System.Messaging.Message();
            this.dvgNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnaddcategory = new Guna.UI.WinForms.GunaImageButton();
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
            this.grdcategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdcategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdcategory.ColumnHeadersHeight = 40;
            this.grdcategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgNo,
            this.dvgid,
            this.dvgName,
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
            this.grdcategory.Location = new System.Drawing.Point(101, 37);
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
            this.grdcategory.Size = new System.Drawing.Size(744, 505);
            this.grdcategory.TabIndex = 2;
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
            this.dvgName.HeaderText = "Name";
            this.dvgName.MinimumWidth = 500;
            this.dvgName.Name = "dvgName";
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
            // btnaddcategory
            // 
            this.btnaddcategory.BackgroundImage = global::qlnh1.Properties.Resources.add;
            this.btnaddcategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddcategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnaddcategory.Image = null;
            this.btnaddcategory.ImageSize = new System.Drawing.Size(64, 64);
            this.btnaddcategory.Location = new System.Drawing.Point(870, 12);
            this.btnaddcategory.Name = "btnaddcategory";
            this.btnaddcategory.OnHoverImage = null;
            this.btnaddcategory.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnaddcategory.Size = new System.Drawing.Size(57, 55);
            this.btnaddcategory.TabIndex = 8;
            this.btnaddcategory.Click += new System.EventHandler(this.btnaddcategory_Click);
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
            // category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1023, 583);
            this.Controls.Add(this.btnaddcategory);
            this.Controls.Add(this.grdcategory);
            this.Name = "category";
            this.Text = "category";
            this.Load += new System.EventHandler(this.category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdcategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI.WinForms.GunaImageButton btnaddcategory;
        public Guna.UI.WinForms.GunaDataGridView grdcategory;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Messaging.Message message1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgName;
        private System.Windows.Forms.DataGridViewImageColumn dvgedit;
        private System.Windows.Forms.DataGridViewImageColumn dvgdel;
    }
}