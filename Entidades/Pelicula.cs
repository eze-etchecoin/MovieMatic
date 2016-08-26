using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Entidades
{
    public class Pelicula
    {
        public string Nombre { get; set; }
        public int AnioEstreno { get; set; }
        public string Genero { get; set; }
        public List<Actor> Actores { get; set; }
        public string Director { get; set; }
        public string Sinopsis { get; set; }


    }
}
