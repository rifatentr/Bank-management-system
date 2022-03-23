using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_Bank01
{
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(comboBox1.Text=="Admin")
            {
                Form2 ob1 = new Form2();
                ob1.Show();
                this.Hide();
            }
            else
            {
                Form3 ob1 = new Form3();
                ob1.Show();
                this.Hide();

            }

            

          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 ob1 = new Form4();
            ob1.Show();
            this.Hide();
        }
    }
}
