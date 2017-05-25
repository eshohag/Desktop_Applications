using BloodGroupFinderWPF.DAL;
using BloodGroupFinderWPF.DAL.Model;

namespace BloodGroupFinderWPF.BLL
{
    class UserManager
    {
        readonly UserGateway _aUserGateway = new UserGateway();

        public string SignUp(User aUser)
        {
            if (_aUserGateway.IsExisting(aUser) == null)
            {
                if (_aUserGateway.SignUp(aUser) != null)
                {
                    return "Successfully signed up.";
                }
                return "Already signed up.";
            }
            return "Failed signed up.";
        }

        public User IsExisting(User aUser)
        {
            return _aUserGateway.IsExisting(aUser);
        }
    }
}
