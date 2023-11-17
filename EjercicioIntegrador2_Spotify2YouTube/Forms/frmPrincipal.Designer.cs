using EjercicioIntegrador2_YouTify;
using Entities.Services;

namespace EjercicioIntegrador2_Spotify2YouTube
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            ilLogos = new ImageList(components);
            tbSpotify = new TabPage();
            mpSpotify = new MainPage();
            lpSpotify = new LoginPanel();
            tbYoutube = new TabPage();
            mpYoutube = new MainPage();
            ssYoutubeSongs = new SongSearch();
            lpYoutube = new LoginPanel();
            tcTabs = new TabControl();
            tbSpotify.SuspendLayout();
            tbYoutube.SuspendLayout();
            tcTabs.SuspendLayout();
            SuspendLayout();
            // 
            // ilLogos
            // 
            ilLogos.ColorDepth = ColorDepth.Depth8Bit;
            ilLogos.ImageStream = (ImageListStreamer)resources.GetObject("ilLogos.ImageStream");
            ilLogos.TransparentColor = Color.Transparent;
            ilLogos.Images.SetKeyName(0, "LogoYT.png");
            ilLogos.Images.SetKeyName(1, "LogoSP.png");
            // 
            // tbSpotify
            // 
            tbSpotify.BackColor = Color.FromArgb(22, 22, 22);
            tbSpotify.Controls.Add(lpSpotify);
            tbSpotify.Controls.Add(mpSpotify);
            tbSpotify.Location = new Point(4, 24);
            tbSpotify.Name = "tbSpotify";
            tbSpotify.Padding = new Padding(3);
            tbSpotify.Size = new Size(1288, 620);
            tbSpotify.TabIndex = 1;
            tbSpotify.Text = "Spotify";
            // 
            // mpSpotify
            // 
            mpSpotify.BackColor = Color.FromArgb(22, 22, 22);
            mpSpotify.BackgroundColor = Color.FromArgb(22, 22, 22);
            mpSpotify.Enabled = false;
            mpSpotify.Location = new Point(0, 0);
            mpSpotify.Name = "mpSpotify";
            mpSpotify.SecondaryColor = Color.FromArgb(45, 45, 45);
            mpSpotify.Size = new Size(1288, 620);
            mpSpotify.TabIndex = 1;
            mpSpotify.Visible = false;
            // 
            // lpSpotify
            // 
            lpSpotify.BackColor = Color.Transparent;
            lpSpotify.FontColor = Color.White;
            lpSpotify.ForeColor = Color.White;
            lpSpotify.ImgIndex = 1;
            lpSpotify.ImgList = ilLogos;
            lpSpotify.Location = new Point(450, 26);
            lpSpotify.Name = "lpSpotify";
            lpSpotify.Size = new Size(393, 524);
            lpSpotify.TabIndex = 0;
            lpSpotify.LoginClick += OnSpotifyLoginClick;
            // 
            // tbYoutube
            // 
            tbYoutube.BackColor = Color.WhiteSmoke;
            tbYoutube.Controls.Add(lpYoutube);
            tbYoutube.Controls.Add(ssYoutubeSongs);
            tbYoutube.Controls.Add(mpYoutube);
            tbYoutube.Location = new Point(4, 24);
            tbYoutube.Name = "tbYoutube";
            tbYoutube.Padding = new Padding(3);
            tbYoutube.Size = new Size(1288, 620);
            tbYoutube.TabIndex = 0;
            tbYoutube.Text = "Youtube";
            // 
            // mpYoutube
            // 
            mpYoutube.BackColor = Color.WhiteSmoke;
            mpYoutube.BackgroundColor = Color.WhiteSmoke;
            mpYoutube.Enabled = false;
            mpYoutube.ImeMode = ImeMode.NoControl;
            mpYoutube.Location = new Point(0, 0);
            mpYoutube.Name = "mpYoutube";
            mpYoutube.SecondaryColor = Color.WhiteSmoke;
            mpYoutube.Size = new Size(1288, 620);
            mpYoutube.TabIndex = 1;
            mpYoutube.Visible = false;
            // 
            // ssYoutubeSongs
            // 
            ssYoutubeSongs.Enabled = false;
            ssYoutubeSongs.Location = new Point(295, 77);
            ssYoutubeSongs.Name = "ssYoutubeSongs";
            ssYoutubeSongs.SecondaryColor = SystemColors.Window;
            ssYoutubeSongs.Size = new Size(993, 543);
            ssYoutubeSongs.TabIndex = 1;
            ssYoutubeSongs.Visible = false;
            // 
            // lpYoutube
            // 
            lpYoutube.BackColor = Color.WhiteSmoke;
            lpYoutube.FontColor = Color.Black;
            lpYoutube.ForeColor = Color.Black;
            lpYoutube.ImgIndex = 0;
            lpYoutube.ImgList = ilLogos;
            lpYoutube.Location = new Point(450, 26);
            lpYoutube.Name = "lpYoutube";
            lpYoutube.Size = new Size(393, 524);
            lpYoutube.TabIndex = 0;
            lpYoutube.LoginClick += OnYoutubeLogin;
            // 
            // tcTabs
            // 
            tcTabs.Controls.Add(tbYoutube);
            tcTabs.Controls.Add(tbSpotify);
            tcTabs.ItemSize = new Size(646, 20);
            tcTabs.Location = new Point(-1, -1);
            tcTabs.Name = "tcTabs";
            tcTabs.SelectedIndex = 0;
            tcTabs.Size = new Size(1296, 648);
            tcTabs.SizeMode = TabSizeMode.Fixed;
            tcTabs.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 639);
            Controls.Add(tcTabs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmPrincipal";
            Text = "YouTify";
            tbSpotify.ResumeLayout(false);
            tbYoutube.ResumeLayout(false);
            tcTabs.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ImageList ilLogos;
        private TabPage tbSpotify;
        private LoginPanel lpSpotify;
        private MainPage mpSpotify;
        private TabPage tbYoutube;
        private LoginPanel lpYoutube;
        private SongSearch ssYoutubeSongs;
        private MainPage mpYoutube;
        private TabControl tcTabs;
    }
}