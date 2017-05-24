using Final_Project.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Final_Project.DAL.Gateway
{
    class DoctorsScheduleGateway : CommonGateway
    {
        public int Add(DoctorsSchedule aDoctorsSchedule)
        {
            Query = "INSERT INTO DoctorsSchedule VALUES(" + aDoctorsSchedule.DoctorID + ",'" + aDoctorsSchedule.Shift + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public DoctorsSchedule FindDoctorID(int doctorId)
        {
            Query = "SELECT *  FROM DoctorsSchedule WHERE DoctorID=" + doctorId + "";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            DoctorsSchedule aDoctorss = null;
            while (Reader.Read())
            {
                aDoctorss = new DoctorsSchedule();
                aDoctorss.DoctorID = Convert.ToInt32(Reader["DoctorID"]);
                aDoctorss.Shift = Reader["Shift"].ToString();

            }
            Reader.Close();
            Connection.Close();
            return aDoctorss;
        }

        public DoctorsSchedule FindSchedule(int id)
        {
            Query = "SELECT *  FROM DoctorsScheduleView WHERE DoctorID=" + id + "";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            DoctorsSchedule aDoctorss = null;
            while (Reader.Read())
            {
                aDoctorss = new DoctorsSchedule();
                aDoctorss.Name = Reader["Name"].ToString();
                aDoctorss.Department = Reader["Department"].ToString();
                aDoctorss.Education = Reader["Education"].ToString();
                aDoctorss.DoctorID = Convert.ToInt32(Reader["DoctorID"]);
                aDoctorss.Shift = Reader["Shift"].ToString();
            }
            Reader.Close();
            Connection.Close();
            return aDoctorss;
        }

        public int Update(DoctorsSchedule aDoctorsSchedule)
        {
            Query = "UPDATE DoctorsSchedule SET Shift='" + aDoctorsSchedule.Shift + "' WHERE DoctorID=" + aDoctorsSchedule.DoctorID;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }


        public List<DoctorsSchedule> SearchByDept_shift(DoctorsSchedule aDoctorsSchedule)
        {
            Query = "SELECT Doctors.Name,Doctors.Department,Doctors.Speciality,DoctorsSchedule.Shift from Doctors join DoctorsSchedule on Doctors.ID=DoctorsSchedule.DoctorID where Shift='" + aDoctorsSchedule.Shift + "' AND Department='" + aDoctorsSchedule.Department + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            List<DoctorsSchedule> AllDoctor = new List<DoctorsSchedule>();
            while (Reader.Read())
            {
                DoctorsSchedule aDoctors = new DoctorsSchedule();
                aDoctors.Name = Reader["Name"].ToString();
                aDoctors.Specilist = Reader["Speciality"].ToString();
                aDoctors.Department = Reader["Department"].ToString();
                aDoctors.Shift = Reader["Shift"].ToString();
                AllDoctor.Add(aDoctors);
            }
            Reader.Close();
            Connection.Close();
            return AllDoctor;
        }
    }
}
