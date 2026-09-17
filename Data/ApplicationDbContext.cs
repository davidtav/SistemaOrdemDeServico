using Microsoft.EntityFrameworkCore;
using GestorOrdemDeServico.Models;
namespace GestorOrdemDeServico.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; } = null!;

        public DbSet<OrdemServico> OrdensServico { get; set; } = null!;
        public DbSet<CategoriaServico> CategoriasServico { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrdemServico>()
                .HasOne(o => o.Cliente)
                .WithMany(c => c.Ordens)
                .HasForeignKey(o => o.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrdemServico>()
                .HasOne(o => o.CategoriaServico)
                .WithMany(c => c.Ordens)
                .HasForeignKey(o => o.CategoriaServicoId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<CategoriaServico>().HasData(
                new CategoriaServico { Id = 1, Nome = "Manutenção", Descricao = "Reparos e manutenção geral" },
                new CategoriaServico { Id = 2, Nome = "Instalação", Descricao = "Instalação de equipamentos e sistemas" },
                new CategoriaServico { Id = 3, Nome = "Consultoria", Descricao = "Serviços de consultoria técnica e suporte" }
                );

        }
    }
}
