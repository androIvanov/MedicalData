using System;
using System.Collections.Generic;

namespace MedicalData.Entities
{
    class Insurance
    {
		public int InsuranceId { get; set; }
		public int GuarantorId { get; set; }
		public string SetID { get; set; }
		public string PlanCode { get; set; }
		public string CompanyID { get; set; }
		public string CompanyName { get; set; }
		public string CompanyAddress { get; set; }
		public string CompanyPhoneNumber { get; set; }
		public string GroupNumber { get; set; }
		public string GroupName { get; set; }
		public DateTime PlanEffectiveDate { get; set; }
		public DateTime PlanExpirationDate { get; set; }
		public string AuthorizationInformation { get; set; }
		public string PlanType { get; set; }
		public string InsuredFamilyName { get; set; }
		public string InsuredGivenName { get; set; }
		public string InsuredMiddleName { get; set; }
		public string InsuredSuffix { get; set; }
		public string RelationshiptoPatient { get; set; }
		public DateTime InsuredsDateOfBirth { get; set; }
		public string InsuredsAddress { get; set; }
		public string CoordinationofBenefits { get; set; }
		public string CoordinationBenefitsPriority { get; set; }
		public byte NoticeofAdmissionCode { get; set; }
		public DateTime NoticeofAdmissionDate { get; set; }
		public byte ReportofEligibilityCode { get; set; }
		public DateTime ReportofEligibilityDate { get; set; }
		public string PreAdmitCertification { get; set; }
		public DateTime VerificationDateTime { get; set; }
		public string VerificationBy { get; set; }
		public string BillingStatus { get; set; }
		public string CompanyPlanCode { get; set; }
		public string PolicyNumber { get; set; }
		public string VerificationStatus { get; set; }
		public string PriorInsurancePlanID { get; set; }
		public string InsuredsIDNumber { get; set; }
		public string SetIDIN2 { get; set; }
		public string InsuredsSSN { get; set; }
		public string InsuredsEmployerName { get; set; }
		public string SetIDIN3 { get; set; }
		public string CertificationNumber { get; set; }
		public string CertifiedBy { get; set; }
		public string CertificationRequired { get; set; }
		public DateTime CertificationDateTime { get; set; }
		public DateTime CertificationModifyDateTime { get; set; }
		public string Operator { get; set; }
		public DateTime CertificationBeginDate { get; set; }
		public DateTime CertificationEndDate { get; set; }
		public int Days { get; set; }
		public string CertificationAgency { get; set; }
		public string PreCertificationReqWindow { get; set; }

		// realtional properties

		public Guarantors Guarantor { get; set; }
		public ICollection<Eligibility> Eligibilities { get; set; }
	}
}
