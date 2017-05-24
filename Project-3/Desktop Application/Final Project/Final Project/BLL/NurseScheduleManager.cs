using Final_Project.DAL.Gateway;
using Final_Project.DAL.Model;

namespace Final_Project.BLL
{
    class NurseScheduleManager
    {
        readonly NurseScheduleGateway aNurseScheduleGateway = new NurseScheduleGateway();
        NurseGateway aNurseGateway = new NurseGateway();
        public NurseSchedule FindSchedule(int id)
        {

            return aNurseScheduleGateway.FindSchedule(id);
        }

        public string Add(NurseSchedule aNurseSchedule)
        {
            if (aNurseGateway.SearchByID(aNurseSchedule.NurseID) != null)
            {
                if (aNurseScheduleGateway.CheckSchedule(aNurseSchedule.NurseID) == null)
                {

                    if (aNurseScheduleGateway.Add(aNurseSchedule) != null)
                    {
                        return "Successfully Added Nurse Schedule ";
                    }
                }
                else
                {
                    return "Already Added Nurse Schedule ";
                }
            }
            return "Invalid Nurse ID";
        }

        public string Update(NurseSchedule aNurseSchedule)
        {
            if (aNurseScheduleGateway.CheckSchedule(aNurseSchedule.NurseID) != null)
            {
                if (aNurseScheduleGateway.Update(aNurseSchedule) != null)
                {
                    return "Successfully Added Nurse Schedule ";
                }
            }

            return "Faild's Update Nurse Schedule ";
        }
    }
}
