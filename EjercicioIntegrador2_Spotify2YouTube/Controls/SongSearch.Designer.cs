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
            lvSongList = new ListView();
            SuspendLayout();
            // 
            // lvSongList
            // 
            lvSongList.Location = new Point(0, 0);
            lvSongList.Name = "lvSongList";
            lvSongList.Size = new Size(993, 543);
            lvSongList.TabIndex = 0;
            lvSongList.UseCompatibleStateImageBehavior = false;
            // 
            // SongSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lvSongList);
            Name = "SongSearch";
            Size = new Size(993, 543);
            ResumeLayout(false);
        }

        #endregion

        private ListView lvSongList;
    }
}
