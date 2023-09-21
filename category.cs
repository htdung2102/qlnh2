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
   
    public partial class category : Form
    {

        
        public category()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string qry = "Select * from ProductType";
            ListBox lb = new ListBox();
            lb.Items.Add(dvgid);
            lb.Items.Add(dvgName);

            mainClass.LoadData(qry, grdcategory, lb);
        }
        private void btnaddcategory_Click(object sender, EventArgs e)
        {
            mainClass.Blurbackground(new addcategory());
            GetData();

        }



        private void btndelete_Click(object sender, EventArgs e)
        {
            

        }

        private void category_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void grdcategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdcategory.CurrentCell.OwningColumn.Name =="dvgedit")
            {
                addcategory cate = new addcategory();                          
                cate.id= Convert.ToInt32(grdcategory.CurrentRow.Cells["dvgid"].Value);
                cate.txttennhom.Text = Convert.ToString(grdcategory.CurrentRow.Cells["dvgName"].Value);
                mainClass.Blurbackground(cate);
                GetData();


            }
            if (grdcategory.CurrentCell.OwningColumn.Name== "dvgdel")
            {
                int id = Convert.ToInt32(grdcategory.CurrentRow.Cells["dvgid"].Value);
                string qry = "Delete from ProductType where ID = '" + id + "' ";
                Hashtable ht = new Hashtable();
                mainClass.sql(qry, ht);

                MessageBox.Show("Xóa thành công");
                GetData();


            }
        }
    }
}
