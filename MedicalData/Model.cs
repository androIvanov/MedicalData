using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MedicalData.EntityConfiguration;
using System.Reflection;

namespace MedicalData
{
    class Model : DbContext
    {
        public DbSet<ClaimPayments> ClaimPayments { get; set; }
        public DbSet<CallsToActions> CallsToActions { get; set; }
        public DbSet<BillingProviders> BillingProviders { get; set; }

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