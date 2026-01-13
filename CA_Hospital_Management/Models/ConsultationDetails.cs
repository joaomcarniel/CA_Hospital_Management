namespace CA_Hospital_Management.Models
{
    public class ConsultationDetails
    {
        public int ConsultDetailsId { get; set; }
        public int NurseId { get; set; } //NurseId
        public int ConsultationId { get; set; }
        public int PatientId { get; set; }
        public DateTime ConsultationDate { get; set; }
        public string Reason { get; set; }
        public string Notes { get; set; }
    }
}
