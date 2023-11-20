using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Helpers;
using EjercicioIntegrador2_YouTify.Model;
using Entities.DTOs;
using Entities.Model;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace EjercicioIntegrador2_YouTify.Repository
{
    internal class PlaylistRepository
    {
        private async static Task<List<Playlist>> GetPlaylists(string owner, string platform)
        {
            string tableName = $"{platform}Playlists";
            string query = QueryHelper.GetPlaylistsQuery(owner, tableName);
            List<Playlist> returnList = new List<Playlist>();

            return (List<Playlist>)await DatabaseHelper.ExecuteSelectQuery<Playlist>(query);
        }
        internal async static Task<List<Playlist>> GetPlaylists(string owner, EPlatform platform)
        {
            return await GetPlaylists(owner, platform.ToString());
        }

        internal static async Task<List<Playlist>> GetPlaylists(User user, EPlatform platform)
        {
            return await GetPlaylists(user.Name, platform);
        }

        internal async static Task CreatePlaylist(Playlist playlist, EPlatform platform)
        {
            string tableName = $"{platform}Playlists";
            string query = QueryHelper.InsertEntityQuery(tableName, playlist);

            await DatabaseHelper.ExecuteInsertQuery(query);
            
        }

        internal static void AddSongsToPlaylist(Playlist selectedPlaylist, List<Song> songs, EPlatform platform)
        {
            string tableName = $"{platform}PlaylistSong";
            string query = QueryHelper.GetAddSongsToPlaylistQuery(tableName, selectedPlaylist, songs);

            DatabaseHelper.ExecuteInsertQuery(query);

        }

        internal static async Task ClonePlaylist(Playlist playlist, User destinationUser, EPlatform basePlatform, EPlatform destinationPlatform)
        {
            try
            {
                await PlaylistRepository.CreatePlaylist(playlist, destinationPlatform);

                Playlist createdPlaylist = (await PlaylistRepository.GetPlaylists(destinationUser, destinationPlatform)).Where(p => p.NameMatches(playlist)).First();
                List<Song> transferableSongs = await SongRepository.GetSongsAvailableForTransfer(playlist, basePlatform);

            }
            catch (Exception ex)
            {
                throw new Exception($"There was a problem cloning the playlist: {ex.Message}");
            }


        }
    }
}
