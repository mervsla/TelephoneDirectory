using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TelephoneDirectory.ReportService.DataAccessLayer.Entitites;

namespace TelephoneDirectory.ReportService.DataAccessLayer.RSContext
{
   public class ReportServiceContext:DbContext
    {
        public DbSet<Report> Reports { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=TDReportServiceDb;Integrated Security=true; User Id=postgres;Password=0010;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Report>().ToTable("Report", "public");
        }
    }
}
