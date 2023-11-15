namespace EjercicioIntegrador2_YouTify
{
    partial class MainPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "", "Holaaaaa" }, -1);
            pnlPlaylistList = new Panel();
            lblNoPlaylists = new Label();
            lvPlaylists = new ListView();
            ilPlaylistIcons = new ImageList(components);
            tbBuscadorCanciones = new TextBox();
            panel1 = new Panel();
            pnlPlaylistList.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPlaylistList
            // 
            pnlPlaylistList.Controls.Add(lblNoPlaylists);
            pnlPlaylistList.Controls.Add(lvPlaylists);
            pnlPlaylistList.Location = new Point(0, 77);
            pnlPlaylistList.Name = "pnlPlaylistList";
            pnlPlaylistList.Size = new Size(296, 543);
            pnlPlaylistList.TabIndex = 0;
            // 
            // lblNoPlaylists
            // 
            lblNoPlaylists.BackColor = Color.Transparent;
            lblNoPlaylists.Font = new Font("Roboto", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblNoPlaylists.Location = new Point(37, 55);
            lblNoPlaylists.Name = "lblNoPlaylists";
            lblNoPlaylists.Size = new Size(194, 59);
            lblNoPlaylists.TabIndex = 1;
            lblNoPlaylists.Text = "There is nothing to show here yet";
            lblNoPlaylists.Visible = false;
            // 
            // lvPlaylists
            // 
            lvPlaylists.BackColor = Color.WhiteSmoke;
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            lvPlaylists.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lvPlaylists.LargeImageList = ilPlaylistIcons;
            lvPlaylists.Location = new Point(0, 0);
            lvPlaylists.Name = "lvPlaylists";
            lvPlaylists.Size = new Size(295, 620);
            lvPlaylists.SmallImageList = ilPlaylistIcons;
            lvPlaylists.TabIndex = 1;
            lvPlaylists.TileSize = new Size(300, 32);
            lvPlaylists.UseCompatibleStateImageBehavior = false;
            lvPlaylists.View = View.Tile;
            // 
            // ilPlaylistIcons
            // 
            ilPlaylistIcons.ColorDepth = ColorDepth.Depth8Bit;
            ilPlaylistIcons.ImageSize = new Size(16, 16);
            ilPlaylistIcons.TransparentColor = Color.Transparent;
            // 
            // tbBuscadorCanciones
            // 
            tbBuscadorCanciones.Location = new Point(441, 20);
            tbBuscadorCanciones.Name = "tbBuscadorCanciones";
            tbBuscadorCanciones.Size = new Size(390, 23);
            tbBuscadorCanciones.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(295, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 543);
            panel1.TabIndex = 2;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(tbBuscadorCanciones);
            Controls.Add(pnlPlaylistList);
            Name = "MainPage";
            Size = new Size(1288, 620);
            pnlPlaylistList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlPlaylistList;
        private ListBox listBox1;
        private ListView lvPlaylists;
        private ImageList ilPlaylistIcons;
        private Label lblNoPlaylists;
        private TextBox tbBuscadorCanciones;
        private Panel panel1;
    }
}
