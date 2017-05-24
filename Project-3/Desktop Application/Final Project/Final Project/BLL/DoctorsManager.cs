using Final_Project.DAL.Gateway;
using Final_Project.DAL.Model;

namespace Final_Project.BLL
{
    class DoctorsManager
    {
        DoctorsGateway aDoctorsGateway = new DoctorsGateway();
        DoctorsScheduleGateway aDoctorsScheduleGateway = new DoctorsScheduleGateway();
        public string Add(Doctors aDoctors)
        {
            if (aDoctorsGateway.Add(aDoctors) != null)
            {

                return "Successfully Saved Doctor Info  \n";
            }
            return "Faild to Added Doctors Info";

        }

        public Doctors FindID(Doctors aDoctors)
        {
            return aDoctorsGateway.FindDoctorID(aDoctors);

        }

        public Doctors SearchByID(int id)
        {
            return aDoctorsGateway.SearchByDoctorID(id);
        }

        public string Update(Doctors aDoctors)
        {
            if (aDoctorsGateway.Update(aDoctors) >= 0)
            {
                return "Successfully Updated Doctor Information";
            }


            return "Failds Update";
        }
    }
}
