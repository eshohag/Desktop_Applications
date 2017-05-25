using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interested_CalculatorApp
{
    public partial class InterestCalculatorUI : Form
    {
        private double balance;
        private double year;
        public InterestCalculatorUI()
        {
            InitializeComponent();
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            bankNameComboBox.ResetText();
            YourBalanceTextBox.Clear();
            timeYearTextBox.Clear();
            interestShowTextBox.Clear();
        }
        private void calculateInterestButton_Click(object sender, EventArgs e)
        {
          
             if (bankNameComboBox.Text == "BRAC")
            {
                balance = Convert.ToDouble(YourBalanceTextBox.Text);
                year = Convert.ToDouble(timeYearTextBox.Text);
                double interest = 0.06;
                double result = interest * year * balance;
                interestShowTextBox.Text = result.ToString();
            }
            else if (bankNameComboBox.Text == "DBBL")
            {
                balance = Convert.ToDouble(YourBalanceTextBox.Text);
                year = Convert.ToDouble(timeYearTextBox.Text);
                double interest = 0.07;
                double result = interest * year * balance;
                interestShowTextBox.Text = result.ToString();

            }
            else if (bankNameComboBox.Text == "HSBC")
            {
                balance = Convert.ToDouble(YourBalanceTextBox.Text);
                year = Convert.ToDouble(timeYearTextBox.Text);
                double interest = 0.08;
                double result = interest * year * balance;
                interestShowTextBox.Text = result.ToString();
            }
            else
            {
                balance = Convert.ToDouble(YourBalanceTextBox.Text);
                year = Convert.ToDouble(timeYearTextBox.Text);
                double interest = 0.09;
                double result = interest*year*balance;
                interestShowTextBox.Text = result.ToString();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
