using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlnh1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void addusercontrol(UserControl userControl)
        {
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            userControl.BringToFront();
            userControl.Dock = DockStyle.Fill;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            UcAddProduct uc = new UcAddProduct();
           
            addusercontrol(uc);
            
        }

        private void btnviewproduct_Click(object sender, EventArgs e)
        {
            ViewProduct vp = new ViewProduct();
            addusercontrol(vp);
        }

        private void btnaddcategory_Click(object sender, EventArgs e)
        {
            addcategory add = new addcategory();
            add.Show();
        }

        private void btnviewcagory_Click(object sender, EventArgs e)
        {
            UCviewcategory ucv = new UCviewcategory();
            addusercontrol(ucv);
        }
    }
}
