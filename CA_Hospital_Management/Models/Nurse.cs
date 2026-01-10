namespace CA_Hospital_Management.Models
{
    public class Nurse : Staff
    {
        public int NurseId
        {
            get => Id;
            set => Id = value;
        }

        public int Hours { get; set; }
    }
}
