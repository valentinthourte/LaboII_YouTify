using EjercicioIntegrador2_YouTify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Model
{
    public class SongList
    {

        private List<Song> songs = new();

        public List<Song> Songs { get => songs; }

        internal SongList(List<Song> songs)
        {
            this.songs = songs;
        }
        public Song this[int index]
        {
            get { return songs[index]; }
        }


        public static implicit operator SongList(List<Song> songList)
        {
            return new SongList(songList);
        }


    }
}
