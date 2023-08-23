using cp1_enterprise.Models;
using Microsoft.EntityFrameworkCore;

namespace cp1_enterprise.Persistence
{
    public class OracleDbContext : DbContext
    {
        public DbSet<Hospede> Hospede { get; set; }

        public DbSet<Quarto> Quarto { get; set; }

        public DbSet<Reserva> Reserva { get; set; }

        public DbSet<Pagamento> Pagamento { get; set; }

        public DbSet<TipoQuarto> TipoQuarto { get; set; } 

        public OracleDbContext(DbContextOptions<OracleDbContext> options) : base(options) { }
    }
}
