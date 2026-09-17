using Microsoft.EntityFrameworkCore;

namespace GestorOrdemDeServico.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}

