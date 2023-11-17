using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Repository;
using Entities.DTOs;
using Entities.Model;

namespace EjercicioIntegrador2_YouTify.Services.Base
{
    public abstract class SongService
    {
        protected async Task<List<Song>> GetSongs(EPlatform platform)
        {
            var songs = await SongRepository.GetSongs(platform);
            return songs;
        }
        protected async Task<List<Song>> GetPlaylistSongs(Playlist playlist, EPlatform platform)
        {
            return await SongRepository.GetSongsForPlaylist(playlist, platform);
        }
        public abstract Task<List<SongDTO>> GetSongs();
        public abstract Task<List<SongDTO>> GetPlaylistSongs(PlaylistDTO playlist);
    }
}