using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        int sum = 0;
        string newNr = "";
        bool sumHasBeenPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddDigit(string nr)
        {
            if (sumHasBeenPressed)
            {
                sum = 0;
                newNr = "";
                textBox1.Text = "";
                sumHasBeenPressed = false;

            }
            textBox1.AppendText(nr);
            newNr += nr;
        }

        private void Summarize()
        {
            if (newNr != "")
            {
            sum = sum + Convert.ToInt32(newNr);
            newNr = "";
            textBox1.Text = Convert.ToString(sum);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDigit("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDigit("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDigit("3");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AddDigit("4");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            AddDigit("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDigit("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddDigit("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddDigit("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            AddDigit("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddDigit("0");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Summarize();
            textBox1.Text = sum + "+";
        }

        private void buttonSummarize_Click(object sender, EventArgs e)
        {
            sumHasBeenPressed = true;
            Summarize();
            textBox1.Text = Convert.ToString(sum);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            sum = 0;
            newNr = "";
            textBox1.Text = "";
        }

        private void arkivToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void omProgrammetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutbox = new AboutBox1();
            aboutbox.Show();
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
