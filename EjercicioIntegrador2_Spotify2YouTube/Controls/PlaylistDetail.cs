using EjercicioIntegrador2_YouTify.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioIntegrador2_YouTify.Controls
{
    public partial class PlaylistDetail : UserControl
    {
        private Playlist playlist;

        internal Playlist ActivePlaylist { set => SetActivePlaylist(value); }



        public PlaylistDetail()
        {
            InitializeComponent();
            InitializeList();
        }

        private void InitializeList()
        {

        }

        private void SetActivePlaylist(Playlist playlist)
        {
            this.playlist = playlist;
            if (playlist is not null)
            {
                playlist.GetPlaylistInformation(out string playlistName, out string playlistOwner);
                this.lblPlaylistName.Text = playlistName;
                this.lblPlaylistOwner.Text = playlistOwner;
                this.Visible = true;
                this.Enabled = true;
            }
            else
            {
                this.Visible = false;
                this.Visible = false;
            }
        }

    }
}
