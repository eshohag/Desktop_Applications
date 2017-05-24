using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taslim.DAL.Gateway;
using Taslim.DAL.Model;

namespace Taslim.BAL
{
    class LibraryManager
    {
        LibraryGateway aLibraryGateway = new LibraryGateway();
        public string Add(Librarian librarian)
        {
            if (aLibraryGateway.Add(librarian) != null)
            {

                MessageBox.Show("Successfully Saved Info");
            }
            return "Faild to Added Info";
        }
    }
}
