using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace EjercicioIntegrador2_YouTify.Interfaces
{
    public interface IEntity
    {
        /// <summary>
        /// se utiliza la interfaz “IEntity” para especificar que funcionalidades deberían cumplir todas
        /// las entidades que forman parte del modelo del sistema. 
        /// Dichas entidades serán capaces de instanciarse a sí mismas a través de un
        /// objeto “SqlDataReader”, ya que es su responsabilidad conocer los campos que
        /// deben obtener y donde deberían asignarlos.También obliga a las entidades a
        /// implementar la obtención de campos y valores necesarios para ejecutar una
        /// consulta de inserción en una base de datos SQL.
        /// </summary>
        /// <param name="dataReader"></param>
        public void MapFromDatabase(SqlDataReader dataReader);
        public string GetInsertFields();
        public string GetInsertValues();
        public string GetSqlId();
    }
}