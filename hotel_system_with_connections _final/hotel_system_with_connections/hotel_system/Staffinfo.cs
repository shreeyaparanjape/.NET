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
    
    public partial class Staffinfo : Form

    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\IC0N\Documents\hoteldb.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\IC0N\Documents\hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            String MyQuery = "select * from Staff_tb1";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);

            StaffGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        public Staffinfo()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
                        con.Open();
            SqlCommand cmd = new SqlCommand("insert into Staff_tb1 values('" + StaffId.Text + "', '" + StaffName.Text + "','" + StaffPhone.Text + "','" + Gender.SelectedItem.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff successfully added");
            con.Close();
            populate();
        }

        private void StaffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           StaffId.Text = StaffGridView.SelectedRows[0].Cells[0].Value.ToString();
            StaffName.Text = StaffGridView.SelectedRows[0].Cells[1].Value.ToString();
            StaffPhone.Text = StaffGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
             
            con.Open();
            String Myquery = "UPDATE Staff_tb1 set StaffName='" + StaffName.Text + "', StaffPhone = '" + StaffPhone.Text + "',Gender = '" + Gender.SelectedItem.ToString() + "' where StaffId = " + StaffId.Text + " )";

            SqlCommand cmd = new SqlCommand(Myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff successfully Edited");
            con.Close();
            populate();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "delete from Staff_tb1 where StaffID = " + StaffId.Text + " ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff successfully deleted");
            con.Close();
            populate();
        }

        /*private void Search_Click(object sender, EventArgs e)
        {
            con.Open();
            String MyQuery = "select * from Staff_tb1 where StaffName='" + StaffSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridView.DataSource = ds.Tables[0];
            con.Close();
        }*/

        private void Staffinfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
