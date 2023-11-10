using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador2_YouTify
{
    public static class DatabaseConnectionHelper
    {
        public static string GetConnectionString()
        {
            return "Server=DESKTOP-GBUDS7S\\SQLEXPRESS;Database=YouTify;User Id=sa;Password=Axoft2010;";//FileHelper.ReadConnectionString();
        }
    }
}

