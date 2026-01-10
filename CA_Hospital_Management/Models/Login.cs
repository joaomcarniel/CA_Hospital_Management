namespace CA_Hospital_Management.Models
{
    public class Login
    {
        public int LoginId { get; set; }
        public string LoginUserName { get; set; }
        public string LoginPassword { get; set; }
        public string LoginRole { get; set; } // Admin / User
        public DateTime LoginCreateDate { get; set; }
        public bool LoginIsActive { get; set; }
    }
}
