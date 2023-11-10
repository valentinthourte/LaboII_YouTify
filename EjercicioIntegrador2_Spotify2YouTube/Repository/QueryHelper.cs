namespace EjercicioIntegrador2_YouTify.Repository
{
    internal static class QueryHelper
    {
        internal static string GetCredentialsQuery(string tableName, Credentials credentials)
        {
            return $"SELECT username,password from {tableName} where username = '{credentials.Username}'";
        }
    }
}