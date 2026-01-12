namespace CA_Hospital_Management.Models
{
    public class DoctorPagedRow
    {
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string County { get; set; }
        public string Gender { get; set; }
        public decimal Pay { get; set; }
        public DateTime Dob { get; set; }

        public int TotalRecords { get; set; }
    }
}
