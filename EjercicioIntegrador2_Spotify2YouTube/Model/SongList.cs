using EjercicioIntegrador2_YouTify.Extensions;
using Entities.DTOs;
using System.CodeDom;

namespace EjercicioIntegrador2_YouTify.Model
{
    internal class SongList
    {
        private List<Song> songs = new();

        private List<Song> originalSongs;
        internal SongList(List<Song> songs) 
        { 
            this.songs = songs;
        }

        internal SongList(List<SongDTO> songs)
        {
            this.songs = songs.Select(s => (Song)s).ToList();
            this.originalSongs = this.songs;
        }


        public Song this[int index]
        {
            get { return songs[index]; }
        }

        internal List<Song> GetSongsByIndices(List<int> list)
        {
            // Utilizo list.Contains porque es una lista de tipos por valor, el contains no comparará por referencia
            return this.originalSongs.Where(s => list.Contains(s.Id)).ToList();
        }

        internal SongList FilterBy(string text)
        {
            this.songs = this.originalSongs;
            string filter = text.ToLower();
            if (!string.IsNullOrEmpty(text))
            {
                this.songs = this.songs.Where(s => s.Name.ToLower().Contains(filter) || s.ArtistName.ToLower().Contains(filter)).ToList();
            }
            return this;
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

        internal void Update(List<Song> songs)
        {
            throw new NotImplementedException();
        }
    }
}