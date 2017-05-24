using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taslim.DAL.Gateway;

namespace Taslim.BAL
{
    class LabControllerManager
    {
        LabControllerGateway aLabControllerGateway = new LabControllerGateway();
        public string Add(DAL.Model.labController aLabController)
        {
            if (aLabControllerGateway.Add(aLabController) != null)
            {

                MessageBox.Show("Successfully Saved Info");
            }
            return "Faild to Added Info";
        }
    }
}
