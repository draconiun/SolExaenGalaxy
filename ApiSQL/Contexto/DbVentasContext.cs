using ApiSQL.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiSQL.Contexto
{
    public class DbVentasContext : DbContext
    {
        public DbVentasContext(DbContextOptions<DbVentasContext> options) : base(options)
        {

        }

        public DbSet<Compra> Compra { get; set; }
    }
}
