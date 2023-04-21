using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3.Entities
{
    public class Artist
    {
        public int IdArtist { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public virtual Artwork Artwork { get; set; }


    }
}
