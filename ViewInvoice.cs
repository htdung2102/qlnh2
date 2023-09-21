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
    public partial class ViewInvoice : UserControl
    {
        public ViewInvoice()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string qry = @" SELECT I.InvoiceDate ,I.InvoiceID, I.CustomerName, I.CompanyName, I.TaxCode, I.Address,
                    (tb.total - 
                                CASE WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
                                ELSE ISNULL(D.DiscountValue,0) END) as Total                   
                    FROM Invoice I INNER JOIN tblorder tb on I. OrderID = tb.ID                   
                                     LEFT JOIN Discount d on d.ID =  tb.DiscountID 
                    WHERE I.InvoiceDate BETWEEN @startdate AND @enddate ";
            Hashtable ht = new Hashtable();
            ht.Add("@startdate", startdate.Value.Date);
            ht.Add("@enddate", enddate.Value.Date);
            ListBox lb = new ListBox();
            lb.Items.Add(dvgdate);
            lb.Items.Add(dvgInvoiceID);
            lb.Items.Add(dvgtname);
            lb.Items.Add(dvgcompany);
            lb.Items.Add(dvgtaxcode);
            lb.Items.Add(dvgaddress);
            lb.Items.Add(dvgnet);
            mainClass.LoadData(qry, grdinvoice, lb, ht);
        }

        private void ViewInvoice_Load(object sender, EventArgs e)
        {
            startdate.Value = DateTime.Now;
            enddate.Value = DateTime.Now;
            LoadData();
        }

        private void startdate_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void enddate_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void grdinvoice_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string[] columnNames = { "dvgnet" };

            if (columnNames.Contains(grdinvoice.Columns[e.ColumnIndex].Name))
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
