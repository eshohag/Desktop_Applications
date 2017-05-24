using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Taslim.DAL.Model;

namespace Taslim.DAL.Gateway
{
    class TeacherGateway : CommonGateway
    {

        public int Add(Teacher teacher)
        {
            Query = "INSERT INTO Teacher VALUES('" + teacher.Name + "','" + teacher.FatherName + "','" + teacher.MotherName + "','" + teacher.Vilage + "','" + teacher.Post + "','" + teacher.Thana + "','" + teacher.Disrict + "','" + teacher.Country + "','" + teacher.Nationality + "','" + teacher.MobileNo + "','" + teacher.Email + "','" + teacher.SSCPoint + "','" + teacher.HSCPoint + "', '" + teacher.HonrsPoint + "', '" + teacher.MastersPoint + "', '" + teacher.SSCSession + "', '" + teacher.HSCSession + "', '" + teacher.HonrsSession + "', '" + teacher.MastersSession + "', '" + teacher.SSCOn + "', '" + teacher.HSCOn + "', '" + teacher.HonrsOn + "', '" + teacher.MastersOn + "', '"+teacher.PHDOn+"', '" + teacher.Designation + "','" + teacher.DateOfJoining + "', '" + teacher.CurrentSalary + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
