using System;
using System.Collections.Generic;

namespace MedicalData.Entities
{
    class Subscriber
    {
		public int SubscriberId { get; set; }
		public int ProviderId { get; set; }
		public int MessageId { get; set; }
		public string PayerResponsibilitySequenceNumberCode { get; set; }
		public string IndividualRelationshipCode { get; set; }
		public string ReferenceIdentification { get; set; }
		public string Name { get; set; }
		public string InsuranceTypeCode { get; set; }
		public string ClaimFilingIndicatorCode { get; set; }
		public string SubscriberEntityTypeQualifier { get; set; }
		public string SubscriberNameLast { get; set; }
		public string SubscriberNameFirst { get; set; }
		public string SubscriberNameMidle { get; set; }
		public string SubscriberNamePrefix { get; set; }
		public string SubscriberNameSuffix { get; set; }
		public string SubscriberIdentificationCodeQualifier { get; set; }
		public string SubscriberIdentificationCode { get; set; }
		public string SubscriberAddress { get; set; }
		public string SubscriberCity { get; set; }
		public string SubscriberState { get; set; }
		public string SubscriberZip { get; set; }
		public DateTime? SubscriberDateOfBirth { get; set; }
		public string SubscriberSex { get; set; }
		public string PayerEntityTypeQualifier { get; set; }
		public string PayerNameLast { get; set; }
		public string PayerNameFirst { get; set; }
		public string PayerNameMidle { get; set; }
		public string PayerNamePrefix { get; set; }
		public string PayerNameSuffix { get; set; }
		public string PayerIdentificationCodeQualifier { get; set; }
		public string PayerIdentificationCode { get; set; }
		public string PayerAddress { get; set; }
		public string PayerCity { get; set; }
		public string PayerState { get; set; }
		public string PayerZip { get; set; }

		// realtional properties

		public EDI837Message EDI837Message { get; set; }
		public ICollection<Patient> Patients { get; set; }
		public BillingProviders BillingProvider { get; set; }
		public ICollection<Claims> Claims { get; set; }
    }
}
