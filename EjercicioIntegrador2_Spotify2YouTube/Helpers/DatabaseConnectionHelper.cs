using EjercicioIntegrador2_YouTify.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador2_YouTify.Helpers
{
    public static class DatabaseConnectionHelper
    {
        public static string GetConnectionString()
        {
            return "Server=DESKTOP-GBUDS7S\\SQLEXPRESS;Database=YouTify;User Id=sa;Password=Axoft2010;";//FileHelper.ReadConnectionString();
        }

        public async static Task<SqlDataReader> ExecuteSelectQuery(string query)
        {
            SqlDataReader dataReader;
            using (SqlConnection sql = new SqlConnection(DatabaseConnectionHelper.GetConnectionString()))
            {
                try
                {
                    await sql.OpenAsync();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = sql;
                        command.CommandType = System.Data.CommandType.Text;
                        command.CommandText = query;
                        dataReader = await command.ExecuteReaderAsync();
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return dataReader;
        }

    }
}

