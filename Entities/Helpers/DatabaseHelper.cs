using EjercicioIntegrador2_YouTify.Interfaces;
using Entities.Exceptions;
using System.Data.SqlClient;

namespace EjercicioIntegrador2_YouTify.Helpers
{
    public static class DatabaseHelper
    {
        public static string GetConnectionString()
        {
            return FileHelper.ReadConnectionString();
        }
        /// <summary>
        /// Executes a reader-type query recieved by parameter to the database specified in DatabaseHelper.GetConnectionString()
        /// and returns a List of obtained values mapped to an IEntity type class
        /// </summary>
        /// <typeparam name="T">Has to implement IEntity, will be type of return list</typeparam>
        /// <param name="query">SQL query to execute against the database.</param>
        /// <returns>A list of T objects</returns>
        public async static Task<IEnumerable<T>> ExecuteSelectQuery<T>(string query) where T : IEntity, new()
        {
            List<T> returnList = new List<T>();
            using (SqlConnection sql = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                try
                {
                    await sql.OpenAsync();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = sql;
                        command.CommandType = System.Data.CommandType.Text;
                        command.CommandText = query;
                        SqlDataReader dataReader = await command.ExecuteReaderAsync();
                        while (dataReader.Read())
                        {
                            T element = new T();
                            element.MapFromDatabase(dataReader);
                            returnList.Add(element);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return returnList;
        }

        internal static async Task ExecuteInsertQuery(string query)
        {
            using (SqlConnection sql = new SqlConnection(DatabaseHelper.GetConnectionString()))
            {
                try
                {
                    await sql.OpenAsync();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = sql;
                        command.CommandType = System.Data.CommandType.Text;
                        command.CommandText = query;
                        await command.ExecuteNonQueryAsync();
                    }
                }
                catch (Exception ex)
                {
                    throw new EDatabaseInsertError($"There was an error executing insert query: {ex.GetType()}: {ex.Message}", ex);
                }
            }
        }
    }
}

