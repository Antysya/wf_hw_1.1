using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rez.Text = Convert.ToString(Convert.ToDouble(num1.Text) + Convert.ToDouble(num2.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rez.Text = Convert.ToString(Convert.ToDouble(num1.Text) * Convert.ToDouble(num2.Text));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            rez.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            rez.Text = Convert.ToString(Convert.ToDouble(num1.Text) - Convert.ToDouble(num2.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(num2.Text) !=0)
            rez.Text = Convert.ToString(Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text));
            else
                num2.Clear();
        }
    }
}
