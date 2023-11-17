using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador2_YouTify.Model
{
    public class Playlist
    {
        private static string defaultIconFilePath; 
        private string Id { get; set; }
        public string Name { get; set; }
        private string IconFilePath { get; set; }
        private string Owner { get; set; }
        public string ImageName { get => this.Id ?? "0"; }


        static Playlist()
        {
            Playlist.defaultIconFilePath = "noicon.png";
        }

        public Playlist()
        {

        }

        public Playlist(string name, string owner, string iconFilePath = "")
        {
            Name = name;
            IconFilePath = iconFilePath;
            Owner = owner;
        }

        internal string GetIconFileName(string directory)
        {
            return !string.IsNullOrEmpty(IconFilePath) && File.Exists(Path.Combine(directory, IconFilePath)) ? Path.Combine(directory, IconFilePath) : Path.Combine(directory, defaultIconFilePath);
        }

        internal void GetPlaylistInformation(out string playlistName, out string playlistOwner)
        {
            playlistName = this.Name;
            playlistOwner = this.Owner;
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

        public static implicit operator PlaylistDTO(Playlist playlist)
        {
            PlaylistDTO dto = new PlaylistDTO();
            dto.Id = playlist.Id;
            dto.Name = playlist.Name;
            dto.Owner = playlist.Owner;
            dto.IconFilePath = playlist.IconFilePath;
            return dto;
        }
    }
}
