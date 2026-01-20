using System.ComponentModel.DataAnnotations;

namespace CA_Hospital_Management.Models.DTOs
{
    public class ConsultationDetailsDto
    {
        [Key]
        public int ConsultDetailsId { get; set; }
        public int NurseId { get; set; }
        public int ConsultationId { get; set; }
        public int PatientId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string NurseFirstName { get; set; }
        public string NurseLastName { get; set; }
        public DateTime ConsultationDate { get; set; }
        public string Reason { get; set; }
        public string Notes { get; set; }
    }
}
