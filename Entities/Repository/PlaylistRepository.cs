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

        internal static async Task AddSongsToPlaylist(Playlist selectedPlaylist, List<Song> songs, EPlatform platform)
        {
            List<Song> playlistSongs = await SongRepository.GetSongsForPlaylist(selectedPlaylist, platform);
            List<Song> songsToAdd = songs.Where(s => !playlistSongs.Contains(s)).ToList(); // I use contains because I override Equals method in Song class
            if (songsToAdd.Count > 0)
            {
                string tableName = $"{platform}PlaylistSong";
                string query = QueryHelper.GetAddSongsToPlaylistQuery(tableName, selectedPlaylist, songsToAdd);

                await DatabaseHelper.ExecuteInsertQuery(query);
            }
        }

        private static async Task TransferPlaylist(EPlatform basePlatform, EPlatform destinationPlatform, List<Song> songList, Playlist destinationPlaylist)
        {
            string query = QueryHelper.GetTransferableSongs(basePlatform, destinationPlatform, songList);
            List<Song> songs = await SongRepository.GetSongsByQuery(query);

            await PlaylistRepository.AddSongsToPlaylist(destinationPlaylist, songs, destinationPlatform);
        }

        internal static async Task ClonePlaylist(Playlist basePlaylist, Playlist destinationPlaylist, User destinationUser, EPlatform basePlatform, EPlatform destinationPlatform)
        {
            try
            {
                List<Song> basePlaylistSongs = await SongRepository.GetSongsForPlaylist(basePlaylist, basePlatform);

                await PlaylistRepository.TransferPlaylist(basePlatform, destinationPlatform, basePlaylistSongs, destinationPlaylist);
            }
            catch (Exception ex)
            {
                throw new Exception($"There was a problem cloning the playlist: {ex.Message}");
            }
        }
    }
}
