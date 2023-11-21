using EjercicioIntegrador2_YouTify.Model;
using System.Data;

namespace YouTify.Forms
{
    public partial class frmAddToPlaylist : Form
    {
        private List<Playlist> playlists;
        private List<string> selectedItems;
        public Playlist SelectedPlaylist { get => this.playlists.Where(p => p.Name == this.cbPlaylists.SelectedItem.ToString()).FirstOrDefault(); }

        public string ListText { get => this.lblItems.Text; set => this.lblItems.Text = value; }

        public frmAddToPlaylist(List<Playlist> playlists, List<Song> selectedSongs)
        {
            InitializeComponent();
            this.playlists = playlists;
            this.selectedItems = selectedSongs.Select(s => s.Name).ToList();
            InitializeControls();
        }
        public frmAddToPlaylist(List<Playlist> playlists, List<string> selectedItems)
        {
            InitializeComponent();
            this.playlists = playlists;
            this.selectedItems = selectedItems;
            InitializeControls();
        }

        private void InitializeControls()
        {
            this.rtbSelectedSongs.Lines = this.selectedItems.ToArray();
            this.cbPlaylists.DataSource = this.playlists.Select(p => p.Name).ToList();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (cbPlaylists.SelectedIndex > -1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
