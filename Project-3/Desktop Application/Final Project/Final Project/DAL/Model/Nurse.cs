using System;

namespace Final_Project.DAL.Model
{
    class Nurse
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string MobileNo { get; set; }
        public string Education { get; set; }
        public string Specialist { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
}
