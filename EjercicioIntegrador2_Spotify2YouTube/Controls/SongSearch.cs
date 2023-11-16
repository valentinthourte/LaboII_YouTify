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

        public Color SecondaryColor { get => this.lvSongList.BackColor; set => SetSecondaryColors(value); }

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
    }
}
