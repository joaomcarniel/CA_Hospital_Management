using System.ComponentModel.DataAnnotations;

namespace CA_Hospital_Management.Models.Entities
{
    public class ConsultationDetails
    {
        [Key]
        public int ConsultDetailsId { get; set; }
        public int NurseId { get; set; }
        public int ConsultationId { get; set; }
        public int PatientId { get; set; }
        public DateTime ConsultationDate { get; set; }
        public string Reason { get; set; }
        public string Notes { get; set; }
    }
}
