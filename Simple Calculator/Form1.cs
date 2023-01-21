using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text=="")
            {
                MessageBox.Show("Both Numbers are mendatory");
            }
            else
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);
                int sum = n1 + n2;
                label4.Text = "Answer is " + sum.ToString();
                label4.Visible = true;

            }
           
        }


        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both Numbers are mendatory");
            }
            else
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);
                int sub = n1 - n2;
                label4.Text = "Answer is " + sub.ToString();
                label4.Visible = true;
            }
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both Numbers are mendatory");
            }
            else
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);

                int mul = n1 * n2;
                label4.Text = "Answer is " + mul.ToString();
                label4.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                float n1 = Int32.Parse(textBox1.Text);
                float n2 = Int32.Parse(textBox2.Text);
             if (n2 == 0)
            {
                MessageBox.Show("Not Possible");
            }
            else { 
                float div = n1 / n2;
                label4.Text = "Answer is " + div.ToString();
                label4.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both Numbers are mendatory");
            }
            else
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);
                int rem = n1 % n2;
                label4.Text = "Answer is " + rem.ToString();
                label4.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Both Numbers are mendatory");
            }
            else
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);
                int pow = 1;
               for(int i = 1; i < n2; i++)
                {
                    pow = pow + 1;
                }
                label4.Text ="Answer is " +pow.ToString();
                label4.Visible = true;
            }
        }
    }
}
