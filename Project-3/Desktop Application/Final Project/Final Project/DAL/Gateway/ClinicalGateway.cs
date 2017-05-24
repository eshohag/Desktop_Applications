using Final_Project.DAL.Model;
using System;
using System.Data.SqlClient;

namespace Final_Project.DAL.Gateway
{
    class ClinicalGateway : CommonGateway
    {
        public int Add(Clinical aClinical)
        {
            Query = "INSERT INTO Clinical VALUES(" + aClinical.Cost + ",'" + aClinical.Description + "','" + aClinical.PatientId + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public Clinical FindByID(string id)
        {
            Query = "Select * from Clinical Where PatientId='" + id + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Clinical aClinical = null;
            while (Reader.Read())
            {
                aClinical = new Clinical();
                aClinical.Cost = Convert.ToDecimal(Reader["Cost"]);
                aClinical.Description = Reader["Description"].ToString();


            }
            Reader.Close();
            Connection.Close();
            return aClinical;
        }

        public int Update(Clinical aClinical)
        {
            Query = "UPDATE Clinical SET Cost=" + aClinical.Cost + ",Description='" + aClinical.Description + "' WHERE PatientId='" + aClinical.PatientId + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
