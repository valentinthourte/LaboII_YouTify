namespace EjercicioIntegrador2_YouTify.Model
{
    public class Credentials
    {
        private string username;
        private string password;

        public string Username { get { return username; } }
        public string Password { get { return password; } }

        public Credentials(string text1, string text2)
        {
            username = text1;
            password = text2;
        }

        internal bool PasswordIsCorrect(string databasePassword)
        {
            return string.Equals(databasePassword, password);
        }
    }
}