using CA_Hospital_Management.Data;
using CA_Hospital_Management.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CA_Hospital_Management.Repositories
{
    public class LoginRepository
    {
        public Login? ValidateLogin(string username, string password)
        {
            using var context = new HospitalDbContext();

            return context.Logins
                .FromSqlRaw(
                    "EXEC ValidateLogin @Username, @Password",
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", password)
                )
                .AsNoTracking()
                .AsEnumerable()
                .FirstOrDefault();
        }
    }
}
