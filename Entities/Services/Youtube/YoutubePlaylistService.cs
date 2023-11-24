using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Interfaces;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Repository;
using EjercicioIntegrador2_YouTify.Services.Base;
using Entities.DTOs;
using Entities.Model;
using Entities.Services.Base;

namespace EjercicioIntegrador2_YouTify.Services.Youtube
{
    public class YoutubePlaylistService : PlaylistService
    {
        public override void AddSongsToPlaylist(PlaylistDTO selectedPlaylist, List<SongDTO> songs)
        {
            base.AddSongsToPlaylist(selectedPlaylist, songs.Select(s => (Song)s).ToList(), EPlatform.Youtube);
        }

        public override void ClonePlaylist(PlaylistDTO basePlaylist, PlaylistDTO destinationPlaylist, User destinationUser)
        {
            base.ClonePlaylist(basePlaylist, destinationPlaylist, destinationUser, EPlatform.Youtube, EPlatform.Spotify);
        }

        public async override Task CreatePlaylist(PlaylistDTO playlist)
        {
            await base.CreatePlaylist(playlist, EPlatform.Youtube);
        }

        public override async Task<List<PlaylistDTO>> GetPlaylistsForUser(User user)
        {
            return (await GetPlaylistsForUserAndPlatform(user, EPlatform.Youtube)).Select(p => (PlaylistDTO)p).ToList();
        }
    }
}