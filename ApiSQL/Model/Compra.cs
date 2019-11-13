using System.ComponentModel.DataAnnotations;

namespace ApiSQL.Model
{
    public class Compra
    {
        [Key]
        public int IdCompra { get; set; }
        public string NombreProveedor { get; set; }
        public decimal Monto { get; set; }
    }
}
