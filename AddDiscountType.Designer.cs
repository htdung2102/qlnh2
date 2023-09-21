
namespace qlnh1
{
    partial class AddDiscountType
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
            this.btnsave = new Guna.UI.WinForms.GunaButton();
            this.txtdistype = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.AnimationHoverSpeed = 0.07F;
            this.btnsave.AnimationSpeed = 0.03F;
            this.btnsave.BaseColor = System.Drawing.Color.SteelBlue;
            this.btnsave.BorderColor = System.Drawing.Color.Black;
            this.btnsave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnsave.FocusedColor = System.Drawing.Color.Empty;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Image = null;
            this.btnsave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnsave.Location = new System.Drawing.Point(114, 114);
            this.btnsave.Name = "btnsave";
            this.btnsave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnsave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnsave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnsave.OnHoverImage = null;
            this.btnsave.OnPressedColor = System.Drawing.Color.Black;
            this.btnsave.Size = new System.Drawing.Size(127, 44);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Lưu";
            this.btnsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtdistype
            // 
            this.txtdistype.BaseColor = System.Drawing.Color.White;
            this.txtdistype.BorderColor = System.Drawing.Color.Silver;
            this.txtdistype.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdistype.FocusedBaseColor = System.Drawing.Color.White;
            this.txtdistype.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtdistype.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdistype.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdistype.Location = new System.Drawing.Point(35, 33);
            this.txtdistype.Name = "txtdistype";
            this.txtdistype.PasswordChar = '\0';
            this.txtdistype.SelectedText = "";
            this.txtdistype.Size = new System.Drawing.Size(290, 46);
            this.txtdistype.TabIndex = 7;
            this.txtdistype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddDiscountType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 232);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtdistype);
            this.Name = "AddDiscountType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDiscountType";
            this.Load += new System.EventHandler(this.AddDiscountType_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnsave;
        public Guna.UI.WinForms.GunaTextBox txtdistype;
    }
}