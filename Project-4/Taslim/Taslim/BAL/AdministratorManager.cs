using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taslim.DAL.Gateway;
using Taslim.DAL.Model;

namespace Taslim.BAL
{
    class AdministratorManager
    {
        AdministratorGateway administratorGateway = new AdministratorGateway();
        public string Add(Administrator administrator)
        {
            if (administratorGateway.Add(administrator) != null)
            {

                 MessageBox.Show("Successfully Saved Administrator Info");
            }
            return "Faild to Added Administrator Info";
        }
    }
}
