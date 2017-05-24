using Final_Project.DAL.Gateway;
using Final_Project.DAL.Model;

namespace Final_Project.BLL
{
    class TreatmentManager
    {
        TreatmentGateway aTreatmentGateway = new TreatmentGateway();
        public Treatment SearchPatientID(string id)
        {

            return aTreatmentGateway.SearchPatientID(id);
        }

        public string Update(Treatment aTreatment)
        {
            if (aTreatmentGateway.Update(aTreatment) != null)
            {
                return "Successfully Update database on Treatment Info. !";
            }
            return "Faild to Update treatment info!";
        }

        public string Add(Treatment aTreatment)
        {

            if (aTreatmentGateway.Add(aTreatment)!=null)
            {
                return "Successfully Added Your Treatment info";
            }
            else
            {
                return "Faild to Added Treatment info";
            }
        }
    }
}
