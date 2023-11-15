using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Helpers;
using EjercicioIntegrador2_YouTify.Model;
using Entities.Model;
using System.Data.SqlClient;

namespace EjercicioIntegrador2_YouTify.Repository
{
    internal class PlaylistRepository
    {
        private async static Task<List<Playlist>> GetPlaylists(string owner, string platform)
        {
            string tableName = $"{platform}Playlists";
            string query = QueryHelper.GetPlaylistsQuery(owner, tableName);
            List<Playlist> returnList = new List<Playlist>();

            return (List<Playlist>)await DatabaseConnectionHelper.ExecuteSelectQuery<Playlist>(query);
        }
        internal async static Task<List<Playlist>> GetPlaylists(string owner, EPlatform platform)
        {
            return await GetPlaylists(owner, platform.ToString());
        }

        internal static async Task<List<Playlist>> GetPlaylists(User user, EPlatform platform)
        {
            return await GetPlaylists(user.Name, platform);
        }
    }
}
