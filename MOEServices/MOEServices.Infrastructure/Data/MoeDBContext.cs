using Microsoft.EntityFrameworkCore;
using MOEServices.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Infrastructure.Data
{
    public class MoeDBContext : DbContext
    {
        public string ConnectionString { get; set; }

        public MoeDBContext(DbContextOptions<MoeDBContext> options) : base(options)
        {

        }

        public DbSet<CertificateAttestation> CertificateAttestations { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
