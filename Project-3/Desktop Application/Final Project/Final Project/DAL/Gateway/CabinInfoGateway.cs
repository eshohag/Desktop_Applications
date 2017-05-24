
using Final_Project.DAL.Model;
using System;
using System.Data.SqlClient;

namespace Final_Project.DAL.Gateway
{
    class CabinInfoGateway : CommonGateway
    {
        public CabinInfo SearchID(string searchId)
        {
            Query = "SELECT  ReleaseDate,AmountOfStay,PerDayCost,TotalCost FROM CabinInfo WHERE PatientId='" + searchId + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            CabinInfo aCabinInfo = null;
            while (Reader.Read())
            {
                aCabinInfo = new CabinInfo();
                aCabinInfo.ReleaseDate = (DateTime)Reader["ReleaseDate"];
                aCabinInfo.AmountOfStay = Convert.ToInt32(Reader["AmountOfStay"]);
                aCabinInfo.PerDayCost = Convert.ToInt32(Reader["PerDayCost"]);
                aCabinInfo.TotalCost = Convert.ToInt32(Reader["TotalCost"]);
            }
            Reader.Close();
            Connection.Close();
            return aCabinInfo;
        }

        public int AddedCabinInfo(CabinInfo aCabinInfo)
        {
            Query = "INSERT INTO CabinInfo VALUES('" + aCabinInfo.ReleaseDate + "'," + aCabinInfo.AmountOfStay + "," + aCabinInfo.PerDayCost + "," + aCabinInfo.TotalCost + ",'" + aCabinInfo.PatientId + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public CabinInfo IsExisting(string searchId)
        {
            Query = "Select TotalCost from CabinInfo WHERE PatientId='" + searchId + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            CabinInfo aCabinInfo = null;
            if (Reader.HasRows)
            {
                Reader.Read();
                aCabinInfo = new CabinInfo();
                aCabinInfo.TotalCost = Convert.ToDouble(Reader["TotalCost"]);
            }
            Connection.Close();
            return aCabinInfo;
        }

        public int UpdateCabinInfo(CabinInfo aCabinInfo)
        {
            Query = "UPDATE CabinInfo SET ReleaseDate='" + aCabinInfo.ReleaseDate + "',AmountOfStay=" + aCabinInfo.AmountOfStay + ",PerDayCost=" + aCabinInfo.PerDayCost + ",TotalCost=" + aCabinInfo.TotalCost + "  WHERE PatientId='" + aCabinInfo.PatientId + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
