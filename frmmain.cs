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
    public partial class frmmain : Form
    {

     
        public frmmain()
        {
            InitializeComponent();         
           
        }
        static frmmain _obj;
        public static frmmain Instance
        {
            get { if(_obj == null ) { _obj = new frmmain(); } return _obj; }
        }
        private Form currentFormChild;
        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelbody.Controls.Add(childForm);
            panelbody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
               
        }
      
        private void btnproduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new product());
        }

        private void panelbody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
        private void gunaButtonbtnproduct2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
        }

        private void btncategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new category());
        }

        private void btntable_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new tableview());

        }

        private void btnstaff_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new staff());
        }    
        private void gunaButton5_Click(object sender, EventArgs e)
        {
            pos ps = new pos();
            ps.Show();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewCustomer());
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Payment());
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HomeForm());
        }

        private void tbnrevenue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RevenueManage());
        }
    }
}
