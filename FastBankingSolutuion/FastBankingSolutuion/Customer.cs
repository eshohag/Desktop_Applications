using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastBankingSolutuion
{
    class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Account BankAccount { get; set; }

        public Customer(string name, string email):this()
        {
            Name = name;
            Email = email;
        }
        public Customer()
        {
            
        }
    }
}
