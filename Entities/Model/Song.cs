using EjercicioIntegrador2_YouTify.Interfaces;
using Entities.DTOs;
using System.Data.SqlClient;

namespace EjercicioIntegrador2_YouTify.Model
{
    public class Song : IEntity
    {
        private int id;
        private string name;
        private string artistName;
        private DateTime creationDate;

        public string InsertFields()
        {
            return $"'title','artist','creationDate'";
        }

        public string InsertValues()
        {
            return $"'{this.name}','{this.artistName}','{DateTime.Now}'";
        }

        public void MapFromDatabase(SqlDataReader dataReader)
        {
            this.id = (int)dataReader["id"];
            this.name = dataReader["title"].ToString();
            this.artistName = dataReader["artist"].ToString();
            this.creationDate = DateTime.Parse(dataReader["creationDate"].ToString());
        }

        public static explicit operator SongDTO(Song song)
        {
            SongDTO dto = new SongDTO();
            dto.Id = song.id;
            dto.Name = song.name;
            dto.Artist= song.artistName;
            dto.CreationDate = song.creationDate;
            return dto;
        }

    }
}