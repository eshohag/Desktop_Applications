using Final_Project.DAL.Model;
using System;
using System.Data.SqlClient;

namespace Final_Project.DAL.Gateway
{
    class DiagnosesGateway : CommonGateway
    {
        public int Add(Diagnoses aDiagnoses)
        {
            Query = "INSERT INTO Diagnoses VALUES(" + aDiagnoses.Cost + ",'" + aDiagnoses.Description + "','" + aDiagnoses.PatientId + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public Diagnoses Search(string id)
        {
            Query = "Select * from Diagnoses Where PatientId='" + id + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Diagnoses aDiagnose = null;
            while (Reader.Read())
            {
                aDiagnose = new Diagnoses();
                aDiagnose.Cost = Convert.ToDecimal(Reader["Cost"]);
                aDiagnose.Description = Reader["Description"].ToString();


            }
            Reader.Close();
            Connection.Close();
            return aDiagnose;
        }

        public int Update(Diagnoses aDiagnoses)
        {
            Query = "UPDATE Diagnoses SET Cost=" + aDiagnoses.Cost + ",Description='" + aDiagnoses.Description + "' WHERE PatientId='" + aDiagnoses.PatientId + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
