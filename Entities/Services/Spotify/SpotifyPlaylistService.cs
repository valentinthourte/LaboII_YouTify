using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Interfaces;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Repository;
using EjercicioIntegrador2_YouTify.Services.Base;
using Entities.DTOs;
using Entities.Model;
using Entities.Services.Base;

namespace EjercicioIntegrador2_YouTify.Services.Spotify
{
    public class SpotifyPlaylistService : PlaylistService
    {
        public override void AddSongsToPlaylist(PlaylistDTO selectedPlaylist, List<SongDTO> songs)
        {
            base.AddSongsToPlaylist(selectedPlaylist, songs.Select(s => (Song)s).ToList(), EPlatform.Spotify);
        }

        public override void CreatePlaylist(PlaylistDTO playlist)
        {
            base.CreatePlaylist(playlist, EPlatform.Spotify);
        }

        public override async Task<List<PlaylistDTO>> GetPlaylistsForUser(User user)
        {
            return (await GetPlaylistsForUserAndPlatform(user, EPlatform.Spotify)).Select(p => (PlaylistDTO)p).ToList();
        }
    }
}