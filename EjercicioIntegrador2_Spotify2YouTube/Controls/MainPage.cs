﻿using System.Data;
using System.Reflection.Metadata.Ecma335;
using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Extensions;
using EjercicioIntegrador2_YouTify.Helpers;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Services.Base;
using Entities.DTOs;
using Entities.Services.Base;
using YouTify;
using YouTify.Forms;

namespace EjercicioIntegrador2_YouTify
{
    /// <summary>
    /// User control shown when user logs in, and controls the user's playlists as well as playlist/available songs
    /// through SongSearch User control
    /// </summary>
    public partial class MainPage : UserControl
    {

        public delegate void TransferPlaylist(Playlist p, EPlatform platform);
        public event TransferPlaylist OnTransferPlaylist;
        private EPlatform platform;
        public EPlatform Platform { set => this.platform = value; }

        private User user;
        private List<Playlist> playlists = new();

        private PlaylistService playlistService;

        private Playlist ActivePlaylist { get => GetActivePlaylist(); }

        private Playlist GetActivePlaylist()
        {
            Playlist playlist;
            try
            {
                playlist = this.playlists.ElementAt(this.lvPlaylists.SelectedIndices[0]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                playlist = null;
            }
            catch (Exception ex)
            {
                playlist = null;
                MessageBox.Show(ex.Message);
            }
            return playlist ;
        }


        public PlaylistService PlaylistService { set => this.playlistService = value; }
        public SongService SongService { set => InitializeSongSearch(value); }

        public Color SecondaryColor { get => this.lvPlaylists.BackColor; set => SetSecondaryColors(value); }
        public Color BackgroundColor
        {
            get => this.BackColor;
            set
            {
                this.BackColor = value;
            }
        }

        private void InitializeSongSearch(SongService value)
        {
            this.ssSongSearch.SongsService = value;
            this.ssSongSearch.onAddToPlaylist += this.OnAddSongToPlaylist;
            this.pdPlaylistDetail.OnAddToPlaylist = this.OnAddSongToPlaylist;
            this.pdPlaylistDetail.SongService = value;
            this.ssSongSearch.Enter();
        }


        private void SetSecondaryColors(Color value)
        {
            this.lvPlaylists.BackColor = value;
            this.lvPlaylists.ForeColor = ColorHelper.InvertColor(value);
            this.ssSongSearch.SecondaryColor = value;
            this.pdPlaylistDetail.SecondaryColor = value;
        }

        public MainPage()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            InitializePlaylists();
        }


        private void InitializePlaylists()
        {
            lvPlaylists.View = View.Tile;
            lvPlaylists.TileSize = new Size(400, 30);
            lvPlaylists.Columns.Add("Titulo", 200);
            lvPlaylists.DoubleClick += OnPlaylistDoubleClick;
        }

        private void OnPlaylistDoubleClick(object? sender, EventArgs e)
        {
            this.ssSongSearch.Enabled = false;
            this.ssSongSearch.Visible = false;

            this.pdPlaylistDetail.ActivePlaylist = this.ActivePlaylist;

        }

        public void SetCurrentUser(User user)
        {
            this.user = user;
            LoadPlaylistsForCurrentUser();
        }

        private async void LoadPlaylistsForCurrentUser()
        {
            try
            {
                lvPlaylists.Items.Clear();
                this.playlists = await GetPlaylistsForCurrentUser();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private async Task<List<Playlist>> GetPlaylistsForCurrentUser()
        {
            return (await this.playlistService.GetPlaylistsForUser(this.user)).Select(p => (Playlist)p).ToList();
        }

        public async Task<List<Playlist>> GetPlaylistsForTransfer()
        {
            try
            {
                return this.playlists ?? await this.GetPlaylistsForCurrentUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new();
            }
        }

        private void OnAddSongToPlaylist(List<Song> songs)
        {
            frmAddToPlaylist frmAddToPlaylist = new frmAddToPlaylist(this.playlists, songs);
            frmAddToPlaylist.ShowDialog();
            if (frmAddToPlaylist.DialogResult == DialogResult.OK)
            {
                try
                {
                    this.playlistService.AddSongsToPlaylist(frmAddToPlaylist.SelectedPlaylist, songs.Select(s => (SongDTO)s).ToList());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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

        private async void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            frmNewPlaylist frmNewPlaylist = new frmNewPlaylist();
            DialogResult result = frmNewPlaylist.ShowDialog();
            if (result == DialogResult.OK)
            {
                PlaylistDTO dto = frmNewPlaylist.GetPlaylist(this.user);
                AddNewPlaylist(dto);
            }
        }
        public async void AddNewPlaylist(Playlist p)
        {
            try
            {
                await this.playlistService.CreatePlaylist(p);
                this.LoadPlaylistsForCurrentUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFindSongs_Click(object sender, EventArgs e)
        {
            this.pdPlaylistDetail.Enabled = false;
            this.pdPlaylistDetail.Visible = false;
            this.ssSongSearch.Enter();
            this.ssSongSearch.Enabled = true;
            this.ssSongSearch.Visible = true;
        }

        private void lvPlaylists_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvPlaylists.SelectedItems.Count > 0)
                {
                    ctxmPlaylistOptions.Show(lvPlaylists, e.Location);
                }
            }
        }

        private void miTransfer_Click(object sender, EventArgs e)
        {
            if (this.OnTransferPlaylist is not null)
            {
                this.OnTransferPlaylist(this.ActivePlaylist, this.platform);
            }
        }

        internal void ClonePlaylist(Playlist basePlaylist)
        {
            if (this.playlists.Any())
            {
                List<string> items = new List<string> { basePlaylist.Name };
                frmAddToPlaylist frm = new frmAddToPlaylist(this.playlists, items);
                frm.ListText = "Selected playlist";

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Playlist selectedPlaylist = frm.SelectedPlaylist;
                    try
                    {
                        this.playlistService.ClonePlaylist(basePlaylist, selectedPlaylist, this.user);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"There was an error transfering the playlist: {ex.Message}");
                    }
                }
            }
            else
            {
                throw new Exception("You must log into every platform in order to transfer.");
            }
            
        }
    }
}
