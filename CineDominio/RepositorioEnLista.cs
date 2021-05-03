using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineDominio
{
    public class RepositorioEnLista<T> : IRepositorio<T> where T : class
    {
        private List<T> entidades;

        public RepositorioEnLista()
        {
            this.entidades = new List<T>();
        }

        public void Agregar(T entidad)
        {
            this.entidades.Add(entidad);
        }

        public int CantidadDeElementos()
        {
            return this.entidades.Count;
        }

        public T Get(T entidad)
        {
            return this.entidades.Where(e => e.Equals(entidad)).FirstOrDefault();
        }
    }
}
