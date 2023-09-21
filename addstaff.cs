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
using VBSQLHelper;
using System.Configuration;

namespace qlnh1
{

    public partial class addstaff : Form
    {
        

        public addstaff()
        {
            InitializeComponent();
           
        }
       
        public int id = 0;
        public bool isUserInput = false;
        private void gunaLineTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
                string qry = "";
                if (id == 0)
                {
                    qry = "insert into Staff values(@username, @password, @name,@phone,@role)";
                }
                else
                {
                 qry = "update Staff set UserName = @username, Password =  @password, StaffName =@name, Phone=@phone, Role =@role where  ID= @id";
                }

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@username", txtuser.Text);
                ht.Add("@password", txtpass.Text);
                ht.Add("@name", txttennv.Text);
                ht.Add("@phone", txtsdt.Text);
                ht.Add("@role", txtchucvu.Text);

                if (mainClass.sql(qry, ht) > 0)
                {
                    //MessageBox.Show("Thêm thành công");
                    id = 0;
                    txtuser.Text = "";
                    txtpass.Text = "";
                    txttennv.Text = "";
                    txtsdt.Text = "";
                    txtchucvu.Text = "";
                    txttennv.Focus();
                }
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            if (isUserInput)
            {
                string qry = "SELECT COUNT(*) FROM Staff WHERE UserName = @username";
                SqlCommand cmd1 = new SqlCommand(qry, mainClass.con);
                cmd1.Parameters.AddWithValue("@username", txtuser.Text);
                if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
                int count = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                if (count > 0)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại");
                    return;
                }
                if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            }
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            isUserInput = true;
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            isUserInput = false;
        }
    }
}
