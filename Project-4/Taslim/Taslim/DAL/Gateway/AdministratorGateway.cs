using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Taslim.DAL.Model;

namespace Taslim.DAL.Gateway
{
    class AdministratorGateway : CommonGateway
    {
        public int Add(Administrator administrator)
        {
            Query = "INSERT INTO Administrator VALUES('" + administrator.Name + "','" + administrator.FatherName + "','" + administrator.MotherName + "','" + administrator.Vilage + "','" + administrator.Post + "','" + administrator.Thana + "','" + administrator.Disrict + "','" + administrator.Country + "','" + administrator.MobileNo + "','" + administrator.Email + "','"+administrator.SSCPoint+"','"+administrator.HSCPoint+"', '"+administrator.HonrsPoint+"', '"+administrator.MastersPoint+"', '"+administrator.SSCSession+"', '"+administrator.HSCSession+"', '"+administrator.HonrsSession+"', '"+administrator.MastersSession+"', '"+administrator.SSCOn+"', '"+administrator.HSCOn+"', '"+administrator.HonrsOn+"', '"+administrator.MastersOn+"', '"+administrator.DateOfJoining+"', '"+administrator.CurrentSalary+"','"+administrator.Nationality+"')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
