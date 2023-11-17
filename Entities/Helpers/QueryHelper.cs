using EjercicioIntegrador2_YouTify.Interfaces;
using EjercicioIntegrador2_YouTify.Model;
using Entities.DTOs;
using Entities.Model;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace EjercicioIntegrador2_YouTify.Helpers
{
    internal static class QueryHelper
    {
        const string DEFAULT_FIELDS = "*";
        const string PLAYLIST_SONG_RELATION_FIELDS = "PlaylistId, SongId";

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

        internal static string GetSongsForPlaylistQuery(string songsTableName, string relationTableName, Playlist playlist)
        {
            string joinClause = $"JOIN {songsTableName} on {relationTableName}.songId = {songsTableName}.id";
            string whereClause = $"WHERE {relationTableName}.playlistId = '{playlist.GetSqlId()}'";
            string fields = Song.SelectFields();
            return QueryHelper.GetSelectQueryForTableWithFilterWithJoinClause(relationTableName, whereClause, joinClause, fields);
        }

        internal static string GetSongsQuery(string tableName)
        {
            string joinClause = $"JOIN Songs on {tableName}.SongId = Songs.Id";
            return QueryHelper.GetSelectQueryForTableWithFilterWithJoinClause(tableName, joinClause);
        }
        internal static string GetAddSongsToPlaylistQuery(string tableName, Playlist selectedPlaylist, List<Song> songs)
        {
            List<string> values = songs.Select(song => $"({selectedPlaylist.GetSqlId()},{song.GetSqlId()})").ToList();

            return QueryHelper.InsertQuery(tableName, PLAYLIST_SONG_RELATION_FIELDS, string.Join(',', values));
        }
        internal static string InsertEntityQuery(string tableName, IEntity entity)
        {
            return QueryHelper.InsertQuery(tableName, entity.GetInsertFields(), $"({entity.GetInsertValues()})");
        }

        internal static string InsertQuery(string tableName, string fields, string values)
        {
            return $"insert into {tableName} ({fields}) values {values};";
        }

        private static string GetSelectQueryForTableWithFilterWithJoinClause(string tableName, string whereClause = "", string joinClause = "")
        {
            return QueryHelper.GetSelectQueryForTableWithFilterWithJoinClause(tableName, whereClause, joinClause, "*");
        }
        private static string GetSelectQueryForTableWithFilterWithJoinClause(string tableName, string whereClause, string joinClause, string fields = DEFAULT_FIELDS)
        {
            return $"select {fields} from {tableName} {joinClause} {whereClause}";
        }


    }
}