using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace qlnh1
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }
        public int id = 0;
        private void txtcusphone_Enter(object sender, EventArgs e)
        {
            
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            string qry = @"Update Customer set CustomerName = @CustomerName, Phone = @Phone WHERE ID = @id";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@CustomerName", txtcusname.Text);
            cmd.Parameters.AddWithValue("@Phone", txtcusphone.Text);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            cmd.ExecuteNonQuery();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            MessageBox.Show("Cập nhật thành công");
            this.Close();
        }
    }
}
