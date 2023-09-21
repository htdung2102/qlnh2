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
    public partial class ViewProduct : UserControl
    {
        public ViewProduct()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = @"SELECT P.ID, P.ProductID, P.Name, P.Price, PT.ID, PT.TypeName, P.Unit FROM Product P INNER JOIN ProductType PT ON P.TypeID = PT.ID WHERE P.Name LIKE '%" + txtsearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dvgIDNO);
            lb.Items.Add(dvgMAMON);
            lb.Items.Add(dvgName);
            lb.Items.Add(dvgprice);
            lb.Items.Add(dvgcatID);
            lb.Items.Add(dvgcat);
            lb.Items.Add(dvgDVT);
            mainClass.LoadData(qry, grdproduct, lb);
        }
        private void ViewProduct_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void grdproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdproduct.CurrentCell.OwningColumn.Name == "dvgedit")
            {
                addproduct cate = new addproduct();
                cate.id = Convert.ToInt32(grdproduct.CurrentRow.Cells["dvgIDNO"].Value);
                cate.cID = Convert.ToInt32(grdproduct.CurrentRow.Cells["dvgcatID"].Value);
                cate.txttenmon.Text = Convert.ToString(grdproduct.CurrentRow.Cells["dvgName"].Value);
                cate.txtgia.Text = Convert.ToString(grdproduct.CurrentRow.Cells["dvgprice"].Value);
                cate.cbDVT.Text = Convert.ToString(grdproduct.CurrentRow.Cells["dvgDVT"].Value);
                mainClass.Blurbackground(cate);
                GetData();
            }
            if (grdproduct.CurrentCell.OwningColumn.Name == "dvgdel")
            {

                int id = Convert.ToInt32(grdproduct.CurrentRow.Cells["dvgIDNO"].Value);
                string qry = "Delete from Product where ID = '" + id + "' ";
                Hashtable ht = new Hashtable();
                mainClass.sql(qry, ht);
                MessageBox.Show("Xóa thành công");
                GetData();
            }
        }

        private void grdproduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string[] columnNames = {"dvgprice" };

            if (columnNames.Contains(grdproduct.Columns[e.ColumnIndex].Name))
            {
                if (e.Value != null)
                {

                    decimal value = Convert.ToDecimal(e.Value);
                    e.Value = value.ToString("N0");
                    e.FormattingApplied = true;
                }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
