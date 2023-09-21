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

namespace qlnh1
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        private static HomeForm _instance;
        public static HomeForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HomeForm();
                }
                return _instance;
            }
        }
        public void UpdateOrderInfo()
        {           
            string qry = @"SELECT COUNT(*) FROM tblorder where OrderDate = CAST(GETDATE() AS DATE)";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            object result = cmd.ExecuteScalar(); 
            int totalOrders = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            lblorder.Text = Convert.ToString(totalOrders);
            countorderpanel.Controls.Add(lblorder);
        }
        public void UpdateAvgPerCus()
        {

            string qry = @" 
                select sum(NoCustomer) from tblorder
                where payStatus ='Paid' and OrderDate = CAST(GETDATE() AS DATE)
            ";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            object result = cmd.ExecuteScalar();
            int noCustomer = result != DBNull.Value ? Convert.ToInt32(result) : 0;
            //  decimal avg = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            lblavgpercus.Text = Convert.ToString(noCustomer);
            avgpercus.Controls.Add(lblavgpercus);
        }
        public void RevenueByDay()
        {
            string qry = @"SELECT  SUM(tb.total - 
                    CASE
                        WHEN D.DiscountValue < 1 THEN ISNULL(D.DiscountValue, 0) * tb.total
                        ELSE ISNULL(D.DiscountValue, 0)
                    END
                ) as Nettotal 
                FROM tblorder tb
                LEFT OUTER JOIN Discount D on tb.DiscountID = D.ID 
                WHERE tb.OrderDate = CAST(GETDATE() AS DATE) and tb.payStatus = 'Paid'
                GROUP BY  tb.OrderDate";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            object result = cmd.ExecuteScalar();
            decimal revenue = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            lblrevenue.Text = revenue.ToString("N0");
            revenuepanel.Controls.Add(lblrevenue);
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            _instance = this;
            UpdateAvgPerCus();
            UpdateOrderInfo();
            RevenueByDay();
            lbldate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
