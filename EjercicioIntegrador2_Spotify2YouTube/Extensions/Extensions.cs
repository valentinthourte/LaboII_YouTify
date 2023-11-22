using EjercicioIntegrador2_YouTify.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace EjercicioIntegrador2_YouTify.Extensions
{
    internal static class Extensions
    {
        /// <summary>
        /// Se implementan métodos de extensión en el proyecto de Windows Forms, para
        /// las clases “Song” y “Playlist”. Estos métodos se utilizan para transformar un
        //  objeto de estos tipos a un tipo “ListViewItem”, utilizado por el control ListView,
        // para mostrar dichos objetos en formato lista.Dichos métodos están
        // implementados en la clase “Extensions”

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
