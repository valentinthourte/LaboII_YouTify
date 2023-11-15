using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PlaylistDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string IconFilePath { get; set; }
        public string Owner { get; set; }
    }
}
