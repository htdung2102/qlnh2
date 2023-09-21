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
    public partial class DiscountList : Form
    {
        public static Transaction TS;
        public DiscountList(Transaction T)
        {
            InitializeComponent();
            TS = T;
        }
        public string DiscountID { get; private set; }

      
        private void AddDiscount()
        {
            string qry = "select * from Discount";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DiscountPanel.Controls.Clear();
            if (dt.Rows.Count > 0)
            {
                //  List<Guna.UI.WinForms.GunaButton> buttons = new List<Guna.UI.WinForms.GunaButton>();
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                    b.BaseColor = Color.FromArgb(29, 38, 125);
                    b.Size = new Size(230, 80);
                    b.Text = row["Description"].ToString();
                    b.Image = null;

                    b.Click += new EventHandler(Type_Click);
                    DiscountPanel.Controls.Add(b);

                }
            }
        }
        private void Type_Click(object sender, EventArgs e)
        {
            
            Guna.UI.WinForms.GunaButton clickedButton = sender as Guna.UI.WinForms.GunaButton;
            string description = clickedButton.Text.ToString();
            string qry1 = "select ID, DiscountValue, TypeID, Point from Discount WHERE Description = @Description";
            SqlCommand cmd1 = new SqlCommand(qry1, mainClass.con);
            cmd1.Parameters.AddWithValue("@Description", description);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            
            string discountType = null;
            decimal discountValue = 0;
            int discountPoints = 0;
           
            using (SqlDataReader reader = cmd1.ExecuteReader())
            {
                if (reader.Read())
                {
                    DiscountID = reader["ID"].ToString();
                    discountType = reader["TypeID"].ToString();
                    discountValue = Convert.ToDecimal(reader["DiscountValue"]);
                    discountPoints = reader["Point"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Point"]);
                }
            }
           
            if (discountType != null)
            {
                switch (discountType)
                {
                    case "3":
                        int customerPoints = GetCustomerPoints();
                        if (customerPoints > 0)
                        {
                            if (customerPoints >= discountPoints)
                            {
                                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn đổi điểm không?", "Xác nhận", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    customerPoints -= discountPoints;
                                    UpdateCustomerPoints(customerPoints);
                                    TS.ShowCustomerInfo();
                                    TS.txtgiamgia.Text = discountValue.ToString("N0");                       
                                }
                            }
                            else
                            {
                                MessageBox.Show("Xin lỗi quý khách không đủ điểm.");
                            }
                        }                       
                        else
                        {
                            MessageBox.Show("Không thể sử dụng mã giảm giá này vì không có thông tin khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case "1":
                        TS.txtgiamgia.Text = discountValue.ToString("N0");
                        break;
                    case "2":
                        decimal totalAmount = Convert.ToDecimal(TS.txttongtien.Text);
                        decimal discountAmount = totalAmount * discountValue;
                        TS.txtgiamgia.Text = discountAmount.ToString("N0");
                        break;
                    default:
                        Console.WriteLine("Loại giảm giá không được hỗ trợ.");
                        break;
                }
            }

            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }

            this.Close();
        }    
        public int GetCustomerPoints()
        {
            string qry = @"SELECT C.Scores FROM
            tblorder tb inner join Customer c on tb.CustomerID = c.ID
            inner join TableList T ON T.ID = tb.TableID 
            where T.TableName = @tname and tb.payStatus = 'Pending'";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@tname", TS.lblban.Text);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            int points = 0;
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    points = Convert.ToInt32(reader[0]);
                }
            }
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            return points;
        }

        public void UpdateCustomerPoints(int newPoints)
        {
            string qry = @"UPDATE Customer SET Scores = @points FROM
                            tblorder tb inner join Customer c on tb.CustomerID = c.ID
                            inner join TableList T ON T.ID = tb.TableID 
                            where T.TableName = @tname and tb.payStatus = 'Pending'";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@points", newPoints);
            cmd.Parameters.AddWithValue("@tname", TS.lblban.Text);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            cmd.ExecuteNonQuery();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
        }
        private void DiscountList_Load(object sender, EventArgs e)
        {
            AddDiscount();
        }
    }
   
   
  
}

