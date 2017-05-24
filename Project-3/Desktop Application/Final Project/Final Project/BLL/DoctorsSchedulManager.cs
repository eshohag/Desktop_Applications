using Final_Project.DAL.Gateway;
using Final_Project.DAL.Model;
using System.Collections.Generic;

namespace Final_Project.BLL
{
    class DoctorsSchedulManager
    {
        DoctorsScheduleGateway aDoctorsScheduleGateway = new DoctorsScheduleGateway();
        DoctorsGateway aDoctorsGateway = new DoctorsGateway();
        public string Add(DoctorsSchedule aDoctorsSchedule)
        {
            if (aDoctorsScheduleGateway.FindDoctorID(aDoctorsSchedule.DoctorID) == null)
            {

                if (aDoctorsScheduleGateway.Add(aDoctorsSchedule) != null)
                {
                    return "Successfully Added Doctor Schedule ";
                }
            }

            return "Faild's or Already Added Doctor Schedule ";
        }

        public DoctorsSchedule FindSchedule(int id)
        {
            return aDoctorsScheduleGateway.FindSchedule(id);
        }

        public string Update(DoctorsSchedule aDoctorsSchedule)
        {
            if (aDoctorsScheduleGateway.FindDoctorID(aDoctorsSchedule.DoctorID) != null)
            {
                if (aDoctorsScheduleGateway.Update(aDoctorsSchedule) != null)
                {
                    return "Successfully Update Doctor Schedule ";
                }
            }

            return "Faild's Update Doctor Schedule ";
        }

        public List<DoctorsSchedule> SearchByDept_shift(DoctorsSchedule aDoctorsSchedule)
        {

            return aDoctorsScheduleGateway.SearchByDept_shift(aDoctorsSchedule);
        }
    }
}
