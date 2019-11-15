using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEnvio.Model
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public string NombreProveedor { get; set; }
        public decimal Monto { get; set; }
    }
}
