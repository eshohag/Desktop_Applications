
namespace Final_Project.DAL.Model
{
    class NurseSchedule
    {
        public int ID { get; set; }
        public int NurseID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string ContactNo { get; set; }
        public string Education { get; set; }
        public string Shift { get; set; }
    }
}
