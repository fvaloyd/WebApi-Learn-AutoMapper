using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperExample.DTOs;
using AutoMapperExample.Models;
using AutoMapperExample.Repository;
using AutoMapperExample.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AutoMapperExample.Controllers
{
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        private readonly IProductRepository _repository;

        public ProductController(IProductService service, IProductRepository repository)
        {
            _service = service;
            _repository = repository;
        }
        // GET all products
        [HttpGet]
        public ActionResult<IEnumerable<ProductDTO>> GetAllProduct()
        {
            return _service.GetAllProductsDTO().ToList();
        }
        // GET product by id
        [HttpGet("{id}")]
        public ActionResult<ProductDTO> GetProduct(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            return _service.GetProductDTO(id);
        }
        // CREATE product
        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            if(product != null)
            {
                _repository.CreateProduct(product);
            }
            return Ok();
        }
        // EDIT product
        [HttpPut]
        public ActionResult EditProduct(Product product)
        {
            _repository.EditProduct(product);
            return NoContent();
        }
        // DELETE product
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            _repository.DeleteProduct(id);
            return NoContent();

        }
    }
}