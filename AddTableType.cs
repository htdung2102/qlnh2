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
    public partial class AddTableType : Form
    {
        public AddTableType()
        {
            InitializeComponent();
        }
        public int id = 0;
        private void AddTableType_Load(object sender, EventArgs e)
        {

        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "insert into TableType values(@name)";

            }
            else
            {

                qry = "update TableType set TypeName =@name  where  TypeID= @id";

            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@name", txttypename.Text);
            if (mainClass.sql(qry, ht) > 0)
            {
                MessageBox.Show("Thêm thành công");
                id = 0;
                txttypename.Text = "";
                txttypename.Focus();
            }
        }
    }
}
