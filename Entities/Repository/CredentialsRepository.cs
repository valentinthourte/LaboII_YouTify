using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Exceptions;
using EjercicioIntegrador2_YouTify.Helpers;
using EjercicioIntegrador2_YouTify.Model;
using System.Data.SqlClient;

namespace EjercicioIntegrador2_YouTify.Repository
{
    internal class CredentialsRepository
    {
        public static async Task<User> CanLogin(Credentials credentials, EPlatform platform)
        {
            string tableName = $"{platform}Credentials";
            try
            {
                Credentials databaseCredentials = ((List<Credentials>)await DatabaseConnectionHelper.ExecuteSelectQuery<Credentials>(QueryHelper.GetCredentialsQuery(tableName, credentials))).FirstOrDefault();

                User user = credentials.CredentialsAreValid(databaseCredentials) ? new User(databaseCredentials) : null;
                
                return user;
            }
            catch (Exception ex)
            {
                throw new EDatabaseConnectionException($"Could not establish a connection to the database: {ex.Message}");
            }
        }
    }
}
