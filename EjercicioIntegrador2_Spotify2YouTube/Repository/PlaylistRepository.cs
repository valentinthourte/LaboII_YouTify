using EjercicioIntegrador2_YouTify.Helpers;
using EjercicioIntegrador2_YouTify.Model;
using System.Data.SqlClient;

namespace EjercicioIntegrador2_YouTify.Repository
{
    internal class PlaylistRepository
    {
        internal async static Task<List<Playlist>> GetPlaylists()
        {
            string tableName = $"playlists";
            string query = QueryHelper.GetPlaylistsQuery();
            List<Playlist> returnList = new List<Playlist>();


            SqlDataReader dataReader = await DatabaseConnectionHelper.ExecuteSelectQuery(query);

            while (dataReader.Read())
            {
                string id = dataReader["id"].ToString();
                string name = dataReader["name"].ToString();
                string filePath = dataReader["filePath"].ToString();
                string owner = dataReader["owner"].ToString();

                returnList.Add(new Playlist(id, name, filePath, owner));
            }
            return returnList;
        }
    }
}