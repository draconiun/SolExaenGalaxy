using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSQL.Helper
{
    public interface IRecibeSuscripcion
    {
        Task PreparaFiltro();
        Task CierraSuscripcionCliente();
    }
}
