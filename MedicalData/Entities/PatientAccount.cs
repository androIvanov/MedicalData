using System;
using System.Collections.Generic;
using System.Text;

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
	}
}
