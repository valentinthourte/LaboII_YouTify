using EjercicioIntegrador2_YouTify.Helpers;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Services.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EjercicioIntegrador2_YouTify.SongSearch;

namespace EjercicioIntegrador2_YouTify.Controls
{
    public partial class PlaylistDetail : UserControl
    {
        private Playlist playlist;

        internal Playlist ActivePlaylist { set => SetActivePlaylist(value); }

        internal OnAddToPlaylist OnAddToPlaylist { set => this.ssPlaylistSongs.onAddToPlaylist += value; }
        public Color SecondaryColor { get => this.BackColor; set => SetSecondaryColors(value); }
        public SongService SongService { set => this.ssPlaylistSongs.SongsService = value; }

        private void SetSecondaryColors(Color value)
        {
            this.ssPlaylistSongs.SecondaryColor = value;
            this.lblPlaylistName.ForeColor = ColorHelper.InvertColor(value);
            this.lblPlaylistOwner.ForeColor = ColorHelper.InvertColor(value);
        }

        public PlaylistDetail()
        {
            InitializeComponent();
        }

        private void SetActivePlaylist(Playlist playlist)
        {
            this.playlist = playlist;
            if (playlist is not null)
            {
                playlist.GetPlaylistInformation(out string playlistName, out string playlistOwner);
                this.lblPlaylistName.Text = playlistName;
                this.lblPlaylistOwner.Text = playlistOwner;

                this.ssPlaylistSongs.SetActivePlaylist(playlist);

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
