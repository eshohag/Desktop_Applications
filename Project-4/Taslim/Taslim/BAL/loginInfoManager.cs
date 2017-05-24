using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taslim.DAL.Gateway;
using Taslim.DAL.Model;

namespace Taslim.BAL
{
    class LoginInfoManager
    {

        LoginInfoGateway aLoginInfoGateway = new LoginInfoGateway();
        public LoginInfo MatchUser(LoginInfo aPersonLoginInfo)
        {

            return aLoginInfoGateway.MatchUser(aPersonLoginInfo);

        }
    }
}
