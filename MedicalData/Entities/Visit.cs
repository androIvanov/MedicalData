using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalData.Entities
{
    class Visit
    {
		public int VIsitId { get; set; }
		public string SetID { get; set; }
		public string PatientClass { get; set; }
		public string AssignedLocation { get; set; }
		public string AdmissionType { get; set; }
		public string PreAdmitNumber { get; set; }
		public string PriorLocation { get; set; }
		public string AttendingDoctorID { get; set; }
		public string AttendingDoctorFamilyName { get; set; } 
		public string AttendingDoctorGivenName { get; set; }  
		public string AttendingDoctorMiddleName { get; set; }
		public string AttendingDoctorSuffix { get; set; }
		public string AttendingDoctorPrefix { get; set; }  
		public string ReferringDoctor { get; set; }   
		public string ConsultingDoctor { get; set; }		
		public string HospitalService { get; set; }	 
		public string TemporaryLocation { get; set; }
		public string PreAdmitTestIndicator { get; set; }
		public string ReadmissionIndicator { get; set; }
		public string AdmitSource { get; set; }
		public string AmbulatoryStatus { get; set; }
		public string VipIndicator { get; set; }
		public string AdmittingDoctorID { get; set; }
		public string AdmittingDoctorFamilyName { get; set; }
		public string AdmittingDoctorGivenName { get; set; } 
		public string AdmittingDoctorMiddleName { get; set; }	
		public string AdmittingDoctorSuffix { get; set; }
		public string AdmittingDoctorPrefix { get; set; }
		public string PatientType { get; set; }
		public string VisitNumber { get; set; }
		public string FinancialClass { get; set; }
		public string CourtesyCode { get; set; }
		public string ContractCode { get; set; }
		public DateTime ContractEffectiveDate { get; set; }	
		public decimal ContractAmount { get; set; }
		public int ContractPeriod { get; set; }
		public string InterestCode { get; set; }
		public string DeleteAccountIndicator { get; set; }
		public DateTime DeleteAccountDate { get; set; }
		public string DischargeDisposition { get; set; }
		public string DischargeToLocation { get; set; }
		public string ServicingFacility { get; set; }
		public string BedStatus { get; set; }
		public string AccountStatus { get; set; }
		public string PendingLocation { get; set; }
		public string PriorTemporaryLocation { get; set; }
		public DateTime AdmitDateTime { get; set; }
		public DateTime DischargeDateTime { get; set; }
		public decimal CurrentPatientBalance { get; set; }
		public decimal TotalCharges { get; set; }
		public decimal TotalAdjustments { get; set; }
		public decimal TotalPayments { get; set; }
		public string AlternateVisitID { get; set; }
		public string VisitIndicator { get; set; }
		public int AccountId { get; set; }
		public string AccommodationCode { get; set; }
		public string AdmitReason { get; set; }
		public string TransferReason { get; set; }
		public DateTime ExpectedAdmitDate { get; set; }	
		public DateTime ExpectedDischargeDate { get; set; }	
		public int EstimatedLengthOfIPstay { get; set; }
		public int ActualLengthOfIPStay { get; set; }
		public string VisitDescription { get; set; }
		public string ReferralSourceCode { get; set; }
		public string PatientStatusCode { get; set; }
    }
}
