using System;
using System.Collections.Generic;
using System.ComponentModel; 
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using System.Data.SqlClient;

namespace qlnh1
{
    public partial class UCrevenueOverview : UserControl
    {
        public UCrevenueOverview()
        {
            InitializeComponent();
        }
        private static UCrevenueOverview _instance;
        public static UCrevenueOverview Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UCrevenueOverview();
                }
                return _instance;
            }
        }
        public void UpdateOrderInfo()
        {

            string qry = @"SELECT COUNT(*) FROM tblorder where OrderDate BETWEEN @startdate AND @enddate and  payStatus = 'Paid'";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@startdate", startdate.Value.Date);
            cmd.Parameters.AddWithValue("@enddate", enddate.Value.Date);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            object result = cmd.ExecuteScalar();
            int totalOrders = (result != null) ? Convert.ToInt32(result) : 0;          
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            lblorder.Text = Convert.ToString(totalOrders);
            countorderpanel.Controls.Add(lblorder);
        }
        public void UpdateAvgPerCus()
        {

            string qry = @" 
                SELECT SUM(total - 
                    CASE
                        WHEN D.DiscountValue < 1 THEN D.DiscountValue * total
                        ELSE ISNULL(D.DiscountValue,0)
                    END) / SUM(NoCustomer) as AverageRevenuePerCustomer
                FROM tblorder tb 
                left join Discount D on tb.DiscountID = D.ID 
                 WHERE tb.OrderDate BETWEEN @startdate AND @enddate and tb.payStatus ='Paid'
            ";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@startdate", startdate.Value.Date);
            cmd.Parameters.AddWithValue("@enddate", enddate.Value.Date);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            object result = cmd.ExecuteScalar();
            decimal avg = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            lblavgpercus.Text = Math.Round(avg).ToString("N0");
            avgpercus.Controls.Add(lblorder);
        }
        public void updateCustomer()
        {
            string qry = @"select sum(NoCustomer) from tblorder where OrderDate BETWEEN @startdate AND @enddate and payStatus = 'Paid' ";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@startdate", startdate.Value.Date);
            cmd.Parameters.AddWithValue("@enddate", enddate.Value.Date);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            object result = cmd.ExecuteScalar();
            int totalcus = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            lblcustotal.Text = Convert.ToString(totalcus);
        }
        public void updateRevenueTotal()
        {
            string qry = @"
            SELECT SUM(tb.total - 
                CASE
                    WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
                    ELSE ISNULL(D.DiscountValue,0)
                END
            ) as Nettotal 
            FROM tblorder tb
            LEFT OUTER JOIN Discount D on tb.DiscountID = D.ID 
            WHERE tb.OrderDate BETWEEN @startdate AND @enddate and tb.payStatus = 'Paid'
        ";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@startdate", startdate.Value.Date);
            cmd.Parameters.AddWithValue("@enddate", enddate.Value.Date);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            object result = cmd.ExecuteScalar();
            decimal total = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            lblrevtotal.Text = Math.Round(total).ToString("N0");
            totalrevenue.Controls.Add(lblrevtotal);
        }
        public void top5product()
        {
            string qry = @"
                SELECT TOP 5 P.Name, SUM(OD.quantity * P.Price) as TotalRevenue
                FROM tblorder O
                INNER JOIN OrderDetails OD ON O.ID = OD.orderID
                INNER JOIN Product P ON OD.ProductID = P.ID
                WHERE O.payStatus = 'Paid'  AND O.OrderDate BETWEEN @startdate AND @enddate
                GROUP BY P.Name
                ORDER BY TotalRevenue DESC";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@startdate", startdate.Value.Date);
            cmd.Parameters.AddWithValue("@enddate", enddate.Value.Date);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 1;
            while (reader.Read())
            {
                // Tìm label tương ứng
                Label lblpname = (Label)this.Controls.Find("lblpname" + i, true).FirstOrDefault();               
                Label lblrevenue = (Label)this.Controls.Find("lblrevenue" + i, true).FirstOrDefault();

                // Cập nhật giá trị cho label
                if (lblpname != null && lblrevenue != null)
                {
                    lblpname.Text = reader["Name"].ToString();                   
                    lblrevenue.Text = Convert.ToDecimal(reader["TotalRevenue"]).ToString("N0");
                }

                i++;
            }
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
        }
        public void Top5CustomerSpent()
        {
            string qry = @"
            SELECT TOP 5 C.CustomerName, SUM(tb.total - 
                CASE
                    WHEN D.DiscountValue < 1 THEN ISNULL(D.DiscountValue, 0) * tb.total
                    ELSE ISNULL(D.DiscountValue, 0)
                END
            ) as TotalSpent
            FROM tblorder tb
            LEFT OUTER JOIN Discount D on tb.DiscountID = D.ID 
            left JOIN Customer C on tb.CustomerID = C.ID
            WHERE tb.OrderDate BETWEEN @startdate AND @enddate and tb.payStatus = 'Paid'
            GROUP BY C.CustomerName
            ORDER BY TotalSpent DESC
        ";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@startdate", startdate.Value.Date);
            cmd.Parameters.AddWithValue("@enddate", enddate.Value.Date);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 1;
            while (reader.Read())
            {
                // Tìm label tương ứng
                Label lblCustomerName = (Label)this.Controls.Find("lblCustomerName" + i, true).FirstOrDefault();
               
                Label lblSpent = (Label)this.Controls.Find("lblSpent" + i, true).FirstOrDefault();

                // Cập nhật giá trị cho label
                if (lblCustomerName != null && lblSpent != null)
                {
                    lblCustomerName.Text = reader["CustomerName"].ToString();

                    lblSpent.Text = Convert.ToDecimal(reader["TotalSpent"]).ToString("N0");
                }

                i++;
            }
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
        }
        private void UCrevenuechart_Load(object sender, EventArgs e)
        {
            _instance = this;
            startdate.Value = DateTime.Now;
            enddate.Value = DateTime.Now;
            UpdateAvgPerCus();
            UpdateOrderInfo();
            updateCustomer();
            updateRevenueTotal();
            top5product();
            Top5CustomerSpent();
        }

        private void startdate_ValueChanged(object sender, EventArgs e)
        {
            UpdateAvgPerCus();
            UpdateOrderInfo();
            updateCustomer();
            updateRevenueTotal();
            top5product();
            Top5CustomerSpent();
        }

        private void enddate_ValueChanged(object sender, EventArgs e)
        {
            UpdateAvgPerCus();
            UpdateOrderInfo();
            updateCustomer();
            updateRevenueTotal();
            top5product();
            Top5CustomerSpent();
        }

        private void top5productpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblrevenue5_Click(object sender, EventArgs e)
        {

        }
    }
}
