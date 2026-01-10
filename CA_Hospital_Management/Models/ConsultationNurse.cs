namespace CA_Hospital_Management.Models
{
    public class ConsultationNurse
    {
        public int ConsultationNurseId { get; set; }
        public int ConsultationNurseIdentification { get; set; } //NurseId
        public int ConsultationId { get; set; }
        public int ConsultationNursePatientId { get; set; }
        public DateTime ConsultationNurseDate { get; set; }
        public string ConsultationNurseReason { get; set; }
        public string ConsultationNurseNotes { get; set; }
    }
}
