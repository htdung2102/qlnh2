
namespace qlnh1
{
    partial class pos
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
            this.tablepanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabletypePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // tablepanel
            // 
            this.tablepanel.Location = new System.Drawing.Point(0, 130);
            this.tablepanel.Name = "tablepanel";
            this.tablepanel.Size = new System.Drawing.Size(1898, 894);
            this.tablepanel.TabIndex = 2;
            this.tablepanel.Click += new System.EventHandler(this.b_click);
            // 
            // tabletypePanel
            // 
            this.tabletypePanel.Location = new System.Drawing.Point(0, 4);
            this.tabletypePanel.Name = "tabletypePanel";
            this.tabletypePanel.Size = new System.Drawing.Size(1898, 120);
            this.tabletypePanel.TabIndex = 3;
            this.tabletypePanel.Click += new System.EventHandler(this.Type_Click);
            // 
            // pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.tabletypePanel);
            this.Controls.Add(this.tablepanel);
            this.Name = "pos";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.pos_FormClosed);
            this.Load += new System.EventHandler(this.pos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel tablepanel;
        private System.Windows.Forms.FlowLayoutPanel tabletypePanel;
    }
}