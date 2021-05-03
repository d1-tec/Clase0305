using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineDominio
{
    public class PeliculasController
    {
        private IRepositorio<Pelicula> repositorioPeliculas;

        public PeliculasController()
        {
            this.repositorioPeliculas = new RepositorioEnLista<Pelicula>();
        }

        public void AgregarPelicula(string nombre, int costo)
        {
            this.repositorioPeliculas.Agregar(new Pelicula() { Nombre = nombre, Costo = costo });
        }

        public bool ExistePelicula(Pelicula pelicula)
        {
            return this.repositorioPeliculas.Get(pelicula) != null;
        }

        public int CantidadDePeliculas() => this.repositorioPeliculas.CantidadDeElementos();
    }
}
