using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MedicalData.Entities;

namespace MedicalData.EntityConfiguration
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Transaction>().HasData(new Transaction
            {
                TransactionId = 1,
                TransactionHandlingCode = "NN",
                TotalActualProviderPaymentAmount = 2999,
                CreditDebitFlag = "C",
                PaymentMethodCode = "FST",
                EFTTraceNumber = "G457JFHG437535HU358",
                PayeeName = "Robert",
            });
            builder.Entity<LineNumber>().HasData(new LineNumber
            {
                LineNumberId = 10,
                TransactionId = 1,
                ProviderId = "PROVIDER225",
                FacilityTypeCode = "GA",
                FiscalPeriodDate = DateTime.UtcNow,
                TotalClaimCount = 65893,
                TotalClaimChargeAmount = 2421
            });
            builder.Entity<ClaimPayments>().HasData(new ClaimPayments
            {
                ClaimPaymentId = 1,
                TransactionId = 1,
                MessageId = 1,
                PatientControlNumber = "JHGE578TOH4",
                ClaimStatusCode = "PS",
                TotalClaimChargeAmount = 567,
                ClaimPaymentAmount = 999,
                ClaimFilingIndicatorCode = "JA",
                PatientEntityTypeQualifier = "S",
                ClaimRecivedDate = DateTime.UtcNow
            });
            builder.Entity<ServicePayment>().HasData(new ServicePayment
            {
                ServicePaymentId = 1,
                ClaimPaymentId = 1,
                ServiceIdQualifier = "JS",
                AdjudicatedProcedureCode = "6F48J56N9476GJG0E5HG",
                LineItemChargeAmount = 4354.22m,
                LineItemProviderPaymentAmount = 34.31m,
                UnitsOfServicePaidCount = 334
            });
            builder.Entity<EDI835Message>().HasData(new EDI835Message
            {
                MessageId = 1,
                Message = "Lorem ipsum ziben aleb",
                DateAdded = DateTime.UtcNow
            });

            //
            builder.Entity<PatientAccount>().HasData(new PatientAccount
            {
                AccountId = 1,
                PersonId = 1,
                AppointmentID = "SSD",
                PatientAccountNumber = "J7A1R3V4A9N",
                StudentIndicator = false,
                Facility = "SoftServe"
            });
            builder.Entity<Visit>().HasData(new Visit
            {
                VisitId = 1,
                SetID = "SETTINGID45678",
                PatientClass = "First",
                AssignedLocation = "Varna",
                AttendingDoctorID = "G589TY8ORIO4590",
                AttendingDoctorFamilyName = "Joshua",
                AttendingDoctorGivenName = "Spark",
                AttendingDoctorMiddleName = "Jonson",
                AttendingDoctorSuffix = "ly",
                AttendingDoctorPrefix = "Dr.",
                ReferringDoctor = "Jackob",
                ConsultingDoctor = "Vladimir",
                HospitalService = "Stavri",
                AdmittingDoctorID = "U57839",
                AdmittingDoctorFamilyName = "Gregor",
                AdmittingDoctorGivenName = "Jo",
                AdmittingDoctorMiddleName = "Marchal",
                AdmittingDoctorSuffix = "ny",
                AdmittingDoctorPrefix = "Juniour",
                PatientType = "Elder",
                VisitNumber = "25CC",
                FinancialClass = "Upper",
                DeleteAccountIndicator = "NO",
                DeleteAccountDate = DateTime.UtcNow,
                AccountStatus = "Innactive",
                AdmitDateTime = DateTime.UtcNow,
                DischargeDateTime = DateTime.UtcNow,
                AccountId = 1,
            });
            builder.Entity<Person>().HasData(
                new Person
                {
                    Id = 1,
                    PatientIdExt = "SURENDERAT20",
                    MRN = "SERVICE",
                    PatientId = "GOSHOPECHEV225",
                    FamilyName = "Silvester",
                    GivenName = "Jo",
                    MiddleName = "Jackson",
                    NameSuffix = "ly",
                    MothersMaidenName = "Marine",
                    DateOfBirth = DateTime.UtcNow,
                    Sex = "M",
                    StreetAddress = "Osmi PRimorski polk",
                    OtherDesignation = "Eastern BG",
                    City = "Varna",
                    State = "VarnaState",
                    Zip = "9010",
                    SNN = "YO"
                }
            );
            builder.Entity<Diagnosis>().HasData(
                new Diagnosis 
                {
                    DiagnosisId = 1,
                    SetID = "Identity",
                    DiagnosisCode = "ITSOK00",
                    DiagnosisDescription = "ALLGOOD",
                    DiagnosticRelatedGroup = "Elders",
                    AccountId = 1,
                }
            );
            builder.Entity<Procedure>().HasData(
                new Procedure 
                {
                    ProcedureId = 1,
                    DiagnosisId = 1,
                    SerID = "JFK",
                    ProcedureCode = "FGHUI96543",
                    ProcedureDescription = "Nothing too serious",
                    ProcedureDateTime = DateTime.UtcNow,
                }
            );
            builder.Entity<Guarantors>().HasData(
                new Guarantors 
                {
                    GuarantorId = 1,
                    AccountId = 1,
                    FamilyName = "Ivanov",
                    GivenName = "Stoqn",
                    MiddleName = "Jack",
                    Suffix = "ly",
                    SetID = "545NM349Y46",
                    StreetAddress = "Vihren40",
                    City = "Sofia",
                    State = "Sofia",
                    Zip = "1701",
                    DateOfBirth = DateTime.UtcNow,
                }
            );
            builder.Entity<Insurance>().HasData(
                new Insurance
                {
                    InsuranceId = 1,
                    GuarantorId = 1,
                    SetID = "GIO6543",
                    PlanCode = "SSG",
                    CompanyID = "IK40563",
                    CompanyName = "IKEA",
                    CompanyAddress = "Sweden",
                    CompanyPhoneNumber = "0555857",
                    GroupNumber = "225",
                    GroupName = "Fourlis",
                    PlanEffectiveDate = DateTime.UtcNow,
                    PlanExpirationDate = DateTime.ParseExact("2005-09-01", "yyyy-MM-dd", null),
                    AuthorizationInformation = "Authorised",
                    PlanType = "Good",
                    InsuredFamilyName = "Dobrevi",
                    InsuredGivenName = "JSON",
                    InsuredMiddleName = "Varchaev",
                    InsuredSuffix = "ny",
                    RelationshiptoPatient = "Daenerys",
                    InsuredsDateOfBirth = DateTime.ParseExact("2005-09-01", "yyyy-MM-dd", null),
                    InsuredsAddress = "Varna, bul Osmi Primorski Polk",
                    ReportofEligibilityCode = 13,
                    ReportofEligibilityDate = DateTime.ParseExact("2005-09-01", "yyyy-MM-dd", null),
                    PreAdmitCertification = "Certificacate",
                    VerificationDateTime = DateTime.ParseExact("2005-09-01", "yyyy-MM-dd", null),
                    VerificationBy = "Jack Morrison",
                    PolicyNumber = "2456",
                    InsuredsIDNumber = "0YR72TL49Z5",
                    SetIDIN2 = "8y2903rj",
                    SetIDIN3 = "GHOP04U78",
                }
            );
            builder.Entity<Eligibility>().HasData(
                new Eligibility 
                {
                    EligibilityId = 1,
                    InsuranceId = 1,
                    SetID = "SOMEID",
                    SetIDZM2 = "835306N",
                }
            );
            builder.Entity<NextOfKin>().HasData(
                new NextOfKin
                {
                    NOKId = 1,
                    AccountId = 1,
                    SetID = "SOMEID",
                    Name = "Jason",
                    Relationship = "brother",
                    Address = "Sofia, Vihren 40",
                    PhoneHome = "305693",
                    PhoneBusiness = "555785"
                }
            );
            builder.Entity<PtdScore>().HasData(
                new PtdScore
                {
                    ScoreId = 1,
                    AccountId = 1,
                    Code = "50GNFH78G",
                    Score = 25.7m,
                    IsResolved = true,
                }
            );
            builder.Entity<CallsToActions>().HasData(
                new CallsToActions
                {
                    Code = "74589OTKJFN",
                    Action1 = "Diagnose",
                    Action2 = "Procedures",
                    PtdCoeficient = 256
                }
            );
            builder.Entity<BillingProviders>().HasData(
                new BillingProviders 
                {
                    ProviderId = 1,
                }
            );
            builder.Entity<Subscriber>().HasData(
                new Subscriber
                {
                    SubscriberId = 1,
                    ProviderId = 1,
                    MessageId = 1,
                    PayerResponsibilitySequenceNumberCode = "S",
                }
            );
            builder.Entity<Patient>().HasData(
                new Patient
                {
                    PatientId = 1,
                    SubscriberId = 1,
                    EntityTypeQualifier = "M",
                    DateOfBirth = DateTime.UtcNow,
                    Sex = "M",
                    IndividualRelationshipCode = "SN"
                }
            );
            builder.Entity<Claims>().HasData(
                new Claims 
                {
                    ClaimId = 1,
                    SubscriberId = 1,
                    PatientControlNumber = "7890OJNB",
                    MonetaryAmount = 56.8m,
                    FacilityCodeValue = "C",
                    FacilityCodeQualifier = "S",
                    ClaimFrequencyTypeCode = "C",
                }
            );
            builder.Entity<EDI837Message>().HasData(
                new EDI837Message 
                {
                    MessageId = 1,
                    Message = "All good",
                    DateAdded = DateTime.UtcNow
                }
            );
            builder.Entity<ServiceLine>().HasData(
                new ServiceLine 
                {
                    ServiceLineId = 1,
                    ClaimId = 1,
                    ServiceIDQualifier = "JS",
                    ServiceID = "ghi7654",
                    MonetaryAmount = 108.2m,
                    UnitForMeasurementCode = "GL",
                    Quantity = 3.5m,
                    ServiceDateTime = DateTime.UtcNow
                }
            );
            builder.Entity<Provider>().HasData(
                new Provider 
                {
                   ProviderId = 1,
                   ClaimId = 1,
                   EntityIdCode = "MS",
                   EntityTypeQualifier = "F",
                }
            );
            //builder.Entity<HL7Messages>().HasData(
            //    new HL7Messages 
            //    {
            //        MessageDateTime = DateTime.UtcNow,
            //        Message = "All finaly good",
            //        AccountId = 1,
            //    }
            //);
        }
    }
}
