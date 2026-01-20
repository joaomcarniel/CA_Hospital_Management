using System.ComponentModel.DataAnnotations;

namespace CA_Hospital_Management.Models.Entities
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }

        public string LoginUserName { get; set; } = string.Empty;
        public string LoginPassword { get; set; } = string.Empty;
        public string LoginRole { get; set; } = string.Empty;
        public DateTime LoginCreateDate { get; set; }
        public int LoginIsActive { get; set; }
    }
}
