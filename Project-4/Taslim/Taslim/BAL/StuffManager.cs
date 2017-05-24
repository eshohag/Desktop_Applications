using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taslim.DAL.Gateway;
using Taslim.DAL.Model;

namespace Taslim.BAL
{
    class StuffManager
    {
        StuffGateway aStuffGateway = new StuffGateway();
        public string Add(Stuff stuff)
        {
            if (aStuffGateway.Add(stuff) != null)
            {

                MessageBox.Show("Successfully Saved Info");
            }
            return "Faild to Added Info";
        }
    }
}
