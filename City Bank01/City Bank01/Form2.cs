﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace City_Bank01
{
    public partial class Form2 : Form
    {

       
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            homepage f2 = new homepage();
            f2.Show();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
               SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\DATA\info01.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * From Table02 Where Username='" + textBox1.Text.Trim() + "' and Password ='" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
               // Form2 ss = new Form2();
               
                //ss.Show();
                Form5 ob1 = new Form5();
                ob1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please double check your Username and password");
            }


        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
