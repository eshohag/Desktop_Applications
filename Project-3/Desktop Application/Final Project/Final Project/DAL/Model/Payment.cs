
namespace Final_Project.DAL.Model
{
    class Payment
    {
        public string ID { get; set; }
        public string PatientId { get; set; }
        public string Name { get; set; }
        public decimal CabinCost { get; set; }
        public decimal ClinicalCost { get; set; }
        public decimal TreatmentCost { get; set; }
        public decimal InstrumentCost { get; set; }
        public decimal DiagnosesCost { get; set; }
        public decimal TotalCost { get; set; }
        public decimal Discount { get; set; }
        public decimal NetPayment { get; set; }
        public decimal AdvancePaid { get; set; }
        public decimal TotalDue { get; set; }
    }
}
