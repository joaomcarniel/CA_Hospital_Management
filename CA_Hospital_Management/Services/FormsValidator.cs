using Microsoft.Data.SqlClient;

namespace CA_Hospital_Management.Services
{
    public static class FormsValidator
    {
        public static bool ValidateForm(Dictionary<string, string> fields, Label message)
        {
            foreach (var field in fields)
            {
                if (string.IsNullOrEmpty(field.Value))
                {
                    message.Text = $"Field {field.Key} is required";
                    message.Visible = true;
                    message.ForeColor = Color.Red;
                    return false;
                }
            }
            return true;
        }
    }
}
