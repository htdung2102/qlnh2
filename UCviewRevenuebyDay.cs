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


namespace qlnh1
{
    public partial class UCviewRevenuebyDay : UserControl
    {
        public UCviewRevenuebyDay()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string qry = @"
                SELECT  tb.OrderDate, COUNT(tb.ID) as OrderCount, SUM(tb.total) AS Total, 
                SUM(
                    CASE
                        WHEN D.DiscountValue < 1 THEN ISNULL(D.DiscountValue, 0) * tb.total
                        ELSE ISNULL(D.DiscountValue, 0)
                    END
                ) as DiscountValue, 
                SUM(tb.total - 
                    CASE
                        WHEN D.DiscountValue < 1 THEN ISNULL(D.DiscountValue, 0) * tb.total
                        ELSE ISNULL(D.DiscountValue, 0)
                    END
                ) as Nettotal 
                FROM tblorder tb
                LEFT OUTER JOIN Discount D on tb.DiscountID = D.ID 
                WHERE tb.OrderDate BETWEEN @startdate AND @enddate and tb.payStatus = 'Paid'
                GROUP BY  tb.OrderDate
            ";
            Hashtable ht = new Hashtable();
            ht.Add("@startdate", startdate.Value.Date);
            ht.Add("@enddate", enddate.Value.Date);
            ListBox lb = new ListBox();
            lb.Items.Add(dvgdate);
            lb.Items.Add(dvgquantity);
            lb.Items.Add(dvgtotal);
            lb.Items.Add(dvgdiscount);
            lb.Items.Add(dvgnet);
            mainClass.LoadData(qry, grdrevenuebytime, lb, ht);
        }
        private void UCviewRevenuebyDay_Load(object sender, EventArgs e)
        {
            LoadData();
             startdate.Value = DateTime.Now;
             enddate.Value = DateTime.Now;
        }

        private void startdate_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void enddate_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void grdrevenuebytime_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string[] columnNames = { "dvgtotal", "dvgdiscount", "dvgnet" };

            if (columnNames.Contains(grdrevenuebytime.Columns[e.ColumnIndex].Name))
            {
                if (e.Value != null)
                {

                    decimal value = Convert.ToDecimal(e.Value);
                    e.Value = value.ToString("N0");
                    e.FormattingApplied = true;
                }
            }
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnin_Click(object sender, EventArgs e)
        {
            DataTable dt = (grdrevenuebytime.DataSource as DataTable).Copy();

            RevenueByDay myReport = new RevenueByDay();
            myReport.SetDataSource(dt);
            myReport.SetParameterValue("startdate", startdate.Value.Date);
            myReport.SetParameterValue("enddate", enddate.Value.Date);

            RevenueByDayReport SR = new RevenueByDayReport();
            SR.crystalReportViewer1.ReportSource = myReport;
            SR.Show();
        }
    }
}
