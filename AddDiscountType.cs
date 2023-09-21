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

namespace qlnh1
{
    public partial class AddDiscountType : Form
    {
        public AddDiscountType()
        {
            InitializeComponent();
        }
        public int id = 0;
        private void AddDiscountType_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "insert into DiscountType values(@name)";

            }
            else
            {

                qry = "update DiscountType set TypeName =@name  where  ID= @id";

            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@name", txtdistype.Text);
            if (mainClass.sql(qry, ht) > 0)
            {
                MessageBox.Show("Thêm thành công");
                id = 0;
                txtdistype.Text = "";
                txtdistype.Focus();

            }
        }
    }
}
