using CA_Hospital_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace CA_Hospital_Management.Data
{
    public class HospitalDbContext : DbContext
    {
        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Nurse> Nurses => Set<Nurse>();
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Consultation> Consultations => Set<Consultation>();
        public DbSet<ConsultationDetails> ConsultationNurses => Set<ConsultationDetails>();
        public DbSet<Login> Logins => Set<Login>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=.;Database=HospitalManagement;Trusted_Connection=True;TrustServerCertificate=True"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().ToTable("Doctors");
            modelBuilder.Entity<Nurse>().ToTable("Nurses");
            modelBuilder.Entity<Patient>().ToTable("Patients");
            modelBuilder.Entity<Consultation>().ToTable("Consultations");
            modelBuilder.Entity<ConsultationDetails>().ToTable("ConsultationNurses");
            modelBuilder.Entity<Login>().ToTable("Logins");
        }
    }
}
