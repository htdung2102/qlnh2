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
using CrystalDecisions.CrystalReports.Engine;

namespace qlnh1
{
    public partial class Transaction : Form
    {
        public static OrderUpdate OD;
        public static pos ps;
        public Transaction(OrderUpdate Od, pos p)
        {
            InitializeComponent();
            OD = Od;
            ps = p;
        }
        private string DiscountID;
        private string TableID;
        bool hasPrinted = false;
        private void loadtablename()
        {
            TableID = ps.TableID1;

            string qry = "SELECT TableName FROM TableList WHERE ID= @TableID";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@TableID", TableID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            string TableName = cmd.ExecuteScalar().ToString();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            this.lblban.Text = TableName;
        }   
        private void LoadOrderDetails()
        {
            string qry1 = @"SELECT OD.DetailID, OD.ProductID, P.Name, P.Unit, OD.Quantity, P.Price, OD.quantity * P.Price AS Amount
                   FROM tblorder O
                   inner join OrderDetails OD ON O.ID = OD.orderID
                   INNER JOIN Product P ON OD.ProductID = P.ID 
                    
                WHERE O.TableID = @TblName AND O.payStatus = 'Pending' ";
            Hashtable ht = new Hashtable();
            ht.Add("@TblName ", TableID);
            ListBox lb = new ListBox();
            lb.Items.Add(dvgIDNO);
            lb.Items.Add(ProID);
            lb.Items.Add(dvgName); 
            lb.Items.Add(dvgunit);
            lb.Items.Add(dvgquantity);
            lb.Items.Add(dvgprice);
            lb.Items.Add(dvgtotal);
            mainClass.LoadData(qry1, grdordercheckout, lb, ht);
            //Load tổng tiền 
            string qry4 = @"SELECT sum(OD.quantity * P.Price) as total 
                            FROM tblorder O
                                    inner join OrderDetails OD ON O.ID = OD.orderID
                                    left join Product P ON P.ID = OD.productID
                            WHERE o.TableID = @tname AND O.payStatus = 'Pending' ";
            SqlCommand cmd4 = new SqlCommand(qry4, mainClass.con);
            cmd4.Parameters.AddWithValue("@tname", TableID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            string result = cmd4.ExecuteScalar().ToString();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            decimal total;
            if (result != null && decimal.TryParse(result.ToString(), out total))
            {
                txttongtien.Text = total.ToString("N0");
            }
            else
            {
            }
            //load số khách 
            string qry6 = @"select NoCustomer from tblorder where TableID = @tname AND payStatus = 'Pending' ";
            SqlCommand cmd6 = new SqlCommand(qry6, mainClass.con);
            cmd6.Parameters.AddWithValue("@tname", TableID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            string Nocus = cmd6.ExecuteScalar().ToString();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            txtNoCus.Text = Nocus;
        }
            private void Transaction_Load(object sender, EventArgs e)
        {
            loadtablename();
            LoadOrderDetails();
            ShowCustomerInfo();
        }

        private void grdorderupdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void UpdateTotalPayment()
        {
            decimal totalAmount;
            if (!decimal.TryParse(txttongtien.Text, out totalAmount))
            {
                totalAmount = 0;
            }
            decimal discountAmount = 0;
            if (!string.IsNullOrEmpty(txtgiamgia.Text))
            {
                if (!decimal.TryParse(txtgiamgia.Text, out discountAmount))
                {
                    discountAmount = 0;
                }
            }
            decimal totalPayment = totalAmount - discountAmount;
            txttongtien.TextChanged -= txttongtien_TextChanged;
            txtphaithanhtoan.Text = totalPayment.ToString("N0");
            txttongtien.TextChanged += txttongtien_TextChanged;
        }
        private void txttongtien_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPayment();
        }
        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPayment();
        }
        private void btndiscount_Click(object sender, EventArgs e)
        {
            DiscountList DL = new DiscountList(this);
            DL.ShowDialog();
            DiscountID = DL.DiscountID;
        }

