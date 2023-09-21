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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        private void addusercontrol(UserControl userControl)
        {
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
        }
        private void btnaddDiscount_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDisType_Click(object sender, EventArgs e)
        {
            AddDiscountType ADT = new AddDiscountType();
            ADT.Show();
        }

        private void btnaddvoucher_Click(object sender, EventArgs e)
        {
            AddVoucher av = new AddVoucher();
            av.Show();
        }

        private void btnviewvoucher_Click(object sender, EventArgs e)
        {
            UCViewVoucher vv = new UCViewVoucher();
            addusercontrol(vv);
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void btnaddpaymethod_Click(object sender, EventArgs e)
        {
            AddPaymethod add = new AddPaymethod();
            add.Show();
        }

        private void btnviewpaymethod_Click(object sender, EventArgs e)
        {
            UCViewPayMethod pm = new UCViewPayMethod();
            addusercontrol(pm);

        }
    }
}
