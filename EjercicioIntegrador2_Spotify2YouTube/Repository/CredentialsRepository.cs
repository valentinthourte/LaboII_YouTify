using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Exceptions;
using EjercicioIntegrador2_YouTify.Helpers;
using EjercicioIntegrador2_YouTify.Model;
using System.Data.SqlClient;

namespace EjercicioIntegrador2_YouTify.Repository
{
    internal class CredentialsRepository
    {
        public static async Task<bool> CanLogin(Credentials credentials, EPlatform platform)
        {
            string tableName = $"{platform}Credentials";
            try
            {
                SqlDataReader dataReader = await DatabaseConnectionHelper.ExecuteSelectQuery(QueryHelper.GetCredentialsQuery(tableName, credentials));
                string databasePassword = String.Empty;
                if (dataReader.Read())
                {
                    databasePassword = dataReader["password"].ToString() ?? String.Empty;
                }
                return !string.IsNullOrEmpty(databasePassword) && credentials.PasswordIsCorrect(databasePassword);
            }
            catch (Exception ex)
            {
                throw new EDatabaseConnectionException($"Could not establish a connection to the database: {ex.Message}");
            }
        }
    }
}
