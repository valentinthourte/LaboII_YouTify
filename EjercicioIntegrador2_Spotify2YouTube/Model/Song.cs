using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador2_YouTify.Model
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ArtistName { get; set;}
        public DateTime CreationDate { get; set;}

        public static explicit operator Song(SongDTO s)
        {
            Song song = new Song();
            song.Id = s.Id;
            song.Name = s.Name;
            song.ArtistName = s.Artist;
            song.CreationDate = s.CreationDate;
            return song;
        }
        public static implicit operator SongDTO(Song s)
        {
            SongDTO dto = new SongDTO();
            dto.Id = s.Id;
            dto.Name = s.Name;
            dto.Artist = s.ArtistName;
            dto.CreationDate = s.CreationDate;
            return dto;
        }
    }
}
