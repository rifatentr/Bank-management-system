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

namespace City_Bank01
{
    public partial class Form10 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\DATA\info01.mdf;Integrated Security=True;Connect Timeout=30");
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Table01  Where username = '" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Account Deleted successfully");

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 ob = new Form5();
            ob.Show();
            this.Hide();
        }
    }
}
