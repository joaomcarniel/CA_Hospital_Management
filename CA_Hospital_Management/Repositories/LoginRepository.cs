using CA_Hospital_Management.Data;
using CA_Hospital_Management.Models.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CA_Hospital_Management.Repositories
{
    public class LoginRepository
    {
        public Login? ValidateLogin(string username)
        {
            using var context = new HospitalDbContext();

            return context.Logins
                .FromSqlRaw(
                    "EXEC ValidateLogin @Username",
                    new SqlParameter("@Username", username)
                )
                .AsNoTracking()
                .AsEnumerable()
                .FirstOrDefault();
        }
    }
}
