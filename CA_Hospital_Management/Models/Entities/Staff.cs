using CA_Hospital_Management.Models.Enums;

namespace CA_Hospital_Management.Models.Entities
{
    public abstract class Staff : Person
    {
        public string? Department { get; set;  }
        public string? ContractType { get; set; }
    }
}
