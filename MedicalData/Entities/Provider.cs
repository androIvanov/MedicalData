namespace MedicalData.Entities
{
    class Provider
    {
		public int ProviderId { get; set; }
		public int ClaimId { get; set; }
		public string EntityIdCode { get; set; }
		public string EntityTypeQualifier { get; set; }
		public string NameLast { get; set; }
		public string NameFirst { get; set; }
		public string NameMidle { get; set; }
		public string NamePrefix { get; set; }
		public string NameSuffix { get; set; }
		public string IdCodeQualifier { get; set; }
		public string IdCode { get; set; }
		public string EmployersIdentificationNumber { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string Zip { get; set; }

		// relational properties

		public Claims Claim { get; set; }
	}
}
