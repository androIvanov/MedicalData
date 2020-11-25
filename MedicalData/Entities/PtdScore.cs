using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalData.Entities
{
    class PtdScore
    {
        public int ScoreId { get; set; }
        public int AccountId { get; set; }
        public string Code { get; set; }
        public decimal Score { get; set; }
        public bool IsResolved { get; set; }
        public string Notes { get; set; }
        public string ResolvedBy { get; set; }
        public DateTime ResolvedDate { get; set; }

    }
}
