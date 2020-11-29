using System;

namespace MedicalData.Entities
{
    class ServiceLine
    {
		public int ServiceLineId { get; set; }
		public int ClaimId { get; set; }
		public string ServiceIDQualifier { get; set; }
		public string ServiceID { get; set; }
		public string ProcedureModifier { get; set; }
		public decimal MonetaryAmount { get; set; }
		public string UnitForMeasurementCode { get; set; }
		public decimal Quantity { get; set; }
		public string FacilityCode { get; set; }
		public string ServiceTypeCode { get; set; }
		public string PrimaryDiagnosisCodePointer { get; set; }
		public string SecondaryDiagnosisCodePointer { get; set; }
		public DateTime ServiceDateTime { get; set; }

		// relational properties

		public Claims Claim { get; set; }
	}
}
