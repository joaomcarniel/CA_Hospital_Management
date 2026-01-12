namespace CA_Hospital_Management.Models
{
    public class ConsultationDto
    {
        public int ConsultationId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public int? ConsultationPatientId { get; set; }
        public int? ConsultationDoctorId { get; set; }
        public DateTime ConsultationDate { get; set; }
        public string ConsultationReason { get; set; }
        public string ConsultationDiagnosis { get; set; }
        public string ConsultationNotes { get; set; }
    }
}
