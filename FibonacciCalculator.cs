using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacciExample1
{
    public partial class FibonacciCalculator : Form
    {
        public FibonacciCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Please Enter A Number For Fibonacci Series";
            textBox1.Text = "";
            button1.Text = "Calculate";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int number = Convert.ToInt32(textBox1.Text);
            int x = 1, y = 1, z;

            if (number == 1)
            {
               listBox1.Items.Add(x);
                
            }
            else if (number == 2)
            {
                listBox1.Items.Add(x);
                listBox1.Items.Add(y);
            }
            else
            {
                listBox1.Items.Add(x);
                listBox1.Items.Add(y);

                while (number >= 3)
                {
                    z = x + y;
                    x = y;
                    y = z;
                    number -= 1;
                    listBox1.Items.Add(z);
                }
            }
        }

    }
}
