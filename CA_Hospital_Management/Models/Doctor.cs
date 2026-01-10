namespace CA_Hospital_Management.Models
{
    public class Doctor : Staff
    {
        public int DoctorId
        {
            get => Id;
            set => Id = value;
        }

        public decimal Pay { get; set; }
    }
}
