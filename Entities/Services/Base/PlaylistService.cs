using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Repository;
using Entities.DTOs;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Services.Base
{
    public abstract class PlaylistService
    {
        protected async Task<List<Playlist>> GetPlaylistsForUserAndPlatform(User user, EPlatform platform)
        {
            return await PlaylistRepository.GetPlaylists(user, platform);
        }

        protected async Task CreatePlaylist(Playlist playlist, EPlatform platform)
        {
            await PlaylistRepository.CreatePlaylist(playlist, platform);
        }

        public abstract Task<List<PlaylistDTO>> GetPlaylistsForUser(User user);
        public abstract void CreatePlaylist(PlaylistDTO playlist);

        public void AddSongsToPlaylist(PlaylistDTO selectedPlaylist, List<Song> songs, EPlatform platform)
        {
            PlaylistRepository.AddSongsToPlaylist(selectedPlaylist, songs, platform);
        }
        public abstract void AddSongsToPlaylist(PlaylistDTO selectedPlaylist, List<SongDTO> songs);
    }
}
