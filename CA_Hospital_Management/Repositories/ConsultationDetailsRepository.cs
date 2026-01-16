
using CA_Hospital_Management.Data;
using CA_Hospital_Management.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CA_Hospital_Management.Repositories
{
    public class ConsultationDetailsRepository
    {
        HospitalDbContext context;

        public ConsultationDetailsRepository()
        {
            context = new HospitalDbContext();
        }

        internal void CreateConsultationDetails(ConsultationDetails consultation)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC CreateConsultationDetails @NurseId, @ConsultationId, @PatientId, @Reason, @Notes, @ConsultationDate",
                new SqlParameter("@NurseId", consultation.NurseId),
                new SqlParameter("@ConsultationId", consultation.ConsultationId),
                new SqlParameter("@PatientId", consultation.PatientId),
                new SqlParameter("@Reason", consultation.Reason),
                new SqlParameter("@Notes", consultation.Notes),
                new SqlParameter("@ConsultationDate", consultation.ConsultationDate)
            );
        }

        internal void DeleteConsultation(int value)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC DeleteConsultationDetails @ConsultDetailsId",
                new SqlParameter("@ConsultDetailsId", value));
        }

        public ListPaginated<ConsultationDetailsDto> SearchConsultationDetailsPaged(string firstName, int pageNumber, int pageSize)
        {
            var result = new ListPaginated<ConsultationDetailsDto>();

            using var conn = new SqlConnection(context.Database.GetConnectionString());
            using var cmd = new SqlCommand("GetConsultationDetailsPaged", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName",
                string.IsNullOrWhiteSpace(firstName) ? DBNull.Value : firstName);
            cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
            cmd.Parameters.AddWithValue("@PageSize", pageSize);

            conn.Open();

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Items.Add(new ConsultationDetailsDto
                {
                    ConsultDetailsId = reader.GetInt32(reader.GetOrdinal("ConsultDetailsId")),
                    NurseId = reader.GetInt32(reader.GetOrdinal("NurseId")),
                    ConsultationId = reader.GetInt32(reader.GetOrdinal("ConsultationId")),
                    PatientId = reader.GetInt32(reader.GetOrdinal("PatientId")),
                    PatientFirstName = reader.GetString(reader.GetOrdinal("PatientFirstName")),
                    PatientLastName = reader.GetString(reader.GetOrdinal("PatientLastName")),
                    NurseFirstName = reader.GetString(reader.GetOrdinal("NurseFirstName")),
                    NurseLastName = reader.GetString(reader.GetOrdinal("NurseLastName")),
                    Reason = reader.GetString(reader.GetOrdinal("Reason")),
                    Notes = reader.GetString(reader.GetOrdinal("Notes")),
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

        internal void UpdateConsultation(ConsultationDetails consultation)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC UpdateConsultationDetails @ConsultDetailsId, @NurseId, @ConsultationId, @PatientId, @Reason, @Notes, @ConsultationDate",
                new SqlParameter("@ConsultDetailsId", consultation.ConsultDetailsId),
                new SqlParameter("@NurseId", consultation.NurseId),
                new SqlParameter("@ConsultationId", consultation.ConsultationId),
                new SqlParameter("@PatientId", consultation.PatientId),
                new SqlParameter("@Reason", consultation.Reason),
                new SqlParameter("@Notes", consultation.Notes),
                new SqlParameter("@ConsultationDate", consultation.ConsultationDate)
            );
        }
    }
}
