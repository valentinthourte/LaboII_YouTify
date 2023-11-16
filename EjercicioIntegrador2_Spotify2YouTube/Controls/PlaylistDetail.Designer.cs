namespace EjercicioIntegrador2_YouTify.Controls
{
    partial class PlaylistDetail
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
            lblPlaylistName = new Label();
            lblPlaylistOwner = new Label();
            lblPlaylistIcon = new Label();
            ssPlaylistSongs = new SongSearch();
            SuspendLayout();
            // 
            // lblPlaylistName
            // 
            lblPlaylistName.AutoSize = true;
            lblPlaylistName.Font = new Font("Roboto", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlaylistName.Location = new Point(8, 8);
            lblPlaylistName.Name = "lblPlaylistName";
            lblPlaylistName.Size = new Size(223, 41);
            lblPlaylistName.TabIndex = 0;
            lblPlaylistName.Text = "PlaylistName";
            // 
            // lblPlaylistOwner
            // 
            lblPlaylistOwner.AutoSize = true;
            lblPlaylistOwner.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlaylistOwner.Location = new Point(23, 59);
            lblPlaylistOwner.Name = "lblPlaylistOwner";
            lblPlaylistOwner.Size = new Size(55, 19);
            lblPlaylistOwner.TabIndex = 1;
            lblPlaylistOwner.Text = "Owner";
            // 
            // lblPlaylistIcon
            // 
            lblPlaylistIcon.AutoSize = true;
            lblPlaylistIcon.Location = new Point(22, 41);
            lblPlaylistIcon.Name = "lblPlaylistIcon";
            lblPlaylistIcon.Size = new Size(0, 15);
            lblPlaylistIcon.TabIndex = 3;
            // 
            // ssPlaylistSongs
            // 
            ssPlaylistSongs.Location = new Point(0, 95);
            ssPlaylistSongs.Name = "ssPlaylistSongs";
            ssPlaylistSongs.SecondaryColor = SystemColors.Window;
            ssPlaylistSongs.Size = new Size(993, 448);
            ssPlaylistSongs.TabIndex = 4;
            // 
            // PlaylistDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ssPlaylistSongs);
            Controls.Add(lblPlaylistIcon);
            Controls.Add(lblPlaylistOwner);
            Controls.Add(lblPlaylistName);
            Name = "PlaylistDetail";
            Size = new Size(993, 543);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlaylistName;
        private Label lblPlaylistOwner;
        private Label lblPlaylistIcon;
        private SongSearch ssPlaylistSongs;
    }
}
