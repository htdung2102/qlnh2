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
    public partial class UCviewRevenuebyMonth : UserControl
    {
        public UCviewRevenuebyMonth()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            int selectedYear = Convert.ToInt32(cbyear.Text);
            int selectedMonth = cbmonth.SelectedItem != null ? Convert.ToInt32(cbmonth.Text) : 0;

            string monthCondition = selectedMonth > 0 ? $"AND MONTH(tb.OrderDate) = {selectedMonth}" : "";

            string qry = $@"
        SELECT  MONTH(tb.OrderDate) as Month, YEAR(tb.OrderDate) as Year, COUNT(tb.ID) as OrderCount, SUM(tb.total) AS Total, 
        SUM(
            CASE
                WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
                ELSE D.DiscountValue
            END
        ) as DiscountValue, 
        SUM(tb.total - 
            CASE
                WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
                ELSE D.DiscountValue
            END
        ) as Nettotal 
        FROM tblorder tb
        LEFT OUTER JOIN Discount D on tb.DiscountID = D.ID 
        WHERE YEAR(tb.OrderDate) = {selectedYear} {monthCondition} and tb.payStatus = 'Paid'
        GROUP BY  MONTH(tb.OrderDate), YEAR(tb.OrderDate)
    ";

            ListBox lb = new ListBox();
            lb.Items.Add(dvgdate);
            lb.Items.Add(dvgyear);
            lb.Items.Add(dvgquantity);
            lb.Items.Add(dvgtotal);
            lb.Items.Add(dvgdiscount);
            lb.Items.Add(dvgnet);
            mainClass.LoadData(qry, grdrevenuebytime, lb);
        }
        private void UCviewRevenuebyMonth_Load(object sender, EventArgs e)
        {
            
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear; year >= currentYear - 10; year--)
            {
                cbyear.Items.Add(year);
            }
        }

        private void cbyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void grdrevenuebytime_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string[] columnNames = { "dvgtotal", "dvgdiscount","dvgnet" };

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
    }
}
