using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperExample.DTOs;
using AutoMapperExample.Models;
using AutoMapperExample.Repository;

namespace AutoMapperExample.Service
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _repository;
        public ProductService(IMapper mapper, IProductRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        // GET all productDTO
        public IEnumerable<ProductDTO> GetAllProductsDTO()
        {
            var products = _repository.GetAllProducts();
            var productsDTO = _repository.GetAllProducts().Select(x => ProductToDTO(x));

            return productsDTO;
        }

        // Get ProductDTO by id
        public ProductDTO GetProductDTO(int id)
        {
            var product = _repository.GetProduct(id);
            return _mapper.Map<ProductDTO>(product);
        }

        public ProductDTO ProductToDTO(Product product)
        {
            return _mapper.Map<ProductDTO>(product);
        }

        

    }
}