using Final_Project.DAL.Model;
using System;
using System.Data.SqlClient;

namespace Final_Project.DAL.Gateway
{
    class DoctorsGateway : CommonGateway
    {
        public int Add(Doctors aDoctors)
        {
            Query = "INSERT INTO Doctors VALUES('" + aDoctors.Name + "','" + aDoctors.Address + "','" + aDoctors.Age + "','" + aDoctors.Sex + "','" + aDoctors.MobileNo + "','" + aDoctors.Education + "','" + aDoctors.Speciality + "','" + aDoctors.Department + "'," + aDoctors.Salary + ",'" + aDoctors.DateOfJoining + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public Doctors FindDoctorID(Doctors aDoctors)
        {
            Query = "SELECT ID  FROM Doctors WHERE Name='" + aDoctors.Name + "' AND Address='" + aDoctors.Address + "'AND Age='" + aDoctors.Age + "' AND MobileNo='" + aDoctors.MobileNo + "' AND Education='" + aDoctors.Education + "' AND Salary=" + aDoctors.Salary + " AND DateOfJoining='" + aDoctors.DateOfJoining + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Doctors aDoctorss = null;
            while (Reader.Read())
            {
                aDoctorss = new Doctors();
                aDoctorss.ID = Convert.ToInt32(Reader["ID"]);

            }
            Reader.Close();
            Connection.Close();
            return aDoctorss;

        }

        public Doctors SearchByDoctorID(int id)
        {
            Query = "Select * from Doctors Where ID=" + id;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Doctors aDoctorss = null;
            while (Reader.Read())
            {
                aDoctorss = new Doctors();
                aDoctorss.Name = Reader["Name"].ToString();
                aDoctorss.Address = Reader["Address"].ToString();
                aDoctorss.Age = Reader["Age"].ToString();
                aDoctorss.Sex = Reader["Sex"].ToString();
                aDoctorss.MobileNo = Reader["MobileNo"].ToString();
                aDoctorss.Education = Reader["Education"].ToString();
                aDoctorss.Speciality = Reader["Speciality"].ToString();
                aDoctorss.Department = Reader["Department"].ToString();
                aDoctorss.DateOfJoining = Convert.ToDateTime(Reader["DateOfJoining"]);
                aDoctorss.Salary = Convert.ToDecimal(Reader["Salary"]);
            }
            Reader.Close();
            Connection.Close();
            return aDoctorss;

        }

        public int Update(Doctors aDoctors)
        {
            Query = "UPDATE Doctors SET Name='" + aDoctors.Name + "',Address='" + aDoctors.Address + "',Age='" + aDoctors.Age + "',Sex='" + aDoctors.Sex + "',MobileNo='" + aDoctors.MobileNo + "',Education='" + aDoctors.Education + "',Speciality='" + aDoctors.Speciality + "',Department='" + aDoctors.Department + "',Salary=" + aDoctors.Salary + ",DateOfJoining='" + aDoctors.DateOfJoining + "'  WHERE ID=" + aDoctors.ID + "";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
