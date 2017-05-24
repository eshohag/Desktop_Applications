using Final_Project.DAL.Model;
using System;
using System.Data.SqlClient;

namespace Final_Project.DAL.Gateway
{
    class InstrumentGateway : CommonGateway
    {
        public int Add(Instrument aInstrument)
        {
            Query = "INSERT INTO Instrument VALUES('" + aInstrument.PatientId + "'," + aInstrument.Cost + ",'" + aInstrument.Description + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public Instrument SearchID(string id)
        {
            Query = "Select * from Instrument Where PatientId='" + id + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Instrument aInstruments = null;
            while (Reader.Read())
            {
                aInstruments = new Instrument();
                aInstruments.Cost = Convert.ToDecimal(Reader["Cost"]);
                aInstruments.Description = Reader["Description"].ToString();


            }
            Reader.Close();
            Connection.Close();
            return aInstruments;
        }

        public int Update(Instrument aInstrument)
        {
            Query = "UPDATE Instrument SET Cost=" + aInstrument.Cost + ",Description='" + aInstrument.Description + "' WHERE PatientId='" + aInstrument.PatientId + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
