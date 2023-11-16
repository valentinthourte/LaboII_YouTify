using EjercicioIntegrador2_YouTify.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTify
{
    public partial class frmNewPlaylist : Form
    {
        private string PlaylistName { get => tbPlaylistName.Text; }
        private string PlaylistIconPath { get => tbIconFilePath.Text; }

        public frmNewPlaylist()
        {
            InitializeComponent();

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.PlaylistName))
            {
                lblWarning.Visible = true;
                lblMustInsertName.Visible = true;
            }
            else
            {
                lblWarning.Visible = false; 
                lblMustInsertName.Visible = false;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            this.ofdIconFile.ShowDialog();
        }

        private void ofdIconFile_FileOk(object sender, CancelEventArgs e)
        {
            this.tbIconFilePath.Text = ofdIconFile.FileName;
        }

        public Playlist GetPlaylist(User user)
        {
            return new Playlist(tbPlaylistName.Text, user.Name, tbIconFilePath.Text);
        }

    }
}
