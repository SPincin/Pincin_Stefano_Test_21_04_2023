using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio3.Entities
{
    public class Artwork
    {
        public int IdArtwork { get; set; }
        public string Name { get; set; }
        public int IdMuseum { get; set; }
        public int IdArtist { get; set; }
        public int IdCharacter { get; set; }
        public virtual Museum Museum { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Character Character { get; set; }




    }
}
