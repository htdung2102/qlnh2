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

    public partial class pos : Form
    {
       
        ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
        ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem();
        public pos()
        { 
            InitializeComponent();
            toolStripMenuItem1.Text = "In phiếu kiểm đồ";
            toolStripMenuItem1.Click += new EventHandler(toolStripMenuItem1_Click);

            // Thêm ToolStripMenuItem vào ContextMenuStrip
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
        }
        public string TableName;
        private order _orderForm;
        private OrderUpdate _orderUpdateForm;
        public string TableID { get; private set; }
        public string TableID1 { get; private set; }
        private void pos_Load(object sender, EventArgs e)
        {           
          
            Addcategory();
            UpdateTableColor();
        }
        private void Addcategory()
        {
            string qry = "select * from TableType";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabletypePanel.Controls.Clear();
            if (dt.Rows.Count > 0)
            {             
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                    b.BaseColor = Color.FromArgb(29, 38, 125);
                    b.Size = new Size(120, 60);
                    b.Text = row["TypeName"].ToString();
                    b.Image = null;
                    b.Click += new EventHandler(Type_Click);
                    tabletypePanel.Controls.Add(b);
                }
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
            string qry = "select * from TableList TL INNER JOIN TableType TT ON TL.TypeID = TT.TypeID WHERE TT.TypeName = @type ";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@type", tableType);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tablepanel.Controls.Clear();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                    b.BaseColor = Color.White;
                    b.ForeColor = Color.FromArgb(0, 0, 0);
                    b.BorderColor = Color.FromArgb(0, 0, 0);
                    b.BorderSize = 1;
                    b.Size = new Size(150, 105);
                    b.Text = row["TableName"].ToString();
                    b.Font = new Font("Arial", 16);                    
                    b.TextAlign = HorizontalAlignment.Center;
                    b.Image = null;
                    b.ContextMenuStrip = contextMenuStrip1;
                    b.MouseClick += new MouseEventHandler(b_MouseClick);
                    tablepanel.Controls.Add(b);               
                }      
            }
            UpdateTableColor();
        }
        private void b_MouseClick(object sender, MouseEventArgs e)
        {
            Guna.UI.WinForms.GunaButton clickedButton = sender as Guna.UI.WinForms.GunaButton;
            if (clickedButton == null)
            {
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                if (clickedButton.BaseColor == Color.White)
                {
                    TableName = clickedButton.Text.ToString();
                    string qry = "SELECT ID FROM TableList WHERE TableName = @TableName";
                    SqlCommand cmd = new SqlCommand(qry, mainClass.con);
                    cmd.Parameters.AddWithValue("@TableName", TableName);
                    if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
                    TableID = cmd.ExecuteScalar().ToString();
                    if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
                    if (_orderForm == null || _orderForm.IsDisposed)
                        _orderForm = new order(this);
                    _orderForm.mainID = 0;
                    _orderForm.grdorder.Rows.Clear();
                    _orderForm.Show();
                    _orderForm.lblban.Text = TableName;
                }
                else if (clickedButton.BaseColor == Color.FromArgb(44, 119, 206))
                {
                    TableName = clickedButton.Text.ToString();
                    string qry = "SELECT ID FROM TableList WHERE TableName = @TableName";
                    SqlCommand cmd = new SqlCommand(qry, mainClass.con);
                    cmd.Parameters.AddWithValue("@TableName", TableName);
                    if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
                    TableID1 = cmd.ExecuteScalar().ToString();
                    if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
                    if (_orderUpdateForm == null || _orderUpdateForm.IsDisposed)
                        _orderUpdateForm = new OrderUpdate(this);
                    _orderUpdateForm.mainID = 0;
                    _orderUpdateForm.Show();
                    _orderUpdateForm.lblban.Text = TableName;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (clickedButton.BaseColor == Color.FromArgb(44, 119, 206))
                {
                    contextMenuStrip1.Show((Control)sender, new Point(e.X, e.Y));
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }
        private void b_click(object sender, EventArgs e)
        {
            
        }
        public void UpdateTableColor()
        {
            foreach (Guna.UI.WinForms.GunaButton b in this.tablepanel.Controls.OfType<Guna.UI.WinForms.GunaButton>())
            {
                string tableName1 = b.Text;
                string qry1 = "Select TableStatus from TableList Where TableName = @TableName";
                SqlCommand cmd1 = new SqlCommand(qry1, mainClass.con);
                cmd1.Parameters.AddWithValue("@TableName", tableName1);
                if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
                string status = cmd1.ExecuteScalar().ToString();
                if (status == "Pending")
                {
                    b.BaseColor = Color.FromArgb(44, 119, 206);
                    b.OnHoverBaseColor = Color.FromArgb(44, 119, 206);
                }
                else if(status == "Waiting")
                {
                    b.BaseColor = Color.Yellow;
                }
                else 
                {
                    b.BaseColor = Color.White;
                }
                if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            }
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void pos_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
