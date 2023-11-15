using System.Data;
using EjercicioIntegrador2_YouTify.Extensions;
using EjercicioIntegrador2_YouTify.Helpers;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Services.Base;

namespace EjercicioIntegrador2_YouTify
{
    public partial class MainPage : UserControl
    {
        private User user;
        private List<Playlist> playlists = new();
        private PlaylistService playlistService;

        public PlaylistService PlaylistService { set => this.playlistService = value; }

        public Color SecondaryColor { get => this.lvPlaylists.BackColor; set => SetSecondaryColors(value); }

        private void SetSecondaryColors(Color value)
        {
            this.lvPlaylists.BackColor = value;
            this.lvPlaylists.ForeColor = ColorHelper.InvertColor(value);
        }

        public Color BackgroundColor
        {
            get => this.BackColor;
            set
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
            lvPlaylists.View = View.Tile;
            lvPlaylists.TileSize = new Size(400, 30);
            lvPlaylists.Columns.Add("Titulo", 200);
        }

        public void SetCurrentUser(User user)
        {
            this.user = user;
            LoadPlaylistsForCurrentUser();
        }

        private async void LoadPlaylistsForCurrentUser()
        {
            lvPlaylists.Items.Clear();
            this.playlists = (await this.playlistService.GetPlaylistsForUser(this.user)).Select(p => (Playlist)p).ToList();
            if (this.playlists.Count == 0)
            {
                lblNoPlaylists.Visible = true;
            }
            else
            {

                lblNoPlaylists.Visible = false;
                this.LoadPlaylistIcons(playlists);
                lvPlaylists.Items.AddRange(this.playlists.Select(playlist => playlist.ToListViewItem()).ToArray());
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
