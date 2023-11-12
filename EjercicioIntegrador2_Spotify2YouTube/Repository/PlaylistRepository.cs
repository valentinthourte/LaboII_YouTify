using EjercicioIntegrador2_YouTify.Helpers;
using EjercicioIntegrador2_YouTify.Model;
using System.Data.SqlClient;

namespace EjercicioIntegrador2_YouTify.Repository
{
    internal class PlaylistRepository
    {
        internal async static Task<List<Playlist>> GetPlaylists(string owner)
        {
            string tableName = $"playlists";
            string query = QueryHelper.GetPlaylistsQuery(owner);
            List<Playlist> returnList = new List<Playlist>();

            return (List<Playlist>)await DatabaseConnectionHelper.ExecuteSelectQuery<Playlist>(query);
        }
    }
}