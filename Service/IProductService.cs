using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperExample.DTOs;

namespace AutoMapperExample.Service
{
    public interface IProductService
    {
        // GET all products
        IEnumerable<ProductDTO> GetAllProductsDTO();
        // Get product by id
        ProductDTO GetProductDTO(int id);
        
    }
}