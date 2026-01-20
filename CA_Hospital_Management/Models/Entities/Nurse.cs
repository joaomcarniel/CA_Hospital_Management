namespace CA_Hospital_Management.Models.Entities
{
    public class Nurse : Staff
    {
        public int NurseId { get; set; }

        public int HoursWorked { get; set; }
    }
}
