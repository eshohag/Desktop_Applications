using Final_Project.DAL.Gateway;
using Final_Project.DAL.Model;

namespace Final_Project.BLL
{
    class ClinicalManager
    {
        ClinicalGateway aClinicalGateway = new ClinicalGateway();
        public string Add(Clinical aClinical)
        {
            if (aClinicalGateway.FindByID(aClinical.PatientId) == null)
            {
                if (aClinicalGateway.Add(aClinical) != null)
                {
                    return "Successfully Added clinical data";
                }

            }
            return "Already  Added clinical data";
        }

        public Clinical FindByID(string id)
        {

            return aClinicalGateway.FindByID(id);
        }

        public string Update(Clinical aClinical)
        {
            if (aClinicalGateway.Update(aClinical) >= 0)
            {
                return "Successfully Update Clinical Info";
            }
            return "Faild's to Update";
        }
    }
}
