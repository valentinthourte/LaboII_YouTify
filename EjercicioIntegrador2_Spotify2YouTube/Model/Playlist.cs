using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador2_YouTify.Model
{
    internal class Playlist
    {
        private static string defaultIconFilePath;
        static Playlist()
        {
            Playlist.defaultIconFilePath = "noicon.png";
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string IconFilePath { get; set; }
        public string Owner { get ; set; }

        public string ImageName { get => this.Id; }
        
        internal string GetIconFileName(string directory)
        {
            return File.Exists(Path.Combine(directory, IconFilePath)) ? Path.Combine(directory, IconFilePath) : Path.Combine(directory, defaultIconFilePath);
        }

        public static implicit operator Playlist(PlaylistDTO dto)
        {
            Playlist p = new Playlist();
            p.Id = dto.Id;
            p.Name = dto.Name;
            p.Owner = dto.Owner;
            p.IconFilePath = dto.IconFilePath;
            return p;
        }


    }
}
