using EjercicioIntegrador2_YouTify.Model;
using EjercicioIntegrador2_YouTify.Services;

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
            mpSpotify.BackgroundColor = tbSpotify.BackColor;
            // Youtube
            lpYoutube.LoginService = new YoutubeLoginService();
            mpYoutube.BackgroundColor = tbYoutube.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
