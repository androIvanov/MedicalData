using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalData.Entities
{
    class LineNumber
    {
		public int LineNumberId { get; set; }

		public int TransactionId { get; set; }

		public string ProviderId { get; set; }

		public string FacilityTypeCode { get; set; }

		public DateTime FiscalPeriodDate { get; set; }

		public int TotalClaimCount { get; set; }

		public decimal TotalClaimChargeAmount { get; set; }

	}
}
