
using Final_Project.DAL.Gateway;
using Final_Project.DAL.Model;

namespace Final_Project.BLL
{
    class CabinInfoManager
    {
        CabinInfoGateway aCabinInfoGateway = new CabinInfoGateway();
        public CabinInfo searchPatientID(string searchId)
        {

            return aCabinInfoGateway.SearchID(searchId);
        }

        public string AddedCabinInfo(CabinInfo aCabinInfo)
        {

            if (aCabinInfoGateway.AddedCabinInfo(aCabinInfo) != null)
            {
                return "Successfully Update your Cabin Info";
            }
            return "Faild Udate Cabine Info";
        }

        public CabinInfo IsExisting(string searchId)
        {
            return aCabinInfoGateway.IsExisting(searchId);
        }

        public string UpdateCabinInfo(CabinInfo aCabinInfo)
        {

            if (aCabinInfoGateway.UpdateCabinInfo(aCabinInfo) >= 0)
            {
                return "Successfully Update Cabin Information!";
            }
            return "Update Faild !";
        }
    }
}
