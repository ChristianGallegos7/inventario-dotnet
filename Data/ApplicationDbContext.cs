using Inventario.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    private DbSet<Producto> Productos { get; set; }

    private DbSet<Categoria> Categorias { get; set; }
}