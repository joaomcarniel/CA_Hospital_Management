
using CA_Hospital_Management.Data;
using CA_Hospital_Management.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CA_Hospital_Management.Repositories
{
    internal class AdminRepository
    {
        HospitalDbContext context;

        public AdminRepository()
        {
            context = new HospitalDbContext();
        }

        internal ListPaginated<Login> SearchLoginsPaged(int pageNumber, int pageSize)
        {
            var result = new ListPaginated<Login>();

            using var conn = new SqlConnection(context.Database.GetConnectionString());
            using var cmd = new SqlCommand("GetLoginsPaged", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PageNumber", pageNumber);
            cmd.Parameters.AddWithValue("@PageSize", pageSize);

            conn.Open();

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                result.Items.Add(new Login
                {
                    LoginId = reader.GetInt32(reader.GetOrdinal("LoginId")),
                    LoginUserName = reader.GetString(reader.GetOrdinal("LoginUserName")),
                    LoginIsActive = reader.GetInt32(reader.GetOrdinal("LoginIsActive")),
                    LoginRole = reader.GetString(reader.GetOrdinal("LoginRole")),
                    LoginCreateDate = reader.GetDateTime(reader.GetOrdinal("LoginCreateDate"))
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

        internal void CreateLogin(Login login)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC CreateLogin @LoginUserName, @LoginPassword, @LoginRole, @LoginIsActive",
                new SqlParameter("@LoginUserName", login.LoginUserName),
                new SqlParameter("@LoginPassword", login.LoginPassword),
                new SqlParameter("@LoginIsActive", login.LoginIsActive),
                new SqlParameter("@LoginRole", login.LoginRole)
            );
        }

        internal void DeleteLogin(int value)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC DeleteLogin @loginId",
                new SqlParameter("@loginId", value));
        }

        internal void UpdateLogin(Login login)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC UpdateLogin @LoginId, @LoginUserName, @LoginRole, @LoginIsActive",
                new SqlParameter("@LoginId", login.LoginId),
                new SqlParameter("@LoginUserName", login.LoginUserName),
                new SqlParameter("@LoginIsActive", login.LoginIsActive),
                new SqlParameter("@LoginRole", login.LoginRole)
            );
        }
        internal void UpdatePasswordLogin(Login login)
        {
            context.Database.ExecuteSqlRaw(
                "EXEC UpdateLoginPassword @LoginId, @LoginUserName, @LoginPassword, @LoginRole, @LoginIsActive",
                new SqlParameter("@LoginId", login.LoginId),
                new SqlParameter("@LoginUserName", login.LoginUserName),
                new SqlParameter("@LoginPassword", login.LoginPassword),
                new SqlParameter("@LoginIsActive", login.LoginIsActive),
                new SqlParameter("@LoginRole", login.LoginRole)
            );
        }
    }
}
