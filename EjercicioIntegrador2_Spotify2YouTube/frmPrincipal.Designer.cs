﻿using EjercicioIntegrador2_YouTify;
using EjercicioIntegrador2_YouTify.Services;

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
            tcTabs = new TabControl();
            tbYoutube = new TabPage();
            lpYoutube = new LoginPanel();
            ilLogos = new ImageList(components);
            tbIntegracion = new TabPage();
            tbSpotify = new TabPage();
            lpSpotify = new LoginPanel();
            tcTabs.SuspendLayout();
            tbYoutube.SuspendLayout();
            tbSpotify.SuspendLayout();
            SuspendLayout();
            // 
            // tcTabs
            // 
            tcTabs.Controls.Add(tbYoutube);
            tcTabs.Controls.Add(tbIntegracion);
            tcTabs.Controls.Add(tbSpotify);
            tcTabs.ItemSize = new Size(430, 20);
            tcTabs.Location = new Point(-1, -1);
            tcTabs.Name = "tcTabs";
            tcTabs.SelectedIndex = 0;
            tcTabs.Size = new Size(1296, 648);
            tcTabs.SizeMode = TabSizeMode.Fixed;
            tcTabs.TabIndex = 0;
            // 
            // tbYoutube
            // 
            tbYoutube.BackColor = Color.White;
            tbYoutube.Controls.Add(lpYoutube);
            tbYoutube.Location = new Point(4, 24);
            tbYoutube.Name = "tbYoutube";
            tbYoutube.Padding = new Padding(3);
            tbYoutube.Size = new Size(1288, 620);
            tbYoutube.TabIndex = 0;
            tbYoutube.Text = "Youtube";
            // 
            // lpYoutube
            // 
            lpYoutube.BackColor = SystemColors.Window;
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
            // ilLogos
            // 
            ilLogos.ColorDepth = ColorDepth.Depth8Bit;
            ilLogos.ImageStream = (ImageListStreamer)resources.GetObject("ilLogos.ImageStream");
            ilLogos.TransparentColor = Color.Transparent;
            ilLogos.Images.SetKeyName(0, "LogoYT.png");
            ilLogos.Images.SetKeyName(1, "LogoSP.png");
            // 
            // tbIntegracion
            // 
            tbIntegracion.Location = new Point(4, 24);
            tbIntegracion.Name = "tbIntegracion";
            tbIntegracion.Padding = new Padding(3);
            tbIntegracion.Size = new Size(1288, 620);
            tbIntegracion.TabIndex = 2;
            tbIntegracion.Text = "Integracion";
            tbIntegracion.UseVisualStyleBackColor = true;
            // 
            // tbSpotify
            // 
            tbSpotify.BackColor = Color.FromArgb(22, 22, 22);
            tbSpotify.Controls.Add(lpSpotify);
            tbSpotify.Location = new Point(4, 24);
            tbSpotify.Name = "tbSpotify";
            tbSpotify.Padding = new Padding(3);
            tbSpotify.Size = new Size(1288, 620);
            tbSpotify.TabIndex = 1;
            tbSpotify.Text = "Spotify";
            // 
            // lpSpotify
            // 
            lpSpotify.BackColor = SystemColors.Window;
            lpSpotify.FontColor = Color.Black;
            lpSpotify.ForeColor = Color.Black;
            lpSpotify.ImgIndex = 1;
            lpSpotify.ImgList = ilLogos;
            lpSpotify.Location = new Point(450, 26);
            lpSpotify.Name = "lpSpotify";
            lpSpotify.Size = new Size(393, 524);
            lpSpotify.TabIndex = 0;
            lpSpotify.LoginClick += OnSpotifyLoginClick;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 639);
            Controls.Add(tcTabs);
            Name = "frmPrincipal";
            Text = "Form1";
            Load += Form1_Load;
            tcTabs.ResumeLayout(false);
            tbYoutube.ResumeLayout(false);
            tbSpotify.ResumeLayout(false);
            ResumeLayout(false);
        }





        #endregion

        private TabControl tcTabs;
        private TabPage tbYoutube;
        private TabPage tbSpotify;
        private TabPage tbIntegracion;
        private ImageList ilLogos;
        private LoginPanel lpYoutube;
        private LoginPanel lpSpotify;
    }
}