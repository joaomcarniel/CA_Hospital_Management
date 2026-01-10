using CA_Hospital_Management.Data;
using CA_Hospital_Management.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Repositories
{
    public class HospitalRepository
    {
        // -------------------- DOCTORS --------------------

        public List<Doctor> GetAllDoctors()
        {
            using var context = new HospitalDbContext();
            return context.Doctors
                .FromSqlRaw("EXEC GetAllDoctors")
                .AsNoTracking()
                .ToList();
        }

        // -------------------- NURSES --------------------

        public List<Nurse> GetAllNurses()
        {
            using var context = new HospitalDbContext();
            return context.Nurses
                .FromSqlRaw("EXEC GetAllNurses")
                .AsNoTracking()
                .ToList();
        }

        public List<Nurse> GetMaleNurses()
        {
            using var context = new HospitalDbContext();
            return context.Nurses
                .FromSqlRaw("EXEC GetMaleNurses")
                .AsNoTracking()
                .ToList();
        }

        // -------------------- PATIENTS --------------------

        public List<Patient> GetAllPatients()
        {
            using var context = new HospitalDbContext();
            return context.Patients
                .FromSqlRaw("EXEC GetAllPatients")
                .AsNoTracking()
                .ToList();
        }

        public List<Patient> GetPatientsAbove25()
        {
            using var context = new HospitalDbContext();
            return context.Patients
                .FromSqlRaw("EXEC GetPatientsAbove25")
                .AsNoTracking()
                .ToList();
        }

        // -------------------- CONSULTATIONS --------------------

        public List<Consultation> GetAllConsultations()
        {
            using var context = new HospitalDbContext();
            return context.Consultations
                .FromSqlRaw("EXEC GetAllConsultations")
                .AsNoTracking()
                .ToList();
        }

        public List<Consultation> GetConsultationsByPatient(int patientId)
        {
            using var context = new HospitalDbContext();
            return context.Consultations
                .FromSqlRaw(
                    "EXEC GetConsultationsByPatient @PatientId",
                    new SqlParameter("@PatientId", patientId)
                )
                .AsNoTracking()
                .ToList();
        }

        public List<Consultation> GetConsultationsByDate(DateTime date)
        {
            using var context = new HospitalDbContext();
            return context.Consultations
                .FromSqlRaw(
                    "EXEC GetConsultationsByDate @Date",
                    new SqlParameter("@Date", date)
                )
                .AsNoTracking()
                .ToList();
        }

        // -------------------- CONSULTATION NURSES --------------------

        public List<ConsultationNurse> GetConsultationNursesByConsultation(int consultationId)
        {
            using var context = new HospitalDbContext();
            return context.ConsultationNurses
                .FromSqlRaw(
                    "EXEC GetConsultationNursesByConsultationId @ConsultationId",
                    new SqlParameter("@ConsultationId", consultationId)
                )
                .AsNoTracking()
                .ToList();
        }

        //// -------------------- REPORTS (DTO) --------------------

        //public List<PatientConsultationReport> GetConsultationCountPerPatient()
        //{
        //    using var context = new HospitalDbContext();

        //    return context.Set<PatientConsultationReport>()
        //        .FromSqlRaw("EXEC GetConsultationCountPerPatient")
        //        .AsNoTracking()
        //        .ToList();
        //}
    }
}
