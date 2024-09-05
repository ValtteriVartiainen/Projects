using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string currentNumber = "";
        private char currentOperator = '\0';
        private bool newOperation = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentNumber += button.Text;
            naytto.Text = currentNumber;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            char operatorClicked = button.Text[0];

            if (!string.IsNullOrEmpty(currentNumber))
            {
                if (newOperation)
                {
                    result = double.Parse(currentNumber);
                    newOperation = false;
                }
                else
                {
                    double secondNumber = double.Parse(currentNumber);
                    result = PerformOperation(result, secondNumber, currentOperator);
                }
            }

            currentOperator = operatorClicked;
            currentNumber = "";
            naytto.Text = result.ToString();
        }

        private double PerformOperation(double firstNumber, double secondNumber, char op)
        {
            switch (op)
            {
                case '+':
                    return firstNumber + secondNumber;
                case '-':
                    return firstNumber - secondNumber;
                case '*':
                    return firstNumber * secondNumber;
                case '/':
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Error: Division by zero");
                        return firstNumber;
                    }
                    return firstNumber / secondNumber;
                default:
                    return secondNumber;
            }
        }

        private void rresult_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentNumber))
            {
                double secondNumber = double.Parse(currentNumber);
                result = PerformOperation(result, secondNumber, currentOperator);
            }

            naytto.Text = result.ToString();
            currentNumber = "";
            newOperation = true;
        }

        private void cclear_Click(object sender, EventArgs e)
        {
            currentNumber = "";
            result = 0;
            currentOperator = '\0';
            newOperation = true;
            naytto.Text = "";
        }
    }
}
