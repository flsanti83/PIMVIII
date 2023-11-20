using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity;
using PIM_VIII.Models;
using System.Data.Entity;

namespace PIM_VIII.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
    }
}