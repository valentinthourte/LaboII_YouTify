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
            lvPlaylists = new ListView();
            Playlist = new ColumnHeader();
            ilPlaylistIcons = new ImageList(components);
            pnlPlaylistList.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPlaylistList
            // 
            pnlPlaylistList.Controls.Add(lvPlaylists);
            pnlPlaylistList.Location = new Point(0, 0);
            pnlPlaylistList.Name = "pnlPlaylistList";
            pnlPlaylistList.Size = new Size(242, 620);
            pnlPlaylistList.TabIndex = 0;
            // 
            // lvPlaylists
            // 
            lvPlaylists.Columns.AddRange(new ColumnHeader[] { Playlist });
            listViewItem1.Checked = true;
            listViewItem1.StateImageIndex = 1;
            lvPlaylists.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            lvPlaylists.Location = new Point(0, 0);
            lvPlaylists.Name = "lvPlaylists";
            lvPlaylists.Size = new Size(236, 620);
            lvPlaylists.TabIndex = 1;
            lvPlaylists.UseCompatibleStateImageBehavior = false;
            // 
            // ilPlaylistIcons
            // 
            ilPlaylistIcons.ColorDepth = ColorDepth.Depth8Bit;
            ilPlaylistIcons.ImageSize = new Size(16, 16);
            ilPlaylistIcons.TransparentColor = Color.Transparent;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlPlaylistList);
            Name = "MainPage";
            Size = new Size(1288, 620);
            pnlPlaylistList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPlaylistList;
        private ListBox listBox1;
        private ListView lvPlaylists;
        private ColumnHeader Playlist;
        private ImageList ilPlaylistIcons;
    }
}
