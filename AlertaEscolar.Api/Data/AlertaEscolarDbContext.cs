
using Microsoft.EntityFrameworkCore;
using AlertaEscolar.Shared.Models;

namespace AlertaEscolar.Api.Data
{
    public class AlertaEscolarDbContext : DbContext
    {
        public AlertaEscolarDbContext(
            DbContextOptions<AlertaEscolarDbContext> options)
            : base(options)
        {
        }

        public DbSet<Caso> Casos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<HistorialCaso> HistorialCasos { get; set; }
    }
}
