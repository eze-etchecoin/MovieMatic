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

        public IOrderedEnumerable<Pelicula> BuscarPeliculaPorNombre(string nombre)
        {
            nombre.ToLower();

            var pelisObtenidas =
                                    from peliActual in _peliteca
                                    where peliActual.Nombre.ToLower().Equals(nombre)
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

        public IOrderedEnumerable<Pelicula> BuscarPeliculaPorGenero(string genero)
        {
            genero.ToLower();

            var pelisObtenidas =
                                    from peliActual in _peliteca
                                    where peliActual.Genero.ToLower().Equals(genero)
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
        
        public Pelicula BuscarPeliculaPorAnio(int anio)
        {
            
            foreach (Pelicula peliactual in _peliteca)
            {
                if (peliactual.AnioEstreno.Equals(anio))
                {
                    return peliactual;
                }
            }

            return null;
        }

        public IOrderedEnumerable<Pelicula> BuscarPeliculaPorDirector(string director)
        {
            director.ToLower();

            var pelisObtenidas =
                                    from peliActual in _peliteca
                                    where peliActual.Director.ToLower().Equals(director)
                                    orderby peliActual.Director
                                    select peliActual;

            return pelisObtenidas;
        }

        public List<Pelicula> BuscarPeliculaPorActor(string nombreActor)
        {
            foreach (var actor in _actores)
            {
                if (actor.NombreApellido.Equals(nombreActor))
                {
                    return actor.Filmografia;
                }
            }

            return null;
        }
    }
}
