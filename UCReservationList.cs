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
    public partial class UCReservationList : UserControl
    {
        public UCReservationList()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = "SELECT * FROM Reservation";

            if (!string.IsNullOrEmpty(txtsearch.Text))
            {
                qry += " WHERE CustomerName LIKE '%" + txtsearch.Text.Trim() + "%'";
            }
            ListBox lb = new ListBox();
            lb.Items.Add(dvgid);
            lb.Items.Add(dvgName);
            lb.Items.Add(dvgphone);
            lb.Items.Add(dvgtname);
            lb.Items.Add(dvgpeople);
            lb.Items.Add(dvgbookdate);
            lb.Items.Add(dvgbooktime);
            lb.Items.Add(dvgarea);
            lb.Items.Add(dvgtype);
            lb.Items.Add(dvgshift);
            lb.Items.Add(dvgtableID);


            mainClass.LoadData(qry, grdtable, lb);
        }
        private void UCReservationList_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void grdtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdtable.CurrentCell.OwningColumn.Name == "dvgedit")
            {
                int currentTableId = Convert.ToInt32(grdtable.CurrentRow.Cells["dvgtableID"].Value);

                // Mở form AddReservation với currentTableId
                AddReservation cate = new AddReservation(currentTableId);           
                cate.id = Convert.ToInt32(grdtable.CurrentRow.Cells["dvgid"].Value);
                cate.txtname.Text = Convert.ToString(grdtable.CurrentRow.Cells["dvgName"].Value);
                cate.txtphone.Text = Convert.ToString(grdtable.CurrentRow.Cells["dvgphone"].Value);
                cate.cID = Convert.ToInt32(grdtable.CurrentRow.Cells["dvgarea"].Value);
                cate.cbtable.Text= Convert.ToString(grdtable.CurrentRow.Cells["dvgtname"].Value);
                cate.txtnocus.Text = Convert.ToString(grdtable.CurrentRow.Cells["dvgpeople"].Value);
                cate.txtdate.Text = Convert.ToString(grdtable.CurrentRow.Cells["dvgbookdate"].Value);
                TimeSpan timeSpan = TimeSpan.Parse(grdtable.CurrentRow.Cells["dvgbooktime"].Value.ToString());
                string time = timeSpan.ToString(@"hh\:mm");
                if (!cate.cbtime.Items.Contains(time))
                {
                    cate.cbtime.Items.Add(time);
                }
                cate.cbtime.SelectedItem = time;
                cate.cbbooktype.Text = Convert.ToString(grdtable.CurrentRow.Cells["dvgtype"].Value);
                cate.txtshift.Text = Convert.ToString(grdtable.CurrentRow.Cells["dvgshift"].Value);
                mainClass.Blurbackground(cate);
                GetData();
             }
            if (grdtable.CurrentCell.OwningColumn.Name == "dvgdel")
            {
                int id = Convert.ToInt32(grdtable.CurrentRow.Cells["dvgid"].Value);
                string tableNameQuery = "SELECT TableTName FROM Reservation WHERE ID = @ID";
                using (SqlCommand cmd1 = new SqlCommand(tableNameQuery, mainClass.con))
                {
                    cmd1.Parameters.AddWithValue("@ID", id);

                    try
                    {
                        mainClass.con.Open();
                        string tname = cmd1.ExecuteScalar()?.ToString();

                        if (!string.IsNullOrEmpty(tname))
                        {
                            // Cập nhật trạng thái của bàn trước khi xóa bàn đặt
                            string updateTableStatusQuery = "UPDATE TableList SET TableStatus = NULL WHERE TableName = @TableName";
                            using (SqlCommand cmd2 = new SqlCommand(updateTableStatusQuery, mainClass.con))
                            {
                                cmd2.Parameters.AddWithValue("@TableName", tname);
                                cmd2.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ nếu có
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                    finally
                    {
                        if (mainClass.con.State == ConnectionState.Open) { mainClass.con.Close(); }
                    }
                }

                // Xóa bàn đặt
                string qry2 = "DELETE FROM Reservation WHERE ID = @ID";
                using (SqlCommand cmd3 = new SqlCommand(qry2, mainClass.con))
                { 
                    cmd3.Parameters.AddWithValue("@ID", id);
                    mainClass.con.Open();
                    cmd3.ExecuteNonQuery();
                    mainClass.con.Close();
                }

                MessageBox.Show("Xóa thành công");
                GetData();
                grdtable.Refresh();
            }
        }

        private void grdtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnaddtable_Click(object sender, EventArgs e)
        {

        }

        private void btnaddreservation_Click(object sender, EventArgs e)
        {
            AddReservation ar = new AddReservation();
            ar.Show();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
