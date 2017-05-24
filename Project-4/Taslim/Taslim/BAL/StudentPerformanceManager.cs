using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taslim.DAL.Gateway;
using Taslim.DAL.Model;

namespace Taslim.BAL
{
    class StudentPerformanceManager
    {
        StudentPerformanceGateway aStudentPerformanceGateway = new StudentPerformanceGateway();
        public string Add(StudentPerformance student)
        {
            if (aStudentPerformanceGateway.Add(student) != null)
            {
                MessageBox.Show("Successfully Saved Info");
            }
            return "Faild to Added Info";
        }

        public DepartmentMaxPer FindMaxPerformanceCSE()
        {

            return aStudentPerformanceGateway.FindMaxPerformanceCSE();
        }

        public DepartmentMaxPer FindMaxPerformanceEEE()
        {

            return aStudentPerformanceGateway.FindMaxPerformanceEEE();
        }
    }
}
