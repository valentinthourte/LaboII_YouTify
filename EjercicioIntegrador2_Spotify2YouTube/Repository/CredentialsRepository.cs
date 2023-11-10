using EjercicioIntegrador2_Spotify2YouTube;
using EjercicioIntegrador2_YouTify.Exceptions;
using System.Data.SqlClient;

namespace EjercicioIntegrador2_YouTify.Repository
{
    internal class CredentialsRepository
    {
        public static async Task<bool> CanLogin(Credentials credentials, EPlatform platform)
        {
            string tableName = $"{platform}Credentials";
            bool canLogin = false;
            try
            {
                using (SqlConnection sql = new SqlConnection(DatabaseConnectionHelper.GetConnectionString()))
                {
                    try
                    {
                        await sql.OpenAsync();
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = sql;
                            command.CommandType = System.Data.CommandType.Text;
                            command.CommandText = QueryHelper.GetCredentialsQuery(tableName, credentials);
                            SqlDataReader dataReader = await command.ExecuteReaderAsync();
                            string databasePassword = String.Empty;
                            if (dataReader.Read())
                            {
                                databasePassword = dataReader["password"].ToString() ?? String.Empty;
                            }
                            canLogin = !string.IsNullOrEmpty(databasePassword) && credentials.PasswordIsCorrect(databasePassword);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    return canLogin;
                }
            }
            catch (Exception ex)
            {
                throw new EDatabaseConnectionException($"Could not establish a connection to the database: {ex.Message}");
            }
        }
    }
}
