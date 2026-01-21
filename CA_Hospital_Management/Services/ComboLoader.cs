using CA_Hospital_Management.Models.Enums;

namespace CA_Hospital_Management.Services
{
    public static class ComboLoader
    {
        public static void LoadCountyCombo(ComboBox cmbCounty)
        {
            cmbCounty.DataSource = Enum.GetValues(typeof(CountiesEnum));
            cmbCounty.SelectedIndex = -1;
        }

        public static void LoadGenderCombo(ComboBox cmbGender)
        {
            cmbGender.DataSource = Enum.GetValues(typeof(GenderEnum));
            cmbGender.SelectedIndex = -1;
        }

        public static void LoadContractCombo(ComboBox cmbContract)
        {
            cmbContract.DataSource = Enum.GetValues(typeof(ContractsEnum));
            cmbContract.SelectedIndex = -1;
        }

        private static readonly string[] activeItems = new string[]
            {
                "Yes", "No"
            };
        private static readonly string[] RoleItems = new string[]
            {
                "Admin", "User"
            };

        public static void LoadActiveCombo(ComboBox cmbActive)
        {
            cmbActive.Items.Clear();
            cmbActive.Items.AddRange(activeItems);
            cmbActive.SelectedIndex = 0;
        }

        public static void LoadRoleCombo(ComboBox cmbRole)
        {
            cmbRole.Items.Clear();
            cmbRole.Items.AddRange(RoleItems);
            cmbRole.SelectedIndex = -1;
        }
    }
}
