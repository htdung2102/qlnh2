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
    public partial class product : Form
    {
        
        public product()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            // string qry = "select IDNO, MAMON,TENMON,GIA, c.TENNHOM from MONAN p inner join NHOMMONAN c ON c.MANHOM = p.MANHOM ";
            string qry = "SELECT P.ID, P.ProductID, P.Name, P.Price, PT.ID, PT.TypeName, P.Unit FROM Product P INNER JOIN ProductType PT ON P.TypeID = PT.ID";

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
        public virtual void btnadd_Click(object sender, EventArgs e)
        {
            mainClass.Blurbackground(new addproduct());
            GetData();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

           
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        public virtual void product_Load(object sender, EventArgs e)
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

        private void btnviewcagory_Click(object sender, EventArgs e)
        {
            category ct = new category();
            ct.Show();
        }
    }
}
