using App.Application.Dto;
using App.Application.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.WebApi.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
           var allList = await _productRepository.GetAllAsync();

           var result = allList.Select(i => new ProductViewDto
            {
                Id = i.Id,
                Name = i.Name
            });

            return Ok(result);
        }
    }
}
