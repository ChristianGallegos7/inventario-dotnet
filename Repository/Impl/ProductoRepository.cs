using Inventario.Data;
using Inventario.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Repository.IRepository.Impl;

public class ProductoRepository : IProductoRepository
{
    private readonly ApplicationDbContext _db;

    public ProductoRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<IEnumerable<Producto>> GetAllProducts()
    {
        var products = await _db.Productos.ToListAsync();
        return products;
    }

    public Task<Producto> GetProductById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Producto> AddProduct(Producto product)
    {
        throw new NotImplementedException();
    }

    public bool UpdateProduct(Producto product)
    {
        throw new NotImplementedException();
    }

    public bool DeleteProduct(Producto product)
    {
        throw new NotImplementedException();
    }
}