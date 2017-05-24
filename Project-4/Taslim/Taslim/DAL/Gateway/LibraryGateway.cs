using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Taslim.DAL.Model;

namespace Taslim.DAL.Gateway
{
    class LibraryGateway: CommonGateway
    {
        public  int Add(Librarian librarian)
        {
            //Query = "[dbo].[sp_Labrarian]";
            //Command = new SqlCommand(Query, Connection);
            //Command.CommandType = CommandType.StoredProcedure;
            //Connection.Open();
            //int rowAffected = Command.ExecuteNonQuery();
            //Connection.Close();
            //return rowAffected;


            Query = "INSERT INTO Librarian VALUES('" + librarian.Name + "','" + librarian.FatherName + "','" + librarian.MotherName + "','" + librarian.Vilage + "','" + librarian.Post + "','" + librarian.Thana + "','" + librarian.Disrict + "','" + librarian.Country + "','" + librarian.Nationality + "','" + librarian.MobileNo + "','" + librarian.Email + "','" + librarian.SSCPoint + "','" + librarian.HSCPoint + "', '" + librarian.HonrsPoint + "', '" + librarian.MastersPoint + "', '" + librarian.SSCSession + "', '" + librarian.HSCSession + "', '" + librarian.HonrsSession + "', '" + librarian.MastersSession + "', '" + librarian.SSCOn + "', '" + librarian.HSCOn + "', '" + librarian.HonrsOn + "', '" + librarian.MastersOn + "','" + librarian.Designation + "','" + librarian.DateOfJoining + "', '" + librarian.CurrentSalary + "')";
            
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
