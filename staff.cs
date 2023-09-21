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
    public partial class staff : Form
    {
        public staff()
        {
            InitializeComponent();
          
        }
         public void GetData()
        {
            string qry = " Select ID, StaffName, Phone, Role, UserName, Password from Staff where StaffName Like '%" + txtsearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dvgIDNO);                     
            lb.Items.Add(dvgName);
            lb.Items.Add(dvgphone);
            lb.Items.Add(dvgrole);
            lb.Items.Add(dvguser);
            lb.Items.Add(dvgpass);

            mainClass.LoadData(qry, grdstaff, lb);
        }
        private void btnaddstaff_Click(object sender, EventArgs e)
        {                               
            mainClass.Blurbackground(new addstaff());
            GetData();
        }
       
        private void btndelete_Click(object sender, EventArgs e)
        {
           
        }
        private void staff_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void grdstaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void grdstaff_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            if (grdstaff.CurrentCell.OwningColumn.Name == "dvgedit")
            {
                addstaff cate = new addstaff();
                cate.id = Convert.ToInt32(grdstaff.CurrentRow.Cells["dvgIDNO"].Value);
                cate.txtuser.Text = Convert.ToString(grdstaff.CurrentRow.Cells["dvguser"].Value);
                cate.txtpass.Text = Convert.ToString(grdstaff.CurrentRow.Cells["dvgpass"].Value);
                cate.txttennv.Text = Convert.ToString(grdstaff.CurrentRow.Cells["dvgName"].Value);
                cate.txtsdt.Text = Convert.ToString(grdstaff.CurrentRow.Cells["dvgphone"].Value);
                cate.txtchucvu.Text = Convert.ToString(grdstaff.CurrentRow.Cells["dvgrole"].Value);
                mainClass.Blurbackground(cate);
                GetData();
            }
            if (grdstaff.CurrentCell.OwningColumn.Name == "dvgdel")
            {

                int id = Convert.ToInt32(grdstaff.CurrentRow.Cells["dvgIDNO"].Value);
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string qry = "Delete from Staff where ID = '" + id + "' ";
                    Hashtable ht = new Hashtable();
                    mainClass.sql(qry, ht);
                 
                    GetData();
                }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
