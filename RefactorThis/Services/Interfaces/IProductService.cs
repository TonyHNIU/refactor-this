﻿using refactor_me.Models.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace refactor_me.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductsByName(string name);
        Task<Product> GetProductsById(Guid id);
        Task<Product> CreateProduct(Product product);
        Task<Product> UpdateProduct(Guid id, Product product);
        Task DeleteProduct(Guid id);
        Task<IEnumerable<ProductOption>> GetProductOptionByProductId(Guid productId);
        Task<ProductOption> GetProductOptionById(Guid id);
        Task<ProductOption> CreateProductOption(Guid productId, ProductOption productOption);
        Task<ProductOption> UpdateProductOption(Guid id, ProductOption productOption);
        Task DeleteProductOption(Guid id);
    }
}