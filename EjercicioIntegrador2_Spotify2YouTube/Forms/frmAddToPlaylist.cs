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

namespace YouTify.Forms
{
    public partial class frmAddToPlaylist : Form
    {
        private List<Playlist> playlists;
        private List<Song> selectedSongs;

        public Playlist SelectedPlaylist { get => this.playlists.Where(p => p.Name == this.cbPlaylists.SelectedItem.ToString()).FirstOrDefault(); }
        public frmAddToPlaylist(List<Playlist> playlists, List<Song> selectedSongs)
        {
            InitializeComponent();
            this.playlists = playlists;
            this.selectedSongs = selectedSongs;
            InitializeControls();
        }

        private void InitializeControls()
        {
            this.rtbSelectedSongs.Lines = this.selectedSongs.Select(s => s.Name).ToArray();
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
