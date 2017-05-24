using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taslim.DAL.Gateway;
using Taslim.DAL.Model;

namespace Taslim.BAL
{
    class AccountManager
    {
        AccountGateway accountGateway = new AccountGateway();
        public string Add(Account account)
        {
            if (accountGateway.Add(account) != null)
            {

                MessageBox.Show("Successfully Saved Administrator Info");
            }
            return "Faild to Added Doctors Info";
        }
    }
}
