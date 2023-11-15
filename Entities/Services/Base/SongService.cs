using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Repository;
using Entities.Model;

namespace EjercicioIntegrador2_YouTify.Services.Base
{
    public abstract class SongService
    {
        protected Task<SongList> GetSongs(EPlatform platform)
        {
            return SongRepository.GetSongs(platform);
        }
        public abstract Task<SongList> GetSongs();
    }
}