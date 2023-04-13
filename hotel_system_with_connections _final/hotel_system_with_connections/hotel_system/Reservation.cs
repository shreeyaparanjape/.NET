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

namespace hotel_system
{
    public partial class RoomNo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\IC0N\Documents\hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            con.Open();
            String MyQuery = "select * from Reservation_tb1";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        public RoomNo()
        {
            InitializeComponent();
        }
        DateTime today;
        private void ReservationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ReservationId.Text = ReservationGridView.SelectedRows[0].Cells[0].Value.ToString();
            RoomNos.Text = ReservationGridView.SelectedRows[0].Cells[2].Value.ToString();
            ClientName.Text = ReservationGridView.SelectedRows[0].Cells[1].Value.ToString();
            today = DateIn.Value;
        }

        private void DateIn_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(DateIn.Value, today);
            if (res < 0)
                MessageBox.Show("Wrong date for reservation");
        }

        private void DateOut_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(DateOut.Value, DateIn.Value);
            if (res < 0)
                MessageBox.Show("Wrong DateOut check once more for reservation");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Reservation_tb1 values('" + ReservationId.Text + "', '" + ClientName.Text + "','" + RoomNos.Text + "','" + DateIn.Text + "','" + DateOut.Text + "' )", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation successfully added");
            con.Close();
            populate();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(ReservationId.Text == "")
            {
                MessageBox.Show("Enter the Reservation id to be deleted");
            }
            else
            {
                con.Open();
                String query = "delete from Reservation_tb1 where StaffID = " + ReservationId.Text + " ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation successfully deleted");
                con.Close();
                populate();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if(ReservationId.Text == "")
            {
                MessageBox.Show("Empty ReservationID, enter Reservation id");
            }
            else
            {
                con.Open();
                String Myquery = "UPDATE Reservation_tb1 set  Client = '" + ClientName.Text + "',Room = '" + RoomNos.Text + "', DateIn = " + DateIn.Value.ToString() + ",DateOut = " + DateOut.Value.ToString() + " where ReservationId = " + ReservationId.Text + ")";

                SqlCommand cmd = new SqlCommand(Myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation id successfully Edited");
                con.Close();
                populate();
            }
        }

       /* private void ReservationSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            String MyQuery = "select * from Reservation_tb1 where ReservationId='" + ReservationSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();   
            con.Close();
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
