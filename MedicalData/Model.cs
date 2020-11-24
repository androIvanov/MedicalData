using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using MedicalData.Entities;

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

        private const string connectionString = "server=localhost; database=MedicalBase; Integrated Security=true";

        protected override void OnConfiguring(DbContextOptionsBuilder contextOptions)
        {
            contextOptions.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

}