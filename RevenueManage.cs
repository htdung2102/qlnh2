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
    public partial class RevenueManage : Form
    {
        public RevenueManage()
        {
            InitializeComponent();
            UCrevenueOverview uCrevenueOverview = new UCrevenueOverview();

            // Thêm UCrevenueOverview vào PanelContainer
            addusercontrol(uCrevenueOverview);
        }
        private void addusercontrol(UserControl userControl)
        {
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            
        }
        private void btnrevebytime_Click(object sender, EventArgs e)
        { 
            UCrevenuebytime rv = new UCrevenuebytime();
            addusercontrol(rv);
        }

        private void btnoverview_Click(object sender, EventArgs e)
        {
            UCrevenueOverview rec = new UCrevenueOverview();
            addusercontrol(rec);
        }

        private void btnsalereport_Click(object sender, EventArgs e)
        {
            UCsalereport sl = new UCsalereport();
            addusercontrol(sl);
        }

        private void RevenueManage_Load(object sender, EventArgs e)
        {

        }

        private void btnaddpaymethod_Click(object sender, EventArgs e)
        {
            UCBillList BL = new UCBillList();
            addusercontrol(BL);
        }

        private void btnrevebycate_Click(object sender, EventArgs e)
        {
            UCrevenuebycategory cate = new UCrevenuebycategory();
            addusercontrol(cate);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ViewInvoice vi = new ViewInvoice();
            addusercontrol(vi);
        }
    }
}
