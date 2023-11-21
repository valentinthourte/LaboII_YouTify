using EjercicioIntegrador2_YouTify.Interfaces;
using Entities.DTOs;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace EjercicioIntegrador2_YouTify.Model
{
    public class Song : IEntity
    {
        private int id;
        private string name;
        private string artistName;
        private DateTime creationDate;

        public static string SelectFields()
        {
            return $"songs.id, songs.title, songs.artist,songs.creationDate";
        }
        public string GetInsertFields()
        {
            return $"'title','artist','creationDate'";
        }

        public string GetInsertValues()
        {
            return $"'{this.name}','{this.artistName}','{DateTime.Now}'";
        }

        public string GetSqlId()
        {
            return this.id.ToString();
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
            dto.Artist = song.artistName;
            dto.CreationDate = song.creationDate;
            return dto;
        }
        public static explicit operator Song(SongDTO dto)
        {
            Song song = new Song();
            song.id = dto.Id;
            song.name = dto.Name;
            song.artistName = dto.Artist;
            song.creationDate = dto.CreationDate;
            return song;
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Song && this.id == ((Song)obj).id;
        }

    }
}