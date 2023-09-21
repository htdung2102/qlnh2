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
    public partial class UCrevenuebycategory : UserControl
    {
        public UCrevenuebycategory()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string qry = @"SELECT pt.TypeName,
                            CASE 
                                WHEN GROUPING_ID(pt.TypeName, p.Name) = 3 THEN N'Tổng cộng'
                                WHEN GROUPING_ID(pt.TypeName, p.Name) = 2 THEN pt.TypeName
                                ELSE p.Name
                            END as Name, 
                            SUM(od.quantity) as Quantity,
                            SUM(od.quantity * p.Price) as Revenue
                        FROM 
                            tblorder o
                        INNER JOIN 
                            orderdetails od ON o.ID = od.orderID
                        INNER JOIN 
                            Product p ON od.productID = p.ID
                        INNER JOIN 
                            ProductType pt ON p.TypeID = pt.ID
                            WHERE 
                            o.OrderDate BETWEEN @StartDate AND @EndDate
                        GROUP BY 
                            ROLLUP (pt.TypeName, p.Name)
                        ORDER BY 
                            CASE 
                                WHEN GROUPING_ID(pt.TypeName, p.Name) = 3 THEN 1 ELSE 0 END,
                                pt.TypeName, 
                            CASE 
                                WHEN p.Name IS NULL THEN 0 ELSE 1 END,
                            p.Name";
            Hashtable ht = new Hashtable();
            ht.Add("@startdate", startdate.Value.Date);
            ht.Add("@enddate", enddate.Value.Date);
            ListBox lb = new ListBox();
            lb.Items.Add(dvgtype);
            lb.Items.Add(dvgproduct);
            lb.Items.Add(dvgquantity);
            lb.Items.Add(dvgrevenue);            
            mainClass.LoadData(qry, grdrevenuebytime, lb, ht);
        }
        private void UCrevenuebycategory_Load(object sender, EventArgs e)
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
            string[] columnNames = { "dvgrevenue"};

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

        private void btnin_Click(object sender, EventArgs e)
        {
           /* DataTable dt = (grdrevenuebytime.DataSource as DataTable).Copy();

            RevenueByCat myReport = new RevenueByCat();
            myReport.SetDataSource(dt);
            myReport.Refresh();

            ReportRevenueByCat SR = new ReportRevenueByCat();
            SR.crystalReportViewer1.ReportSource = myReport;
            SR.Show();*/
        }
    }
}
