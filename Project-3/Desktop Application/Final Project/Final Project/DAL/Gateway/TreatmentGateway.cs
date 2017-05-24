using Final_Project.DAL.Model;
using System;
using System.Data.SqlClient;

namespace Final_Project.DAL.Gateway
{
    class TreatmentGateway : CommonGateway
    {
        public Treatment SearchPatientID(string id)
        {
            Query = "SELECT * FROM Treatment WHERE PatientId='" + id + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Treatment aTreatment = null;
            if (Reader.Read())
            {
                aTreatment = new Treatment();
                aTreatment.Name = Reader["Name"].ToString();
                aTreatment.DiseaseName = Reader["DiseaseName"].ToString();
                aTreatment.Description = Reader["Description"].ToString();
                aTreatment.Cost = Convert.ToDecimal(Reader["Cost"]);

            }
            Reader.Close();
            Connection.Close();
            return aTreatment;

        }

        public int Update(Treatment aTreatment)
        {
            Query = "UPDATE Treatment SET Name='" + aTreatment.Name + "',DiseaseName='" + aTreatment.DiseaseName + "',Cost='" + aTreatment.Cost + "',Description='" + aTreatment.Description + "' WHERE PatientId='" + aTreatment.PatientId + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }

        public int Add(Treatment aTreatment)
        {
            Query = "INSERT INTO Treatment VALUES('" + aTreatment.Name + "','" + aTreatment.DiseaseName + "'," + aTreatment.Cost + ",'" + aTreatment.Description + "','" + aTreatment.PatientId + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }
    }
}
