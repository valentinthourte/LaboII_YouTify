using EjercicioIntegrador2_YouTify.Extensions;
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

        public static implicit operator SongList(List<Song> songList)
        {
            return new SongList(songList);
        }

        public static implicit operator SongList(Entities.Model.SongList v)
        {
            return new SongList(v.Songs.Select(s => (Song)s).ToList());
        }
    }
}