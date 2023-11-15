using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Interfaces;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Repository;
using EjercicioIntegrador2_YouTify.Services.Base;
using Entities.DTOs;
using Entities.Model;

namespace EjercicioIntegrador2_YouTify.Services.Youtube
{
    public class YoutubePlaylistService : PlaylistService
    {
        public override async Task<List<PlaylistDTO>> GetPlaylistsForUser(User user)
        {
            return (await GetPlaylistsForUserAndPlatform(user, EPlatform.Youtube)).Select(p => (PlaylistDTO)p).ToList();
        }
    }
}