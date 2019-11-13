using ApiSQL.Contexto;
using ApiSQL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ApiSQL.Services
{
    public class ProcesaDatos : IProcesaDatos
    {
        private readonly IOptions<ParametroConfig> options;

        public ProcesaDatos(IOptions<ParametroConfig> options)
        {
            this.options = options;
        }
        public void Registrar(Compra compra)
        {
            var opciones = new DbContextOptionsBuilder<DbVentasContext>();
            opciones.UseSqlServer(options.Value.CnnBd);

            using (DbVentasContext context = new DbVentasContext(opciones.Options))
            {
                context.Compra.Add(compra);
                context.SaveChanges();
            }
        }
    }

    public interface IProcesaDatos
    {
        void Registrar(Compra compra);
    }
}
