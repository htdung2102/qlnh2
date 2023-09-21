
namespace qlnh1
{
    partial class ChangeTable
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
            this.TypePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tablepanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // TypePanel
            // 
            this.TypePanel.BackColor = System.Drawing.Color.White;
            this.TypePanel.Location = new System.Drawing.Point(24, 37);
            this.TypePanel.Name = "TypePanel";
            this.TypePanel.Size = new System.Drawing.Size(776, 83);
            this.TypePanel.TabIndex = 1;
            this.TypePanel.Click += new System.EventHandler(this.Type_Click);
            // 
            // tablepanel
            // 
            this.tablepanel.BackColor = System.Drawing.Color.White;
            this.tablepanel.Location = new System.Drawing.Point(24, 137);
            this.tablepanel.Name = "tablepanel";
            this.tablepanel.Size = new System.Drawing.Size(776, 393);
            this.tablepanel.TabIndex = 2;
            this.tablepanel.Click += new System.EventHandler(this.b_click);
            // 
            // ChangeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(66)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(826, 542);
            this.Controls.Add(this.TypePanel);
            this.Controls.Add(this.tablepanel);
            this.Name = "ChangeTable";
            this.Text = "ChangeTable";
            this.Load += new System.EventHandler(this.ChangeTable_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel TypePanel;
        private System.Windows.Forms.FlowLayoutPanel tablepanel;
    }
}