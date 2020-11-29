using System.Collections.Generic;

namespace MedicalData.Entities
{
    class CallsToActions
    {
        public string Code { get; set; }
        public string Action1 { get; set; }
        public string Action2 { get; set; }
        public int PtdCoeficient { get; set; }

        // relational properties
        
        public ICollection<PtdScore> PtdScores { get; set; }
    }
}
