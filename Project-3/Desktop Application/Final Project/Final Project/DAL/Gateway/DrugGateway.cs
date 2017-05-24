using Final_Project.DAL.Model;
using System;
using System.Data.SqlClient;

namespace Final_Project.DAL.Gateway
{
    class DrugGateway : CommonGateway
    {
        public int AddDrugs(Drug aDrug)
        {
            Query = "INSERT INTO Drug VALUES('" + aDrug.Name + "','" + aDrug.GroupName + "','" + aDrug.Company + "'," + aDrug.Cost + "," + aDrug.AmountOfDrug + ")";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public Drug FindDrugID(Drug aDrugs)
        {                                       
            Query = "SELECT DrugId  FROM Drug WHERE Name='" + aDrugs.Name + "' AND GroupName='" + aDrugs.GroupName + "'AND Company='" + aDrugs.Company + "' AND Cost=" + aDrugs.Cost + " AND AmountOfDrug=" + aDrugs.AmountOfDrug + " ";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Drug aDrug = null;
            while (Reader.Read())
            {
                aDrug = new Drug();
                aDrug.DrugId = Convert.ToInt32(Reader["DrugId"]);
            }
            Reader.Close();
            Connection.Close();
            return aDrug;

        }

        public Drug SearchDrugID(int id)
        {
            Query = "SELECT *  FROM Drug WHERE DrugId=" + id + "";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Drug aDrug = null;
            while (Reader.Read())
            {
                aDrug = new Drug();
                aDrug.Name = Reader["Name"].ToString();
                aDrug.Company = Reader["Company"].ToString();
                aDrug.GroupName = Reader["GroupName"].ToString();
                aDrug.AmountOfDrug = Convert.ToInt32(Reader["AmountOfDrug"]);
                aDrug.Cost = Convert.ToDecimal(Reader["Cost"]);

            }
            Reader.Close();
            Connection.Close();
            return aDrug;
        }

        public int Update(Drug aDrug)
        {
            Query = "UPDATE Drug SET Name='" + aDrug.Name + "',GroupName='" + aDrug.GroupName + "',Company='" + aDrug.Company + "',Cost=" + aDrug.Cost + ",AmountOfDrug=" + aDrug.AmountOfDrug + "  WHERE DrugId=" + aDrug.DrugId + "";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }

        public Drug IsExixtingName(Drug aDrugs)
        {
            Query = "SELECT Name  FROM Drug WHERE Name='" + aDrugs.Name + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Drug aDrug = null;
            while (Reader.Read())
            {
                aDrug = new Drug();
                aDrug.Name = Reader["Name"].ToString();


            }
            Reader.Close();
            Connection.Close();
            return aDrug;
        }
    }
}
