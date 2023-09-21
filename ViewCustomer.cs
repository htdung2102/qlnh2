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

namespace qlnh1
{
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = @"
               ;WITH W AS (SELECT tb.CustomerID, COUNT(tb.ID) AS PurchaseCount, SUM(tb.total) AS TotalSpent
            FROM tblorder tb inner join Customer C ON tb.CustomerID = c.ID
            GROUP BY CustomerID)
            SELECT C.ID, C.CustomerName, C.Phone, w.PurchaseCount, w.TotalSpent, c.Levels, c.Scores 
            FROM W LEFT JOIN Customer C ON W.CustomerID = C.ID
             WHERE C.CustomerName LIKE '%" + txtsearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dvgid);
            lb.Items.Add(dvgName);
            lb.Items.Add(dvgphone);
            lb.Items.Add(dvgCount);
            lb.Items.Add(dvgSpent);
            lb.Items.Add(dvglevel);
            lb.Items.Add(dvgscore);

            mainClass.LoadData(qry, grdcustomer, lb);
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void grdcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdcustomer.CurrentCell.OwningColumn.Name == "dvgedit")
            {
                UpdateCustomer cate = new UpdateCustomer();
                cate.id = Convert.ToInt32(grdcustomer.CurrentRow.Cells["dvgid"].Value);
                cate.txtcusname.Text = Convert.ToString(grdcustomer.CurrentRow.Cells["dvgName"].Value);
                cate.txtcusphone.Text = Convert.ToString(grdcustomer.CurrentRow.Cells["dvgphone"].Value);
                mainClass.Blurbackground(cate);
                GetData();


            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
