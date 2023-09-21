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
    public partial class UCBillList : UserControl
    {
        public UCBillList()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string qry = @"select OrderDate, TableName, NoCustomer,tb.total,
                        CASE
                        WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
                        ELSE ISNULL(D.DiscountValue,0)
                        END as DiscountTotal
                        ,(tb.total - 
                                        CASE
                                            WHEN D.DiscountValue < 1 THEN D.DiscountValue * tb.total
                                            ELSE ISNULL(D.DiscountValue,0)
                                        END
                                    ) as Nettotal 
                    from tblorder tb left join Discount d on tb.DiscountID = d.ID
                    inner join TableList tl on tl.ID = tb.TableID 
                    WHERE OrderDate BETWEEN @startdate AND @enddate and tb.payStatus = 'Paid'
                    ";
            Hashtable ht = new Hashtable();
            ht.Add("@startdate", startdate.Value.Date);
            ht.Add("@enddate", enddate.Value.Date);
            ListBox lb = new ListBox();
            lb.Items.Add(dvgorderdate);
            lb.Items.Add(dvgtname);
            lb.Items.Add(dvgpeople);
            lb.Items.Add(dvgtotal);
            lb.Items.Add(dvgdiscount);
            lb.Items.Add(dvgnet);
            mainClass.LoadData(qry, grdbillList, lb, ht);
        }
        private void UCBillList_Load(object sender, EventArgs e)
        {
            startdate.Value = DateTime.Now;
            enddate.Value = DateTime.Now;
            LoadData();
        }

        private void grdbillList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string[] columnNames = { "dvgtotal", "dvgdiscount", "dvgnet" };

            if (columnNames.Contains(grdbillList.Columns[e.ColumnIndex].Name))
            {
                if (e.Value != null)
                {

                    decimal value = Convert.ToDecimal(e.Value);
                    e.Value = value.ToString("N0");
                    e.FormattingApplied = true;
                }
            }
        }

        private void startdate_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void enddate_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void grdbillList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
