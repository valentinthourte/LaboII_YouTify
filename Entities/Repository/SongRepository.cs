using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Helpers;
using EjercicioIntegrador2_YouTify.Model;
using Entities.Model;

namespace EjercicioIntegrador2_YouTify.Repository
{
    internal class SongRepository
    {
        internal static async Task<List<Song>> GetSongs(EPlatform platform)
        {
            string tableName = $"{platform}Songs";
            string query = QueryHelper.GetSongsQuery(tableName);

            var songs = (List<Song>)await DatabaseConnectionHelper.ExecuteSelectQuery<Song>(query);
            return songs;
        }

        internal static async Task<List<Song>> GetSongsForPlaylist(Playlist playlist, EPlatform platform)
        {
            string songsTableName = $"Songs";
            string relationTableName = $"{platform}PlaylistSong";
            
            string query = QueryHelper.GetSongsForPlaylistQuery(songsTableName, relationTableName, playlist);

            var songs = (List<Song>)await DatabaseConnectionHelper.ExecuteSelectQuery<Song>(query);
            return songs;
        }
    }
}