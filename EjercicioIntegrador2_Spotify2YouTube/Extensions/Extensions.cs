using EjercicioIntegrador2_YouTify.Model;

namespace EjercicioIntegrador2_YouTify.Extensions
{
    internal static class Extensions
    {
        /// <summary>
        /// Extends Song class to add 
        /// </summary>
        /// <param name="song"></param>
        /// <returns></returns>
        public static ListViewItem ToListViewItem(this Song song)
        {
            ListViewItem item = new ListViewItem(song.Name);
            item.SubItems.Add(song.ArtistName);
            item.SubItems.Add(song.CreationDate.ToString("dd/MM/yyyy"));
            return item;
        }
        public static ListViewItem ToListViewItem(this Playlist playlist)
        {
            ListViewItem item = new ListViewItem(playlist.Name);
            item.ImageKey = playlist.ImageName;
            return item;
        }
    }
}
