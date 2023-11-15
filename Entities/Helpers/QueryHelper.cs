using EjercicioIntegrador2_YouTify.Model;

namespace EjercicioIntegrador2_YouTify.Helpers
{
    internal static class QueryHelper
    {
        internal static string GetCredentialsQuery(string tableName, Credentials credentials)
        {
            string whereClause = $"where username = '{credentials.Username}'";
            return QueryHelper.GetSelectQueryForTableWithFilterWithJoinClause(tableName, whereClause);
        }

        internal static string GetPlaylistsQuery(string owner, string tableName)
        {
            string whereClause = $"where owner = '{owner}'";
            return QueryHelper.GetSelectQueryForTableWithFilterWithJoinClause(tableName, whereClause);
        }

        internal static string GetSongsQuery(string tableName)
        {
            string joinClause = $"JOIN Songs on {tableName}.SongId = Songs.Id";
            return QueryHelper.GetSelectQueryForTableWithFilterWithJoinClause(tableName, joinClause);
        }

        private static string GetSelectQueryForTableWithFilterWithJoinClause(string tableName, string whereClause = "", string joinClause = "")
        {
            return $"select * from {tableName} {joinClause} {whereClause}";
        }
    }
}