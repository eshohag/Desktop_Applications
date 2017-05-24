using Final_Project.DAL.Gateway;
using Final_Project.DAL.Model;

namespace Final_Project.BLL
{
    class DrugManager
    {
        DrugGateway aDrugGateway = new DrugGateway();
        public int AddDrugs(Drug aDrug)
        {
            if (aDrugGateway.IsExixtingName(aDrug) != null)
            {
                return 10; //10 is Already Assign a Drug Number
            }
            else
            {
                return aDrugGateway.AddDrugs(aDrug);
            }

        }

        public Drug FindDrugID(Drug aDrug)
        {

            return aDrugGateway.FindDrugID(aDrug);
        }

        public Drug SearchDrugID(int id)
        {

            return aDrugGateway.SearchDrugID(id);
        }

        public string Update(Drug aDrug)
        {
            if (aDrugGateway.Update(aDrug) != null)
            {
                return "Successfully Update Drug Information !";
            }

            return "Faild Update !";

        }
    }
}
