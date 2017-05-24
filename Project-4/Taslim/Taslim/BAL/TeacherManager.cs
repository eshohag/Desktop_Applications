using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taslim.DAL.Gateway;
using Taslim.DAL.Model;

namespace Taslim.BAL
{
    class TeacherManager
    {
        TeacherGateway teacherGateway = new TeacherGateway();
        public string Add(Teacher teacher)
        {
            if (teacherGateway.Add(teacher) != null)
            {

                MessageBox.Show("Successfully Saved Teacher Info");
            }
            return "Faild to Added Teacher Info";
        }
    }
}
