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
    public partial class AddReservation : Form
    {
        public int currentTableId;
        public int id = 0;
        public int cID = 0;
        public AddReservation(int currentTableId = -1)
        {
            InitializeComponent();
            txtname.Text = "Họ tên";
            txtname.ForeColor = Color.Gray;
            this.currentTableId = currentTableId;
        }
       
       
        public class Table
        {
            public int ID { get; set; }
            public string TableName { get; set; }
            public int TypeID { get; set; }
        }
        private void FilterTables()
        {                     
                if (cbtype.SelectedValue != null)
                {
                    int selectedTypeID = (int)cbtype.SelectedValue;
                    var tables = GetTablesByTypeID(selectedTypeID);
                    DateTime date = txtdate.Value.Date;
                    string dateString = date.ToString("yyyy-MM-dd");
                    if (string.IsNullOrEmpty(txtshift.Text))
                    {
                        return;
                    }
                    int shift;
                    try
                    {
                        shift = Convert.ToInt32(txtshift.Text);
                    }
                    catch (FormatException)
                    {
                        return;
                    }
                    var reservedTables = GetReservedTables(dateString, shift);
                    if (reservedTables.Count > 0)
                    {
                    tables = tables.Where(table => !reservedTables.Any(reservedTable => reservedTable.ID == table.ID && table.ID != currentTableId)).ToList();
                }
                    cbtable.DisplayMember = "TableName";
                    cbtable.ValueMember = "ID";
                    cbtable.DataSource = tables;
                }
            
        }

        private void AddReservation_Load(object sender, EventArgs e)
        {
            string qry = "select TypeID , TypeName from TableType";
            mainClass.cbfill(qry, cbtype, "TypeName", "TypeID");
            if (cID > 0)
            {
                cbtype.SelectedValue = cID;
            }

            if (id > 0)
            {
                updateloaddata();
            }
            TimeSpan startTime = new TimeSpan(10, 0, 0);
            TimeSpan endTime = new TimeSpan(22, 0, 0);
            while (startTime <= endTime)
            {
                cbtime.Items.Add(startTime.ToString(@"hh\:mm"));
                startTime = startTime.Add(new TimeSpan(0, 15, 0));
            }
          //  FilterTables();
           
        }
        private void updateloaddata()
        {
            string qry = @"select * from Reservation where ID ='" + id + "'";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                txtname.Text = dt.Rows[0]["CustomerName"].ToString();
                cbtable.Text = dt.Rows[0]["TableTName"].ToString();
                
            }
        }
     
        private void cbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterTables();
        }
       
        private List<Table> GetReservedTables(string date,  int shift)
        {
            List<Table> tables = new List<Table>();
            string qry = @"Select TableID , TableTName from Reservation where BookDate = @Date and Shift = @Shift";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@Date", date);
            cmd.Parameters.AddWithValue("@Shift", shift);

            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string tableName = reader.GetString(1);
                Console.WriteLine($"ID: {id}, TableName: {tableName}"); // In ra giá trị ID và TableName
                tables.Add(new Table { ID = id, TableName = tableName });
            }

            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }

            return tables;
        }
        private List<Table> GetTablesByTypeID(int typeID)
        {
            List<Table> tables = new List<Table>();
            string qry = @"Select ID, TableName from TableList where TypeID =@TypeID";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@TypeID", typeID);

            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tables.Add(new Table { ID = reader.GetInt32(0), TableName = reader.GetString(1) });
            }

            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }

            return tables;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "insert into Reservation  values(@CustomerName, @Phone, @TableTName, @NoPeople, @BookDate, @BookTime, @TypeID,@Type, @Shift, @TableID)";

            }
            else
            {

                qry = "update Reservation set CustomerName =@CustomerName, Phone = @Phone, TableTName = @TableTName, NoPeople = @NoPeople, BookDate = @BookDate, BookTime = @BookTime, TypeID = @TypeID, Type =@Type, Shift = @Shift where  ID= @id";

            }

            Hashtable ht = new Hashtable();

            ht.Add("@id", id);
            ht.Add("@CustomerName", txtname.Text);
            ht.Add("@Phone", txtphone.Text) ;
            ht.Add("@TableTName", cbtable.Text);
            ht.Add("@NoPeople", Convert.ToInt32(txtnocus.Text));
            ht.Add("@BookDate", txtdate.Value.Date);        
            TimeSpan timeSpan = TimeSpan.ParseExact((string)cbtime.SelectedItem, "hh\\:mm", null);
            ht.Add("@BookTime", timeSpan);
            ht.Add("@TypeID", cbtype.SelectedValue);
            ht.Add("@Type", cbbooktype.Text);
            ht.Add("@Shift", Convert.ToInt32(txtshift.Text));
            ht.Add("@TableID", cbtable.SelectedValue);
            if (mainClass.sql(qry, ht) > 0)
            {
                //MessageBox.Show("Thêm thành công");
                id = 0;
                txtname.Text = "";
                txtname.Focus();
            }
            if (cbbooktype.Text == "Đã xác nhận")
            {
                string updateTableStatusQuery = "UPDATE TableList SET TableStatus = 'Waiting' WHERE ID = @TableID";
                SqlCommand cmd = new SqlCommand(updateTableStatusQuery, mainClass.con);
                cmd.Parameters.AddWithValue("@TableID", cbtable.SelectedValue);
                if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
                cmd.ExecuteNonQuery();
                if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            }
            else
            {
                string updateTableStatusQuery = "UPDATE TableList SET TableStatus = NULL WHERE ID = @TableID";
                SqlCommand cmd = new SqlCommand(updateTableStatusQuery, mainClass.con);
                cmd.Parameters.AddWithValue("@TableID", cbtable.SelectedValue);
                if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
                cmd.ExecuteNonQuery();
                if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            }
            this.Close();
        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            if (txtname.Text == "Họ tên")
            {
                txtname.Text = "";
                txtname.ForeColor = Color.Black;
            }
        }
        public int GetShift(TimeSpan time)
        {
            if (time >= new TimeSpan(10, 0, 0) && time < new TimeSpan(14, 0, 0))
            {
                return 1; 
            }
            else if (time >= new TimeSpan(14, 0, 0) && time < new TimeSpan(17, 0, 0))
            {
                return 2; 
            }
            else
            {
                return 3; 
            }
        }
        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                txtname.Text = "Họ tên";
                txtname.ForeColor = Color.Gray;
            }
        }

        private void cbtime_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            var time = TimeSpan.Parse(cbtime.SelectedItem.ToString());
            var shift = GetShift(time);
            txtshift.Text = shift.ToString();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}