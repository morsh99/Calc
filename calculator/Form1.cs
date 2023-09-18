using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {

        string input = "";
        string number1_str = "";
        string number2_str = "";
        double num1_double = 0.0;
        double num2_double = 0.0;
        char function = '\0';
        double result = 0.0;
        bool eq_pressed = false;
        bool negative = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                display1.Text = "";
                eq_pressed = false;
            }
            display2.Text = "";
            input += "1";
            display2.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                display1.Text = "";
                eq_pressed = false;
            }
            display2.Text = "";
            input += "2";
            display2.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                display1.Text = "";
                eq_pressed = false;
            }
            display2.Text = "";
            input += "3";
            display2.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                display1.Text = "";
                eq_pressed = false;
            }
            display2.Text = "";
            input += "4";
            display2.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (eq_pressed == true)
            {
                display1.Text = "";
                eq_pressed = false;
            }
            display2.Text = "";
            input += "5";
            display2.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                display1.Text = "";
                eq_pressed = false;
            }
            display2.Text = "";
            input += "6";
            display2.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (eq_pressed == true)
            {
                display1.Text = "";
                eq_pressed = false;
            }
            display2.Text = "";
            input += "7";
            display2.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                display1.Text = "";
                eq_pressed = false;
            }
            display2.Text = "";
            input += "8";
            display2.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                display1.Text = "";
                eq_pressed = false;
            }
            display2.Text = "";
            input += "9";
            display2.Text += input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                display1.Text = "";
                eq_pressed = false;
            }
            display2.Text = "";
            input += "0";
            display2.Text += input;
        }

        private void button_point_Click(object sender, EventArgs e)
        {

            if (eq_pressed == true)
            {
                display1.Text = "";
                eq_pressed = false;
            }
            display2.Text = "";
            if (input.Contains("/") == false)
            {
                input += "/";
            }
            display2.Text += input;
        }

        //functions---------------------------------------------------------------------------
       
        private void button_negative_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                if (negative == false)
                {
                    number1_str = "-" + result.ToString();
                    result = Convert.ToDouble(number1_str);
                    display2.Text = number1_str;
                    negative = true;
                }
                else
                {
                    number1_str = result.ToString();
                    display2.Text = display1.Text.Remove(0,1);
                    negative = false;
                }

                //eq_pressed = false;
            }

            else if (eq_pressed == false)
            {
                if (negative == false)
                {
                    display2.Text = "";
                    input = "-" + input;
                    display2.Text += input;
                    negative = true;
                }
                else
                {
                    display2.Text = "";
                    input = input.Remove(0, 1);
                    display2.Text += input;
                    negative = false;
                }
            }
            
            
        }

        private void button_devide_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                number1_str = result.ToString();
                function = '÷';
                display1.Text = number1_str;
                display1.Text += " " + function + " ";
                display2.Text = "0";
                eq_pressed = false;
                negative = false;
            }

            if (function == '\0')
            {
                function = '÷';
                display2.Text = "0";
                number1_str = input;
                input = "";

                display1.Text = number1_str;
                display1.Text += " " + function + " ";
                negative = false;
            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                number1_str = result.ToString();
                function = '×';
                display1.Text = number1_str;
                display1.Text += " " + function + " ";
                display2.Text = "0";
                eq_pressed = false;
                negative = false;
            }

            if (function == '\0')
            {
                function = '×';
                display2.Text = "0";
                number1_str = input;
                input = "";

                display1.Text = number1_str;
                display1.Text += " " + function + " ";
                negative = false;
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                number1_str = result.ToString();
                function = '-';
                display1.Text = number1_str;
                display1.Text += " " + function + " ";
                display2.Text = "0";
                eq_pressed = false;
                negative = false;
            }

            if (function == '\0')
            {
                function = '-';
                display2.Text = "0";
                number1_str = input;
                input = "";

                display1.Text = number1_str;
                display1.Text += " " + function + " ";
                negative = false;
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                number1_str = result.ToString();
                function = '+';
                display1.Text = number1_str;
                display1.Text += " " + function + " ";
                display2.Text = "0";
                eq_pressed = false;
                negative = false;
            }

            if (function == '\0')
            {
                function = '+';
                display2.Text = "0";
                number1_str = input;
                input = "";

                display1.Text = number1_str;
                display1.Text += " " + function + " ";
                negative = false;
            }
        }

        private void button_root_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                number1_str = result.ToString();
                function = 'r';
                display1.Text = "sqrt(" + number1_str + ") = ";
                num1_double = Convert.ToDouble(number1_str);
                result = Math.Sqrt(num1_double);
                display2.Text = result.ToString();
                //eq_pressed = false;
            }

            if (function == '\0')
            {
                function = 'r';
                display2.Text = "0";
                number1_str = input;
                input = "";

                display1.Text = "sqrt(" + number1_str + ") = ";
                num1_double = Convert.ToDouble(number1_str);
                result = Math.Sqrt(num1_double);
                display2.Text = result.ToString();
                eq_pressed = true;
                function = '\0';
            }
        }

        private void button_power_Click(object sender, EventArgs e)
        {
            if (eq_pressed == true)
            {
                number1_str = result.ToString();
                function = 'p';
                display1.Text = number1_str + " ^ ";
                display2.Text = "0";
                eq_pressed = false;
            }

            if (function == '\0')
            {
                function = 'p';
                display2.Text = "0";
                number1_str = input;
                input = "";

                display1.Text = number1_str + " ^ " ;
            }
        }

        //equal button------------------------------------------------------------------------

        private void button_eq_Click(object sender, EventArgs e)
        {
            if (eq_pressed == false)
            {
                eq_pressed = true;
                number2_str = input;
                input = "";
                display1.Text += number2_str;
                display1.Text += " = ";

                num1_double = Convert.ToDouble(number1_str);
                num2_double = Convert.ToDouble(number2_str);

                //calculate the resulat based on chosen function
                if (function == '+')
                {
                    result = num1_double + num2_double;
                    display2.Text = result.ToString();
                }
                else if (function == '-')
                {
                    result = num1_double - num2_double;
                    display2.Text = result.ToString();
                }
                else if (function == '×')
                {
                    result = num1_double * num2_double;
                    display2.Text = result.ToString();
                }
                else if (function == '÷')
                {
                    if (num2_double != 0)
                    {
                        result = num1_double / num2_double;
                        display2.Text = result.ToString();
                    }
                    else
                    {
                        display2.Text = "NaN";
                    }

                }
                else if (function == 'p')
                {
                    result = Math.Pow(num1_double, num2_double);
                    display2.Text = result.ToString();
                }
             
                function = '\0';
                negative = false;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            input = "";
            number1_str = "";
            number2_str = "";
            function = '\0';
            result = 0;
            display1.Text = "";
            display2.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
