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
    public partial class UCsalereport : UserControl
    {
        public int id = 0;
        public int cID = 0;
        public UCsalereport()
        {
            InitializeComponent();
        }

        private void UCsalereport_Load(object sender, EventArgs e)
        {
            string qry = "select ID , Name from department ";
            mainClass.cbfill(qry, cbdepart, "Name", "ID");
            if (cID > 0)
            {
                cbdepart.SelectedValue = cID;
            }
            if (id > 0)
            {
                LoadData();
            }
            enddate.Value = DateTime.Now;
        }
        private void LoadData()
        {
            string qry = @"select p.Name, sum(od.quantity) as quantity
        from tblorder tb left join OrderDetails OD ON tb.ID = od.orderID
        left join product p on od.productID = p.ID
        left join ProductType pt on pt.ID = p.TypeID
        where tb.OrderDate BETWEEN  @startdate AND @enddate and tb.payStatus = 'Paid'";

            string selectedDepartment = cbdepart.SelectedItem != null ? cbdepart.SelectedItem.ToString() : "All";

            Hashtable ht = new Hashtable();
            ht.Add("@startdate", startdate.Value.Date);
            ht.Add("@enddate", enddate.Value.Date);

            if (selectedDepartment != "All")
            {
                qry += " and pt.Department = @Department";
                ht.Add("@Department", (int)cbdepart.SelectedValue);
            }

            qry += " group by p.Name";

            ListBox lb = new ListBox();
            lb.Items.Add(dvgname);
            lb.Items.Add(dvgquantity);
            mainClass.LoadData(qry, grdsalereport, lb, ht);

        }

        private void startdate_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void enddate_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbdepart_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            

        }

        private void btnin_Click_1(object sender, EventArgs e)
        {
            DataTable dt = (grdsalereport.DataSource as DataTable).Copy(); 

            SaleReport myReport = new SaleReport();
            myReport.SetDataSource(dt); 
            myReport.Refresh();

            SALERPT SR = new SALERPT();
            SR.crystalReportViewer1.ReportSource = myReport;
            SR.Show();
        }
    }
}
