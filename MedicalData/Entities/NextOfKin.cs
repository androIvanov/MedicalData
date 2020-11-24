using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalData.Entities
{
    class NextOfKin
    {
		public int NOKId { get; set; }
		public int AccountId { get; set; }
		public string SetID { get; set; }
		public string Name { get; set; }
		public string Relationship { get; set; }
		public string Address { get; set; }
		public string PhoneHome { get; set; }
		public  string PhoneBusiness { get; set; }
	}
}
