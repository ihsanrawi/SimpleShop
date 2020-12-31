using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleShop.ApplicationCore.Entities;
using SimpleShop.ApplicationCore.Interfaces;

namespace SimpleShop.ApplicationCore.Services
{
    public class ProductService : IProductService
    {
        private readonly IAsyncRepository<Product> _productRepository;

        public ProductService(IAsyncRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            return await _productRepository.ListAllAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task AddNewProduct(Product product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task UpdateProduct(int id, Product product)
        {
            var productToUpdate = await _productRepository.GetByIdAsync(id);

            if (productToUpdate == null)
            {
                return;
            }

            productToUpdate.Name = product.Name;
            productToUpdate.Description = product.Description;
            productToUpdate.Price = product.Price;
            
            await _productRepository.UpdateAsync(productToUpdate);
        }
        
        public async Task DeleteProductAsync(int productId)
        {
            var basket = await _productRepository.GetByIdAsync(productId);
            await _productRepository.DeleteAsync(basket);
        }
    }
}