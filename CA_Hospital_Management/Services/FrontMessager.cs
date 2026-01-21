using CA_Hospital_Management.Models.Entities;

namespace CA_Hospital_Management.Services
{
    public static class FrontMessager
    {
        public static void BuildExceptionMessage(Label lblMessage, string errorMessage)
        {
            lblMessage.Text = $"Error: {errorMessage}";
            lblMessage.ForeColor = Color.Red;
            lblMessage.Visible = true;
        }

        public static void BuildSuccessMessage(Label lblMessage, string entity, string action)
        {
            lblMessage.Text = $"{entity} {action} successfully.";
            lblMessage.ForeColor = Color.Green;
            lblMessage.Visible = true;
        }
    }
}
