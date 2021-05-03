using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineDominio
{
    public class Pelicula
    {
        public string Nombre { get; set; }
        public int Costo { get; set; }

        public override bool Equals(object obj)
        {
            Pelicula otraPelicula = obj as Pelicula;

            if (otraPelicula == null) return false;

            return this.Nombre.Equals(otraPelicula.Nombre);
        }
    }
}
