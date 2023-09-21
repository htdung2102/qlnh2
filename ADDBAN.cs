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
    public partial class ADDBAN : Form
    {
        

        public int  id = 0 ;
        public int cID = 0;


   
        public ADDBAN()
        {
            InitializeComponent();
          //  tbl = tb;
        }
              
        private void ADDBAN_Load(object sender, EventArgs e)
        {
            string qry = "select TypeID , TypeName from TableType";
            mainClass.cbfill(qry, cbtabletype, "TypeName", "TypeID");
            if (cID > 0)
            {
                cbtabletype.SelectedValue = cID;
            }

            if (id > 0)
            {
                updateloaddata();
            }

        }
        private void btnsave_Click(object sender, EventArgs e)
        {        
            string qry ="";

            if (id == 0)
            {
                qry = "insert into TableList values(@name, NULL, @tabletype)";             

            }
             else 
            {

                qry = "update TableList set TableName =@name, TypeID = @tabletype  where  ID= @id";
           
            }
           
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@name", txttenban.Text);
            ht.Add("@tabletype", cbtabletype.SelectedValue);

            if (mainClass.sql(qry, ht) > 0)
            {
                MessageBox.Show("Thêm thành công");
                id = 0;
                txttenban.Text = "";
                txttenban.Focus();              
            }
        }
        private void updateloaddata()
        {
            string qry = @"select * from TableList where ID ='" + id + "'";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            DataTable dt = new DataTable();

            if (dt.Rows.Count > 0)
            {
                txttenban.Text = dt.Rows[0]["TableName"].ToString();
                
               
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
