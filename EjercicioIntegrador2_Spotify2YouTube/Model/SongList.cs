using EjercicioIntegrador2_YouTify.Extensions;
using Entities.DTOs;
using System.CodeDom;

namespace EjercicioIntegrador2_YouTify.Model
{
    internal class SongList
    {

        private List<Song> songs = new();

        internal SongList(List<Song> songs) 
        { 
            this.songs = songs;
        }

        internal SongList(List<SongDTO> songs)
        {
            this.songs = songs.Select(s => (Song)s).ToList();
        }


        public Song this[int index]
        {
            get { return songs[index]; }
        }

        internal List<ListViewItem> GetListViewItems()
        {
            List<ListViewItem> returnList = new();
            foreach (Song song in this.songs)
            {
                ListViewItem item = song.ToListViewItem();
                returnList.Add(item);
            }
            return returnList;
        }

    }
}