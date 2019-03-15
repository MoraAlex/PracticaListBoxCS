using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoPirataSpotify
{
    class Metadata
    {
        public Metadata(string artista, string album, int anio, string genero)
        {
            this.artista = artista;
            this.album = album;
            this.anio = anio;
            this.genero = genero;
        }
        public string artista { get; set; }
        public string album { get; set; }
        public int anio { get; set; }
        public string genero { get; set; }

        public override string ToString() {
            return artista + "\r\n" + album + "\r\n" + anio + "\r\n" + genero + "\r\n";
        }
    }
}

