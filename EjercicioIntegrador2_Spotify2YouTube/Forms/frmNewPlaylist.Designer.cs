namespace YouTify
{
    partial class frmNewPlaylist
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
            lblPlaylistName = new Label();
            tbPlaylistName = new TextBox();
            tbIconFilePath = new TextBox();
            btnSelectFile = new Button();
            ofdIconFile = new OpenFileDialog();
            btnCreate = new Button();
            lblFilePath = new Label();
            lblWarning = new Label();
            lblMustInsertName = new Label();
            SuspendLayout();
            // 
            // lblPlaylistName
            // 
            lblPlaylistName.AutoSize = true;
            lblPlaylistName.Location = new Point(148, 43);
            lblPlaylistName.Name = "lblPlaylistName";
            lblPlaylistName.Size = new Size(77, 15);
            lblPlaylistName.TabIndex = 0;
            lblPlaylistName.Text = "Playlist name";
            // 
            // tbPlaylistName
            // 
            tbPlaylistName.Location = new Point(42, 68);
            tbPlaylistName.Name = "tbPlaylistName";
            tbPlaylistName.Size = new Size(293, 23);
            tbPlaylistName.TabIndex = 1;
            // 
            // tbIconFilePath
            // 
            tbIconFilePath.Location = new Point(42, 154);
            tbIconFilePath.Name = "tbIconFilePath";
            tbIconFilePath.Size = new Size(263, 23);
            tbIconFilePath.TabIndex = 4;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(307, 154);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(28, 23);
            btnSelectFile.TabIndex = 5;
            btnSelectFile.Text = "...";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // ofdIconFile
            // 
            ofdIconFile.FileName = "openFileDialog1";
            ofdIconFile.FileOk += ofdIconFile_FileOk;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(150, 231);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.Location = new Point(148, 132);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(76, 15);
            lblFilePath.TabIndex = 7;
            lblFilePath.Text = "Icon file path";
            // 
            // lblWarning
            // 
            lblWarning.BackColor = Color.Red;
            lblWarning.Location = new Point(41, 67);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(295, 25);
            lblWarning.TabIndex = 8;
            lblWarning.Visible = false;
            // 
            // lblMustInsertName
            // 
            lblMustInsertName.AutoSize = true;
            lblMustInsertName.ForeColor = Color.Red;
            lblMustInsertName.Location = new Point(42, 94);
            lblMustInsertName.Name = "lblMustInsertName";
            lblMustInsertName.Size = new Size(161, 15);
            lblMustInsertName.TabIndex = 9;
            lblMustInsertName.Text = "This field must not be empty.";
            lblMustInsertName.Visible = false;
            // 
            // frmNewPlaylist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 275);
            Controls.Add(lblMustInsertName);
            Controls.Add(lblFilePath);
            Controls.Add(btnCreate);
            Controls.Add(btnSelectFile);
            Controls.Add(tbIconFilePath);
            Controls.Add(tbPlaylistName);
            Controls.Add(lblPlaylistName);
            Controls.Add(lblWarning);
            Name = "frmNewPlaylist";
            Text = "New Playlist";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlaylistName;
        private TextBox tbPlaylistName;
        private TextBox tbIconFilePath;
        private Button btnSelectFile;
        private OpenFileDialog ofdIconFile;
        private Button btnCreate;
        private Label lblFilePath;
        private Label lblWarning;
        private Label lblMustInsertName;
    }
}