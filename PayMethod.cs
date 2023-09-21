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
    public partial class PayMethod : Form
    {
        public static Transaction TS;
        public PayMethod(Transaction T)
        {
            InitializeComponent();
            TS = T;
        }

        private void PayMethod_Load(object sender, EventArgs e)
        {
            AddPayMethod();
        }
        private void AddPayMethod()
        {
            string qry = "select * from PaymentMethod";
            SqlCommand cmd = new SqlCommand(qry, mainClass.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PayMethodPanel.Controls.Clear();
            if (dt.Rows.Count > 0)
            {               
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                    b.BaseColor = Color.FromArgb(29, 38, 125);
                    b.Size = new Size(120, 60);
                    b.Text = row["Name"].ToString();
                    b.Image = null;

                    b.Click += new EventHandler(Type_Click);
                    PayMethodPanel.Controls.Add(b);

                }
                //flowLayoutPanel1.Controls.AddRange(buttons.ToArray());
            }
        }
        private void Type_Click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaButton clickedButton = sender as Guna.UI.WinForms.GunaButton;
            string PayName = clickedButton.Text.ToString();
            TS.txtHTTT.Text = PayName;
            this.Close();

        }
    }
}
