using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalData.Entities
{
    class Person
    {

		public int Id { get; set; }
		public string PatientIdExt { get; set; }
		public string MRN { get; set; }
		public string PatientId { get; set; }
		public string FamilyName { get; set; }
		public string GivenName { get; set; }
		public string MiddleName { get; set; }
		public string NameSuffix { get; set; }
		public string MothersMaidenName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Sex { get; set; }
		public string Race { get; set; }
		public string StreetAddress { get; set; }
		public string OtherDesignation { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }
		public string Country { get; set; }
		public string PhoneHome { get; set; }
		public string PhoneBusiness { get; set; }
		public string Language { get; set; }
		public string SNN { get; set; }
		public string DriversLicense { get; set; }
		public bool MultipleBirthIndicator { get; set; }
		public int BirthOrder { get; set; }
		public string Citizenship { get; set; }
		public DateTime PatientDeathDate { get; set; }
		public int PatientDeathIndicator { get; set; }
	}
}
