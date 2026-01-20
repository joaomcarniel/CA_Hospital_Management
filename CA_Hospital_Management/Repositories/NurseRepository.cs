
using CA_Hospital_Management.Data;
using CA_Hospital_Management.Models.DTOs;
using CA_Hospital_Management.Models.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CA_Hospital_Management.Repositories
{
    public class NurseRepository
    {
        HospitalDbContext context;

        public NurseRepository()
        {
            context = new HospitalDbContext();
        }

        public void CreateNurse(Nurse nurse)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC CreateNurse @FirstName, @LastName, @Address, @County, @Dob, @Phone, @Email, @Gender, @HoursWorked",
                new SqlParameter("@FirstName", nurse.FirstName),
                new SqlParameter("@LastName", nurse.LastName),
                new SqlParameter("@Address", nurse.Address),
                new SqlParameter("@County", nurse.County),
                new SqlParameter("@Dob", nurse.Dob),
                new SqlParameter("@Phone", nurse.Phone),
                new SqlParameter("@Email", nurse.Email),
                new SqlParameter("@Gender", nurse.Gender),
                new SqlParameter("@HoursWorked", nurse.HoursWorked)
            );
        }

        public void DeleteNurse(int value)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC DeleteNurse @NurseId",
                new SqlParameter("NurseId", value));
        }

        public ListPaginated<Nurse> SearchNursesPaged(string firstName, int pageNumber, int pageSize)
        {
            var result = new ListPaginated<Nurse>();

            using var conn = new SqlConnection(context.Database.GetConnectionString());
            using var cmd = new SqlCommand("GetNursesPaged", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName",
                string.IsNullOrWhiteSpace(firstName) ? DBNull.Value : firstName);
            cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
            cmd.Parameters.AddWithValue("@PageSize", pageSize);

            conn.Open();

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Items.Add(new Nurse
                {
                    NurseId = reader.GetInt32(reader.GetOrdinal("NurseId")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                    Email = reader.GetString(reader.GetOrdinal("Email")),
                    Address = reader.GetString(reader.GetOrdinal("Addr")),
                    County = reader.GetString(reader.GetOrdinal("County")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    HoursWorked = reader.GetInt32(reader.GetOrdinal("HoursWorked")),
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

        public ListPaginated<Nurse> SearchMaleNursesPaged(string firstName, int pageNumber, int pageSize)
        {
            var result = new ListPaginated<Nurse>();

            using var conn = new SqlConnection(context.Database.GetConnectionString());
            using var cmd = new SqlCommand("[GetMaleNurses]", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
            cmd.Parameters.AddWithValue("@PageSize", pageSize);

            conn.Open();

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Items.Add(new Nurse
                {
                    NurseId = reader.GetInt32(reader.GetOrdinal("NurseId")),
                    FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                    LastName = reader.GetString(reader.GetOrdinal("LastName")),
                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                    Email = reader.GetString(reader.GetOrdinal("Email")),
                    Address = reader.GetString(reader.GetOrdinal("Addr")),
                    County = reader.GetString(reader.GetOrdinal("County")),
                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                    HoursWorked = reader.GetInt32(reader.GetOrdinal("HoursWorked")),
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

        public void UpdateNurse(Nurse nurse)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC UpdateNurse @NurseId, @FirstName, @LastName, @Address, @County, @Dob, @Phone, @Email, @Gender, @HoursWorked",
                new SqlParameter("@NurseId", nurse.NurseId),
                new SqlParameter("@FirstName", nurse.FirstName),
                new SqlParameter("@LastName", nurse.LastName),
                new SqlParameter("@Address", nurse.Address),
                new SqlParameter("@County", nurse.County),
                new SqlParameter("@Dob", nurse.Dob),
                new SqlParameter("@Phone", nurse.Phone),
                new SqlParameter("@Email", nurse.Email),
                new SqlParameter("@Gender", nurse.Gender),
                new SqlParameter("@HoursWorked", nurse.HoursWorked)
            );
        }
    }
}
