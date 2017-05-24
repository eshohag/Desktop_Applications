using Final_Project.DAL.Model;
using System;
using System.Data.SqlClient;

namespace Final_Project.DAL.Gateway
{
    class PaymentGateway : CommonGateway
    {
        public Payment SearchByID(string patientId)
        {
            Query = " Select * from PaymentCost WHERE PatientId='" + patientId + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Payment aPayment = null;
            while (Reader.Read())
            {
                aPayment = new Payment();
                aPayment.PatientId = Reader["PatientId"].ToString();
                aPayment.Name = Reader["Name"].ToString();
                aPayment.CabinCost = Convert.ToDecimal(Reader["CabinCost"]);
                aPayment.ClinicalCost = Convert.ToDecimal(Reader["ClinicalCost"]);
                aPayment.DiagnosesCost = Convert.ToDecimal(Reader["DiagnosesCost"]);
                aPayment.TreatmentCost = Convert.ToDecimal(Reader["TreatmentCost"]);
                aPayment.InstrumentCost = Convert.ToDecimal(Reader["InstrumentCost"]);


            }
            Reader.Close();
            Connection.Close();
            return aPayment;
        }

        public int Add(Payment aPayment)
        {
            Query = "INSERT INTO Payment VALUES('" + aPayment.Name + "','" + aPayment.PatientId + "'," + aPayment.CabinCost + "," + aPayment.ClinicalCost + "," + aPayment.DiagnosesCost + "," + aPayment.InstrumentCost + "," + aPayment.TreatmentCost + "," + aPayment.TotalCost + "," + aPayment.Discount + "," + aPayment.AdvancePaid + "," + aPayment.TotalDue + "," + aPayment.NetPayment + ")";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public Payment FindID(string patientId)
        {
            Query = " Select * from Payment WHERE PatientId='" + patientId + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Payment YesFindIt = null;
            while (Reader.Read())
            {
                YesFindIt = new Payment();
                YesFindIt.PatientId = Reader["PatientId"].ToString();
                YesFindIt.Name = Reader["Name"].ToString();
                YesFindIt.CabinCost = Convert.ToDecimal(Reader["CabinCost"]);
                YesFindIt.ClinicalCost = Convert.ToDecimal(Reader["ClinicalCost"]);
                YesFindIt.DiagnosesCost = Convert.ToDecimal(Reader["DiagnosesCost"]);
                YesFindIt.TreatmentCost = Convert.ToDecimal(Reader["TreatmentCost"]);
                YesFindIt.InstrumentCost = Convert.ToDecimal(Reader["InstrumentCost"]);
                YesFindIt.TotalCost = Convert.ToDecimal(Reader["TotalCost"]);
                YesFindIt.Discount = Convert.ToDecimal(Reader["Discount"]);
                YesFindIt.NetPayment = Convert.ToDecimal(Reader["NetPayment"]);
                YesFindIt.AdvancePaid = Convert.ToDecimal(Reader["AdvancePaid"]);
                YesFindIt.TotalDue = Convert.ToDecimal(Reader["TotalDue"]);

            }
            Reader.Close();
            Connection.Close();
            return YesFindIt;
        }
    }
}
