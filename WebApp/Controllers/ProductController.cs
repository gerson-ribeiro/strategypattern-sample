using Microsoft.AspNetCore.Mvc;
using StrategyPattern.Sample.Products.Application.ProductFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductFactory _factory;

        public ProductController(IProductFactory factory)
        {
            _factory = factory;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_factory.GetAllProduct.GetProducts());
        }

        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            return Ok(_factory.ProductById.GetById(id));
        }

        [HttpPatch("{productId}")]
        public IActionResult ApplyDiscount(int productId)
        {
            return Ok(_factory.ApplyDiscount.Handler(productId));
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            return Ok(_factory.CreateProduct.Create(new StrategyPattern.Sample.Domain.Products.Entities.Product
            {
                Id = product.Id,
                Identification = product.Identification,
                Price = product.Price,
                Type = (StrategyPattern.Sample.Domain.Products.Enums.ProductTypeEnum) product.Type
            }));
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Product product)
        {
            return Ok(_factory.UpdateProduct.Update(new StrategyPattern.Sample.Domain.Products.Entities.Product
            {
                Id = product.Id,
                Identification = product.Identification,
                Price = product.Price,
                Type = (StrategyPattern.Sample.Domain.Products.Enums.ProductTypeEnum)product.Type
            }));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            return Ok(_factory.DeleteProduct.Delete(id));
        }
    }
}
