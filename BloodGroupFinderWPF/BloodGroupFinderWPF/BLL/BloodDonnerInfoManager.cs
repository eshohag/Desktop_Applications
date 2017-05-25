using BloodGroupFinderWPF.DAL;
using BloodGroupFinderWPF.DAL.Model;

namespace BloodGroupFinderWPF.BLL
{
    class BloodDonnerInfoManager
    {
        BloodDonnerInfoGateway aBloodDonnerInfoGateway = new BloodDonnerInfoGateway();
        public string Save(ProfileCreate aProfileCreate)
        {
            if (aBloodDonnerInfoGateway.Save(aProfileCreate) != null)
            {
                return "Succesfully Saved";
            }
            return "Failed Saved";
        }
    }
}
