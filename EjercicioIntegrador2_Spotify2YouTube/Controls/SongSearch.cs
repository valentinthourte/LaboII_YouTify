using EjercicioIntegrador2_YouTify.Helpers;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Services.Base;

namespace EjercicioIntegrador2_YouTify
{
    public partial class SongSearch : UserControl
    {
        private SongList songList;
        private SongService songService;

        public SongService SongsService { set => this.songService = value; }
        internal SongList Songs { set => UpdateSongList(value); }

        internal delegate void OnAddToPlaylist(List<Song> songs);
        internal delegate void OnRemoveFromPlaylist(List<Song> songs);
        internal event OnAddToPlaylist onAddToPlaylist;
        internal event OnRemoveFromPlaylist onRemoveFromPlaylist;


        public Color SecondaryColor { get => this.lvSongList.BackColor; set => SetSecondaryColors(value); }

        private List<Song> SelectedSongs { get => GetSelectedSongs(); }

        private List<Song> GetSelectedSongs()
        {
            return songList.GetSongsByIndices(this.lvSongList.SelectedIndices.Cast<int>().ToList());
        }

        private void SetSecondaryColors(Color value)
        {
            this.lvSongList.BackColor = value;
            this.lvSongList.ForeColor = ColorHelper.InvertColor(value);
        }

        private void UpdateSongList(SongList songs)
        {
            this.songList = songs;
            if (songs is not null)
            {
                lvSongList.Items.Clear();
                List<ListViewItem> items = this.songList.GetListViewItems();
                lvSongList.Items.AddRange(items.ToArray());
            }
        }

        public SongSearch()
        {
            InitializeComponent();
            InitializeList();
        }

        private async void InitializeList()
        {
            lvSongList.View = View.Details;
            lvSongList.Columns.Add("Title", 250);
            lvSongList.Columns.Add("Artist", 250);
            lvSongList.Columns.Add("Date Added", 250);
        }

        public async void Enter()
        {
            this.Enabled = true;
            this.Visible = true;
            this.Songs = new SongList(await this.songService.GetSongs());
        }

        public async void SetActivePlaylist(Playlist playlist)
        {
            var songs = (await this.songService.GetPlaylistSongs(playlist));
            this.Songs = new SongList(songs);

            this.Enabled = true;
            this.Visible = true;
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Songs = this.songList.FilterBy(tbSearch.Text);
        }

        private void miAddSongToPlaylist_Click(object sender, EventArgs e)
        {
            if (this.onAddToPlaylist is not null && this.SelectedSongs.Count > 0)
            {
                this.onAddToPlaylist(this.SelectedSongs);
            }
        }

        private void lvSongList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvSongList.SelectedItems.Count > 0)
                {
                    ctxmSongContextMenu.Show(lvSongList, e.Location);
                }
            }
        }
    }
}
