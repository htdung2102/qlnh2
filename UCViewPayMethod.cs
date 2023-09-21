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
    public partial class UCViewPayMethod : UserControl
    {
        public UCViewPayMethod()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = "Select * from PaymentMethod";
            ListBox lb = new ListBox();
            lb.Items.Add(dvgid);
            lb.Items.Add(dvgName);
            lb.Items.Add(dvgIsActive);

            mainClass.LoadData(qry, grdpaymethod, lb);
        }
        private void UCViewPayMethod_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void grdpaymethod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdpaymethod.CurrentCell.OwningColumn.Name == "dvgedit")
            {
                AddPaymethod cate = new AddPaymethod();
                cate.id = Convert.ToInt32(grdpaymethod.CurrentRow.Cells["dvgid"].Value);
                cate.txttenHT.Text = Convert.ToString(grdpaymethod.CurrentRow.Cells["dvgName"].Value);
                cate.cbIsActive.Text = Convert.ToString(grdpaymethod.CurrentRow.Cells["dvgIsActive"].Value);
                mainClass.Blurbackground(cate);
                GetData();
            }
        }
    }
}
