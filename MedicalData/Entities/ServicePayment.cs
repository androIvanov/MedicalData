using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalData.Entities
{
    class ServicePayment
    {
		public int ServicePaymentId { get; set; }
		public int ClaimPaymentId { get; set; }
		public string ServiceIdQualifier { get; set; }
		public string AdjudicatedProcedureCode { get; set; }
		public string ProcedureModifier { get; set; }
		public decimal LineItemChargeAmount { get; set; }
		public decimal LineItemProviderPaymentAmount { get; set; }
		public string NUBCRevenueCode { get; set; }
		public int UnitsOfServicePaidCount { get; set; }
		public string MedicalProcedureIdQualifier { get; set; }
		public string MedicalProcedureCode { get; set; }
		public string MedicalProcedureModifier { get; set; }
		public DateTime ServiceDate { get; set; }
		public string ClaimAdjustmentGroupCode { get; set; }
		public string AdjustmentReasonCode { get; set; }
		public decimal AdjustmentAmount { get; set; }
		public int AdjustmentQuantity { get; set; }
		public string LineItemControlNumber { get; set; }
		public string ServiceSupplementalAmountQualifierCode { get; set; }
		public decimal ServiceSupplementalAmount { get; set; }
	}
}
