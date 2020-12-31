using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleShop.ApplicationCore.Entities;

namespace SimpleShop.ApplicationCore.Interfaces
{
    public interface IProductService
    {
        public Task<IEnumerable<Product>> GetAllProduct();

        public Task<Product> GetProductById(int id);

        public Task AddNewProduct(Product product);

        public Task UpdateProduct(int id, Product product);

        public Task DeleteProductAsync(int productId);
    }
}