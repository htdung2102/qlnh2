using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlnh1
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "UserName")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "UserName";
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

            txtUser.Text = "UserName";
            txtUser.ForeColor = Color.Gray;

            txtPass.Text = "Password";
            txtPass.ForeColor = Color.Gray;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.PasswordChar = '*';
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Gray;
                
            }
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            if (mainClass.IsValidUser(txtUser.Text, txtPass.Text) == false)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ");
                return;
            }
            else
            {
                mainClass.GlobalVariables.StaffID = mainClass.GetStaffID(txtUser.Text);
                this.Hide();
                frmmain frm = new frmmain();
                frm.Show();
                HomeForm homeForm = new HomeForm();
                frm.OpenChildForm(homeForm);


            }
        }
    }
}
