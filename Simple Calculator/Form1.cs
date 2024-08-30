using System;
using System.Data;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        Boolean wasLastOperator = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!wasLastOperator)
            {
                richTextBox1.Text = richTextBox1.Text + "-";
                wasLastOperator = true;
            }

        }


        private void button12_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;

            var result = new DataTable().Compute(text, null);

            label1.Text = result.ToString();


        }

        private void button13_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "3";
            wasLastOperator = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "2";
            wasLastOperator = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "1";
            wasLastOperator = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "7";
            wasLastOperator = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "8";
            wasLastOperator = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "9";
            wasLastOperator = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!wasLastOperator)
            {
                richTextBox1.Text = richTextBox1.Text + "/";
                wasLastOperator = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            label1.Text = "";
            wasLastOperator = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "4";
            wasLastOperator = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "5";
            wasLastOperator = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "6";
            wasLastOperator = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!wasLastOperator)
            {
                richTextBox1.Text = richTextBox1.Text + "*";
                wasLastOperator = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int Lenght = richTextBox1.Text.Length - 1;
            richTextBox1.Text = richTextBox1.Text.Remove(Lenght);
            wasLastOperator = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "0";
            wasLastOperator = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + ".";
            wasLastOperator = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!wasLastOperator)
            {
                richTextBox1.Text = richTextBox1.Text + "+";
                wasLastOperator = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedChars = "1234567890-+*/.";

            if (!allowedChars.Contains(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                return;
            }

            string currentText = richTextBox1.Text;

            string specialChars = "+-*/.";

            if (currentText.Length > 0 && specialChars.Contains(currentText.Last()) && specialChars.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}