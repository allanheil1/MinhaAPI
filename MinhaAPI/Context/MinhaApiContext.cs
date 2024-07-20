using Microsoft.EntityFrameworkCore;
using MinhaAPI.Models;

namespace MinhaAPI.Context
{
    public class MinhaApiContext: DbContext
    {
        public MinhaApiContext(DbContextOptions<MinhaApiContext> options) : base (options)
        {
        }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Produto>? Produtos { get; set; }

    }
}
