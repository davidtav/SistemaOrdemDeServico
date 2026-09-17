using Microsoft.EntityFrameworkCore;
using GestorOrdemDeServico.Models;
namespace GestorOrdemDeServico.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; } = null!;

        public DbSet<OrdemServico> OrdensServico { get; set; } = null!;
        public DbSet<CategoriaServico> CategoriasServico { get; set; } = null!;
       
    }
}

