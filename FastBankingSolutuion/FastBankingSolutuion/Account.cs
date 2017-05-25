using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastBankingSolutuion
{
    class Account
    {
        public string AccountNumber { get; set; }
        public string OpeningDate { get; set; }
        public double Balance { get; private set; }

        public string Deposite(double amount)
        {
            Balance += amount;
            return ""+ (MessageBox.Show("Deposite Success"));
        }
        public string Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                Balance = Balance-amount;
                return "" + (MessageBox.Show("Withdraw Success"));
            }
            else if (amount < 0)
            {
                return "" + (MessageBox.Show("Withdraw Failed Negative  Balance"));

            }
            else
            {
                return "" + (MessageBox.Show("Withdraw Failed Insufficient Balance"));        
            }
          
        }
    }
}
