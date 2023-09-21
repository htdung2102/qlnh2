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
    public partial class ChangeTable : Form
    {
        private string currentTableName;
        public static OrderUpdate od;
        public static pos ps;
        public ChangeTable(OrderUpdate ud, pos p, string tableName)
        {
            InitializeComponent();
            od = ud;
            ps = p;
            currentTableName = tableName;
        }
        public string NewTableID { get; private set; }
        private string OriginTableID;
        private void ChangeTable_Load(object sender, EventArgs e)
        {
            Addcategory();
        }
        private void Addcategory()
        {
            string qry = "select * from TableType";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TypePanel.Controls.Clear();
            if (dt.Rows.Count > 0)
            {
                //  List<Guna.UI.WinForms.GunaButton> buttons = new List<Guna.UI.WinForms.GunaButton>();
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                    b.BaseColor = Color.FromArgb(29, 38, 125);
                    b.Size = new Size(90, 50);
                    b.Text = row["TypeName"].ToString();
                    b.Image = null;

                    b.Click += new EventHandler(Type_Click);
                    TypePanel.Controls.Add(b);

                }
                //flowLayoutPanel1.Controls.AddRange(buttons.ToArray());
            }
        }
        private void Type_Click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaButton clickedButton = sender as Guna.UI.WinForms.GunaButton;
            if (clickedButton == null)
            {              
                return;
            }

            string tableType = clickedButton.Text.ToString();
            Addban(tableType);
        }
        private void Addban(string tableType)
        {
            string qry = "select * from TableList TL INNER JOIN TableType TT ON TL.TypeID = TT.TypeID WHERE TT.TypeName = @type AND TL.TableStatus IS NULL";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@type", tableType);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tablepanel.Controls.Clear();
            if (dt.Rows.Count > 0)
            {
                //  List<Guna.UI.WinForms.GunaButton> buttons = new List<Guna.UI.WinForms.GunaButton>();
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                    b.BaseColor = Color.White;
                    b.ForeColor = Color.FromArgb(0, 0, 0);
                    b.BorderColor = Color.FromArgb(0, 0, 0);
                    b.BorderSize = 1;
                    b.Size = new Size(66, 51);
                    b.Text = row["TableName"].ToString();
                    b.Font = new Font("Arial", 11);
                    b.TextAlign = HorizontalAlignment.Center;
                    b.Image = null;

                    b.Click += new EventHandler(b_click);
                    tablepanel.Controls.Add(b);

                }

            }
        //    UpdateTableColor();

        }
        private void b_click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaButton clickedButton = sender as Guna.UI.WinForms.GunaButton;
            if (clickedButton == null)
            {             
                return;
            }
            OriginTableID = ps.TableID1;

            string newTableName = clickedButton.Text;
            //   string originalTableName = od.lblban.Text;
            string qry = "SELECT ID FROM TableList WHERE TableName = @TableName";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@TableName", newTableName);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            NewTableID = cmd.ExecuteScalar().ToString();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }

            string updateQuery = "UPDATE tblorder SET TableID = @newTableID WHERE TableID= @originalTableID";
            SqlCommand updateCmd = new SqlCommand(updateQuery, mainClass.con);
            updateCmd.Parameters.AddWithValue("@newTableID", NewTableID);
            updateCmd.Parameters.AddWithValue("@originalTableID", OriginTableID);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            updateCmd.ExecuteNonQuery();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }

            string qry1 = @"UPDATE TableList 
               SET TableStatus = 
                     CASE 
                         WHEN ID= @originalTableID THEN NULL
                         WHEN ID = @newTableID THEN 'Pending'
                     END
               WHERE ID IN (@originalTableID,@newTableID)";
            SqlCommand cmd1 = new SqlCommand(qry1, mainClass.con);
            cmd1.Parameters.AddWithValue("@originalTableID", OriginTableID);
            cmd1.Parameters.AddWithValue("@newTableID", NewTableID);

            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            cmd1.ExecuteNonQuery();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            ps.UpdateTableColor();

            this.Close();
            od.Close();          

        }
       
    }
}
