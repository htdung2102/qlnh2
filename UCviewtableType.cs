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
    public partial class UCviewtableType : UserControl
    {
        public UCviewtableType()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = "select * from TableType";
            ListBox lb = new ListBox();
            lb.Items.Add(dvgid);
            lb.Items.Add(dvgName);
           

            mainClass.LoadData(qry, grdtabletype, lb);
        }
        private void UCviewtableType_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void grdtabletype_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdtabletype.CurrentCell.OwningColumn.Name == "dvgdel")
            {
                int id = Convert.ToInt32(grdtabletype.CurrentRow.Cells["dvgid"].Value);
                string qry = "Delete from TableTypewhere ID = '" + id + "' ";
                Hashtable ht = new Hashtable();
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    mainClass.sql(qry, ht);
                    MessageBox.Show("Xóa thành công");
                    GetData();
                }
                else if (dialogResult == DialogResult.No)
                {

                }


            }
        }
    }
}
