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
    public partial class UCViewVoucher : UserControl
    {
        public UCViewVoucher()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = @"Select * from Discount";
            ListBox lb = new ListBox();
            lb.Items.Add(dvgid);
            lb.Items.Add(dvgcode);
            lb.Items.Add(dvgdes);
            lb.Items.Add(dvgvalue);
            lb.Items.Add(dvgtypeID);
            lb.Items.Add(dvgstart);
            lb.Items.Add(dvgend);
            lb.Items.Add(dvgpoint);

            mainClass.LoadData(qry, grdvoucher, lb);
        }
        private void UCViewVoucher_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void grdvoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdvoucher.CurrentCell.OwningColumn.Name == "dvgedit")
            {
                AddVoucher cate = new AddVoucher();
                cate.id = Convert.ToInt32(grdvoucher.CurrentRow.Cells["dvgid"].Value);
                cate.txtcode.Text = Convert.ToString(grdvoucher.CurrentRow.Cells["dvgcode"].Value);
                cate.txtdescription.Text = Convert.ToString(grdvoucher.CurrentRow.Cells["dvgdes"].Value);
                cate.txtvalue.Text = Convert.ToString(grdvoucher.CurrentRow.Cells["dvgvalue"].Value);
                cate.cID = Convert.ToInt32(grdvoucher.CurrentRow.Cells["dvgtypeID"].Value);
                cate.startdate.Text = Convert.ToString(grdvoucher.CurrentRow.Cells["dvgstart"].Value);
                cate.enddate.Text = Convert.ToString(grdvoucher.CurrentRow.Cells["dvgend"].Value);
                cate.txtpoint.Text = Convert.ToString(grdvoucher.CurrentRow.Cells["dvgpoint"].Value);

                mainClass.Blurbackground(cate);
                GetData();


            }
        }
    }
}
