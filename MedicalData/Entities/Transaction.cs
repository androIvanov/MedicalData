using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalData.Entities
{
    class Transaction
    {
		public int TransactionId { get; set; }
		public string TransactionHandlingCode { get; set; }
		public decimal TotalActualProviderPaymentAmount { get; set; }
		public string CreditDebitFlag { get; set; }
		public string PaymentMethodCode { get; set; }
		public string PaymentFormatCode { get; set; }
		public string DFIIdNumberQualifier_BPR06 { get; set; }
		public string SenderDFIIdentifier { get; set; }
		public string AccountNumberQualifier_BPR08 { get; set; }
		public string SenderBankAccountNumber { get; set; }
		public string PayerId_BPR10 { get; set; }
		public string OriginatingCompanySupplementalCode_BPR11 { get; set; }
		public string DFIIdNumberQualifier_BPR12 { get; set; }
		public string ReceiverOrProviderBankIDNumber { get; set; }
		public string AccountNumberQualifier_BPR14 { get; set; }
		public string ReceiverOrProviderAccountNumber { get; set; }
		public DateTime CheckIssueOrEFTEffectiveDate { get; set; }
		public string EFTTraceNumber { get; set; }
		public string ReceiverId_REF_EV { get; set; }
		public DateTime ProductionDate_REF_405 { get; set; }
		public string PayerName { get; set; }
		public string PayerIdentifier_N104 { get; set; }
		public string PayerAddress { get; set; }
		public string PayerCity { get; set; }
		public string PayerState { get; set; }
		public string PayerZip { get; set; }
		public string ReferenceIdQualifier_REF_2U { get; set; }
		public string AdditionalPayerId_REF_2U { get; set; }
		public string PayerContactName { get; set; }
		public string CommunicationNumberQualifier_PER_CX { get; set; }
		public string CommunicationNumber_PER_CX { get; set; }
		public string PayeeName { get; set; }
		public string PayeeIdCodeQualifier { get; set; }
		public string PayeeIdCode { get; set; }
		public string PayeeAddress { get; set; }
		public string PayeeCity { get; set; }
		public string PayeeState { get; set; }
		public string PayeeZip { get; set; }
		public string PayeeReferenceIdQualifier_REF_PQ { get; set; }
		public string AdditionalPayeeId_REF_PQ { get; set; }
		public string PayeeReferenceIdQualifier_REF_TJ { get; set; }
		public string AdditionalPayeeId_REF_TJ { get; set; }
    }
}
