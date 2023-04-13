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
    public partial class Roominfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\IC0N\Documents\hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            con.Open();
            String MyQuery = "select * from Room_tb1";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        public Roominfo()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Room_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            String isfree;
            if (YesRadio.Checked == true)
                isfree = "Free";
            else
                isfree = "Busy";
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Room_tb1 values('" + RoomId.Text + "', '" + RoomPhone.Text + "','" + isfree + "' )", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room successfully added");
            con.Close();
            populate();
        }

        private void RoomGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           RoomId.Text = RoomGridView.SelectedRows[0].Cells[0].Value.ToString();
 
            RoomPhone.Text = RoomGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "delete from Room_tb1 where RoomID = " + RoomId.Text + " ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room successfully deleted");
            con.Close();
            populate();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            String isfree;
            if (YesRadio.Checked == true)
                isfree = "Free";
            else
                isfree = "Busy";
            con.Open();
            String Myquery = "UPDATE Room_tb1 set  RoomPhone = '" + RoomPhone.Text + "',RoomFree = '" +isfree + "' where RoomId = " + RoomId.Text + " )";

            SqlCommand cmd = new SqlCommand(Myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Room successfully Edited");
            con.Close();
            populate();
        }

        private void RoomSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            String MyQuery = "select * from Room_tb1 where RoomId='" + RoomSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
    
    }
