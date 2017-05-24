using Final_Project.DAL.Model;
using System.Data.SqlClient;

namespace Final_Project.DAL.Gateway
{
    class LoginInfoGateway : CommonGateway
    {
        public loginInfo MatchUser(loginInfo aPersonLoginInfo)
        {
            Query = "Select * From loginInfo where UserType='" + aPersonLoginInfo.UserType + "' AND UserName='" + aPersonLoginInfo.UserName + "' AND Password='" + aPersonLoginInfo.Password + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            loginInfo user = null;
            while (Reader.Read())
            {
                user = new loginInfo();
                user.Name = Reader["Name"].ToString();
                user.UserType = (string)Reader["UserType"];
                user.UserName = Reader["UserName"].ToString();
                user.Password = Reader["Password"].ToString();

            }
            Reader.Close();
            Connection.Close();
            return user;

        }
    }
}
