using System;
using System.Collections.Generic;

namespace MedicalData.Entities
{
    class ClaimPayments
    {
        public int ClaimPaymentId { get; set; }
        public int TransactionId { get; set; }
        public int MessageId { get; set; }
        public int PatientControlNumber { get; set; }
        public int ClaimStatusCode { get; set; }
        public decimal TotalClaimChargeAmount { get; set; }
        public decimal ClaimPaymentAmount { get; set; }
        public decimal PatientResponsibilityAmount { get; set; }
        public string ClaimFilingIndicatorCode { get; set; }
        public string PayerClaimControlNumber { get; set; }
        public string FacilityCodeValue { get; set; }
        public string ClaimFrequencyTypeCode { get; set; }
        public string PatientEntityTypeQualifier { get; set; }
        public string PatientLastName { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientMiddleName { get; set; }
        public string SubscriberEntiryTypeQualifier { get; set; }
        public string SubscriberLastName { get; set; }
        public string SubscriberFirstName { get; set; }
        public string SubscriberMiddleName { get; set; }
        public string SubscribreNameSuffix { get; set; }
        public string SubscriberIdCodeQualifier { get; set; }
        public string SubscriberIdentifierCode { get; set; }
        public string CorrectedSubscriberEntiryTypeQualifier { get; set; }
        public string CorrectedSubscriberLastName { get; set; }
        public string CorrectedSubscriberFirstName { get; set; }
        public string CorrectedSubscriberMiddleName { get; set; }
        public string CorrectedSubscribreNameSuffix { get; set; }
        public string RenderingProviderEntityTypeQualifier { get; set; }
        public string RenderingProviderLastName { get; set; }
        public string RenderingProviderFirstName { get; set; }
        public string RenderingProviderMiddleName { get; set; }
        public string RenderingProviderNameSuffix { get; set; }
        public string RenderingProviderIdCodeQualifier { get; set; }
        public string RenderingProviderId { get; set; }
        public DateTime ClaimRecivedDate { get; set; }
        public DateTime ClaimPaymentPeriodStartDate { get; set; }
        public DateTime ClaimPaymentPeriodEndDate { get; set; }
        public string ClaimContactComunicationsNumberQualifier { get; set; }
        public string ClaimContactComunicationsNumber { get; set; }
        public decimal CoverageAmount { get; set; }

        // realtional properties

        public EDI835Message EDI835Message { get; set; }
        public ICollection<ServicePayment> ServicePayments { get; set; }
        public Transaction Transaction { get; set; }
    }
}
