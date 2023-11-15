using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Services.Base;
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
        public override Task<SongList> GetSongs()
        {
            return base.GetSongs(EPlatform.Youtube);
        }
    }
}
