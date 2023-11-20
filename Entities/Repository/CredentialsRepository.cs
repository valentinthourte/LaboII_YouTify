using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Exceptions;
using EjercicioIntegrador2_YouTify.Helpers;
using EjercicioIntegrador2_YouTify.Model;
using Entities.Model;
using System.Data.SqlClient;
using System.Net;
using System.Runtime.CompilerServices;

namespace EjercicioIntegrador2_YouTify.Repository
{
    internal class CredentialsRepository
    {
        public static async Task<User> CanLogin(Credentials credentials, EPlatform platform)
        {
            try
            {
                Credentials databaseCredentials = await CredentialsRepository.GetCredentialsFromDatabase(credentials, platform);

                User user = credentials.CredentialsAreValid(databaseCredentials) ? new User(databaseCredentials) : null;
                
                return user;
            }
            catch (Exception ex)
            {
                throw new EDatabaseConnectionException($"Could not establish a connection to the database: {ex.Message}");
            }
        }

        private static async Task<Credentials> GetCredentialsFromDatabase(Credentials c, EPlatform platform)
        {
            string tableName = $"{platform}Credentials";
            return ((List<Credentials>)await DatabaseHelper.ExecuteSelectQuery<Credentials>(QueryHelper.GetCredentialsQuery(tableName, c))).FirstOrDefault();
        }

        internal static async Task<User> SignUp(Credentials credentials, EPlatform platform)
        {
            string tableName = $"{platform}Credentials";
            try
            {
                string query = QueryHelper.InsertCredentialsQuery(tableName, credentials);
                await DatabaseHelper.ExecuteInsertQuery(query);

                return new User(await CredentialsRepository.GetCredentialsFromDatabase(credentials, platform));
            }
            catch (SqlException e)
            {
                return null;
            }
            catch (Exception e)
            {
                throw new Exception($"A problem has occurred creating credentials in the database: {e.GetType()}: {e.Message}");
            }
        }
    }
}
