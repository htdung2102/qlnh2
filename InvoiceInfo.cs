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
    public partial class InvoiceInfo : Form
    {
        private int orderId;
        public int id = 0;
        
        public static Transaction ts;
        public static OrderUpdate od;
        public static pos p;
       public InvoiceInfo(int orderId, OrderUpdate OD, Transaction TS, pos P)
        {
            InitializeComponent();
            this.orderId = orderId;
            ts = TS;
            od = OD;
            p = P;
        }

        private void InvoiceInfo_Load(object sender, EventArgs e)
        {          
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "insert into Invoice values(@OrderID, @CustomerName, @Company, @TaxCode, @Address, @InvoiceDate)";

            }
            Hashtable ht = new Hashtable();
            // ht.Add("@id", id);
            ht.Add("@OrderID",orderId);
            ht.Add("@CustomerName", string.IsNullOrEmpty(txtcusname.Text) ? (object)DBNull.Value : txtcusname.Text);
            ht.Add("@Company", string.IsNullOrEmpty(txtcompany.Text) ? (object)DBNull.Value : txtcompany.Text);
            ht.Add("@TaxCode", string.IsNullOrEmpty(txttaxcode.Text) ? (object)DBNull.Value : txttaxcode.Text);
            ht.Add("@Address", string.IsNullOrEmpty(txtaddress.Text) ? (object)DBNull.Value : txtaddress.Text);
            ht.Add("@InvoiceDate", Convert.ToDateTime(DateTime.Now.Date));
            mainClass.sql(qry, ht);
           
            string query = @" SELECT I.InvoiceID, I.CustomerName, I.CompanyName, I.TaxCode, I.Address, P.Name as ProductName, P.Unit, OD.quantity, P.Price, TB.total as Total ,
                                CASE
                                                WHEN ISNULL(D.DiscountValue, 0) < 1 THEN ISNULL(D.DiscountValue, 0) * tb.total
                                                ELSE ISNULL(D.DiscountValue, 0) END as DiscountValue, TL.TableName
                                FROM Invoice I INNER JOIN tblorder tb on I. OrderID = tb.ID
                                                INNER JOIN OrderDetails od on od.orderID = tb.ID
                                                INNER JOIN Product p on p.ID = od.productID
                                                LEFT JOIN Discount d on d.ID =  tb.DiscountID 
                                                INNER JOIN TableList tl on tl.ID = tb.TableID Where tb.ID = @OrderID";
            SqlCommand cmd1 = new SqlCommand(query, mainClass.con);
            cmd1.Parameters.AddWithValue("@OrderID", orderId);
            mainClass.con.Open();
            DataTable dt = new DataTable("Invoice");
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            mainClass.con.Close();
            RptInvoice tt = new RptInvoice();
            tt.SetDataSource(dt);
            tt.Refresh();
            ShowInvoice IT = new ShowInvoice();
            IT.crystalReportViewer1.ReportSource = tt;
            // IT.crystalReportViewer1.Refresh();
            IT.FormClosed += (s, args) =>
            {               
                string updateQuery = "UPDATE tblorder SET payStatus = 'Paid' WHERE ID = @OrderID";
                SqlCommand updateCmd = new SqlCommand(updateQuery, mainClass.con);
                updateCmd.Parameters.AddWithValue("@OrderID", orderId);
                mainClass.con.Open();
                updateCmd.ExecuteNonQuery();
                mainClass.con.Close();
                UpdateTableStatus();
                HomeForm.Instance.UpdateAvgPerCus();            
                this.Close();
                ts.Close();
                od.Close();
            };
            IT.Show();
        }
        private void UpdateTableStatus()
        {
            //lấy TableID để cập nhật trạng thái bàn sau khi đóng form 
            string qry1 = @"Select TableID from tblorder WHERE ID = @Orderid";
            SqlCommand Cmd1 = new SqlCommand(qry1, mainClass.con);
            Cmd1.Parameters.AddWithValue("@Orderid", orderId);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            int TableID = (int)Cmd1.ExecuteScalar();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            //Cập nhật trạng thái bàn 
            string qry3 = @"UPDATE TableList SET TableStatus = NULL WHERE ID = @tTableID";
            SqlCommand cmd3 = new SqlCommand(qry3, mainClass.con);
            cmd3.Parameters.AddWithValue("@tTableID", TableID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            cmd3.ExecuteNonQuery();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            p.UpdateTableColor();
        }
    }
}
