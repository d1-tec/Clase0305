using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CineDominio;

namespace CineTest
{
    [TestClass]
    public class ComprasControllerTest
    {
        private Pelicula pelicula = new Pelicula() { Nombre = "Star Wars", Costo = 150 };
        private PeliculasController peliculasController;

        [TestInitialize]
        public void Setup()
        {
            peliculasController = new PeliculasController();
        }

        [TestMethod]
        public void SeCompranDosEntradasParaUnaPeliculaYSeDevuelveElMonto()
        {
            peliculasController.AgregarPelicula(pelicula.Nombre, pelicula.Costo);
            ComprasController comprasController = new ComprasController(peliculasController);
            
            int montoDeLaCompra = comprasController.ProcesarCompra(pelicula, 2);
            
            Assert.AreEqual(montoDeLaCompra, 300);
        }

        [TestMethod]
        [ExpectedException(typeof(PeliculaNoExisteException))]
        public void SiSeCompraUnaEntradaDeUnaPeliculaQueNoExisteSeDevuelveError()
        {
            ComprasController comprasController = new ComprasController(peliculasController);
            
            comprasController.ProcesarCompra(pelicula, 2);
        }
    }
}
