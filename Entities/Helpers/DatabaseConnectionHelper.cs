﻿using EjercicioIntegrador2_YouTify.Interfaces;
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

        public async static Task<IEnumerable<T>> ExecuteSelectQuery<T>(string query) where T : IEntity, new()
        {
            List<T> returnList = new List<T>();
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

    }
}
