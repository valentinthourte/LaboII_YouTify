using EjercicioIntegrador2_YouTify.Interfaces;
using System.CodeDom;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace EjercicioIntegrador2_YouTify.Model
{
    public class Credentials: IEntity
    {
        private string username = "";
        private string password = "";

        public string Username { get { return username; } }
        public string Password { get { return password; } }

        public Credentials()
        {

        }
        public Credentials(string text1, string text2)
        {
            username = text1;
            password = text2;
        }

        internal bool CredentialsAreValid(Credentials credentials)
        {
            return credentials is not null && credentials == this;
        }

        public void MapFromDatabase(SqlDataReader dataReader)
        {
            this.username = dataReader["username"].ToString();
            this.password = dataReader["password"].ToString();
        }

        public static bool operator ==(Credentials credentials1, Credentials credentials2)
        {
            return credentials1 is not null && credentials2 is not null && string.Equals(credentials1.Username, credentials2.Username) && string.Equals(credentials1.Password, credentials2.Password);
        }

        public static bool operator !=(Credentials credentials1, Credentials credentials2)
        {
            return !(credentials1 == credentials2);
        }

    }
}