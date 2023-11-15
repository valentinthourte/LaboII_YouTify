using EjercicioIntegrador2_YouTify.Interfaces;
using System.Data.SqlClient;

namespace Entities.Model
{
    public class Song : IEntity
    {
        public int id;
        public string name;
        public string artistName;
        public DateTime creationDate;

        public void MapFromDatabase(SqlDataReader dataReader)
        {
            this.id = (int)dataReader["id"];
            this.name = dataReader["title"].ToString();
            this.artistName = dataReader["artist"].ToString();
            this.creationDate = DateTime.Parse(dataReader["creationDate"].ToString());
        }



    }
}