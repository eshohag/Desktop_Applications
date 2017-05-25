using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class CalculatorUI : Form
    {
        private double Value = 0;
        private string opertion = "";
        private bool operationPressed = false;

        public CalculatorUI()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            operationPressed = false;
            if (displayTextBox.Text == "0")
            {
                displayTextBox.Clear();
            }      
                Button mybutton = (Button) sender;
                displayTextBox.Text = displayTextBox.Text + mybutton.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = "0";
        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            Button mybutton = (Button)sender;
            opertion = mybutton.Text;
            Value = Convert.ToDouble(displayTextBox.Text);
            operationPressed = true;
            displayTextBox.Text = "";
            equationLabel.Text=Value+" "+opertion; 
        }
        private void equalButton_Click(object sender, EventArgs e)
        {            
            equationLabel.Text = "";
            switch (opertion)
            {
                case "+":
                    displayTextBox.Text = (Value + Convert.ToDouble(displayTextBox.Text)).ToString();
                    break;
                case "-":
                    displayTextBox.Text = (Value - Convert.ToDouble(displayTextBox.Text)).ToString();
                    break;
                case "*":
                    displayTextBox.Text = (Value * Convert.ToDouble(displayTextBox.Text)).ToString();
                    break;
                case "/":
                    displayTextBox.Text = (Value / Convert.ToDouble(displayTextBox.Text)).ToString();
                    break;
                default:
                    break;
            }           
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            //displayTextBox.Clear();
            displayTextBox.Text="0";
            Value = 0;
        }
    }
}
