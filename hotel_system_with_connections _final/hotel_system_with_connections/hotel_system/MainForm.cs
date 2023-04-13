﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_system
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientinfo client = new Clientinfo();
            client.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Roominfo room = new Roominfo();
            room.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TurnOff_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staffinfo staff = new Staffinfo();
            staff.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RoomNo res = new RoomNo();
            res.Show();
            this.Hide();
        }
    }
}
