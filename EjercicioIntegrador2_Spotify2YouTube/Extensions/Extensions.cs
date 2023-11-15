using EjercicioIntegrador2_YouTify.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EjercicioIntegrador2_YouTify.Extensions
{
    internal static class Extensions
    {
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
            item.ImageKey = playlist.Id;
            return item;
        }
    }
}