        private void txtTienkhachDua_TextChanged(object sender, EventArgs e)
        {
            txtTienkhachDua.TextChanged -= txtTienkhachDua_TextChanged;

            decimal totalPayment;
            if (!decimal.TryParse(txtphaithanhtoan.Text, out totalPayment))
            { 
                totalPayment = 0;
            }

            decimal cashGiven;
            if (!decimal.TryParse(txtTienkhachDua.Text, out cashGiven))
            {
                cashGiven = 0;
            }
            txtTienkhachDua.TextChanged += txtTienkhachDua_TextChanged;
            decimal changeDue = cashGiven - totalPayment;
            txtTienThua.Text = changeDue.ToString("N0");
        }

        private void txtTienkhachDua_Leave(object sender, EventArgs e)
        {
            decimal cashGiven;
            if (decimal.TryParse(txtTienkhachDua.Text, out cashGiven))
            {
                txtTienkhachDua.Text = cashGiven.ToString("N0");
            }
            else
            {
            }
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            PayMethod PM = new PayMethod(this);
            PM.Show();
        }
        private int GetPaymentMethodID(string paymentMethodName)
        {
            string qry = "SELECT ID FROM PaymentMethod WHERE Name = @Name";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@Name", paymentMethodName);

            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            int paymentMethodID = Convert.ToInt32(cmd.ExecuteScalar());
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }

