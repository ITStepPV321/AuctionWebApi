using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IEntityService<CreateProductDto, ProductDto> _productService;

        public ProductController(IEntityService<CreateProductDto, ProductDto> productService)
        {
            _productService = productService;
        }

        // ACHTUNG: Наступні дії робити лише завдяки сервісу!!!

        // TODO: Отримання усіх товарів
        [HttpGet]
        public IActionResult Get()
        {
            // LOGIC

            return Ok();
        }

        // TODO: Отримання товару за Id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // LOGIC

            return Ok();
        }

        // TODO: Створення товару
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            // LOGIC

            return Ok();
        }

        // TODO: Редагування товару
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            // LOGIC

            return Ok();
        }

        // TODO: Видалення товару
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // LOGIC

            return Ok();
        }
    }
}