using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaculatorUIApp
{
    public partial class CalculatorUI : Form
    {
        private double firstNum;
        private double secondNum;
        public CalculatorUI()
        {
            InitializeComponent();
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            firstNum = Convert.ToDouble(firstNumberTextBox.Text);
            secondNum = Convert.ToDouble(secondNumberTextBox.Text);
            double result = Add(firstNum, secondNum);
            resultTextBox.Text = result.ToString();
        }

        private double Add(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }

        private void substractionButton_Click(object sender, EventArgs e)
        {
             if(secondNum == firstNum || secondNum > firstNum)
           {
               double result = secondNum - firstNum;
               resultTextBox.Text = result.ToString();
           }
             else
            {
                double result = firstNum - secondNum;
                resultTextBox.Text = result.ToString();
            }
           
        }      
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double result = firstNum*secondNum;
            resultTextBox.Text = result.ToString();
        }

        private void divitionButton_Click(object sender, EventArgs e)
        {
            if (firstNum > secondNum)
            {
                double result = firstNum / secondNum;
                resultTextBox.Text = result.ToString();
            }
            else
            {
                double result = secondNum / firstNum;
                resultTextBox.Text = result.ToString();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Clear();
            secondNumberTextBox.Clear();
            resultTextBox.Clear();
        }
    }
}
