using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador2_YouTify.Model
{
    internal class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ArtistName { get; set;}
        public DateTime CreationDate { get; set;}

        public static explicit operator Song(Entities.Model.Song s)
        {
            Song song = new Song();
            song.Id = s.id;
            song.Name = s.name;
            song.ArtistName = s.artistName;
            song.CreationDate = s.creationDate;
            return song;
        }
    }
}
