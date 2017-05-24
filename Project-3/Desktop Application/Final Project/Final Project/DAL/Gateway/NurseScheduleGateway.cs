using Final_Project.DAL.Model;
using System;
using System.Data.SqlClient;

namespace Final_Project.DAL.Gateway
{
    class NurseScheduleGateway : CommonGateway
    {
        public NurseSchedule FindSchedule(int id)
        {

            Query = "SELECT *  FROM NurseScheduleView WHERE NurseID=" + id + "";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            NurseSchedule aNurse = null;
            while (Reader.Read())
            {
                aNurse = new NurseSchedule();
                aNurse.Name = Reader["Name"].ToString();
                aNurse.Department = Reader["Department"].ToString();
                aNurse.Education = Reader["Education"].ToString();
                aNurse.NurseID = Convert.ToInt32(Reader["NurseID"]);
                aNurse.Shift = Reader["Shift"].ToString();

            }
            Reader.Close();
            Connection.Close();
            return aNurse;
        }

        public int Add(NurseSchedule aNurseSchedule)
        {
            Query = "INSERT INTO NurseSchedule VALUES(" + aNurseSchedule.NurseID + ",'" + aNurseSchedule.Shift + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public NurseSchedule CheckSchedule(int nurseId)
        {
            Query = "SELECT *  FROM NurseSchedule WHERE NurseID=" + nurseId + "";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            NurseSchedule aNurse = null;
            while (Reader.Read())
            {
                aNurse = new NurseSchedule();
                //aNurse.Name = Reader["Name"].ToString();
                //aNurse.Department = Reader["Department"].ToString();
                //aNurse.Education = Reader["Education"].ToString();
                aNurse.NurseID = Convert.ToInt32(Reader["NurseID"]);


            }
            Reader.Close();
            Connection.Close();
            return aNurse;
        }

        public int Update(NurseSchedule aNurseSchedule)
        {
            Query = "UPDATE NurseSchedule SET Shift='" + aNurseSchedule.Shift + "' WHERE NurseID=" + aNurseSchedule.NurseID;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
