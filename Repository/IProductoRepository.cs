using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventario.Models;

namespace Inventario.Repository.IRepository
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetAllProducts();

        Task<Producto> GetProductById(int id);
        
        Task<Producto> AddProduct(Producto product);

        bool UpdateProduct(Producto product);

        bool DeleteProduct(Producto product);
    }
}