using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Services.Base;
using Entities.DTOs;
using Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador2_YouTify.Services.Spotify
{
    public class SpotifySongService : SongService
    {
        public async override Task<List<SongDTO>> GetSongs()
        {
            return (await base.GetSongs(EPlatform.Spotify)).Select(song => (SongDTO)song).ToList();
        }
    }
}
