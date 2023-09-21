
namespace qlnh1
{
    partial class DiscountList
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
            this.btncheck = new Guna.UI.WinForms.GunaButton();
            this.txtDisCode = new Guna.UI.WinForms.GunaTextBox();
            this.DiscountPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btncheck
            // 
            this.btncheck.AnimationHoverSpeed = 0.07F;
            this.btncheck.AnimationSpeed = 0.03F;
            this.btncheck.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btncheck.BorderColor = System.Drawing.Color.Black;
            this.btncheck.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btncheck.FocusedColor = System.Drawing.Color.Empty;
            this.btncheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncheck.ForeColor = System.Drawing.Color.White;
            this.btncheck.Image = null;
            this.btncheck.ImageSize = new System.Drawing.Size(20, 20);
            this.btncheck.Location = new System.Drawing.Point(725, 35);
            this.btncheck.Name = "btncheck";
            this.btncheck.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btncheck.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btncheck.OnHoverForeColor = System.Drawing.Color.White;
            this.btncheck.OnHoverImage = null;
            this.btncheck.OnPressedColor = System.Drawing.Color.Black;
            this.btncheck.Size = new System.Drawing.Size(127, 44);
            this.btncheck.TabIndex = 6;
            this.btncheck.Text = "Check";
            this.btncheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDisCode
            // 
            this.txtDisCode.BaseColor = System.Drawing.Color.White;
            this.txtDisCode.BorderColor = System.Drawing.Color.Silver;
            this.txtDisCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisCode.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDisCode.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDisCode.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDisCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDisCode.Location = new System.Drawing.Point(106, 34);
            this.txtDisCode.Name = "txtDisCode";
            this.txtDisCode.PasswordChar = '\0';
            this.txtDisCode.SelectedText = "";
            this.txtDisCode.Size = new System.Drawing.Size(581, 46);
            this.txtDisCode.TabIndex = 5;
            this.txtDisCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DiscountPanel
            // 
            this.DiscountPanel.Location = new System.Drawing.Point(12, 120);
            this.DiscountPanel.Name = "DiscountPanel";
            this.DiscountPanel.Size = new System.Drawing.Size(933, 511);
            this.DiscountPanel.TabIndex = 7;
            // 
            // DiscountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 643);
            this.Controls.Add(this.DiscountPanel);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.txtDisCode);
            this.Name = "DiscountList";
            this.Text = "DiscountList";
            this.Load += new System.EventHandler(this.DiscountList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btncheck;
        public Guna.UI.WinForms.GunaTextBox txtDisCode;
        private System.Windows.Forms.FlowLayoutPanel DiscountPanel;
    }
}