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
    public partial class Clientinfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\IC0N\Documents\hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            con.Open();
            String MyQuery = "select * from Client_tb1";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridView.DataSource = ds.Tables[0];
            con.Close();
        }
        public Clientinfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ClientId.Text = ClientGridView.SelectedRows[0].Cells[0].Value.ToString();
            ClientName.Text = ClientGridView.SelectedRows[0].Cells[1].Value.ToString();
            Phone.Text = ClientGridView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Client_tb1 values('" + ClientId.Text + "', '" + ClientName.Text + "','" + Phone.Text + "','" + Country.SelectedItem.ToString() + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client successfully added");
            con.Close();
            populate();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Clientinfo_Load(object sender, EventArgs e)
        {
            Datelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            populate();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            con.Open();
            String Myquery = "UPDATE Client_tb1 set ClientName='" + ClientName.Text + "', ClientPhone = '" + Phone.Text + "',ClientCountry = '" + Country.SelectedItem.ToString() + "' where ClientID = " + ClientId.Text + " )"; 

            SqlCommand cmd = new SqlCommand(Myquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client successfully Edited");
            con.Close();
            populate();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "delete from Client_tb1 where ClientID = '" + ClientId.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client successfully deleted");
            con.Close();
            populate();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void search_Click_1(object sender, EventArgs e)
        {
            con.Open();
            String MyQuery = "select * from Client_tb1 where ClientName='" + search.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(MyQuery, con);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridView.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
