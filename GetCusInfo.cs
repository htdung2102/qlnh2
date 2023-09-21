using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace qlnh1
{
    public partial class GetCusInfo : Form
    {
        public GetCusInfo()
        {
            InitializeComponent();
        }

        public string CustomerName { get; private set; }
        public string CustomerID { get; private set; }
        private void btncheck_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtcusphone.Text;

            // Query your customer database here with the phone number
            string qry = "SELECT CustomerName, ID FROM Customer WHERE Phone = @phone";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            cmd.Parameters.AddWithValue("@phone", phoneNumber);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtcusname.Text = reader["CustomerName"].ToString();
                CustomerID = reader["ID"].ToString();
            }
            else
            {
                MessageBox.Show("Khách hàng mới");
                txtcusname.Clear();
                CustomerID = null;
            }
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtcusphone.Text;
            string name = txtcusname.Text;
          //  byte[] utf8Bytes = Encoding.UTF8.GetBytes(name);

            // Save the new customer to your database here
            string qry1 = @"INSERT INTO Customer ( CustomerName, Phone, Scores) VALUES ( @name, @phone, @Scores);
                       SELECT SCOPE_IDENTITY()";
            SqlCommand cmd1 = new SqlCommand(qry1, mainClass.con);
            cmd1.Parameters.AddWithValue("@phone", phoneNumber);
            cmd1.Parameters.AddWithValue("@name", name);
       //     cmd1.Parameters.AddWithValue("@Levels", name);
            cmd1.Parameters.AddWithValue("@Scores", Convert.ToDouble(0));

            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            cmd1.ExecuteNonQuery();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
            MessageBox.Show("Customer saved");

            string qry2 = "SELECT ID FROM Customer WHERE Phone = @phone";
            SqlCommand cmd2 = new SqlCommand(qry2, mainClass.con);
            cmd2.Parameters.AddWithValue("@phone", txtcusphone.Text);
            if (mainClass.con.State == ConnectionState.Closed) { mainClass.con.Open(); }
            CustomerID = cmd2.ExecuteScalar().ToString();
            if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); } 

        }
        private bool IsValidCustomerInfo()
        {
            // Kiểm tra xem tên và số điện thoại có được nhập hay không
            if (string.IsNullOrWhiteSpace(txtcusname.Text) || string.IsNullOrWhiteSpace(txtcusphone.Text))
            {
                MessageBox.Show("Vui lòng nhập tên và số điện thoại của khách hàng.");
                return false;
            }

            // (Tùy chọn) Kiểm tra xem số điện thoại có hợp lệ hay không
            if (!Regex.IsMatch(txtcusphone.Text, @"^\d{10}$")) // Số điện thoại gồm 10 chữ số
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập lại.");
                return false;
            }

            return true;
        }
        private void lblclose_Click(object sender, EventArgs e)
        {
            
            if (IsValidCustomerInfo())
            {
                // Lưu tên khách hàng
                CustomerName = txtcusname.Text;

                // Đóng form
                this.Close();
            }
        }

        private void GetCusInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
