using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Services.Spotify;
using EjercicioIntegrador2_YouTify.Services.Youtube;


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
            lpSpotify.LoginService = new SpotifyLoginService();
            mpSpotify.PlaylistService = new SpotifyPlaylistService();
            mpSpotify.SongService = new SpotifySongService();
            mpSpotify.BackgroundColor = tbSpotify.BackColor;

            // Youtube
            lpYoutube.LoginService = new YoutubeLoginService();
            mpYoutube.PlaylistService = new YoutubePlaylistService();
            mpYoutube.SongService = new YoutubeSongService();
            mpYoutube.BackgroundColor = tbYoutube.BackColor;
        }

        private async void OnSpotifyLoginClick(object sender, EventArgs e)
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
    }
}
