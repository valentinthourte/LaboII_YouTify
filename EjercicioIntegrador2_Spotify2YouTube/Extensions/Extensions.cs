using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador2_YouTify.Extensions
{
    public static class DirectoryExtensions
    {
        public static string GetAssetsFilePath()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "assets/");
        }
    }

}
