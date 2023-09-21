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
    public partial class addcategory : Form
    {
       
        public addcategory()
        {
            InitializeComponent();
           
        }
        public int id = 0;
        public int cID = 0;
        private void btnsave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "insert into ProductType values(@name, @department)";

            }
            else
            {

                qry = "update ProductType set TypeName =@name, Department =@department  where  ID= @id";

            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@name", txttennhom.Text);
            ht.Add("@department", Convert.ToInt32(cbdepart.SelectedValue));
            if (mainClass.sql(qry, ht) > 0)
            {
                MessageBox.Show("Thêm thành công");
                id = 0;
                txttennhom.Text = "";
                txttennhom.Focus();
            }



        }

        private void addcategory_Load(object sender, EventArgs e)
        {
            string qry = "select ID , Name from department";
            mainClass.cbfill(qry, cbdepart, "Name", "ID");
            if (cID > 0)
            {
                cbdepart.SelectedValue = cID;
            }
            if (id > 0)
            {
                
            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
