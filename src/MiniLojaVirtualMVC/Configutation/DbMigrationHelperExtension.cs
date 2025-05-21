using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MiniLojaVirtual.Commom.Data;
using MiniLojaVirtual.Commom.Model;

namespace MiniLojaVirtual.Mvc.Configutation
{
    public static class DbMigrationHelperExtension
    {
        public static void UseDbMigrationHelper(this WebApplication app)
        {
            DbMigrationHelpers.EnsureSeedData(app).Wait();
        }
    }

    public static class DbMigrationHelpers
    {
        public static async Task EnsureSeedData(WebApplication serviceScope)
        {
            var services = serviceScope.Services.CreateScope().ServiceProvider;
            await EnsureSeedData(services);
        }

        public static async Task EnsureSeedData(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope();
            var env = scope.ServiceProvider.GetRequiredService<IWebHostEnvironment>();

            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            if (env.IsDevelopment())
            {
                await context.Database.MigrateAsync();

                await EnsureSeedProducts(context);
            }
        }

        private static async Task EnsureSeedProducts(ApplicationDbContext context)
        {

            if (context.Users.Any())
                return;

            var userId = Guid.NewGuid().ToString();

            await context.Users.AddAsync(new IdentityUser
            {
                Id = userId,
                UserName = "teste@teste.com",
                NormalizedUserName = "TESTE@TESTE.COM",
                Email = "teste@teste.com",
                NormalizedEmail = "TESTE@TESTE.COM",
                AccessFailedCount = 0,
                LockoutEnabled = false,
                PasswordHash = "AQAAAAIAAYagAAAAEFgVnnpkALy2OnEd8461SF1y+my6Qi0b3ZQL59YWqBY9EYzt/4pTeDFUPo0UoXRZzQ==",
                TwoFactorEnabled = false,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            });

            await context.Vendedor.AddAsync(
                new Vendedor()
                {
                    Id = userId,
                    Nome = "Vendedor Teste"
                });

            var categoria = new Categoria()
            {
                Descricao = "Categoria Descrição",
                Name = "Categoria Nome"
            };


            await context.Categoria.AddAsync(
                categoria
                );

            await context.Produto.AddAsync(
                new Produto()
                {
                    Categoria = categoria,
                    Descricao = "Descrição do Produto",
                    Estoque = 100,
                    Nome = "Nome Produto",
                    Preco = 1099,
                    VendedorId = userId
                });

            await context.SaveChangesAsync();
        }
    }
}