namespace YouTify.Forms
{
    partial class frmAddToPlaylist
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbSelectedSongs = new RichTextBox();
            lblItems = new Label();
            cbPlaylists = new ComboBox();
            lblSelectPlaylist = new Label();
            btnDone = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // rtbSelectedSongs
            // 
            rtbSelectedSongs.Location = new Point(12, 38);
            rtbSelectedSongs.Name = "rtbSelectedSongs";
            rtbSelectedSongs.ReadOnly = true;
            rtbSelectedSongs.Size = new Size(460, 293);
            rtbSelectedSongs.TabIndex = 0;
            rtbSelectedSongs.Text = "";
            // 
            // lblItems
            // 
            lblItems.AutoSize = true;
            lblItems.Location = new Point(199, 9);
            lblItems.Name = "lblItems";
            lblItems.Size = new Size(88, 15);
            lblItems.TabIndex = 1;
            lblItems.Text = "Selected songs:";
            lblItems.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbPlaylists
            // 
            cbPlaylists.FormattingEnabled = true;
            cbPlaylists.Location = new Point(119, 362);
            cbPlaylists.Name = "cbPlaylists";
            cbPlaylists.Size = new Size(244, 23);
            cbPlaylists.TabIndex = 2;
            // 
            // lblSelectPlaylist
            // 
            lblSelectPlaylist.AutoSize = true;
            lblSelectPlaylist.Location = new Point(199, 344);
            lblSelectPlaylist.Name = "lblSelectPlaylist";
            lblSelectPlaylist.Size = new Size(87, 15);
            lblSelectPlaylist.TabIndex = 3;
            lblSelectPlaylist.Text = "Select a playlist";
            // 
            // btnDone
            // 
            btnDone.Location = new Point(136, 401);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(75, 23);
            btnDone.TabIndex = 4;
            btnDone.Text = "Add";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(256, 401);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddToPlaylist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnDone);
            Controls.Add(lblSelectPlaylist);
            Controls.Add(cbPlaylists);
            Controls.Add(lblItems);
            Controls.Add(rtbSelectedSongs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmAddToPlaylist";
            Text = "Add to playlist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbSelectedSongs;
        private Label lblItems;
        private ComboBox cbPlaylists;
        private Label lblSelectPlaylist;
        private Button btnDone;
        private Button btnCancel;
    }
}