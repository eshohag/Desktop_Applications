using Final_Project.DAL.Gateway;
using Final_Project.DAL.Model;

namespace Final_Project.BLL
{
    class LoginInfoManager
    {
        LoginInfoGateway aLoginInfoGateway = new LoginInfoGateway();
        public loginInfo MatchUser(loginInfo aPersonLoginInfo)
        {

            return aLoginInfoGateway.MatchUser(aPersonLoginInfo);

        }
    }
}
