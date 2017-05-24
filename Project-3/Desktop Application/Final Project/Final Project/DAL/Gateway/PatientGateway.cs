

using Final_Project.DAL.Model;
using System;
using System.Data.SqlClient;

namespace Final_Project.DAL.Gateway
{
    class PatientGateway : CommonGateway
    {

        public int Save(Patient aPatient)
        {
            Query = "INSERT INTO Patients VALUES('" + aPatient.PatientId + "','" + aPatient.Name + "','" + aPatient.Age + "','" + aPatient.Sex + "','" + aPatient.AddressP + "','" + aPatient.MobileNo + "','" + aPatient.Admission + "','" + aPatient.BedNo + "','" + aPatient.CabinNo + "','" + aPatient.Type + "','" + aPatient.CabinType + "')";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;
        }

        public Patient searchPatientID(string searchId)
        {
            Query = "SELECT * FROM Patients WHERE PatientId='" + searchId + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Patient aPatient = null;
            if (Reader.Read())
            {
                aPatient = new Patient();
                aPatient.Name = Reader["Name"].ToString();
                aPatient.Age = (int)Reader["Age"];
                aPatient.AddressP = Reader["AddressP"].ToString();
                aPatient.Admission = (DateTime)Reader["Admission"];
                aPatient.BedNo = Reader["BedNo"].ToString();
                aPatient.CabinNo = Reader["CabinNo"].ToString();
                aPatient.CabinType = Reader["CabinType"].ToString();
                aPatient.MobileNo = Reader["MobileNo"].ToString();
                aPatient.Type = Reader["Type"].ToString();
                aPatient.Sex = Reader["Sex"].ToString();
            }
            Reader.Close();
            Connection.Close();
            return aPatient;

        }

        public int update(Patient aPatientInfoUpdate)
        {
            Query = "UPDATE Patients SET Name='" + aPatientInfoUpdate.Name + "',Age=" + aPatientInfoUpdate.Age + ",Sex='" + aPatientInfoUpdate.Sex + "" +
                    "',AddressP='" + aPatientInfoUpdate.AddressP + "',MobileNo='" + aPatientInfoUpdate.MobileNo + "',Admission='" + aPatientInfoUpdate.Admission + "" +
                    "',BedNo='" + aPatientInfoUpdate.BedNo + "',CabinNo='" + aPatientInfoUpdate.CabinNo + "',Type='" + aPatientInfoUpdate.Type + "" +
                    "',CabinType='" + aPatientInfoUpdate.CabinType + "' WHERE PatientId='" + aPatientInfoUpdate.PatientId + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();
            Connection.Close();
            return rowAffected;

        }

        public Patient ExistingID(string patientId)
        {
            Query = "SELECT * FROM Patients WHERE PatientId='" + patientId + "'";
            Command = new SqlCommand(Query, Connection);
            Connection.Open();
            Reader = Command.ExecuteReader();
            Patient aPatient = null;
            if (Reader.Read())
            {
                aPatient = new Patient();
                aPatient.PatientId = Reader["PatientId"].ToString();
            }
            Reader.Close();
            Connection.Close();
            return aPatient;

        }
    }
}
