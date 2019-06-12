using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                Double sR1 = double.Parse(SR1.Text); // these four lines are coding in the boxes where the user can input their numbers and the boxes are coded to represent a variable 
                Double sR2 = double.Parse(SR2.Text);
                Double sR3 = double.Parse(textBox5.Text);
                Double sR4 = double.Parse(textBox6.Text);

                double TR = sR1 + sR2 + sR3 + sR4; // this is the formula for the series circuit and it uses the variables from the inbox boxes 
                MessageBox.Show("Total resistance = " + TR.ToString("0.00") + " cm");
            }
            catch
            {
                MessageBox.Show("Stop! You have violated the law PAY THE COURT A FINE OR SERVE YOUR SENTENCE!");// this is for when anything than an number is entered it comes up with this message to notify the user they have entered something invalid 
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SR1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double pR1 = double.Parse(textBox1.Text); // this is the same code again except it is coding the boxes into variables 
                Double pR2 = double.Parse(textBox2.Text);
                Double pR3 = double.Parse(textBox3.Text);
                Double pR4 = double.Parse(textBox4.Text);


                double TR = 1/pR1 + 1/pR2 + 1/pR3 + 1/pR4; // this is the formula for the parrallel cicuit whihc is also using the variables 
                MessageBox.Show("Total resistance = " + TR.ToString("0.00") + " cm");
            }
            catch
            {
                MessageBox.Show("wait i know you......AHA *backs away "); // this is another msg that tells the user thay have entered an incorrect character 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e) // these lines of code are for renaming parts of the program so that it is easier for me to code
        {

        }
    }
}
