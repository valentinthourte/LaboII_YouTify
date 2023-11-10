namespace EjercicioIntegrador2_Spotify2YouTube
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void OnSpotifyLoginClick(object sender, EventArgs e)
        {
            if (await lpSpotify.Login())
            {
                lpSpotify.Enabled = false;
                lpSpotify.Visible = false;
            }
        }

        private async void OnYoutubeLogin(object sender, EventArgs e)
        {
            if (await lpYoutube.Login())
            {
                lpYoutube.Enabled = false;
                lpYoutube.Visible = false;
            }
        }
    }
}
