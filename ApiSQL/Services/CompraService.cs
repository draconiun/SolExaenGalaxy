using ApiSQL.Contexto;
using ApiSQL.Model;
using System.Collections.Generic;
using System.Linq;

namespace ApiSQL.Services
{
    public class CompraService : ICompraService
    {
        private readonly DbVentasContext _context;
        public CompraService(DbVentasContext context)
        {
            _context = context;
        }
        public List<Compra> Listar()
        {
            return _context.Compra.ToList();
        }

        public Compra Registrar(Compra compra)
        {
            _context.Compra.Add(compra);
            _context.SaveChanges();
            return compra;
        }
    }

    public interface ICompraService
    {
        Compra Registrar(Compra compra);
        List<Compra> Listar();
    }
}
