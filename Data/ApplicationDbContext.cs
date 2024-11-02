using Inventario.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Producto> Productos { get; set; }

    public DbSet<Categoria> Categorias { get; set; }
}