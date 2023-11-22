using EjercicioIntegrador2_YouTify.Helpers;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entities.Services.Base
{
    public static class SerializeService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="songs"></param>
        /// <param name="destination"></param>
        public static void ToJson(List<SongDTO> songs, string destination)
        {
            string json = JsonSerializer.Serialize(songs);
            FileHelper.WriteToFile(json, destination);
        }

    }
}
