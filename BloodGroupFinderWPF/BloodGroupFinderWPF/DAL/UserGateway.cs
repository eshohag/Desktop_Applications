using BloodGroupFinderWPF.DAL.Model;
using System.Data.SqlClient;

namespace BloodGroupFinderWPF.DAL
{
    class UserGateway : CommonGateway
    {
        public int SignUp(User aUser)
        {
            Query = "INSERT INTO Users VALUES('" + aUser.Name + "','" + aUser.Password + "','" + aUser.MobileNo + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
        public User IsExisting(User aUsers)
        {
            Query = "Select * from Users WHERE Password='" + aUsers.Password + "' AND MobileNo='" + aUsers.MobileNo + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            User aUser = null;
            if (Reader.HasRows)
            {
                Reader.Read();
                aUser = new User();
                aUser.Name = Reader["Name"].ToString();
                aUser.MobileNo = Reader["MobileNo"].ToString();
                aUser.Password = Reader["Password"].ToString();

            }
            Connection.Close();
            return aUser;
        }
    }
}
