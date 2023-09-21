using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace qlnh1
{
    public partial class tableview : Form
    {
        
        public tableview()
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
        private void tableview_Load(object sender, EventArgs e)
        {
          //  GetData();
        }

        private void grdtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnaddtable_Click(object sender, EventArgs e)
        {
            
            mainClass.Blurbackground(new ADDBAN());
            //GetData();
        }

        private void grdtable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnaddtabletype_Click(object sender, EventArgs e)
        {
            AddTableType add = new AddTableType();
            add.ShowDialog();
        }

        private void btnbook_Click(object sender, EventArgs e)
        {
           
        }

        private void btnviewtable_Click(object sender, EventArgs e)
        {
            UCviewtableList vt = new UCviewtableList();
            addusercontrol(vt);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            UCReservationList rv = new UCReservationList();
            addusercontrol(rv);
        }

        private void btnviewtabletype_Click(object sender, EventArgs e)
        {
            UCviewtableType tt = new UCviewtableType();
            addusercontrol(tt);
        }
    }
}
