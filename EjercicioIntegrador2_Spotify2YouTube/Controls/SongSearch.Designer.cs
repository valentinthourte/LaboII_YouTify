namespace EjercicioIntegrador2_YouTify
{
    partial class SongSearch
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
            lvSongList = new ListView();
            tbSearch = new TextBox();
            ctxmSongContextMenu = new ContextMenuStrip(components);
            miAddSongToPlaylist = new ToolStripMenuItem();
            miRemove = new ToolStripMenuItem();
            btnExport = new Button();
            ctxmSongContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lvSongList
            // 
            lvSongList.Location = new Point(0, 28);
            lvSongList.Name = "lvSongList";
            lvSongList.Size = new Size(993, 515);
            lvSongList.TabIndex = 0;
            lvSongList.UseCompatibleStateImageBehavior = false;
            lvSongList.MouseClick += lvSongList_MouseClick;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(134, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search";
            tbSearch.Size = new Size(343, 23);
            tbSearch.TabIndex = 1;
            tbSearch.KeyPress += tbSearch_KeyPress;
            // 
            // ctxmSongContextMenu
            // 
            ctxmSongContextMenu.Items.AddRange(new ToolStripItem[] { miAddSongToPlaylist, miRemove });
            ctxmSongContextMenu.Name = "ctxmSongContextMenu";
            ctxmSongContextMenu.Size = new Size(151, 48);
            // 
            // miAddSongToPlaylist
            // 
            miAddSongToPlaylist.Name = "miAddSongToPlaylist";
            miAddSongToPlaylist.Size = new Size(150, 22);
            miAddSongToPlaylist.Text = "Add to playlist";
            miAddSongToPlaylist.Click += miAddSongToPlaylist_Click;
            // 
            // miRemove
            // 
            miRemove.Enabled = false;
            miRemove.Name = "miRemove";
            miRemove.Size = new Size(150, 22);
            miRemove.Text = "Remove";
            // 
            // btnExport
            // 
            btnExport.Location = new Point(885, 2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(75, 23);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export to...";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // SongSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExport);
            Controls.Add(tbSearch);
            Controls.Add(lvSongList);
            Name = "SongSearch";
            Size = new Size(993, 543);
            ctxmSongContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvSongList;
        private TextBox tbSearch;
        private ContextMenuStrip ctxmSongContextMenu;
        private ToolStripMenuItem miAddSongToPlaylist;
        private ToolStripMenuItem miRemove;
        private Button btnExport;
    }
}
