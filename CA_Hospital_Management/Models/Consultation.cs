namespace CA_Hospital_Management.Models
{
    public class Consultation
    {
        public int ConsultationId { get; set; }
        public int ConsultationPatientId { get; set; }
        public int ConsultationDoctorId { get; set; }
        public DateTime ConsultationDate { get; set; }
        public string ConsultationReason { get; set; }
        public string ConsultationDiagnosis { get; set; }
        public string ConsultationNotes { get; set; }
    }
}
