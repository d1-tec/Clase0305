using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineDominio
{
    public interface IRepositorio<T>
    {
        void Agregar(T entidad);
        int CantidadDeElementos();
        T Get(T entidad);
    }
}
