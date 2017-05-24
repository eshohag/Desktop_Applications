using System;

namespace Final_Project.DAL.Model
{
    class CabinInfo
    {
        public int ID { get; set; }
        public string PatientId { get; set; }
        public string Name { get; set; }
        public string CabinNo { get; set; }
        public string BedNo { get; set; }
        public string AddressP { get; set; }
        public string CabinType { get; set; }
        public int AmountOfStay { get; set; }
        public DateTime Admission { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double PerDayCost { get; set; }
        public double TotalCost { get; set; }
    }
}
