using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioIntegrador2_YouTify.Extensions;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Services;

namespace EjercicioIntegrador2_YouTify
{
    public partial class MainPage : UserControl
    {
        private User user;
        private List<Playlist> playlists = new();

        public Color BackgroundColor { set
            {
                this.BackColor = value;
            }
        }
        public MainPage()
        {
            InitializeComponent();
            InitializePlaylists();
        }

        private void InitializePlaylists()
        {
            lvPlaylists.View = View.Details;
            lvPlaylists.Columns.Add("Titulo", 200);
            lvPlaylists.Columns.Add("Icono", 60);
        }

        public void SetCurrentUser(User user)
        {
            this.user = user;
            LoadPlaylistsForCurrentUser();
        }

        private async void LoadPlaylistsForCurrentUser()
        {
            lvPlaylists.Items.Clear();
            this.playlists = await PlaylistService.GetPlaylistsForUser(this.user);
            if (this.playlists.Count == 0)
            {
                lblNoPlaylists.Visible = true;
            }
            else
            {

                lblNoPlaylists.Visible = false;
                this.LoadPlaylistIcons(playlists);
                lvPlaylists.Items.AddRange(this.playlists.Select(playlist => (ListViewItem)playlist).ToArray());
            }
        }

        private void LoadPlaylistIcons(List<Playlist> playlists)
        {
            ilPlaylistIcons.Images.Clear();
            foreach (Playlist playlist in playlists)
            {
                string iconPath = playlist.GetIconFileName(DirectoryExtensions.GetAssetsFilePath());
                ilPlaylistIcons.Images.Add(playlist.ImageName, Image.FromFile(iconPath));
            }
        }
    }
}
