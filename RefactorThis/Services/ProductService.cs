using refactor_me.Data.Interfaces;
using refactor_me.Models.DbModel;
using refactor_me.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace refactor_me.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllProducts();
        }

        public async Task<Product> GetProductsByName(string name)
        {
            return await _productRepository.GetProductsByName(name);
        }

        public async Task<Product> GetProductsById(Guid id)
        {
            return await _productRepository.GetProductsById(id);
        }

        public async Task<Product> CreateProduct(Product model)
        {
            model.Id = Guid.NewGuid();
            return await _productRepository.CreateProduct(model);
        }

        public async Task<Product> UpdateProduct(Guid id, Product model)
        {
            model.Id = id;
            return await _productRepository.UpdateProduct(model);
        }

        public async Task DeleteProduct(Guid id)
        {
            await _productRepository.DeleteProduct(id);
        }

        public async Task<IEnumerable<ProductOption>> GetProductOptionByProductId(Guid productId)
        {
            return await _productRepository.GetProductOptionByProductId(productId);
        }

        public async Task<ProductOption> GetProductOptionById(Guid id)
        {
            return await _productRepository.GetProductOptionById(id);
        }

        public async Task<ProductOption> CreateProductOption(Guid productId, ProductOption model)
        {
            model.ProductId = productId;
            model.Id = Guid.NewGuid();
            return await _productRepository.CreateProductOption(model);
        }

        public async Task<ProductOption> UpdateProductOption(Guid id, ProductOption model)
        {
            model.Id = id;
            return await _productRepository.UpdateProductOption(model);
        }

        public async Task DeleteProductOption(Guid id)
        {
            await _productRepository.DeleteProductOption(id);
        }
    }
}