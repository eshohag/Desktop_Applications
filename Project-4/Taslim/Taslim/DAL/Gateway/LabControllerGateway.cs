using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Taslim.DAL.Gateway
{
    class LabControllerGateway : CommonGateway
    {

        public int Add(Model.labController aLabController)
        {

            Query = "INSERT INTO LabController VALUES('" + aLabController.Name + "','" + aLabController.FatherName + "','" + aLabController.MotherName + "','" + aLabController.Vilage + "','" + aLabController.Post + "','" + aLabController.Thana + "','" + aLabController.Disrict + "','" + aLabController.Country + "','" + aLabController.Nationality + "','" + aLabController.MobileNo + "','" + aLabController.Email + "','" + aLabController.SSCPoint + "','" + aLabController.HSCPoint + "', '" + aLabController.HonrsPoint + "', '" + aLabController.MastersPoint + "', '" + aLabController.SSCSession + "', '" + aLabController.HSCSession + "', '" + aLabController.HonrsSession + "', '" + aLabController.MastersSession + "', '" + aLabController.SSCOn + "', '" + aLabController.HSCOn + "', '" + aLabController.HonrsOn + "', '" + aLabController.MastersOn + "','" + aLabController.Designation + "','" + aLabController.DateOfJoining + "', '" + aLabController.CurrentSalary + "')";
            //Query = "[dbo].[sp_LabController]";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
