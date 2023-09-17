using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salwa
{
    public partial class Form1 : Form
    {
        int num;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("An apple a day keeps the doctor away :)");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (int.TryParse(HOURS.Text, out num)) 

            {
                MessageBox.Show("Correect input.int");
            }
            else
            {
                MessageBox.Show("Renter input ");
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TIMES OF GOING TO THE GYM ");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "All is Everything Needed to Stay Healthy ";
        }
    }
}
