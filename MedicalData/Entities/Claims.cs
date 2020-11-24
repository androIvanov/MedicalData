using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalData.Entities
{
    class Claims
    {
    public int ClaimId { get; set; }
	public int SubscriberId { get; set; }
    public string PatientControlNumber { get; set; }
	public decimal MonetaryAmount { get; set; }
	public string FacilityCodeValue { get; set; }
	public string FacilityCodeQualifier { get; set; }
	public string ClaimFrequencyTypeCode { get; set; }
    public string SignatureOnFileIndicator { get; set; }
	public string ProviderAcceptAssignmentCode { get; set; }
	public string AssignmentOfBenefitsIndicator { get; set; }
	public string RelatedCausesCode { get; set; }
	public DateTime OnsetDate { get; set; }
	public string DTP434 { get; set; }
	public string PrincipalDiagnosisCode { get; set; } 
	public string AdditionalDiagnosisCode1 { get; set; }
	public string AdditionalDiagnosisCode2 { get; set; }
	public string OccurrenceCode { get; set; }
	public DateTime OccurenceDate { get; set; }
	public string InstitutionalAdmissionTypeCode { get; set; }
	public string InstitutionalAdmissionSourceCode { get; set; }
	public string InstitutionalInstitutionalPatientStatusCode { get; set; }
	public string ClaimRefferenceId { get; set; }
    }
}
