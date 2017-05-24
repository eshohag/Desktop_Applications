using Final_Project.DAL.Gateway;
using Final_Project.DAL.Model;

namespace Final_Project.BLL
{
    class PatientManager
    {
        PatientGateway aPatientGateway = new PatientGateway();

        public string Add(Patient aPatient)
        {
            if (aPatientGateway.ExistingID(aPatient.PatientId) == null)
            {
                if (aPatientGateway.Save(aPatient) != null)
                {
                    return "Successfully Added Patient Information \n Your Patient ID is " + aPatient.PatientId;
                }
                return "System Error";

            }
            return "Add Faild because of Already Existing ID ";

        }

        public Patient searchPatientID(string searchId)
        {

            return aPatientGateway.searchPatientID(searchId);
        }

        public string Update(Patient aPatientInfoUpdate)
        {

            if (aPatientGateway.update(aPatientInfoUpdate) != null)
            {
                return "Successfully Update Information!";
            }
            return "Faild Update Patient Information!";
        }
    }
}
