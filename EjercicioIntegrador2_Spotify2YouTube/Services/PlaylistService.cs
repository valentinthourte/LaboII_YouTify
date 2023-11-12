using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Repository;

namespace EjercicioIntegrador2_YouTify.Services
{
    internal class PlaylistService
    {
        internal async static Task<List<Playlist>> GetPlaylists(string owner)
        {
            return await PlaylistRepository.GetPlaylists(owner);
        }

        internal async static Task<List<Playlist>> GetPlaylistsForUser(User user)
        {
            return await PlaylistService.GetPlaylists(user.Name);
        }

    }
}