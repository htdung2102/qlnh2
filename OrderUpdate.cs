using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace qlnh1
{
    public partial class OrderUpdate : Form
    {
        public pos ps;
        public int mainID;
        private string CustomerID;
        private string TableID;
      

        private void loadtablename()
        {
            TableID = ps.TableID1;

            string qry = "SELECT TableName FROM TableList WHERE ID= @TableID";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@TableID", TableID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            string TableName = cmd.ExecuteScalar().ToString();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            TableName = lblban.Text;
        }
        public OrderUpdate(pos p)
        {
            InitializeComponent();
            ps = p;
            this.Shown += new EventHandler(this.OrderUpdate_Shown);
        }
        private void OrderUpdate_Load(object sender, EventArgs e)
        {          
            grdorderupdate.BorderStyle = BorderStyle.FixedSingle;
            Addcategory();
            productpanel.Controls.Clear();
            loadproduct();
            lblban.Text = "";
          //  LoadOrderDetails();
            loadtablename();
        }
        private void OrderUpdate_Shown(object sender, EventArgs e)
        {
            LoadOrderDetails();
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
                // Hiển thị tất cả món ăn trong productpanel
                foreach (var item in productpanel.Controls)
                {
                    var pro = (ucproduct)item;
                    pro.Visible = true;
                }
            }
            else
            {
                // Lọc món ăn theo nhóm khi nút khác được nhấn
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
                foreach (DataGridViewRow Item in grdorderupdate.Rows)
                {
                    if (Convert.ToInt32(Item.Cells["ProID"].Value) == wdg.id)
                    {
                        Item.Cells["dvgamount"].Value = int.Parse(Item.Cells["dvgamount"].Value.ToString()) + 1;
                        Item.Cells["dvgtotal"].Value = int.Parse(Item.Cells["dvgamount"].Value.ToString()) * double.Parse(Item.Cells["dvgprice"].Value.ToString());
                        gettotal();
                        return;
                    }
                }
                // Add the new item to the data source instead of directly to the DataGridView
                DataTable dt = (DataTable)grdorderupdate.DataSource;
                DataRow newRow = dt.NewRow();
                newRow.ItemArray = new object[] { 0, wdg.id, wdg.pname, wdg.punit,1, wdg.pprice, wdg.pprice };              
                dt.Rows.Add(newRow);
                grdorderupdate.Rows[grdorderupdate.Rows.Count - 1].Cells["dvgtick"].Value = false;
                gettotal();
            }; 
        }
       
        private void loadproduct()
        {
            string qry = "SELECT * FROM Product P INNER JOIN ProductType PT ON P.TypeID = PT.ID";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt); foreach (DataRow Item in dt.Rows)
            {
                Byte[] imagearray = (byte[])Item["Image"];
                byte[] imagebytearray = imagearray;

                additem("0", Item["ID"].ToString(), Item["Name"].ToString(), Item["TypeName"].ToString(), Item["Unit"].ToString(), Item["Price"].ToString(), Image.FromStream(new MemoryStream(imagearray)));
            }
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void grdorder_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
        private void grdorder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdorderupdate.Columns[e.ColumnIndex].Name == "dvgadd")
            {
                grdorderupdate.Rows[e.RowIndex].Cells["dvgamount"].Value = (int)grdorderupdate.Rows[e.RowIndex].Cells["dvgamount"].Value + 1;
                grdorderupdate.Rows[e.RowIndex].Cells["dvgtotal"].Value = int.Parse(grdorderupdate.Rows[e.RowIndex].Cells["dvgamount"].Value.ToString()) * double.Parse(grdorderupdate.Rows[e.RowIndex].Cells["dvgprice"].Value.ToString());
                gettotal();
                return;
            }
            else if (grdorderupdate.Columns[e.ColumnIndex].Name == "dvgsub")
            {
                grdorderupdate.Rows[e.RowIndex].Cells["dvgamount"].Value = (int)grdorderupdate.Rows[e.RowIndex].Cells["dvgamount"].Value - 1;
                grdorderupdate.Rows[e.RowIndex].Cells["dvgtotal"].Value = int.Parse(grdorderupdate.Rows[e.RowIndex].Cells["dvgamount"].Value.ToString()) * double.Parse(grdorderupdate.Rows[e.RowIndex].Cells["dvgprice"].Value.ToString());
                gettotal();
                return;
            }
            grdorderupdate.Update();
        }
     
        private void LoadOrderDetails()
        {
            string TblName = lblban.Text;           
            string qry1 = @"SELECT OD.DetailID, OD.ProductID, P.Name, P.Unit, OD.Quantity, P.Price, OD.quantity * P.Price AS Amount
                   FROM tblorder O
                   inner join OrderDetails OD ON O.ID = OD.orderID
                   INNER JOIN Product P ON OD.ProductID = P.ID 
                    INNER JOIN TableList T ON T.ID = O.TableID
                    WHERE T.TableName = @TblName AND O.payStatus = 'Pending' ";
            // Tạo một Hashtable để lưu trữ các tham số và giá trị tương ứng
            Hashtable ht = new Hashtable();
            ht.Add("@TblName ", TblName);

            // Tạo một ListBox và thêm các cột DataGridView vào nó
            ListBox lb = new ListBox();
            lb.Items.Add(dvgIDNO);
            lb.Items.Add(ProID); 
            lb.Items.Add(dvgName);
            lb.Items.Add(dvgDVT);
            lb.Items.Add(dvgamount);
            lb.Items.Add(dvgprice);
            lb.Items.Add(dvgtotal);
            mainClass.LoadData(qry1, grdorderupdate, lb, ht);
            foreach (DataGridViewRow row in grdorderupdate.Rows)
            {
                row.Cells["dvgtick"].Value = true;
            }
           
            grdorderupdate.Refresh();
         
            //Load tổng tiền 
            string qry4 = @"SELECT sum(OD.quantity * P.Price) as total 
                            FROM tblorder O
                                    inner join OrderDetails OD ON O.ID = OD.orderID
                                    left join Product P ON P.ID = OD.productID
                            INNER JOIN  TableList T ON T.ID = O.TableID
                            WHERE T.TableName = @tname AND O.payStatus = 'Pending' ";
            SqlCommand cmd4 = new SqlCommand(qry4, mainClass.con);
            cmd4.Parameters.AddWithValue("@tname", lblban.Text);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            string result = cmd4.ExecuteScalar().ToString();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            Decimal total;
            if (result != null && decimal.TryParse(result.ToString(), out total))
            {
                // Định dạng giá trị của btnTotal dưới dạng tiền tệ
                btnTotal.Text= total.ToString("N0");
            }
           

            string qry6 = @"select NoCustomer from tblorder 
                where TableID = @tname AND payStatus = 'Pending' ";
            SqlCommand cmd6 = new SqlCommand(qry6, mainClass.con);
            cmd6.Parameters.AddWithValue("@tname", TableID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            string tbname = cmd6.ExecuteScalar().ToString();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            txtsokhach.Text = tbname;

            string qry = "SELECT CustomerID FROM tblOrder where TableID = @tname1 AND payStatus = 'Pending'";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@tname1", TableID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            string customerId = cmd.ExecuteScalar().ToString();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }

            if (!string.IsNullOrEmpty(customerId))
            {
                // Nếu order đã có CustomerID, lấy tên khách hàng từ bảng Customer
                qry = "SELECT CustomerName FROM Customer WHERE ID = @customerId";
                cmd = new SqlCommand(qry, mainClass.con);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
                lblcusname.Text = cmd.ExecuteScalar()?.ToString();
                if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            }
        }
        private void gettotal()
        {
            double tot = 0;
            btnTotal.Text = "";
            foreach (DataGridViewRow item in grdorderupdate.Rows)
            {
                tot += item.Cells["dvgtotal"].Value != null ? double.Parse(item.Cells["dvgtotal"].Value.ToString()) : 0;
            }
            btnTotal.Text = tot.ToString("N0");
        }
        private void btnIN_Click(object sender, EventArgs e)
        {
           // bool hasChanges = false;
            
            string qry1 = @"Update tblorder set total= @total,CustomerID = @cusID, NoCustomer = @NoCustomer where TableID = @tbname AND payStatus = 'Pending'";
            string qry2 = ""; // OrderDetail

            Hashtable ht = new Hashtable();
            SqlCommand cmd1 = new SqlCommand(qry1, mainClass.con);
            cmd1.Parameters.AddWithValue("@total", Convert.ToDecimal(btnTotal.Text));
            cmd1.Parameters.AddWithValue("@tbname", TableID);
            cmd1.Parameters.AddWithValue("@NoCustomer", Convert.ToInt32(txtsokhach.Text));
            if (CustomerID != null)
            {
                cmd1.Parameters.AddWithValue("@cusID", CustomerID);
            }
            else
            {
                cmd1.Parameters.AddWithValue("@cusID", DBNull.Value);
            }

            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            cmd1.ExecuteNonQuery();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
           
            string qry3 = @"SELECT ID FROM tblorder WHERE TableID= @tbname AND payStatus = 'Pending'";
            SqlCommand cmd3 = new SqlCommand(qry3, mainClass.con);
            cmd3.Parameters.AddWithValue("@tbname", TableID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            mainID = (int)cmd3.ExecuteScalar();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }

            foreach (DataGridViewRow row in grdorderupdate.Rows)
            {
                
                int DetailID = Convert.ToInt32(row.Cells["dvgIDNO"].Value);
                int quantity = Convert.ToInt32(row.Cells["dvgamount"].Value);

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = mainClass.con;
                if(quantity == 0) 
                {
                    qry2 = @"DELETE FROM OrderDetails WHERE DetailID = @ID";
                }

               else if (DetailID == 0) // insert
                {
                    qry2 = @"Insert into OrderDetails(orderID, productID, quantity, Printstatus, PrintQuantity) values(@orderID, @productID, @quantity, 0,0)";
                   
                    //hasChanges = true;
                }
                else // update
                {
                    qry2 = @"Update OrderDetails Set quantity= @quantity, Printstatus = 0 Where DetailID = @ID and Printstatus = 1";
                    //hasChanges = true;
                }

                cmd2.CommandText = qry2;
                cmd2.Parameters.AddWithValue("@ID", DetailID);
                cmd2.Parameters.AddWithValue("@orderID", mainID);
                cmd2.Parameters.AddWithValue("@productID", Convert.ToInt32(row.Cells["ProID"].Value));
                cmd2.Parameters.AddWithValue("@quantity", Convert.ToInt32(row.Cells["dvgamount"].Value));

                if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
                cmd2.ExecuteNonQuery();
                if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            }
             if (grdorderupdate.RowCount == 0)
             {
                 // Update table status to null
                 string qry = @"UPDATE TableList SET TableStatus = NULL WHERE TableName = @tbname";
                 SqlCommand cmd = new SqlCommand(qry, mainClass.con);
                 cmd.Parameters.AddWithValue("@tbname", lblban.Text);
                 if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
                 cmd.ExecuteNonQuery();
                string qry5 = @"DELETE FROM tblorder WHERE TableID= @tbname AND payStatus = 'Pending'";
                SqlCommand cmd5 = new SqlCommand(qry5, mainClass.con);
                cmd5.Parameters.AddWithValue("@tbname", TableID);
                cmd5.ExecuteNonQuery();
                if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
                ps.UpdateTableColor();

             }
            
                string qry4 = @" select TL.TableName, st.StaffName,p.Name, od.quantity - ISNULL(od.PrintQuantity, 0) as quantity  from tblorder tb inner join OrderDetails od on tb.ID = od.orderID 
                                    inner join Product p on od.productID = p.ID
                                    INNER JOIN TableList tl on tb.TableID = tl.ID 
                                    INNER JOIN Staff st on tb.StaffID = st.ID 
                            where tb.TableID = @TableID and tb.payStatus = 'Pending' and od.Printstatus = 0 and  (od.quantity - ISNULL(od.PrintQuantity, 0)) >0";
                SqlCommand cmd4 = new SqlCommand(qry4, mainClass.con);
                cmd4.Parameters.Clear();
                cmd4.Parameters.AddWithValue("@TableID", TableID);
                mainClass.con.Open();
                DataTable dt = new DataTable("KitchenBill");
                SqlDataAdapter da = new SqlDataAdapter(cmd4);
                da.Fill(dt);
                mainClass.con.Close();
                KitchenBill kb = new KitchenBill();
                kb.SetDataSource(dt);
                kb.Refresh();
                BillKitchen bk = new BillKitchen();
                bk.crystalReportViewer1.ReportSource = kb;
                // IT.crystalReportViewer1.Refresh();
                bk.FormClosed += (s, args) => this.Close();
                bk.Show();
                string updateQuery = @"UPDATE OrderDetails SET Printstatus = 1 , PrintQuantity = quantity WHERE orderID = @orderID and Printstatus = 0";
                SqlCommand updateCmd = new SqlCommand(updateQuery, mainClass.con);
                updateCmd.Parameters.Clear();
                updateCmd.Parameters.AddWithValue("@orderID", mainID);
                mainClass.con.Open();
                updateCmd.ExecuteNonQuery();
                mainClass.con.Close();        
             //   this.Close();
        }

        private void grdorderupdate_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (grdorderupdate.SelectedRows.Count > 0)
            {
               
               /* int DetailID = Convert.ToInt32(grdorderupdate.SelectedRows[0].Cells["dvgIDNO"].Value);             
                string qry = @"DELETE FROM OrderDetails WHERE DetailID = @ID";
                SqlCommand cmd = new SqlCommand(qry, mainClass.con);
                cmd.Parameters.AddWithValue("@ID", DetailID);
                if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
                cmd.ExecuteNonQuery();
                if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }*/
                grdorderupdate.Rows.RemoveAt(grdorderupdate.SelectedRows[0].Index);
                gettotal();
            }
        }

        private void btncus_Click(object sender, EventArgs e)
        {
            GetCusInfo gc = new GetCusInfo();
            gc.ShowDialog();
            lblcusname.Text = gc.txtcusname.Text;
            CustomerID = gc.CustomerID;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnchangetable_Click(object sender, EventArgs e)
        {
            string currentTableName = lblban.Text;
            ChangeTable CT = new ChangeTable(this, ps, currentTableName);
            CT.Show();
        }

        private void grdorderupdate_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string[] columnNames = { "dvgtotal", "dvgprice" };

            if (columnNames.Contains(grdorderupdate.Columns[e.ColumnIndex].Name))
            {
                if (e.Value != null)
                {

                    decimal value = Convert.ToDecimal(e.Value);
                    e.Value = value.ToString("N0");
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            Transaction TS = new Transaction(this, ps);
            TS.Show();
        }
    }
}