            return paymentMethodID;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!hasPrinted)
            {
                MessageBox.Show("Vui lòng in tạm tính trước khi lưu!");
                return;
            }
            if (string.IsNullOrEmpty(txtHTTT.Text))
            {
                MessageBox.Show("Vui lòng chọn hình thức thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string payMethod = txtHTTT.Text;
            int orderID = 0;
            string qry = @"Update tblorder Set OrderDate = @OrderDate,  PayMethodID = @PayMethodID OUTPUT INSERTED.ID where TableID= @TableID and payStatus ='Pending'";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@OrderDate", Convert.ToDateTime(DateTime.Now.Date));
           // cmd.Parameters.AddWithValue("@payStatus", "Paid");
            cmd.Parameters.AddWithValue("@PayMethodID", GetPaymentMethodID(payMethod));
            cmd.Parameters.AddWithValue("@TableID", TableID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            orderID = (int)cmd.ExecuteScalar();
           // cmd.ExecuteNonQuery();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }

            string qry2 = @" DECLARE @OrderTotal DECIMAL;
                            SELECT @OrderTotal = total FROM tblorder WHERE ID = @orderID;
                            UPDATE C
                            SET Scores = CASE
                                WHEN @OrderTotal < 500000 THEN ISNULL(C.Scores, 0) + 10
                                WHEN @OrderTotal >= 500000 AND O.total < 1000000 THEN ISNULL(C.Scores, 0) + 15
                                 WHEN @OrderTotal >= 1000000 THEN ISNULL(C.Scores, 0) + 25
                                ELSE ISNULL(C.Scores, 0)
                            END, 
                                    Levels = CASE
                                                WHEN ISNULL(C.Scores, 0) >= 50 THEN 'Platinum'
                                                WHEN ISNULL(C.Scores, 0) >= 30 THEN 'Gold'
                                                WHEN ISNULL(C.Scores, 0) >= 20 THEN 'Silver'
                                                ELSE 'Titan'
                                            END
                            FROM Customer C
                            INNER JOIN tblorder O ON C.ID = O.CustomerID
                            WHERE O.ID = @orderID;";
            SqlCommand cmd2 = new SqlCommand(qry2, mainClass.con);
            cmd2.Parameters.AddWithValue("@orderID", orderID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            cmd2.ExecuteNonQuery();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }

           
            MessageBox.Show("Đã lưu");
        }
        private void btntamtinh_Click(object sender, EventArgs e)
        {
            hasPrinted = true;
            int orderID = 0;
            string qry = @"Update tblorder Set  NoCustomer = @NoCustomer, DiscountID = @DiscountID  OUTPUT INSERTED.ID where TableID = @tname and payStatus = 'Pending'";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con); 
            cmd.Parameters.AddWithValue("@NoCustomer", Convert.ToInt32(txtNoCus.Text));
            if (string.IsNullOrEmpty(DiscountID))
            {
                cmd.Parameters.AddWithValue("@DiscountID", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@DiscountID", DiscountID);
            }
            cmd.Parameters.AddWithValue("@tname", TableID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            orderID = (int)cmd.ExecuteScalar();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }          
            string query = @"
                select  tb.OrderTime, t.TableName, c.CustomerName, c.Phone , p.Name , p.Price , od.quantity, 
                CASE
                    WHEN ISNULL(D.DiscountValue, 0) < 1 THEN ISNULL(D.DiscountValue, 0) * tb.total
                    ELSE ISNULL(D.DiscountValue, 0) END as DiscountValue,
                tb.total,
                (p.Price * od.quantity) as Amount,
                (tb.total - 
                    CASE
                        WHEN ISNULL(D.DiscountValue, 0) < 1 THEN ISNULL(D.DiscountValue, 0) * tb.total
                        ELSE ISNULL(D.DiscountValue, 0)
                    END) as paytotal, 
                tb.NoCustomer, st.StaffName                          
                from  tblorder tb 
                INNER JOIN OrderDetails od on tb.ID = od.orderID 
                INNER JOIN Product p on od.productID = p.ID
                LEFT OUTER JOIN Customer c on  c.ID =  tb.CustomerID 
                LEFT OUTER JOIN Discount D on tb.DiscountID = D.ID 
                INNER JOIN Staff st on st.ID = tb.StaffID  
                INNER JOIN TableList t on t.ID = tb.TableID
                where tb.TableID = @tname and tb.payStatus = 'Pending'";
            SqlCommand cmd1 = new SqlCommand(query, mainClass.con);
            cmd1.Parameters.Clear();
            cmd1.Parameters.AddWithValue("@tname", TableID);
            mainClass.con.Open();   
            DataTable dt = new DataTable("tamtinhdata");
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            mainClass.con.Close();                  
             rptamtinh tt = new rptamtinh();
            tt.SetDataSource(dt);
            tt.Refresh();
            intamtinh IT = new intamtinh();
            IT.crystalReportViewer1.ReportSource = tt;
            IT.Show(); 
        }  
        private void grdordercheckout_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string[] columnNames = { "dvgtotal", "dvgprice" };

            if (columnNames.Contains(grdordercheckout.Columns[e.ColumnIndex].Name))
            {
                if (e.Value != null)
                {
                    decimal value = Convert.ToDecimal(e.Value);
                    e.Value = value.ToString("N0");
                    e.FormattingApplied = true;
                }
            }
        }
        public void ShowCustomerInfo()
        {
            string qry = @"SELECT c.CustomerName, c.Scores 
                                   FROM tblorder tb 
                                          INNER JOIN Customer c ON tb.CustomerID = c.ID 
                                   WHERE tb.TableID = @tname AND tb.payStatus = 'Pending'";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@tname", TableID); ; ;
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lblcusname.Text = reader[0].ToString();
                lblpoint.Text = reader[1].ToString();
            }
            reader.Close();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
        }
        public int OrderID()
        {
            string qry = @"Select ID from tblorder where TableID = @TableID and payStatus = 'Pending'";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@TableID", TableID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            int orderID = (int)cmd.ExecuteScalar();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            return orderID;
        }

      

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            int orderId = OrderID();
            InvoiceInfo ivf = new InvoiceInfo(orderId, OD, this,ps);
            ivf.ShowDialog();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            string qry = @"Update tblorder set payStatus = @payStatus where TableID= @TableID and payStatus ='Pending'";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@payStatus", "Paid");
            cmd.Parameters.AddWithValue("@TableID", TableID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            cmd.ExecuteNonQuery();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }

            string qry3 = @"UPDATE TableList SET TableStatus = NULL WHERE TableName = @tenBan";
            SqlCommand cmd3 = new SqlCommand(qry3, mainClass.con);
            cmd3.Parameters.AddWithValue("@tenBan", lblban.Text);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            cmd3.ExecuteNonQuery();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            ps.UpdateTableColor();
            HomeForm.Instance.UpdateAvgPerCus();
            this.Close();
            OD.Close();
        }
    }
}  
