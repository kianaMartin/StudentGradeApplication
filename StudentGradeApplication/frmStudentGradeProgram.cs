using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double GradeEnglish, GradeMath, GradeScience, GradeFilipino, GradeHistory, GenAverage, Total;
            string name = textBox1.Text;
            GradeEnglish = Convert.ToDouble(textBox2.Text);
            GradeMath = Convert.ToDouble(textBox4.Text);
            GradeScience = Convert.ToDouble(textBox3.Text);
            GradeFilipino = Convert.ToDouble(textBox6.Text);
            GradeHistory = Convert.ToDouble(textBox5.Text);
            Total = GradeEnglish + GradeMath + GradeScience + GradeFilipino + GradeHistory;
            GenAverage = Total / 5;
            label8.Text = (GenAverage >= 75.00) ? "The student passed." : "Failed";
            label9.Text = ("The general average of " + name + " is " + GenAverage);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
