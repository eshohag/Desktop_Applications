using Final_Project.DAL.Gateway;
using Final_Project.DAL.Model;

namespace Final_Project.BLL
{
    class NurseManager
    {
        NurseGateway aNurseGateway = new NurseGateway();
        public string Add(Nurse aNurse)
        {
            Nurse aNursew = aNurseGateway.FindID(aNurse);
            if (aNursew != null)
            {
                return "Already Assign to Nurse Information";
            }
            else
            {

                if (aNurseGateway.Add(aNurse) >= 0)
                {
                    return "Successfully Saved Info";
                }


            }

            return "Faild to added nurse Info";
        }

        public Nurse FindID(Nurse aNurse)
        {
            return aNurseGateway.FindID(aNurse);

        }

        public Nurse SearchByID(int id)
        {

            return aNurseGateway.SearchByID(id);
        }


        public string Update(Nurse aNurse)
        {

            if (aNurseGateway.Update(aNurse) >= 0)
            {
                return "Successfully Updated";
            }
            return "Faild Update";
        }
    }
}
