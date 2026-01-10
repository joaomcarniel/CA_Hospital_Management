namespace CA_Hospital_Management.Models
{
    public class Patient : Person
    {
        public int PatientId
        {
            get => Id;
            set => Id = value;
        }
    }
}
