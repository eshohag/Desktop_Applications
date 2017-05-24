using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Taslim.DAL.Model;

namespace Taslim.DAL.Gateway
{
    class LoginInfoGateway : CommonGateway
    {
        public LoginInfo MatchUser(LoginInfo aPersonLoginInfo)
        {
            Query = "Select * From LoginInfo where UserName='" + aPersonLoginInfo.UserName + "' AND Password='" + aPersonLoginInfo.Password + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            LoginInfo user = null;
            while (Reader.Read())
            {
                user = new LoginInfo();
                user.Name = Reader["Name"].ToString();
                user.UserName = Reader["UserName"].ToString();
                user.Password = Reader["Password"].ToString();

            }
            Reader.Close();
            Connection.Close();
            return user;

        }
    }
}
