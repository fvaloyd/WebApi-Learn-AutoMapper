using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperExample.Models;

namespace AutoMapperExample.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _Context;
        public ProductRepository(ProductContext context)
        {
            _Context = context;
        }
        // GET all products
        public IEnumerable<Product> GetAllProducts()
        {
            var products = _Context.Products.ToList();
            
            return products;
        }
        // GET product by id
        public Product GetProduct(int id)
        {
            var product = _Context.Products.Find(id);
            
            return product; 
        }
        // CREATE product
        public void CreateProduct(Product product)
        {
            _Context.Products.Add(product);
            _Context.SaveChanges();
        }
        // EDIT product
        public void EditProduct(Product product)
        {
            _Context.Update(product);
            _Context.SaveChanges();
        }
        // DELETE product
        public void DeleteProduct(int id)
        {
            var product = GetProduct(id);
            if(product != null)
            _Context.Products.Remove(product);
            _Context.SaveChanges();
        }
    }
}