using CA_Hospital_Management.Data;
using CA_Hospital_Management.Models.DTOs;
using CA_Hospital_Management.Models.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data;

namespace CA_Hospital_Management.Repositories
{
    public class DoctorRepository
    {
        HospitalDbContext context;
        public DoctorRepository()
        {
            context = new HospitalDbContext();
        }

        public ListPaginated<Doctor> SearchDoctorsPaged(string firstName, int pageNumber, int pageSize)
        {
            var result = new ListPaginated<Doctor>();

            using var conn = new SqlConnection(context.Database.GetConnectionString());
            using var cmd = new SqlCommand("GetDoctorsPaged", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName",
                string.IsNullOrWhiteSpace(firstName) ? DBNull.Value : firstName);
            cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
            cmd.Parameters.AddWithValue("@PageSize", pageSize);

            conn.Open();

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Items.Add(new Doctor
                {
                    DoctorId = reader.GetInt32(reader.GetOrdinal("DoctorId")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                    Email = reader.GetString(reader.GetOrdinal("Email")),
                    Address = reader.GetString(reader.GetOrdinal("Addr")),
                    County = reader.GetString(reader.GetOrdinal("County")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    Pay = reader.GetDecimal(reader.GetOrdinal("Pay")),
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


        internal void CreateDoctor(Doctor doctor)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC CreateDoctor @FirstName, @LastName, @Address, @County, @Dob, @Phone, @Email, @Gender, @Pay",
                new SqlParameter("@FirstName", doctor.FirstName),
                new SqlParameter("@LastName", doctor.LastName),
                new SqlParameter("@Address", doctor.Address),
                new SqlParameter("@County", doctor.County),
                new SqlParameter("@Dob", doctor.Dob),
                new SqlParameter("@Phone", doctor.Phone),
                new SqlParameter("@Email", doctor.Email),
                new SqlParameter("@Gender", doctor.Gender),
                new SqlParameter("@Pay", doctor.Pay)
            );
        }

        internal void DeleteDoctor(int value)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC DeleteDoctor @DoctorId",
                new SqlParameter("DoctorId", value));
        }

        internal void UpdateDoctor(Doctor doctor)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC UpdateDoctor @DoctorId, @FirstName, @LastName, @Address, @County, @Dob, @Phone, @Email, @Gender, @Pay",
                new SqlParameter("@DoctorId", doctor.DoctorId),
                new SqlParameter("@FirstName", doctor.FirstName),
                new SqlParameter("@LastName", doctor.LastName),
                new SqlParameter("@Address", doctor.Address),
                new SqlParameter("@County", doctor.County),
                new SqlParameter("@Dob", doctor.Dob),
                new SqlParameter("@Phone", doctor.Phone),
                new SqlParameter("@Email", doctor.Email),
                new SqlParameter("@Gender", doctor.Gender),
                new SqlParameter("@Pay", doctor.Pay)
            );
        }

        public List<Doctor> GetDoctorByFirstName(string firstName)
        {
            return context.Doctors
                .FromSqlRaw("EXEC GetDoctorByFirstName @firstName",
                new SqlParameter("@firstName", firstName))
                .AsNoTracking()
                .ToList();
        }
    }
}
