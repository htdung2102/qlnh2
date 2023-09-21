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

    public partial class ucproduct : UserControl
    {
        public ucproduct()
        {
            InitializeComponent();
        }
        public event EventHandler onSelect = null;
        public int id { get; set; }
        public string pprice { get; set; }
        /*{
            get { return lblprice.Text; }
            set { lblprice.Text = value; }
        }*/
        public string pcategory { get; set; }
        public string pname
        {
            get { return lblname.Text; }
            set { lblname.Text = value; }
        }
        public Image pimage
        {
            get { return txtimage.Image; }
            set { txtimage.Image = value; }
        }
        public string punit { get; set; }
        private void ucproduct_Load(object sender, EventArgs e)
        {

        }

        private void txtimage_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
