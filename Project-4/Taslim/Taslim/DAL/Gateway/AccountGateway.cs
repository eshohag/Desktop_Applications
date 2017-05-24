using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Taslim.DAL.Model;

namespace Taslim.DAL.Gateway
{
    class AccountGateway : CommonGateway
    {
        public int Add(Account account)
        {
            Query = "INSERT INTO Accounts VALUES('" + account.Name + "','" + account.FatherName + "','" + account.MotherName + "','" + account.Vilage + "','" + account.Post + "','" + account.Thana + "','" + account.Disrict + "','" + account.Country + "','" + account.Nationality + "','" + account.MobileNo + "','" + account.Email + "','" + account.SSCPoint + "','" + account.HSCPoint + "', '" + account.HonrsPoint + "', '" + account.MastersPoint + "', '" + account.SSCSession + "', '" + account.HSCSession + "', '" + account.HonrsSession + "', '" + account.MastersSession + "', '" + account.SSCOn + "', '" + account.HSCOn + "', '" + account.HonrsOn + "', '" + account.MastersOn + "', '" + account.DateOfJoining + "', '" + account.CurrentSalary + "')";

           // Query = "INSERT into [dbo].[sp_Accounts]";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
    