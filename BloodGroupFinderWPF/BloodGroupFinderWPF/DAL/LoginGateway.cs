
using System;
using BloodGroupFinderWPF.DAL.Model;
using System.Data.SqlClient;

namespace BloodGroupFinderWPF.DAL
{
    class LoginGateway : CommonGateway
    {
        public User Login(User aUsers)
        {
            Query = "Select * from Users WHERE Name='" + aUsers.Name + "' AND MobileNo='" + aUsers.MobileNo + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            User aUser = null;
            if (Reader.HasRows)
            {
                Reader.Read();
                aUser = new User();
                aUser.ID = Convert.ToInt32(Reader["ID"]);
                aUser.Name = Reader["Name"].ToString();
                aUser.MobileNo = Reader["MobileNo"].ToString();
                aUser.Password = Reader["Password"].ToString();

            }
            Connection.Close();
            return aUser;
        }
    }
}
