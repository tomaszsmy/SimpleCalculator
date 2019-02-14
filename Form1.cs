using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string text;
        private bool ischar;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Calculator";
            text = "";
            ischar= false;
            screen.Text = "0";
        }

        private void Addscreen(string x)
        {   
            ischar = true;
            text += x;
            screen.Text = text;
        }

        private void B1_Click(object sender, EventArgs e)
        {
            Addscreen("1");
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Addscreen("2");
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Addscreen("3");
        }

        private void B6_Click(object sender, EventArgs e)
        {
            Addscreen("6");
        }

        private void B5_Click(object sender, EventArgs e)
        {
            Addscreen("5");
        }

        private void B4_Click(object sender, EventArgs e)
        {
            Addscreen("4");
        }

        private void B7_Click(object sender, EventArgs e)
        {
            Addscreen("7");
        }

        private void B8_Click(object sender, EventArgs e)
        {
            Addscreen("8");
        }

        private void B9_Click(object sender, EventArgs e)
        {
            Addscreen("9");
        }

        private void B_division_Click(object sender, EventArgs e)
        {
            
            if (ischar) Addscreen("/");
            ischar = false;

        }

        private void B_multiplication_Click(object sender, EventArgs e)
        {
            if (ischar) Addscreen("*");
            ischar = false;
        }

        private void B_subtraction_Click(object sender, EventArgs e)
        {
            if (ischar) Addscreen("-");
            ischar = false;
        }

        private void B_adding_Click(object sender, EventArgs e)
        {
            if (ischar) Addscreen("+");
            ischar = false;
        }

        private string[] SplitChars(int value)
        {
            string[] chars = new string[value];
            int count = 0;
            for (int i = 0; i < screen.Text.Length; i++)
            {
                if (screen.Text[i] == '+') chars[count++] = "+";
                else if (screen.Text[i] == '-') chars[count++] = "-";
                else if (screen.Text[i] == '*') chars[count++] = "*";
                else if (screen.Text[i] == '/') chars[count++] = "/";

            }
            return chars;
        }

        private void B_result_Click(object sender, EventArgs e)
        {


            if (ischar)
            { 
            double[] numbers = Array.ConvertAll(screen.Text.Split(new string[] { "+","-" ,"*","/"}, StringSplitOptions.None),double.Parse);
            string[] chars = SplitChars(numbers.Length);
            double result=0;
          
 

            for(int i=0;i<numbers.Length-1;i++)
            {
                if(chars[i]=="+") result = numbers[i] + numbers[i + 1];
                else if (chars[i ] == "-") result += numbers[i] - numbers[i + 1];
                else if (chars[i] == "/") result += numbers[i] / numbers[i + 1];
                else if (chars[i ] == "*") result +=  numbers[i] * numbers[i + 1];


            }
            text = result.ToString();
            screen.Text = result.ToString();
            }
        }

        private void B0_Click(object sender, EventArgs e)
        {
            Addscreen("0");
        }

        private void B_clear_Click(object sender, EventArgs e)
        {

            if (text.Length > 0)
            {
                screen.Text = "";
                text = text.Substring(0, text.Length - 1);
                screen.Text = text;
            } 
            if (text.Length==0) screen.Text = "0";
           
        }

       
    }
}
