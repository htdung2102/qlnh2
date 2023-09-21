using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace qlnh1
{
    public partial class order : Form
    {
        public static pos ps;
        public order(pos p)
        {
            InitializeComponent();
            ps = p;
        }
        public int mainID = 0;
        private string CustomerID;
        public string cusname = "";
        private string TableID;
        private void loadtablename()
        {
            TableID = ps.TableID;
            string qry = "SELECT TableName FROM TableList WHERE ID= @TableID";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@TableID", TableID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
         string TableName = cmd.ExecuteScalar().ToString();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            TableName = lblban.Text;
        }
        private void order_Load(object sender, EventArgs e)
        {
            grdorder.BorderStyle = BorderStyle.FixedSingle;
            Addcategory();
            productpanel.Controls.Clear();
            loadproduct();
            loadtablename();
        }

        private void grdorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if (grdorder.Columns[e.ColumnIndex].Name == "dvgadd") 
            {             
                grdorder.Rows[e.RowIndex].Cells["dvgamount"].Value = (int)grdorder.Rows[e.RowIndex].Cells["dvgamount"].Value + 1;
                grdorder.Rows[e.RowIndex].Cells["dvgtotal"].Value = int.Parse(grdorder.Rows[e.RowIndex].Cells["dvgamount"].Value.ToString()) * double.Parse(grdorder.Rows[e.RowIndex].Cells["dvgprice"].Value.ToString());
                gettotal();
                return;
            }
            else if (grdorder.Columns[e.ColumnIndex].Name == "dvgsub") 
            {              
                grdorder.Rows[e.RowIndex].Cells["dvgamount"].Value = (int)grdorder.Rows[e.RowIndex].Cells["dvgamount"].Value - 1;
                grdorder.Rows[e.RowIndex].Cells["dvgtotal"].Value = int.Parse(grdorder.Rows[e.RowIndex].Cells["dvgamount"].Value.ToString()) * double.Parse(grdorder.Rows[e.RowIndex].Cells["dvgprice"].Value.ToString());
                gettotal();
                return;
            }
            grdorder.Update();  
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Addcategory()
        {
            string qry = "select * from ProductType";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            flowLayoutPanel1.Controls.Clear();
            Guna.UI.WinForms.GunaButton allCategoryButton = new Guna.UI.WinForms.GunaButton();
            allCategoryButton.BaseColor = Color.FromArgb(29, 38, 125);
            allCategoryButton.Size = new Size(120, 60);
            allCategoryButton.Text = "All Categories";
            allCategoryButton.Image = null;
            allCategoryButton.Click += new EventHandler(b_Click);
            flowLayoutPanel1.Controls.Add(allCategoryButton);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                    b.BaseColor = Color.FromArgb(29, 38, 125);
                    b.Size = new Size(120, 60);
                    b.Text = row["TypeName"].ToString();
                    b.Image = null;

                    b.Click += new EventHandler(b_Click);
                    flowLayoutPanel1.Controls.Add(b);
                }
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaButton b = (Guna.UI.WinForms.GunaButton)sender;
            if (b == null)
            {
                return;
            }

            if (b.Text == "All Categories")
            {
                foreach (var item in productpanel.Controls)
                {
                    var pro = (ucproduct)item;
                    pro.Visible = true;
                }
            }
            else
            {
                foreach (var item in productpanel.Controls)
                {
                    var pro = (ucproduct)item;
                    pro.Visible = pro.pcategory.ToLower().Contains(b.Text.Trim().ToLower());
                }
            }
        }

        private void additem(string id, string proID, string name, string cate, string Punit, string price, Image Pimage)
        {
            var w = new ucproduct()
            {
                pname = name,
                pprice = price,
                pcategory = cate,
                pimage = Pimage,
                id = Convert.ToInt32(proID),
                punit = Punit
            };
            productpanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucproduct)ss;
                foreach (DataGridViewRow Item in grdorder.Rows)
                {
                    if (Convert.ToInt32(Item.Cells["ProID"].Value) == wdg.id)
                    {
                        Item.Cells["dvgamount"].Value = int.Parse(Item.Cells["dvgamount"].Value.ToString()) + 1;
                        Item.Cells["dvgtotal"].Value = int.Parse(Item.Cells["dvgamount"].Value.ToString()) * double.Parse(Item.Cells["dvgprice"].Value.ToString());
                        gettotal();
                        return;
                    }
                }
                grdorder.Rows.Add(new object[] { 0, 0, wdg.id, wdg.pname, wdg.punit, 1, wdg.pprice, wdg.pprice });
                gettotal();
            };

        }
        private void loadproduct()
        {
            string qry = "SELECT * FROM Product P INNER JOIN ProductType PT ON P.TypeID = PT.ID ";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); foreach (DataRow Item in dt.Rows)
            {
                Byte[] imagearray = (byte[])Item["Image"];
                byte[] imagebytearray = imagearray;

                additem("0",Item["ID"].ToString(), Item["Name"].ToString(), Item["TypeName"].ToString(), Item["Unit"].ToString(), Item["Price"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
            }

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in productpanel.Controls)
            {
                var pro = (ucproduct)item;
                pro.Visible = pro.pname.ToLower().Contains(txtsearch.Text.Trim().ToLower());
            }
        }

        private void grdorder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in grdorder.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
            string[] columnNames = { "dvgtotal", "dvgprice" };

            if (columnNames.Contains(grdorder.Columns[e.ColumnIndex].Name))
            {
                if (e.Value != null)
                {

                    decimal value = Convert.ToDecimal(e.Value);
                    e.Value = value.ToString("N0");
                    e.FormattingApplied = true;
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
       
        private void gettotal()
        {
            double tot = 0;
            btnTotal.Text = "";
            foreach (DataGridViewRow item in grdorder.Rows)
            {
                tot += item.Cells["dvgtotal"].Value != null ? double.Parse(item.Cells["dvgtotal"].Value.ToString()) : 0;
            }
            btnTotal.Text = tot.ToString("N0");
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsokhach.Text))
            {
                MessageBox.Show("Vui lòng nhập số khách.", "Thông báo", MessageBoxButtons.OK);
                return; 
            }
            int staffID = mainClass.GlobalVariables.StaffID;     
            string qry1 = ""; //Order
            string qry2 = ""; //OrderDetail
            int DetailID = 0;
            
            if (mainID == 0)//insert
            {
                qry1 = @"Insert into tblorder Values( @OrderDate, @OrderTime, @payStatus, @total, @CustomerID, @NoCustomer, @PaymethodID, @StaffID,  @DiscountID, @TableID);
                            SELECT SCOPE_IDENTITY()";
            }
            else //update
            {
                qry1 = @"Update tblorder Set payStatus = @payStatus, total = @total where ID = @ID
                            ";
            }
            Hashtable ht = new Hashtable();
            SqlCommand cmd = new SqlCommand(qry1, mainClass.con);
            cmd.Parameters.AddWithValue("@ID", mainID);
            cmd.Parameters.AddWithValue("@OrderDate", DBNull.Value);
            cmd.Parameters.AddWithValue("@OrderTime", DateTime.Now.ToShortTimeString());
            cmd.Parameters.AddWithValue("@payStatus","Pending");
            cmd.Parameters.AddWithValue("@total",Convert.ToDecimal(btnTotal.Text));
            cmd.Parameters.AddWithValue("@NoCustomer", Convert.ToInt32(txtsokhach.Text));
            cmd.Parameters.AddWithValue("@PaymethodID", DBNull.Value);            
            cmd.Parameters.AddWithValue("@StaffID", staffID);
            cmd.Parameters.AddWithValue("@DiscountID", DBNull.Value);
            cmd.Parameters.AddWithValue("@TableID", TableID);
            if (CustomerID != null)
            {
                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
            }
            else
            {
                cmd.Parameters.AddWithValue("@CustomerID", DBNull.Value);
            }

            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            if (mainID == 0)
            {
                mainID = Convert.ToInt32(cmd.ExecuteScalar()); 
            }
            else
            {
                cmd.ExecuteNonQuery();
            }
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }

            foreach (DataGridViewRow row in grdorder.Rows)
            {
                DetailID = Convert.ToInt32(row.Cells["dvgIDNO"].Value);
                int quantity = Convert.ToInt32(row.Cells["dvgamount"].Value);
                if (DetailID == 0) //insert
                {
                    qry2 = @"Insert into OrderDetails values(@orderID, @productID, @quantity, @Prinstatus, @quantity)";
                }
                else //update
                {
                    qry2 = @"Update OrderDetails Set productID= @productID, quantity= @quantity
                            Where DetailID = @ID";
                }
                SqlCommand cmd2 = new SqlCommand(qry2, mainClass.con);
                cmd2.Parameters.AddWithValue("@ID", DetailID);
                cmd2.Parameters.AddWithValue("@orderID", mainID);
                cmd2.Parameters.AddWithValue("@productID", Convert.ToInt32(row.Cells["ProID"].Value));
                cmd2.Parameters.AddWithValue("@quantity", quantity);
                cmd2.Parameters.AddWithValue("@Prinstatus", 0);
                if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
                cmd2.ExecuteNonQuery();
                if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            }           
            string qry3 = @"UPDATE TableList SET TableStatus = 'Pending' WHERE TableName = @tenBan";
            SqlCommand cmd3 = new SqlCommand(qry3, mainClass.con); 
            cmd3.Parameters.AddWithValue("@tenBan", lblban.Text);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            cmd3.ExecuteNonQuery();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }    
            ps.UpdateTableColor();
            HomeForm.Instance.UpdateOrderInfo();
            string qry = @" select TL.TableName, st.StaffName,p.Name, od.quantity from tblorder tb inner join OrderDetails od on tb.ID = od.orderID 
                                    inner join Product p on od.productID = p.ID
                                    INNER JOIN TableList tl on tb.TableID = tl.ID 
                                    INNER JOIN Staff st on tb.StaffID = st.ID 
                            where tb.TableID = @TableID and tb.payStatus = 'Pending' and od.Printstatus = 0";
            SqlCommand cmd1 = new SqlCommand(qry, mainClass.con);
            cmd1.Parameters.Clear();
            cmd1.Parameters.AddWithValue("@TableID", TableID);
            mainClass.con.Open();
            DataTable dt = new DataTable("KitchenBill");
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            mainClass.con.Close();
            KitchenBill kb = new KitchenBill();
            kb.SetDataSource(dt);
            kb.Refresh();
            BillKitchen bk = new BillKitchen();
            bk.crystalReportViewer1.ReportSource = kb;
            bk.FormClosed += (s, args) => this.Close();
            bk.Show();
            string updateQuery = @"UPDATE OrderDetails SET Printstatus = 1 WHERE orderID = @orderID and Printstatus = 0";
            SqlCommand updateCmd = new SqlCommand(updateQuery, mainClass.con);
            updateCmd.Parameters.Clear();
            updateCmd.Parameters.AddWithValue("@orderID", mainID);
    
            mainClass.con.Open();
            updateCmd.ExecuteNonQuery();
            mainClass.con.Close();    
        }
        private void btncus_Click(object sender, EventArgs e)
        {
            GetCusInfo gc = new GetCusInfo();
            gc.ShowDialog();
            lblcusname.Text = gc.txtcusname.Text;
            CustomerID = gc.CustomerID;
        }

        private void txtsokhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (grdorder.SelectedRows.Count > 0)
            {
                grdorder.Rows.RemoveAt(grdorder.SelectedRows[0].Index);
                gettotal();
            }
        }

        private void lblcusname_Click(object sender, EventArgs e)
        {

        }
    } 
}
    

