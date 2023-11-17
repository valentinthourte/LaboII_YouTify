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

namespace EjercicioIntegrador2_YouTify.Services.Youtube
{
    public class YoutubeSongService : SongService
    {
        public async override Task<List<SongDTO>> GetPlaylistSongs(PlaylistDTO playlist)
        {
            return (await base.GetPlaylistSongs(playlist, EPlatform.Youtube)).Select(song => (SongDTO)song).ToList();
        }

        public async override Task<List<SongDTO>> GetSongs()
        {
            return (await base.GetSongs(EPlatform.Youtube)).Select(song => (SongDTO)song).ToList();
        }
    }
}
