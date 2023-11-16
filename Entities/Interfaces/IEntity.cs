using System.Data.SqlClient;

namespace EjercicioIntegrador2_YouTify.Interfaces
{
    public interface IEntity
    {
        public void MapFromDatabase(SqlDataReader dataReader);

        public string InsertFields();
        public string InsertValues();
    }
}