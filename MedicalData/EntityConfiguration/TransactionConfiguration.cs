using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalData.EntityConfiguration
{
    class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(k => k.TransactionId);
			builder.Property(x => x.TransactionId).HasColumnType("int").IsRequired();
			builder.Property(x => x.TransactionHandlingCode).HasColumnType("varchar(2)").IsRequired();
			builder.Property(x => x.TotalActualProviderPaymentAmount).HasColumnType("decimal(18, 2)").IsRequired();
			builder.Property(x => x.CreditDebitFlag).HasColumnType("nchar(1)").IsRequired();
			builder.Property(x => x.PaymentMethodCode).HasColumnType("nchar(3)").IsRequired();
			builder.Property(x => x.PaymentFormatCode).HasColumnType("varchar(10)");
			builder.Property(x => x.DFIIdNumberQualifier_BPR06).HasColumnType("nchar(2)");
			builder.Property(x => x.SenderDFIIdentifier).HasColumnType("varchar(12)");
			builder.Property(x => x.AccountNumberQualifier_BPR08).HasColumnType("varchar(3)");
			builder.Property(x => x.SenderBankAccountNumber).HasColumnType("varchar(35)");
			builder.Property(x => x.PayerId_BPR10).HasColumnType("varchar(10)");
			builder.Property(x => x.OriginatingCompanySupplementalCode_BPR11).HasColumnType("varchar(10)");
			builder.Property(x => x.DFIIdNumberQualifier_BPR12).HasColumnType("nchar(2)");
			builder.Property(x => x.ReceiverOrProviderBankIDNumber).HasColumnType("varchar(12)");
			builder.Property(x => x.AccountNumberQualifier_BPR14).HasColumnType("varchar(3)");
			builder.Property(x => x.ReceiverOrProviderAccountNumber).HasColumnType("varchar(35)");
			builder.Property(x => x.CheckIssueOrEFTEffectiveDate).HasColumnType("date");
			builder.Property(x => x.EFTTraceNumber).HasColumnType("nvarchar(50)").IsRequired();
			builder.Property(x => x.ReceiverId_REF_EV).HasColumnType("nvarchar(50)");
			builder.Property(x => x.ProductionDate_REF_405).HasColumnType("date");
			builder.Property(x => x.PayerName).HasColumnType("nvarchar(60)");
			builder.Property(x => x.PayerIdentifier_N104).HasColumnType("nvarchar(80)");
			builder.Property(x => x.PayerAddress).HasColumnType("nvarchar(80)");
			builder.Property(x => x.PayerCity).HasColumnType("nvarchar(50)");
			builder.Property(x => x.PayerState).HasColumnType("nvarchar(2)");
			builder.Property(x => x.PayerZip).HasColumnType("nvarchar(10)");
			builder.Property(x => x.ReferenceIdQualifier_REF_2U).HasColumnType("nvarchar(3)");
			builder.Property(x => x.AdditionalPayerId_REF_2U).HasColumnType("nvarchar(50)");
			builder.Property(x => x.PayerContactName).HasColumnType("nvarchar(60)");
			builder.Property(x => x.CommunicationNumberQualifier_PER_CX).HasColumnType("nvarchar(2)");
			builder.Property(x => x.CommunicationNumber_PER_CX).HasColumnType("nvarchar(256)");
			builder.Property(x => x.PayeeName).HasColumnType("nvarchar(60)").IsRequired();
			builder.Property(x => x.PayeeIdCodeQualifier).HasColumnType("nvarchar(2)");
			builder.Property(x => x.PayeeIdCode).HasColumnType("nvarchar(80)");
			builder.Property(x => x.PayeeAddress).HasColumnType("nvarchar(80)");
			builder.Property(x => x.PayeeCity).HasColumnType("nvarchar(50)");
			builder.Property(x => x.PayeeState).HasColumnType("nvarchar(2)");
			builder.Property(x => x.PayeeZip).HasColumnType("nvarchar(10)");
			builder.Property(x => x.PayeeReferenceIdQualifier_REF_PQ).HasColumnType("nvarchar(3)");
			builder.Property(x => x.AdditionalPayeeId_REF_PQ).HasColumnType("nvarchar(80)");
			builder.Property(x => x.PayeeReferenceIdQualifier_REF_TJ).HasColumnType("nvarchar(3)");
			builder.Property(x => x.AdditionalPayeeId_REF_TJ).HasColumnType("nvarchar(80)");

			// relations

			builder.HasMany(r => r.ClaimPayments);
			builder.HasMany(r => r.LineNumbers);

			// seeding

			//builder.HasData(
			//	new Transaction 
			//	{
			//		TransactionId = 1,
			//		TransactionHandlingCode = "NN",
			//		TotalActualProviderPaymentAmount = 2999,
			//		CreditDebitFlag = "C",
			//		PaymentMethodCode = "FST",
			//		EFTTraceNumber = "G457JFHG437535HU358",
			//		PayeeName = "Robert",
			//	}	
			//);
		}
    }
}
