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
    public partial class AddVoucher : Form
    {
        public AddVoucher()
        {
            InitializeComponent();
        }
        public int id = 0;
        public int cID = 0;
        private void AddVoucher_Load(object sender, EventArgs e)
        {
            string qry = "select ID , TypeName from DiscountType";
            mainClass.cbfill(qry, cbtype, "TypeName", "ID");
            if (cID > 0)
            {
                cbtype.SelectedValue = cID;
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
                qry = "insert into Discount values( @Code, @Description, @DiscountValue , @TypeID, @StartDate, @EndDate, @Point)";
            }
            else
            {
                qry = "update Discount set Code =  @Code, Description = @Description, DiscountValue = @DiscountValue, TypeID = @TypeID, StartDate = @StartDate, EndDate = @EndDate, Point = @Point " +
                    "where  ID= @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Code", txtcode.Text);
            ht.Add("@Description", txtdescription.Text);
            //  ht.Add("@DiscountValue", txtvalue.Text);
            string discountType = cbtype.Text.ToString();
            if (discountType == "Percent")
            {
                // Loại bỏ ký tự '%' và chuyển đổi thành số thập phân
                string discountValue = txtvalue.Text.Replace("%", "");
                decimal percentValue = Convert.ToDecimal(discountValue) / 100;
                ht.Add("@DiscountValue", percentValue);
            }
            else
            {
                // Chuyển đổi giá trị thành số nguyên
                int fixedValue = Convert.ToInt32(txtvalue.Text);
                ht.Add("@DiscountValue", fixedValue);
            }

            ht.Add("@TypeID", cbtype.SelectedValue);
            ht.Add("@StartDate", startdate.Value.Date);
            ht.Add("@EndDate", enddate.Value.Date);
            ht.Add("@Point", Convert.ToInt32(txtpoint.Text));


            if (mainClass.sql(qry, ht) > 0)
            {
                MessageBox.Show("Thêm thành công");
                id = 0;
                txtcode.Text = "";
                txtcode.Focus();
            }
        }
        private void updateloaddata()
        {
            string qry = @"select * from Discount  where ID ='" + id + "'";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            DataTable dt = new DataTable();

            if (dt.Rows.Count > 0)
            {
                txtcode.Text = dt.Rows[0]["Code"].ToString();
                txtdescription.Text = dt.Rows[0]["description"].ToString();
                txtvalue.Text = dt.Rows[0]["value"].ToString();
                startdate.Text = dt.Rows[0]["startdate"].ToString();
                enddate.Text = dt.Rows[0]["enddate"].ToString();

            }
        }
    }
}
