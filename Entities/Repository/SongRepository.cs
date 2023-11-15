using EjercicioIntegrador2_YouTify.Enums;
using EjercicioIntegrador2_YouTify.Helpers;
using EjercicioIntegrador2_YouTify.Model;
using Entities.Model;

namespace EjercicioIntegrador2_YouTify.Repository
{
    internal class SongRepository
    {
        internal static async Task<SongList> GetSongs(EPlatform platform)
        {
            string tableName = $"{platform}Songs";
            string query = QueryHelper.GetSongsQuery(tableName);

            return (List<Song>)await DatabaseConnectionHelper.ExecuteSelectQuery<Song>(query);
        }
    }
}