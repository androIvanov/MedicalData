using System;
using System.Collections.Generic;

namespace MedicalData.Entities
{
    class Guarantors
    {
		public int GuarantorId { get; set; }
		public int AccountId { get; set; }
		public string FamilyName { get; set; }
		public string GivenName { get; set; }
		public string MiddleName { get; set; }
		public string Suffix { get; set; }
		public string SetID { get; set; }
		public string StreetAddress { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string PhoneNumberHome { get; set; }
		public string PhoneNumberBusiness { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Relationship { get; set; }
		public string SNN { get; set; }
		public string EmployerName { get; set; }
		public string EmployerAddress { get; set; }
		public string EmployerPhoneNumber { get; set; }

		// realtional properties

		public PatientAccount PatientAccount { get; set; }
		public ICollection<Insurance> Insurances { get; set; }
	}
}
