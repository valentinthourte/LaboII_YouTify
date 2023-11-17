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
            panel1 = new Panel();
            ssSongSearch = new SongSearch();
            pdPlaylistDetail = new Controls.PlaylistDetail();
            btnFindSongs = new Button();
            btnNewPlaylist = new Button();
            ctxmPlaylistOptions = new ContextMenuStrip(components);
            miTransfer = new ToolStripMenuItem();
            asdToolStripMenuItem = new ToolStripMenuItem();
            miSynchronize = new ToolStripMenuItem();
            pnlPlaylistList.SuspendLayout();
            panel1.SuspendLayout();
            ctxmPlaylistOptions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPlaylistList
            // 
            pnlPlaylistList.Controls.Add(lblNoPlaylists);
            pnlPlaylistList.Controls.Add(lvPlaylists);
            pnlPlaylistList.Location = new Point(0, 106);
            pnlPlaylistList.Name = "pnlPlaylistList";
            pnlPlaylistList.Size = new Size(296, 514);
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
            lvPlaylists.Location = new Point(1, -1);
            lvPlaylists.Name = "lvPlaylists";
            lvPlaylists.Size = new Size(295, 515);
            lvPlaylists.SmallImageList = ilPlaylistIcons;
            lvPlaylists.TabIndex = 1;
            lvPlaylists.TileSize = new Size(300, 32);
            lvPlaylists.UseCompatibleStateImageBehavior = false;
            lvPlaylists.View = View.Tile;
            lvPlaylists.MouseClick += lvPlaylists_MouseClick;
            // 
            // ilPlaylistIcons
            // 
            ilPlaylistIcons.ColorDepth = ColorDepth.Depth8Bit;
            ilPlaylistIcons.ImageSize = new Size(16, 16);
            ilPlaylistIcons.TransparentColor = Color.Transparent;
            // 
            // panel1
            // 
            panel1.Controls.Add(ssSongSearch);
            panel1.Controls.Add(pdPlaylistDetail);
            panel1.Location = new Point(295, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 543);
            panel1.TabIndex = 2;
            // 
            // ssSongSearch
            // 
            ssSongSearch.Location = new Point(0, 0);
            ssSongSearch.Name = "ssSongSearch";
            ssSongSearch.SecondaryColor = SystemColors.Window;
            ssSongSearch.Size = new Size(993, 543);
            ssSongSearch.TabIndex = 3;
            // 
            // pdPlaylistDetail
            // 
            pdPlaylistDetail.Location = new Point(3, 3);
            pdPlaylistDetail.Name = "pdPlaylistDetail";
            pdPlaylistDetail.SecondaryColor = SystemColors.Control;
            pdPlaylistDetail.Size = new Size(993, 543);
            pdPlaylistDetail.TabIndex = 4;
            pdPlaylistDetail.Visible = false;
            // 
            // btnFindSongs
            // 
            btnFindSongs.Location = new Point(172, 48);
            btnFindSongs.Name = "btnFindSongs";
            btnFindSongs.Size = new Size(95, 23);
            btnFindSongs.TabIndex = 5;
            btnFindSongs.Text = "Find songs";
            btnFindSongs.UseVisualStyleBackColor = true;
            btnFindSongs.Click += btnFindSongs_Click;
            // 
            // btnNewPlaylist
            // 
            btnNewPlaylist.Location = new Point(17, 48);
            btnNewPlaylist.Name = "btnNewPlaylist";
            btnNewPlaylist.Size = new Size(95, 23);
            btnNewPlaylist.TabIndex = 6;
            btnNewPlaylist.Text = "New playlist";
            btnNewPlaylist.UseVisualStyleBackColor = true;
            btnNewPlaylist.Click += btnNewPlaylist_Click;
            // 
            // ctxmPlaylistOptions
            // 
            ctxmPlaylistOptions.Items.AddRange(new ToolStripItem[] { miTransfer, miSynchronize });
            ctxmPlaylistOptions.Name = "ctxmPlaylistOptions";
            ctxmPlaylistOptions.Size = new Size(181, 70);
            // 
            // miTransfer
            // 
            miTransfer.DropDownItems.AddRange(new ToolStripItem[] { asdToolStripMenuItem });
            miTransfer.Name = "miTransfer";
            miTransfer.Size = new Size(180, 22);
            miTransfer.Text = "Transfer to";
            miTransfer.Click += miTransfer_Click;
            // 
            // asdToolStripMenuItem
            // 
            asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            asdToolStripMenuItem.Size = new Size(180, 22);
            asdToolStripMenuItem.Text = "New playlist";
            // 
            // miSynchronize
            // 
            miSynchronize.Enabled = false;
            miSynchronize.Name = "miSynchronize";
            miSynchronize.Size = new Size(180, 22);
            miSynchronize.Text = "Synchronize with";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNewPlaylist);
            Controls.Add(btnFindSongs);
            Controls.Add(panel1);
            Controls.Add(pnlPlaylistList);
            Name = "MainPage";
            Size = new Size(1288, 620);
            pnlPlaylistList.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ctxmPlaylistOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPlaylistList;
        private ListBox listBox1;
        private ListView lvPlaylists;
        private ImageList ilPlaylistIcons;
        private Label lblNoPlaylists;
        private Panel panel1;
        private SongSearch ssSongSearch;
        private Controls.PlaylistDetail pdPlaylistDetail;
        private Button btnFindSongs;
        private Button btnNewPlaylist;
        private ContextMenuStrip ctxmPlaylistOptions;
        private ToolStripMenuItem miTransfer;
        private ToolStripMenuItem miSynchronize;
        private ToolStripMenuItem asdToolStripMenuItem;
    }
}
