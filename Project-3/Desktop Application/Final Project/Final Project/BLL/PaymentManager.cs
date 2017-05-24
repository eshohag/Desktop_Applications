using Final_Project.DAL.Gateway;
using Final_Project.DAL.Model;

namespace Final_Project.BLL
{
    class PaymentManager
    {
        PaymentGateway aPaymentGateway = new PaymentGateway();
        public Payment SearchByID(string patientId)
        {
            if (aPaymentGateway.FindID(patientId) == null)
            {
                return aPaymentGateway.SearchByID(patientId);
            }
            return aPaymentGateway.FindID(patientId);
        }

        public string Add(Payment aPayment)
        {
            if (aPaymentGateway.FindID(aPayment.PatientId) == null)
            {
                if (aPaymentGateway.Add(aPayment) != null)
                {
                    return "Successfully Saved or Added info!";
                }
            }

            return "Faild's Saved or Added because of Already Entered info!";
        }
    }
}
