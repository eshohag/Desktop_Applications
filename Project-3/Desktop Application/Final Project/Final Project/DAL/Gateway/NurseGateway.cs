using Final_Project.DAL.Model;
using System;
using System.Data.SqlClient;

namespace Final_Project.DAL.Gateway
{
    class NurseGateway : CommonGateway
    {
        public int Add(Nurse aNurse)
        {
            Query = "INSERT INTO Nurses VALUES('" + aNurse.Name + "','" + aNurse.Address + "','" + aNurse.Age + "','" + aNurse.Sex + "','" + aNurse.MobileNo + "','" + aNurse.Education + "','" + aNurse.Specialist + "','" + aNurse.Department + "'," + aNurse.Salary + ",'" + aNurse.DateOfJoining + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }

        public Nurse FindID(Nurse aNurse)
        {

            Query = "SELECT ID  FROM Nurses WHERE Name='" + aNurse.Name + "' AND Address='" + aNurse.Address + "'AND Age='" + aNurse.Age + "' AND MobileNo='" + aNurse.MobileNo + "' AND Education='" + aNurse.Education + "' AND Salary=" + aNurse.Salary + " AND DateOfJoining='" + aNurse.DateOfJoining + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Nurse aNurses = null;
            while (Reader.Read())
            {
                aNurses = new Nurse();
                aNurses.ID = Convert.ToInt32(Reader["ID"]);

            }
            Reader.Close();
            Connection.Close();
            return aNurses;
        }

        public Nurse SearchByID(int id)
        {
            Query = "Select * from Nurses Where ID=" + id;
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Nurse aNurs = null;
            while (Reader.Read())
            {
                aNurs = new Nurse();
                aNurs.Name = Reader["Name"].ToString();
                aNurs.Address = Reader["Address"].ToString();
                aNurs.Age = Reader["Age"].ToString();
                aNurs.Sex = Reader["Sex"].ToString();
                aNurs.MobileNo = Reader["MobileNo"].ToString();
                aNurs.Education = Reader["Education"].ToString();
                aNurs.Specialist = Reader["Specialist"].ToString();
                aNurs.Department = Reader["Department"].ToString();
                aNurs.Salary = Convert.ToDecimal(Reader["Salary"]);
                aNurs.DateOfJoining = Convert.ToDateTime(Reader["DateOfJoining"]);

            }
            Reader.Close();
            Connection.Close();
            return aNurs;
        }

        ////public Nurse IsExistingNurse(Nurse aNurse)
        ////{
        ////    Query = "SELECT *  FROM Nurses WHERE ID=" + aNurse.ID;
        ////    Command = new SqlCommand(Query, Connection);
        ////    Connection.Open();
        ////    Reader = Command.ExecuteReader();
        ////    Nurse aNurses = null;
        ////    while (Reader.Read())
        ////    {
        ////        aNurses = new Nurse();
        ////        aNurses.ID = Convert.ToInt32(Reader["ID"]);

        ////    }
        ////    Reader.Close();
        ////    Connection.Close();
        ////    return aNurses;

        ////}
        public int Update(Nurse aNurse)
        {
            Query = "UPDATE Nurses SET Name='" + aNurse.Name + "',Address='" + aNurse.Address + "',Age='" + aNurse.Age + "',Sex='" + aNurse.Sex + "',MobileNo='" + aNurse.MobileNo + "',Education='" + aNurse.Education + "', Specialist='" + aNurse.Specialist + "',Department='" + aNurse.Department + "',Salary=" + aNurse.Salary + ",DateOfJoining='" + aNurse.DateOfJoining + "'  WHERE ID=" + aNurse.ID + "";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
