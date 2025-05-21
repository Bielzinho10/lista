using Microsoft.EntityFrameworkCore;
using lista.Models; // ou o namespace correto da sua classe Lista

namespace lista.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Adicione seus DbSets aqui, por exemplo:
        // public DbSet<SeuModelo> SeusModelos { get; set; }
        public DbSet<Lista> Listas { get; set; }
    }
}