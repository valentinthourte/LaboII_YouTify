using EjercicioIntegrador2_YouTify.Model;

namespace EjercicioIntegrador2_YouTify.Helpers
{
    internal static class QueryHelper
    {
        internal static string GetCredentialsQuery(string tableName, Credentials credentials)
        {
            return $"SELECT username,password from {tableName} where username = '{credentials.Username}'";
        }

        internal static string GetPlaylistsQuery()
        {
            return $"select * from playlists";
        }
    }
}