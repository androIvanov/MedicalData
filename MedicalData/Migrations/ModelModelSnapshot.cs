﻿// <auto-generated />
using System;
using MedicalData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MedicalData.Migrations
{
    [DbContext(typeof(Model))]
    partial class ModelModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

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
#pragma warning restore 612, 618
        }
    }
}
