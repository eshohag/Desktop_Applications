using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Taslim.DAL.Model;

namespace Taslim.DAL.Gateway
{
    class StuffGateway : CommonGateway
    {

        public int Add(Stuff stuff)
        {
            Query = "INSERT INTO Stuff VALUES('" + stuff.Name + "','" + stuff.FatherName + "','" + stuff.MotherName + "','" + stuff.Vilage + "','" + stuff.Post + "','" + stuff.Thana + "','" + stuff.Disrict + "','" + stuff.Country + "','" + stuff.Nationality + "','" + stuff.MobileNo + "','" + stuff.Email + "','" + stuff.JSCPoint + "','" + stuff.SSCPoint + "','" + stuff.HSCPoint + "','" + stuff.JSCSession + "', '" + stuff.SSCSession + "', '" + stuff.HSCSession + "','" + stuff.SSCOn + "', '" + stuff.HSCOn + "', '" + stuff.DateOfJoining + "', '" + stuff.CurrentSalary + "')";

            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
