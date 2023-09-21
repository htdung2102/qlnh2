
namespace qlnh1
{
    partial class PayMethod
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
            this.PayMethodPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // PayMethodPanel
            // 
            this.PayMethodPanel.Location = new System.Drawing.Point(4, 1);
            this.PayMethodPanel.Name = "PayMethodPanel";
            this.PayMethodPanel.Size = new System.Drawing.Size(579, 405);
            this.PayMethodPanel.TabIndex = 0;
            // 
            // PayMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 418);
            this.Controls.Add(this.PayMethodPanel);
            this.Name = "PayMethod";
            this.Text = "PayMethod";
            this.Load += new System.EventHandler(this.PayMethod_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PayMethodPanel;
    }
}