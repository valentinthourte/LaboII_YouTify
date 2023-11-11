using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Repository;

namespace EjercicioIntegrador2_YouTify.Services
{
    internal class PlaylistService
    {
        internal async static Task<List<Playlist>> GetPlaylists()
        {
            return await PlaylistRepository.GetPlaylists();
        }
    }
}