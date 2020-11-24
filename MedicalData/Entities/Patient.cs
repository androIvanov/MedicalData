using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalData.Entities
{
    class Patient
    {
		public int PatientId { get; set; }
		public int SubscriberId { get; set; }
		public string EntityTypeQualifier { get; set; }
		public string NameLast { get; set; }
		public string NameFirst { get; set; }
		public string NameMidle { get; set; }
		public string NamePrefix { get; set; }
		public string NameSuffix { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Sex { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZIp { get; set; }
		public string IndividualRelationshipCode { get; set; }
	}
}
