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
using System.IO;

namespace qlnh1
{
    public partial class UcAddProduct : UserControl
    {
        public int id = 0;
        public int cID = 0;

        public UcAddProduct()
        {
            InitializeComponent();
        }

        private void UcAddProduct_Load(object sender, EventArgs e)
        {
            string qry = "select ID ,TypeName from ProductType";
            mainClass.cbfill(qry, cbcat, "TypeName", "ID");
            if (cID > 0)
            {
                cbcat.SelectedValue = cID;
            }

            if (id > 0)
            {
                updateloaddata();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "insert into Product values(@name,@price,@img,@catid,@DVT)";
            }
            else
            {
                qry = "update  Product set  Name =@name, Price=@price, TypeID=@catid,Image=@img, Unit= @DVT where ID= @id";
            }
            //image
            Image temp = new Bitmap(txtimage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            imageByteArray = ms.ToArray();
            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@name", txttenmon.Text);
            ht.Add("@price", txtgia.Text);
            ht.Add("@catid", Convert.ToInt32(cbcat.SelectedValue));
            ht.Add("@img", imageByteArray);
            ht.Add("@DVT", cbDVT.Text);

            if (mainClass.sql(qry, ht) > 0)
            {
                MessageBox.Show("Thêm thành công");
                id = 0;
                cID = 0;
                txttenmon.Text = "";
                txtgia.Text = "";
                cbcat.SelectedIndex = 0;
                cbcat.SelectedIndex = -1;
                txtimage.Image = qlnh1.Properties.Resources.burger;
                txttenmon.Focus();
            }
        }
        string filepath;
        byte[] imageByteArray;
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)!* .png; |* .jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                txtimage.Image = new Bitmap(filepath);
            }
        }
        private void updateloaddata()
        {
            string qry = @"select * from Product where ID ='" + id + "'";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            DataTable dt = new DataTable();

            if (dt.Rows.Count > 0)
            {
                txttenmon.Text = dt.Rows[0]["Name"].ToString();
                txtgia.Text = dt.Rows[0]["Price"].ToString();

                Byte[] imageArray = (Byte[])(dt.Rows[0]["Image"]);
                Byte[] imageByteArray = imageArray;
                txtimage.Image = Image.FromStream(new MemoryStream(imageArray));

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
