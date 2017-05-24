using Final_Project.DAL.Gateway;
using Final_Project.DAL.Model;

namespace Final_Project.BLL
{
    class DiagnosesManager
    {
        DiagnosesGateway aDiagnosesGateway = new DiagnosesGateway();
        PatientGateway aPatientGateway = new PatientGateway();
        public string Add(Diagnoses aDiagnoses)
        {
            if (aPatientGateway.searchPatientID(aDiagnoses.PatientId) != null)
            {
                if (aDiagnosesGateway.Add(aDiagnoses) != null)
                {
                    return "Successfully Added Info";
                }
            }

            return "Faild's  Added Info";
        }

        public Diagnoses Search(string id)
        {
            return aDiagnosesGateway.Search(id);
        }

        public string Update(Diagnoses aDiagnoses)
        {
            if (aDiagnosesGateway.Update(aDiagnoses) != null)
            {
                return "Successfully Update Info";
            }
            return "Unable to Update Info";
        }
    }
}
