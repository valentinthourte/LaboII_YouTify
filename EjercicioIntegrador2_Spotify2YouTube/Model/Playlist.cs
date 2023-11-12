using EjercicioIntegrador2_YouTify.Interfaces;
using System.Data.SqlClient;

namespace EjercicioIntegrador2_YouTify.Model
{
    internal class Playlist : IEntity
    {
        private static string defaultIconFilePath;
        private string id;
        private string name;
        private string iconFilePath;
        private string owner;

        static Playlist()
        {
            Playlist.defaultIconFilePath = "noicon.png";
        }

        public Playlist()
        {
            this.id = "-1";
            this.name = "";
            this.iconFilePath = "";
            this.owner = "";
        }

        public Playlist(string id, string name, string filePath, string owner)
        {
            this.id = id;
            this.name = name;
            this.iconFilePath = filePath;
            this.owner = owner;
        }

        public string ImageName { get => this.id; }

        public void MapFromDatabase(SqlDataReader dataReader)
        {
            this.id = dataReader["id"].ToString();
            this.name = dataReader["name"].ToString();
            this.iconFilePath = dataReader["iconFilePath"].ToString();
            this.owner = dataReader["owner"].ToString();
        }

        internal string GetIconFileName(string directory)
        {
            return File.Exists(Path.Combine(directory, iconFilePath)) ? Path.Combine(directory, iconFilePath) : Path.Combine(directory, defaultIconFilePath);
        }

        public static explicit operator ListViewItem(Playlist playlist)
        {
            ListViewItem item = new ListViewItem(playlist.name);
            item.ImageKey = playlist.id;
            return item;
        }

    }
}
