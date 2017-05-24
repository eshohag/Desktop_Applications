
using System;

namespace Final_Project.DAL.Model
{
    class Patient
    {
        public string PatientId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string MobileNo { get; set; }
        public string AddressP { get; set; }
        public string Sex { get; set; }
        public string BedNo { get; set; }
        public string CabinNo { get; set; }
        public DateTime Admission { get; set; }
        public string Type { get; set; }
        public string CabinType { get; set; }

    }
}
