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
    public partial class UCviewtableList : UserControl
    {
        public int id = 0;
        public int cID = 0;
        public UCviewtableList()
        {
            InitializeComponent();
        }
   

        private void UCviewtableList_Load(object sender, EventArgs e)
        {
            string qry = "select TypeID , TypeName from TableType ";
            mainClass.cbfill(qry, cbtype, "TypeName", "TypeID");
            if (cID > 0)
            {
                cbtype.SelectedValue = cID;
            }
            if (id > 0)
            {
                GetData();
            }
            
        }
        private void GetData()
        {
            string qry = " select ID, TableName, TableStatus, TypeName from TableList tl inner join TableType tt on tl.TypeID = tt.TypeID ";
            string selectedtype = cbtype.SelectedItem != null ? cbtype.SelectedItem.ToString() : "All";
            Hashtable ht = new Hashtable();
            bool whereClauseAdded = false;

            if (selectedtype != "All")
            {
                qry += " Where tt.TypeID = @TypeID";
                ht.Add("@TypeID", (int)cbtype.SelectedValue);
                whereClauseAdded = true;
            }

            string searchValue = txtsearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchValue))
            {
                qry += whereClauseAdded ? " And" : " Where";
                qry += " TableName LIKE @TableName";
                ht.Add("@TableName", "%" + searchValue + "%");
            }

            ListBox lb = new ListBox();
            lb.Items.Add(dvgid);
            lb.Items.Add(dvgName);
            lb.Items.Add(dvgstatus);
            lb.Items.Add(dvgtype);

            mainClass.LoadData(qry, grdtable, lb, ht);
        }
        private void grdtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdtable.CurrentCell.OwningColumn.Name == "dvgedit")
            {
                ADDBAN cate = new ADDBAN();
                cate.id = Convert.ToInt32(grdtable.CurrentRow.Cells["dvgid"].Value);
                cate.txttenban.Text = Convert.ToString(grdtable.CurrentRow.Cells["dvgName"].Value);
                mainClass.Blurbackground(cate);
                GetData();
            }
            if (grdtable.CurrentCell.OwningColumn.Name == "dvgdel")
            {
                string id = Convert.ToString(grdtable.CurrentRow.Cells["dvgid"].Value);
                string qry = "Delete from TableList where ID = '" + id + "' ";
                Hashtable ht = new Hashtable();
                mainClass.sql(qry, ht);

                MessageBox.Show("Xóa thành công");
                GetData();
            }
        }

        private void cbtype_SelectedValueChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
