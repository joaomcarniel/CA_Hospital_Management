using CA_Hospital_Management.Data;
using CA_Hospital_Management.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CA_Hospital_Management.Repositories
{
    public class DoctorRepository
    {
        HospitalDbContext context;
        public DoctorRepository()
        {
            context = new HospitalDbContext();
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
    }
}
