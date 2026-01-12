
using CA_Hospital_Management.Data;
using CA_Hospital_Management.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CA_Hospital_Management.Repositories
{
    public class ConsultationRepository
    {
        HospitalDbContext context;

        public ConsultationRepository()
        {
            context = new HospitalDbContext();
        }
        public ListPaginated<ConsultationDto> SearchConsultationPaged(string firstName, int pageNumber, int pageSize)
        {
            var result = new ListPaginated<ConsultationDto>();

            using var conn = new SqlConnection(context.Database.GetConnectionString());
            using var cmd = new SqlCommand("GetConsultationsPaged", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName",
                string.IsNullOrWhiteSpace(firstName) ? DBNull.Value : firstName);
            cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
            cmd.Parameters.AddWithValue("@PageSize", pageSize);

            conn.Open();

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Items.Add(new ConsultationDto
                {
                    ConsultationId = reader.GetInt32(reader.GetOrdinal("ConsultationId")),
                    ConsultationPatientId = reader.GetInt32(reader.GetOrdinal("ConsultationPatientId")),
                    ConsultationDoctorId = reader.GetInt32(reader.GetOrdinal("ConsultationDoctorId")),
                    PatientFirstName = reader.GetString(reader.GetOrdinal("PatientFirstName")),
                    PatientLastName = reader.GetString(reader.GetOrdinal("PatientLastName")),
                    DoctorFirstName = reader.GetString(reader.GetOrdinal("DoctorFirstName")),
                    DoctorLastName = reader.GetString(reader.GetOrdinal("DoctorLastName")),
                    ConsultationReason = reader.GetString(reader.GetOrdinal("ConsultationReason")),
                    ConsultationDiagnosis = reader.GetString(reader.GetOrdinal("ConsultationDiagnosis")),
                    ConsultationNotes = reader.GetString(reader.GetOrdinal("ConsultationNotes")),
                    ConsultationDate = reader.GetDateTime(reader.GetOrdinal("ConsultationDate")),
                    
                });
            }
            if (reader.NextResult() && reader.Read())
            {
                result.TotalRecords = reader.GetInt32(0);
                result.TotalPages = (int)Math.Ceiling(
                    (double)result.TotalRecords / pageSize);
            }

            return result;
        }

        internal void CreateConsultation(Consultation consultation)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC CreateConsultation @ConsultationPatientId, @ConsultationDoctorId, @ConsultationReason, @ConsultationDiagnosis, @ConsultationNotes, @ConsultationDate",
                new SqlParameter("@ConsultationPatientId", consultation.ConsultationPatientId),
                new SqlParameter("@ConsultationDoctorId", consultation.ConsultationDoctorId),
                new SqlParameter("@ConsultationReason", consultation.ConsultationReason),
                new SqlParameter("@ConsultationDiagnosis", consultation.ConsultationDiagnosis),
                new SqlParameter("@ConsultationNotes", consultation.ConsultationNotes),
                new SqlParameter("@ConsultationDate", consultation.ConsultationDate)
            );
        }

        internal void DeleteConsultation(int value)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC DeleteConsultation @ConsultationId",
                new SqlParameter("@ConsultationId", value));
        }

        internal void UpdateConsultation(Consultation consultation)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC UpdateConsultation @ConsultationId, @ConsultationPatientId, @ConsultationDoctorId, @ConsultationReason, @ConsultationDiagnosis, @ConsultationNotes, @ConsultationDate",
                new SqlParameter("@ConsultationId", consultation.ConsultationId),
                new SqlParameter("@ConsultationPatientId", consultation.ConsultationPatientId),
                new SqlParameter("@ConsultationDoctorId", consultation.ConsultationDoctorId),
                new SqlParameter("@ConsultationReason", consultation.ConsultationReason),
                new SqlParameter("@ConsultationDiagnosis", consultation.ConsultationDiagnosis),
                new SqlParameter("@ConsultationNotes", consultation.ConsultationNotes),
                new SqlParameter("@ConsultationDate", consultation.ConsultationDate)
            );
        }
    }
}
