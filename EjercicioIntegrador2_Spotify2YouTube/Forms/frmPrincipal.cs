using EjercicioIntegrador2_YouTify;
using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Services.Spotify;
using EjercicioIntegrador2_YouTify.Services.Youtube;
using YouTify.Forms;

namespace EjercicioIntegrador2_Spotify2YouTube
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            // Spotify
            lpSpotify.LoginService = new SpotifyUserService();
            mpSpotify.PlaylistService = new SpotifyPlaylistService();
            mpSpotify.SongService = new SpotifySongService();
            mpSpotify.OnTransferPlaylist += OnTransferPlaylist;
            mpSpotify.Platform = EPlatform.Spotify;
            mpSpotify.BackgroundColor = tbSpotify.BackColor;

            // Youtube
            lpYoutube.LoginService = new YoutubeUserService();
            mpYoutube.PlaylistService = new YoutubePlaylistService();
            mpYoutube.SongService = new YoutubeSongService();
            mpYoutube.OnTransferPlaylist += OnTransferPlaylist;
            mpYoutube.Platform = EPlatform.Youtube;
            mpYoutube.BackgroundColor = tbYoutube.BackColor;
        }

        private async void OnSpotifyLogin(object sender, EventArgs e)
        {
            User user = await lpSpotify.Login();
            if (user is not null)
            {
                lpSpotify.Enabled = false;
                lpSpotify.Visible = false;
                mpSpotify.SetCurrentUser(user);
                mpSpotify.Enabled = true;
                mpSpotify.Visible = true;
            }
        }

        private async void OnYoutubeLogin(object sender, EventArgs e)
        {
            User user = await lpYoutube.Login();
            if (user is not null)
            {
                lpYoutube.Enabled = false;
                lpYoutube.Visible = false;
                mpYoutube.SetCurrentUser(user);
                mpYoutube.Enabled = true;
                mpYoutube.Visible = true;

            }
        }
        private async void OnSpotifySignup(object sender, EventArgs e)
        {
            User user = await lpSpotify.Signup();
            if (user is not null)
            {
                this.OnSuccessfulSpotifyEnter(user);
            }
        }

        private async void OnYoutubeSignup(object sender, EventArgs e)
        {
            User user = await lpYoutube.Signup();
            if (user is not null)
            {
                this.OnSuccessfulYoutubeEnter(user);
            }
        }

        private void OnSuccessfulYoutubeEnter(User user)
        {
            lpYoutube.Enabled = false;
            lpYoutube.Visible = false;
            mpYoutube.SetCurrentUser(user);
            mpYoutube.Enabled = true;
            mpYoutube.Visible = true;
        }
        private void OnSuccessfulSpotifyEnter(User user)
        {
            lpSpotify.Enabled = false;
            lpSpotify.Visible = false;
            mpSpotify.SetCurrentUser(user);
            mpSpotify.Enabled = true;
            mpSpotify.Visible = true;
        }


        private void OnTransferPlaylist(Playlist p, EPlatform platform)
        {
            switch (platform)
            {
                case EPlatform.Spotify:
                    {
                        mpYoutube.ClonePlaylist(p);
                        break;
                    }
                case EPlatform.Youtube:
                    {
                        mpSpotify.ClonePlaylist(p);
                        break;
                    }
            }
        }
    }
}
