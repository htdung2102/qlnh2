using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace qlnh1
{
    public partial class UCrevenuebytime : UserControl
    {
        public UCrevenuebytime()
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
        private void UCrevenuebytime_Load(object sender, EventArgs e)
        {
           
        }

        private void startdate_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void enddate_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void grdrevenuebytime_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void btnday_Click(object sender, EventArgs e)
        {
            UCviewRevenuebyDay rvd = new UCviewRevenuebyDay();
            addusercontrol(rvd);
        }

        private void btnmonth_Click(object sender, EventArgs e)
        {
            UCviewRevenuebyMonth rvm = new UCviewRevenuebyMonth();
            addusercontrol(rvm);
        }
    }

}
