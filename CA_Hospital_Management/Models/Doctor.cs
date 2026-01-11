namespace CA_Hospital_Management.Models
{
    public class Doctor : Staff
    {
        public int DoctorId { get; set; }

        public decimal Pay { get; set; }
    }
}
