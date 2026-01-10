namespace CA_Hospital_Management.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string County { get; set; }
        public DateTime Dob { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - Dob.Year;
                if (Dob.Date > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}
