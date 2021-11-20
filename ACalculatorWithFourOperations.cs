using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//a calculator with four operations
namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "*";
            button4.Text = "/";
            button5.Text = "Clear!";
            label1.Text = "number 1";
            label2.Text = "number 2";
            label3.Text = "result=";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text); //Burda string olan text box'ı integer'a çevirdik
            int n2 = Convert.ToInt32(textBox2.Text);

            int sum = n1 + n2;

            textBox3.Text = Convert.ToString(sum); //int değerinde olan toplamı yazdırbilmek için stringe çevirdik
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text); 
            int n2 = Convert.ToInt32(textBox2.Text);

            int remainder = n1 - n2;

            textBox3.Text = Convert.ToString(remainder);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);

            int product = n1 * n2;

            textBox3.Text = Convert.ToString(product);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);

            int division = n1 / n2;

            textBox3.Text = Convert.ToString(division);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
