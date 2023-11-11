using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioIntegrador2_YouTify.Services;

namespace EjercicioIntegrador2_YouTify
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            InitializeData();
        }

        private async void InitializeData()
        {
            InitializePlaylists();


            //ilPlaylistIcons.Images.Add("1", Image.FromFile());


        }

        private async void InitializePlaylists()
        {
            lvPlaylists.View = View.Details;
            lvPlaylists.Columns.Add("Titulo", 200);
            lvPlaylists.Columns.Add("Icono", 60);

            var playlists = await PlaylistService.GetPlaylists();
        }
    }
}
