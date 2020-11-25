﻿// <auto-generated />
using System;
using MedicalData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MedicalData.Migrations
{
    [DbContext(typeof(Model))]
    [Migration("20201124190208_sixth")]
    partial class sixth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MedicalData.BillingProviders", b =>
                {
                    b.Property<int>("ProviderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Addres")
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EntityTypeQualifier")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("IdentificationCode")
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("IdentificationCodeQualifier")
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("NameFirst")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NameLast")
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("NameMiddle")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("NamePrefix")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("NameSuffix")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ProviderCode")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ReferenceID")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ReferenceIdQualifier")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("TaxReferenceId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TaxReferenceIdQualifier")
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ProviderId");

                    b.ToTable("BillingProviders");
                });

            modelBuilder.Entity("MedicalData.CallsToActions", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Action1")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Action2")
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("PtdCoeficient")
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.ToTable("CallsToActions");
                });

            modelBuilder.Entity("MedicalData.ClaimPayments", b =>
                {
                    b.Property<int>("ClaimPaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimContactComunicationsNumber")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("ClaimContactComunicationsNumberQualifier")
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ClaimFilingIndicatorCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("ClaimFrequencyTypeCode")
                        .HasColumnType("nchar(1)");

                    b.Property<decimal>("ClaimPaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ClaimPaymentPeriodEndDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("ClaimPaymentPeriodStartDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("ClaimRecivedDate")
                        .HasColumnType("date");

                    b.Property<string>("ClaimStatusCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("CorrectedSubscriberEntiryTypeQualifier")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("CorrectedSubscriberFirstName")
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("CorrectedSubscriberLastName")
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("CorrectedSubscriberMiddleName")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CorrectedSubscribreNameSuffix")
                        .HasColumnType("nchar(10)");

                    b.Property<decimal>("CoverageAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FacilityCodeValue")
                        .HasColumnType("nvarchar(2)");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.Property<string>("PatientControlNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(38)");

                    b.Property<string>("PatientEntityTypeQualifier")
                        .IsRequired()
                        .HasColumnType("nchar(1)");

                    b.Property<string>("PatientFirstName")
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("PatientLastName")
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("PatientMiddleName")
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal>("PatientResponsibilityAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PayerClaimControlNumber")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RenderingProviderEntityTypeQualifier")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("RenderingProviderFirstName")
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("RenderingProviderId")
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("RenderingProviderIdCodeQualifier")
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("RenderingProviderLastName")
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("RenderingProviderMiddleName")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("RenderingProviderNameSuffix")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SubscriberEntiryTypeQualifier")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("SubscriberFirstName")
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("SubscriberIdCodeQualifier")
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("SubscriberIdentifierCode")
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("SubscriberLastName")
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("SubscriberMiddleName")
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("SubscribreNameSuffix")
                        .HasColumnType("nvarchar(25)");

                    b.Property<decimal>("TotalClaimChargeAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("ClaimPaymentId");

                    b.ToTable("ClaimPayments");
                });

            modelBuilder.Entity("MedicalData.Entities.Claims", b =>
                {
                    b.Property<int>("ClaimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AdditionalDiagnosisCode1")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("AdditionalDiagnosisCode2")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("AssignmentOfBenefitsIndicator")
                        .HasColumnType("nchar(1)");

                    b.Property<string>("ClaimFrequencyTypeCode")
                        .IsRequired()
                        .HasColumnType("nchar(1)");

                    b.Property<string>("ClaimRefferenceId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DTP434")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("FacilityCodeQualifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("FacilityCodeValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("InstitutionalAdmissionSourceCode")
                        .HasColumnType("nchar(1)");

                    b.Property<string>("InstitutionalAdmissionTypeCode")
                        .HasColumnType("nchar(1)");

                    b.Property<string>("InstitutionalInstitutionalPatientStatusCode")
                        .HasColumnType("nvarchar(2)");

                    b.Property<decimal>("MonetaryAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OccurenceDate")
                        .HasColumnType("date");

                    b.Property<string>("OccurrenceCode")
                        .HasColumnType("nvarchar(2)");

                    b.Property<DateTime>("OnsetDate")
                        .HasColumnType("date");

                    b.Property<string>("PatientControlNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(38)");

                    b.Property<string>("PrincipalDiagnosisCode")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ProviderAcceptAssignmentCode")
                        .HasColumnType("nchar(1)");

                    b.Property<string>("RelatedCausesCode")
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("SignatureOnFileIndicator")
                        .HasColumnType("nchar(1)");

                    b.Property<int>("SubscriberId")
                        .HasColumnType("int");

                    b.HasKey("ClaimId");

                    b.ToTable("Claims");
                });

            modelBuilder.Entity("MedicalData.Entities.Diagnosis", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("DiagnosisCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DiagnosisCodingMethod")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DiagnosisDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("DiagnosisDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("DiagnosisType")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DiagnosticRelatedGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SetID")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DiagnosisId");

                    b.ToTable("Diagnosis");
                });

            modelBuilder.Entity("MedicalData.Entities.EDI835Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageId");

                    b.ToTable("EDI835Messages");
                });

            modelBuilder.Entity("MedicalData.Entities.EDI837Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MessageId");

                    b.ToTable("EDI837Message");
                });

            modelBuilder.Entity("MedicalData.Entities.Eligibility", b =>
                {
                    b.Property<int>("EligibilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("COBSequence")
                        .HasColumnType("int");

                    b.Property<string>("EligibilityStatus")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("InsuranceId")
                        .HasColumnType("int");

                    b.Property<string>("SetID")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SetIDZM2")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("UnpaidBalance")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("UnpaidBalanceType")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EligibilityId");

                    b.ToTable("Eligibility");
                });

            modelBuilder.Entity("MedicalData.Entities.Guarantors", b =>
                {
                    b.Property<int>("GuarantorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("EmployerAddress")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("EmployerName")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("EmployerPhoneNumber")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("GivenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumberBusiness")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumberHome")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Relationship")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SNN")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SetID")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Suffix")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("GuarantorId");

                    b.ToTable("Guarantors");
                });

            modelBuilder.Entity("MedicalData.Entities.HL7Messages", b =>
                {
                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MessageDateTime")
                        .HasColumnType("datetime");

                    b.ToTable("HL7Messages");
                });

            modelBuilder.Entity("MedicalData.Entities.Insurance", b =>
                {
                    b.Property<int>("InsuranceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AuthorizationInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("BillingStatus")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CertificationAgency")
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CertificationBeginDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("CertificationDateTime")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("CertificationEndDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("CertificationModifyDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("CertificationNumber")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CertificationRequired")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CertifiedBy")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CompanyID")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CompanyPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CompanyPlanCode")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CoordinationBenefitsPriority")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CoordinationofBenefits")
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Days")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("GroupNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GuarantorId")
                        .HasColumnType("int");

                    b.Property<string>("InsuredFamilyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("InsuredGivenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("InsuredMiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("InsuredSuffix")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("InsuredsAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("InsuredsDateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("InsuredsEmployerName")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("InsuredsIDNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("InsuredsSSN")
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("NoticeofAdmissionCode")
                        .IsRequired()
                        .HasColumnType("varbinary(50)");

                    b.Property<DateTime>("NoticeofAdmissionDate")
                        .HasColumnType("date");

                    b.Property<string>("Operator")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PlanCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("PlanEffectiveDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("PlanExpirationDate")
                        .HasColumnType("date");

                    b.Property<string>("PlanType")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PolicyNumber")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PreAdmitCertification")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PreCertificationReqWindow")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PriorInsurancePlanID")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RelationshiptoPatient")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("ReportofEligibilityCode")
                        .IsRequired()
                        .HasColumnType("varbinary(50)");

                    b.Property<DateTime>("ReportofEligibilityDate")
                        .HasColumnType("date");

                    b.Property<string>("SetID")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SetIDIN2")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SetIDIN3")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VerificationBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("VerificationDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("VerificationStatus")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InsuranceId");

                    b.ToTable("Insurances");
                });

            modelBuilder.Entity("MedicalData.Entities.LineNumber", b =>
                {
                    b.Property<int>("LineNumberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FacilityTypeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)");

                    b.Property<DateTime>("FiscalPeriodDate")
                        .HasColumnType("date");

                    b.Property<string>("ProviderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("TotalClaimChargeAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TotalClaimCount")
                        .HasColumnType("int");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("LineNumberId");

                    b.ToTable("LineNumbers");
                });

            modelBuilder.Entity("MedicalData.Entities.NextOfKin", b =>
                {
                    b.Property<int>("NOKId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nchar(255)");

                    b.Property<string>("PhoneBusiness")
                        .IsRequired()
                        .HasColumnType("nchar(255)");

                    b.Property<string>("PhoneHome")
                        .IsRequired()
                        .HasColumnType("nchar(255)");

                    b.Property<string>("Relationship")
                        .IsRequired()
                        .HasColumnType("nchar(255)");

                    b.Property<string>("SetID")
                        .IsRequired()
                        .HasColumnType("nchar(255)");

                    b.HasKey("NOKId");

                    b.ToTable("NextOfKins");
                });
#pragma warning restore 612, 618
        }
    }
}