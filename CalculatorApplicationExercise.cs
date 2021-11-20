using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplicationExercise
{
    
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "number 1";
            label2.Text = "number 2"; 
            label3.Text = "result=";
            button1.Text = "sin";
            button2.Text = "cos";
            button3.Text = "tan";
            button4.Text = "x^y";
            button5.Text = "x^3";
            button6.Text = "x^2";
            button7.Text = "ln";
            button8.Text = "log"; 
            button9.Text = "1/x";
            button10.Text = "+";
            button11.Text = "-";
            button12.Text = "*";
            button13.Text = "/";
            button14.Text = "Clear!";
        }

        // sine
        private void button1_Click(object sender, EventArgs e)
        {
               
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double result = Math.Sin(number1);

            textBox3.Text = Convert.ToString(result);
           
        }

        //cosine
        private void button2_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double result = Math.Cos(number1);

            textBox3.Text = Convert.ToString(result);
        }

        //tangent
        private void button3_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double result =Math.Tan(number1);

            textBox3.Text = Convert.ToString(result);
        }

        //x^y
        private void button4_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double result = Math.Pow(number1,number2);

            textBox3.Text = Convert.ToString(result);
        }

        //x^3
        private void button5_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double result = Math.Pow(number1,3);

            textBox3.Text = Convert.ToString(result);
        }

        //x^2
        private void button6_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double result = Math.Pow(number1,2);

            textBox3.Text = Convert.ToString(result);
        }

        //ln
        private void button7_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double result = Math.Exp(number1);

            textBox3.Text = Convert.ToString(result);
        }

        //log
        private void button8_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double result = Math.Log(number1);

            textBox3.Text = Convert.ToString(result);
        }

        // 1/x
        private void button9_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double result = (1/number1);

            textBox3.Text = Convert.ToString(result);
        }

        // additon
        private void button10_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double result = number1+number2;

            textBox3.Text = Convert.ToString(result);
        }

        //substrsction
        private void button11_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double result = number1-number2 ;

            textBox3.Text = Convert.ToString(result);
        }

        //multiplying
        private void button12_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double result = number1*number2;

            textBox3.Text = Convert.ToString(result);
        }

        //division
        private void button13_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(textBox1.Text);
            double number2 = Convert.ToDouble(textBox2.Text);

            double result = number1/number2;

            textBox3.Text = Convert.ToString(result);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";


        }
    }
}