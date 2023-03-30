using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        // Task of type Product 
        Task<Product> GetProductsByIdAsync(int id);
        // Returnic an readonly list of products
        Task<IReadOnlyList<Product>> GetProductsAsync();
        //
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}