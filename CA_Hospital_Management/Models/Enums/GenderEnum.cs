using System.ComponentModel;

namespace CA_Hospital_Management.Models.Enums
{
    public enum GenderEnum
    {
        Female,
        Male,
        [Description("Prefer Not to Say")]
        PreferNotToSay,
        Other

    }
}
