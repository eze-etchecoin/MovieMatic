using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Actor
    {
        public string NombreApellido { get; set; }
        public List<Pelicula> Filmografia { get; set; }
    }
}
