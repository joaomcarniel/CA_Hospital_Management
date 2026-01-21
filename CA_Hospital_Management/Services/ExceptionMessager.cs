namespace CA_Hospital_Management.Services
{
    public static class ExceptionMessager
    {
        public static void BuildExceptionMessage(Label lblMessage, string errorMessage)
        {
            lblMessage.Text = $"Error: {errorMessage}";
            lblMessage.ForeColor = Color.Red;
            lblMessage.Visible = true;
        }
    }
}
