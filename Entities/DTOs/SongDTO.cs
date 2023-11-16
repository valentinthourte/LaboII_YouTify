using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class SongDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
