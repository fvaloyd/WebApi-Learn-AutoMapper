using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperExample.Models;

namespace AutoMapperExample.Repository
{
    public interface IProductRepository
    {
        // GET all products
        IEnumerable<Product> GetAllProducts();
        // Get product by id
        Product GetProduct(int id);
        // Create product
        void CreateProduct(Product product);
        // Edit product
        void EditProduct(Product product);
        // Delete product
        void DeleteProduct(int id);
    }
}