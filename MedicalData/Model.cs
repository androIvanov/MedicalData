using Microsoft.EntityFrameworkCore;
using System.Reflection;
using MedicalData.Entities;
using System;
using MedicalData.EntityConfiguration;

namespace MedicalData
{
    class Model : DbContext
    {
        public DbSet<ClaimPayments> ClaimPayments { get; set; }
        public DbSet<CallsToActions> CallsToActions { get; set; }
        public DbSet<BillingProviders> BillingProviders { get; set; }
        public DbSet<Claims> Claims { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<EDI835Message> EDI835Messages { get; set; }
        public DbSet<EDI837Message> EDI837Message { get; set; }
        public DbSet<Eligibility> Eligibility { get; set; }
        public DbSet<Guarantors> Guarantors { get; set; }
        public DbSet<HL7Messages> HL7Messages { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<LineNumber> LineNumbers { get; set; }
        public DbSet<NextOfKin> NextOfKins { get; set; }
        public DbSet<PatientAccount> PatientAccounts { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<ServiceLine> ServiceLines { get; set; }
        public DbSet<ServicePayment> ServicePayments { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<PtdScore> PtdScores { get; set; }

        private const string connectionString = "server=localhost; database=MedicalBase; Integrated Security=true";

        protected override void OnConfiguring(DbContextOptionsBuilder contextOptions)
        {
            contextOptions.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Seed();
        }
    }

}