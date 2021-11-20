using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//This application determines whether or not to pass according to the score between 0-100 entered.
//Scores over 60 pass.
namespace ApplicationExersice2
{
    public partial class ApplicationExercise2 : Form
    {
        public ApplicationExercise2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "  Please Enter Your Note!";
            
            button1.Text = "CALCULATE!";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int note = Convert.ToInt32(textBox1.Text);

            if(note>100)
            {
                MessageBox.Show("Invalid Value! Please Enter a Valid Value!");
            }         
            else if (note >= 60)
            {
                MessageBox.Show("Congratulations! You've pass!");
            }
            else if (note>0 && note<60)
            {
                MessageBox.Show("Sorry! You've failed!");
            }
            else
            {
                MessageBox.Show("Invalid Value! Please Enter a Valid Value!");
            }
        }
    }
}
