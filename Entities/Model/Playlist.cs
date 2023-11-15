using EjercicioIntegrador2_YouTify.Interfaces;
using Entities.DTOs;
using System.Data.SqlClient;

namespace Entities.Model
{
    public class Playlist : IEntity
    {
        private string id;
        private string name;
        private string iconFilePath;
        private string owner;

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



        public void MapFromDatabase(SqlDataReader dataReader)
        {
            this.id = dataReader["id"].ToString();
            this.name = dataReader["name"].ToString();
            this.iconFilePath = dataReader["iconFilePath"].ToString();
            this.owner = dataReader["owner"].ToString();
        }

        public static implicit operator PlaylistDTO(Playlist playlist)
        {
            PlaylistDTO dto = new();
            dto.Id = playlist.id;
            dto.Name = playlist.name;
            dto.Owner = playlist.owner;
            dto.IconFilePath = playlist.iconFilePath;
            
            return dto;
        }

    }
}
