using Microsoft.EntityFrameworkCore;
using TimeLineApi.Models;

namespace TimeLineApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Evento> Eventos { get; set; } // Exemplo de tabela
    }
}
