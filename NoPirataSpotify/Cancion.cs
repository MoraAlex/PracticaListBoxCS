using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoPirataSpotify
{
    class Cancion
    {
        public Cancion(string nombre, string duracion, Metadata metadata)
        {
            this.nombre = nombre;
            this.duracion = duracion;
            this.metadata = metadata;
        }
        public string nombre { get; set; }
        public string duracion { get; set; }
        public Metadata metadata { get; set; }
    }
}
