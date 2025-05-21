using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MiniLojaVirtual.Commom.Model;

namespace MiniLojaVirtual.Commom.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Produto> Produto { get; set; }
    }
}
