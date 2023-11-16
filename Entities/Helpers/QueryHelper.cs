using EjercicioIntegrador2_YouTify.Interfaces;
using EjercicioIntegrador2_YouTify.Model;
using Entities.Model;
using System.Net;

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

        internal static string InsertEntityQuery(string tableName, IEntity entity)
        {
            return $"insert into {tableName} ({entity.InsertFields()}) values ({entity.InsertValues()})";
        }

        private static string GetSelectQueryForTableWithFilterWithJoinClause(string tableName, string whereClause = "", string joinClause = "")
        {
            return $"select * from {tableName} {joinClause} {whereClause}";
        }
    }
}