using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador2_YouTify.Model
{
    internal class Playlist
    {
        private string id;
        private string name;
        private string filePath;
        private string owner;

        public Playlist(string id, string name, string filePath, string owner)
        {
            this.id = id;
            this.name = name;
            this.filePath = filePath;
            this.owner = owner;
        }

    }
}
