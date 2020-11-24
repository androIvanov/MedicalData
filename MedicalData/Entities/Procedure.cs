using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalData.Entities
{
    class Procedure
    {
		public int ProcedureId { get; set; }
		public int DiagnosisId { get; set; }
		public string SerID { get; set; }
		public string ProcedureCodingMethod { get; set; }
		public string ProcedureCode { get; set; }
		public string ProcedureDescription { get; set; }
		public DateTime ProcedureDateTime { get; set; }
		public string AssociatedDiagnosis { get; set; }
	}
}
