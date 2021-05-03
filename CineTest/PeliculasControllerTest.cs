using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CineDominio;

namespace CineTest
{
    [TestClass]
    public class PeliculasControllerTest
    {
        [TestMethod]
        public void SeDaDeAltaUnaPeliculaConNombreYCostoValido()
        {
            PeliculasController peliculasController = new PeliculasController();
            peliculasController.AgregarPelicula("Star Wars", 150);
            Assert.AreEqual(peliculasController.CantidadDePeliculas(), 1);
        }

        [TestMethod]
        public void SeDanDeAltaDosPeliculasConNombreYCostoValido()
        {
            PeliculasController peliculasController = new PeliculasController();
            peliculasController.AgregarPelicula("Star Wars", 150);
            peliculasController.AgregarPelicula("Scarface", 200);
            Assert.AreEqual(peliculasController.CantidadDePeliculas(), 2);
        }
    }
}
