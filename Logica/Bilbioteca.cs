using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class Bilbioteca
    {
        private List<Pelicula> _peliteca = new List<Pelicula>();
        private List<Actor> _actores = new List<Actor>();

        public void AgregarPelicula(Pelicula peliNueva)
        {
            _peliteca.Add(peliNueva);

            foreach (var actorNuevo in peliNueva.Actores)
            {
                actorNuevo.Filmografia.Add(peliNueva);

                foreach (var actorEnBiblioteca in _actores)
                {
                    if (!actorEnBiblioteca.NombreApellido.Equals(actorNuevo.NombreApellido))
                    {
                        _actores.Add(actorNuevo);
                    }
                }
            }
        }

        public IOrderedEnumerable<Pelicula> ObtenerPeliculasPorNombre(string nombre)
        {
            nombre.ToLower();

            var pelisObtenidas =
                                    from peliActual in _peliteca
                                    where peliActual.Nombre.ToLower().Contains(nombre)
                                    orderby peliActual.Nombre
                                    select peliActual;

            return pelisObtenidas;

            //nombre.ToLower();

            //foreach (Pelicula peliactual in _biblioteca)
            //{
            //    peliactual.Nombre.ToLower();

            //    if (peliactual.Nombre.Equals(nombre))
            //    {
            //        return peliactual;
            //    }
            //}

            //return null;
        }

        public List<string> ObtenerGeneros()
        {
            var listaGeneros = new List<string>();

            foreach (var peliActual in _peliteca)
            {
                if (!listaGeneros.Contains(peliActual.Genero))
                {
                    listaGeneros.Add(peliActual.Genero);
                }
                
            }

            return listaGeneros;
        }

        public IOrderedEnumerable<Pelicula> ObtenerPeliculasPorGenero(string genero)
        {
            genero.ToLower();

            var pelisObtenidas =
                                    from peliActual in _peliteca
                                    where peliActual.Genero.ToLower().Contains(genero)
                                    orderby peliActual.Genero
                                    select peliActual;

            return pelisObtenidas;
        }

        public List<int> ObtenerAnios()
        {
            var listaAnios = new List<int>();

            foreach (var peliActual in _peliteca)
            {
                if (!listaAnios.Contains(peliActual.AnioEstreno))
                {
                    listaAnios.Add(peliActual.AnioEstreno);
                }

            }

            return listaAnios;
        }
        
        public IEnumerable<Pelicula> BuscarPeliculasPorAnio(int anio)
        {
            List<Pelicula> pelisEncontradas = new List<Pelicula>();

            foreach (Pelicula peliActual in _peliteca)
            {
                if (peliActual.AnioEstreno == anio)
                {
                    pelisEncontradas.Add(peliActual);
                }
            }

            return pelisEncontradas;
            
        }

        public IOrderedEnumerable<Pelicula> BuscarPeliculasPorDirector(string director)
        {
            director.ToLower();

            var pelisObtenidas =
                                    from peliActual in _peliteca
                                    where peliActual.Director.ToLower().Contains(director)
                                    orderby peliActual.Nombre
                                    select peliActual;

            return pelisObtenidas;
        }

        public List<Pelicula> BuscarPeliculasPorActor(string nombreActor)
        {
            foreach (var actor in _actores)
            {
                if (actor.NombreApellido.Contains(nombreActor))
                {
                    return actor.Filmografia;
                }
            }

            return null;
        }

        public void EliminarPelicula(Pelicula peliADestruir)
        {
            int puntero = _peliteca.IndexOf(peliADestruir);
            _peliteca.RemoveAt(puntero);
        }
    }
}
