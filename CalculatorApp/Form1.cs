using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    // Calculator form
    public partial class Form1 : Form
    {
        string firstNumber;
        string secondNumber;
        char function;
        double result = 0.0;
        string userInput = "";


        public Form1()
        {
            InitializeComponent();
        }

        // Event handlers for the calculator buttons
        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userInput))
            {
                double currentNumber = Convert.ToDouble(userInput);
                currentNumber = -currentNumber; // Toggle the sign of the number
                userInput = currentNumber.ToString();
                calculatorDisplay.Text = userInput; // Update the display
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "";
            userInput += "0";
            calculatorDisplay.Text = userInput; 
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "";
            userInput += ".";
            calculatorDisplay.Text = userInput;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "";
            userInput += "1";
            calculatorDisplay.Text = userInput;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "";
            userInput += "2";
            calculatorDisplay.Text = userInput;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "";
            userInput += "3";
            calculatorDisplay.Text = userInput;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "";
            userInput += "4";
            calculatorDisplay.Text = userInput;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "";
            userInput += "5";
            calculatorDisplay.Text = userInput;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "";
            userInput += "6";
            calculatorDisplay.Text = userInput;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "";
            userInput += "7";
            calculatorDisplay.Text = userInput;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "";
            userInput += "8";
            calculatorDisplay.Text = userInput;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "";
            userInput += "9";
            calculatorDisplay.Text = userInput;
        }

        // Event handlers for the calculator functions
        private void btnON_Click(object sender, EventArgs e)
        {
            if (calculatorDisplay.Text == "")
            {
                calculatorDisplay.Text = "0";
            }
            else if (calculatorDisplay.Text == "0")
            {
                calculatorDisplay.Text = "0";
            }
            else
            {
                calculatorDisplay.Text = userInput;
            }

        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            resetCalculator();
            calculatorDisplay.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetCalculator();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            function = '/';
            firstNumber = userInput;
            userInput = "";
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            function = '*';
            firstNumber = userInput;
            userInput = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            function = '-';
            firstNumber = userInput;
            userInput = "";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            function = '+';
            firstNumber = userInput;
            userInput = "";
        }

        // Event handler for the equals button
        private void btnEquals_Click(object sender, EventArgs e)
        {
            secondNumber = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(firstNumber);
            secondNum = Convert.ToDouble(secondNumber);

            switch (function)
            {
                // Plus
                case '+':
                    result = firstNum + secondNum;
                    calculatorDisplay.Text = result.ToString();
                    break;

                // Minus
                case '-':
                    result = firstNum - secondNum;
                    calculatorDisplay.Text = result.ToString();
                    break;

                // Divide
                case '/':
                    if (secondNum == 0)
                    {
                        calculatorDisplay.Text = "Lol. No.";
                    }
                    else
                    {
                        result = firstNum / secondNum;
                        calculatorDisplay.Text = result.ToString();
                    }
                    break;

                // Multiply
                case '*':
                    result = firstNum * secondNum;
                    calculatorDisplay.Text = result.ToString();
                    break;

                default:
                    calculatorDisplay.Text = "Invalid operation";
                    break;
            }
        }

        // Reset the calculator
        private void resetCalculator()
        {
            firstNumber = "";
            secondNumber = "";
            function = ' ';
            result = 0.0;
            userInput = "";
            calculatorDisplay.Text = "0";
        }
    }
}
