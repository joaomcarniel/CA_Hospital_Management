
using CA_Hospital_Management.Data;
using CA_Hospital_Management.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CA_Hospital_Management.Repositories
{
    public class PatientRepository
    {
        HospitalDbContext context;

        public PatientRepository()
        {
            context = new HospitalDbContext();
        }

        public void CreatePatient(Patient patient)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC CreatePatient @FirstName, @LastName, @Address, @County, @Dob, @Phone, @Email, @Gender, @PatientNumber",
                new SqlParameter("@FirstName", patient.FirstName),
                new SqlParameter("@LastName", patient.LastName),
                new SqlParameter("@Address", patient.Address),
                new SqlParameter("@County", patient.County),
                new SqlParameter("@Dob", patient.Dob),
                new SqlParameter("@Phone", patient.Phone),
                new SqlParameter("@Email", patient.Email),
                new SqlParameter("@Gender", patient.Gender),
                new SqlParameter("@PatientNumber", patient.PatientNumber)
            );
        }

        public void DeletePatient(int value)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC DeletePatient @PatientId",
                new SqlParameter("PatientId", value));
        }

        public ListPaginated<Patient> SearchPatientsPaged(string firstName, int pageNumber, int pageSize)
        {
            var result = new ListPaginated<Patient>();

            using var conn = new SqlConnection(context.Database.GetConnectionString());
            using var cmd = new SqlCommand("GetPatientsPaged", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName",
                string.IsNullOrWhiteSpace(firstName) ? DBNull.Value : firstName);
            cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
            cmd.Parameters.AddWithValue("@PageSize", pageSize);

            conn.Open();

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Items.Add(new Patient
                {
                    PatientId = reader.GetInt32(reader.GetOrdinal("PatientId")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                    Email = reader.GetString(reader.GetOrdinal("Email")),
                    Address = reader.GetString(reader.GetOrdinal("Addr")),
                    County = reader.GetString(reader.GetOrdinal("County")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    PatientNumber = reader.GetInt32(reader.GetOrdinal("PatientNumber")),
                    Dob = reader.GetDateTime(reader.GetOrdinal("Dob"))
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

        public ListPaginated<Patient> SearchPatientsAbove25Paged(int pageNumber, int pageSize)
        {
            var result = new ListPaginated<Patient>();

            using var conn = new SqlConnection(context.Database.GetConnectionString());
            using var cmd = new SqlCommand("GetPatientsAbove25", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
            cmd.Parameters.AddWithValue("@PageSize", pageSize);

            conn.Open();

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Items.Add(new Patient
                {
                    PatientId = reader.GetInt32(reader.GetOrdinal("PatientId")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                    Email = reader.GetString(reader.GetOrdinal("Email")),
                    Address = reader.GetString(reader.GetOrdinal("Addr")),
                    County = reader.GetString(reader.GetOrdinal("County")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    PatientNumber = reader.GetInt32(reader.GetOrdinal("PatientNumber")),
                    Dob = reader.GetDateTime(reader.GetOrdinal("Dob"))
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

        public void UpdatePatient(Patient patient)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC UpdatePatient @PatientId, @FirstName, @LastName, @Address, @County, @Dob, @Phone, @Email, @Gender, @PatientNumber",
                new SqlParameter("@PatientId", patient.PatientId),
                new SqlParameter("@FirstName", patient.FirstName),
                new SqlParameter("@LastName", patient.LastName),
                new SqlParameter("@Address", patient.Address),
                new SqlParameter("@County", patient.County),
                new SqlParameter("@Dob", patient.Dob),
                new SqlParameter("@Phone", patient.Phone),
                new SqlParameter("@Email", patient.Email),
                new SqlParameter("@Gender", patient.Gender),
                new SqlParameter("@PatientNumber", patient.PatientNumber)
            );
        }
    }
}
