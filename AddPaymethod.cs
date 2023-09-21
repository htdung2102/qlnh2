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
    public partial class AddPaymethod : Form
    {
        public AddPaymethod()
        {
            InitializeComponent();
        }
        public int id = 0;
        
        private void AddPaymethod_Load(object sender, EventArgs e)
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "insert into PaymentMethod values(@name, @IsActive)";

            }
            else
            {

                qry = "update PaymentMethod set Name =@name, IsActive = @IsActive  where  ID= @id";

            }
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@name", txttenHT.Text);
            ht.Add("@IsActive", Convert.ToInt32(cbIsActive.Text));
            if (mainClass.sql(qry, ht) > 0)
            {
                MessageBox.Show("Thêm thành công");
                id = 0;
                txttenHT.Text = "";
                txttenHT.Focus();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
