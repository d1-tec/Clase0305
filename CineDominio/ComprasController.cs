using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineDominio
{
    public class ComprasController
    {
        private PeliculasController peliculasController;

        public ComprasController(PeliculasController peliculasController)
        {
            this.peliculasController = peliculasController;
        }

        public int ProcesarCompra(Pelicula pelicula, int cantidadDeEntradas)
        {
            if (!peliculasController.ExistePelicula(pelicula)) throw new PeliculaNoExisteException();

            return pelicula.Costo* cantidadDeEntradas;
        }
    }
}
