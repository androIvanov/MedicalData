using System;
using System.Collections.Generic;

namespace MedicalData.Entities
{
	class PatientAccount
	{
		public int AccountId { get; set; }
		public int PersonId { get; set; }
		public string AppointmentID { get; set; }
		public string PatientAccountNumber { get; set; }
		public string PrimaryCareProvider { get; set; }
		public bool StudentIndicator { get; set; }
		public string Facility { get; set; }

		// navigational properties

		public Person Person { get; set; }
		public ICollection<Diagnosis> Diagnoses { get; set; }
		public ICollection<NextOfKin> NextOfKins { get; set; }
		public ICollection<PtdScore> PtdScores { get; set; }
		public ICollection<Visit> Visits { get; set; }
		public ICollection<Guarantors> Guarantors { get; set; }
	}
}
