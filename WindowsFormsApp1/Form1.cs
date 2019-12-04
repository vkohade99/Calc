using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<double> numbers = new List<double>();
        List<string> operations = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
                textBox1.Text = "7";
                
            else textBox1.Text = textBox1.Text + "7";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0) numbers.Add(Convert.ToDouble(textBox1.Text));
            operations.Add("-");
            textBox1.Text = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
                textBox1.Text = "8";
            else textBox1.Text = textBox1.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
                textBox1.Text = "9";
            else textBox1.Text = textBox1.Text + "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
                textBox1.Text = "4";
            else textBox1.Text = textBox1.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
                textBox1.Text = "5";
            else textBox1.Text = textBox1.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
                textBox1.Text = "6";
            else textBox1.Text = textBox1.Text + "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
                textBox1.Text = "1";
            else textBox1.Text = textBox1.Text + "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
                textBox1.Text = "2";
            else textBox1.Text = textBox1.Text + "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
                textBox1.Text = "3";
            else textBox1.Text = textBox1.Text + "3";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
                textBox1.Text = "0";
            else textBox1.Text = textBox1.Text + "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
                textBox1.Text = "0.";
            else textBox1.Text = textBox1.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Console.WriteLine(numbers.Count);
            numbers.Add(Convert.ToDouble(textBox1.Text));
            string operation = operations[0];
            double num1 = numbers[0];
            double num2 = numbers[1];
            double result = 0;
            switch (operation)
            {
                case "/": 
                    if(num2!=0) result = num1 / num2;
                        break;
                case "+": 
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "x":
                    result = num1 * num2;
                    break;
            }
            numbers.RemoveAt(0);
            operations.RemoveAt(0);
            numbers[0] = result;
            textBox1.Text = result.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (numbers.Count == 0) numbers.Add(Convert.ToDouble(textBox1.Text));
            operations.Add("/");
            textBox1.Text = null;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (numbers.Count == 0) numbers.Add(Convert.ToDouble(textBox1.Text));
            operations.Add("x");
            textBox1.Text = null;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(numbers.Count==0) numbers.Add(Convert.ToDouble(textBox1.Text));
            operations.Add("+");
            textBox1.Text = null;
        }
    }
}
