namespace MedicalData.Entities
{
    class Eligibility
    {
        public int EligibilityId { get; set; }
        public int InsuranceId { get; set; }
        public string SetID { get; set; }
        public string EligibilityStatus { get; set; }
        public int COBSequence { get; set; }
        public string SetIDZM2 { get; set; }
        public decimal UnpaidBalance { get; set; }
        public string UnpaidBalanceType { get; set; }

        // relational databases

        public Insurance Insurance { get; set; }
    }
}
