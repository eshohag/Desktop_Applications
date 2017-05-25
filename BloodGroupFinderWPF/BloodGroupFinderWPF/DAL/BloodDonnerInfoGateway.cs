
using BloodGroupFinderWPF.DAL.Model;
using System.Data.SqlClient;

namespace BloodGroupFinderWPF.DAL
{
    class BloodDonnerInfoGateway : CommonGateway   //Inheritance class
    {
        public int Save(ProfileCreate aProfileCreate)
        {
            Query = "INSERT INTO Donner VALUES('" + aProfileCreate.Name + "','" + aProfileCreate.BloodGroup + "','" + aProfileCreate.ContactNo + "', '" + aProfileCreate.Address + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }
    }
}
