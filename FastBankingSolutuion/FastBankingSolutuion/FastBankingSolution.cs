using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastBankingSolutuion
{
    public partial class FastBankingSolution : Form
    {
        public FastBankingSolution()
        {
            InitializeComponent();
        }

        private Account anAccount;
        private Customer aCustomer;
        private double amount;
        private void saveButton_Click(object sender, EventArgs e)
        {
            anAccount = new Account();
            anAccount.AccountNumber = accountNumberTextBox.Text;
            anAccount.OpeningDate = openingDateTextBox.Text;

            aCustomer=new Customer();
            aCustomer.Name = nameTextBox.Text;
            aCustomer.Email = emailTextBox.Text;

            aCustomer.BankAccount = anAccount;

            saveButton.Enabled = false;
        }

        private void depositeButton_Click(object sender, EventArgs e)
        {
           amount = Convert.ToDouble(amountTextBox.Text);
            aCustomer.BankAccount.Deposite(amount);
            amountTextBox.Text=String.Empty;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            aCustomer.BankAccount.Withdraw(amount);
            amountTextBox.Text = String.Empty;
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            string name = aCustomer.Name;
            string email = aCustomer.Email;
            string ac = aCustomer.BankAccount.AccountNumber;
            string openingdate = aCustomer.BankAccount.OpeningDate;
            string balance = aCustomer.BankAccount.Balance.ToString();
            showNameTextBox.Text = name;
            showEmailTextBox.Text = email;
            bankAcTextBox.Text = ac;
            showOpeningDatetextBox.Text = openingdate;           
            showBalanceTextBox.Text = balance;
            welcomeMessageLabel.Text = "Welcome to ..." + name;
        }
    }
}
