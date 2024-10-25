using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IEntityService<CreateProductDto, ProductDto> _productService;
        private readonly IMapper _mapper;
        public ProductController(IEntityService<CreateProductDto, ProductDto> productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        // ACHTUNG: Наступні дії робити лише завдяки сервісу!!!

        // TODO: Отримання усіх товарів
        [HttpGet]
        public IActionResult Get()
        {
            // LOGIC
            List<ProductDto> products = _productService.GetAll();
            return Ok();
        }

        // TODO: Отримання товару за Id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // LOGIC
            ProductDto product = _productService.GetById(id);
            return Ok(product);
        }

        // TODO: Створення товару
        [HttpPost]
        public IActionResult Post([FromBody] CreateProductDto newProduct)
        {
            // LOGIC
            ProductDto productDto = _mapper.Map<ProductDto>(newProduct);
            return Ok();
        }

        // TODO: Редагування товару
        [HttpPut("{id}")]
        public IActionResult Put( [FromBody] ProductDto updatedProduct)
        {
            // LOGIC
            _productService.Update(updatedProduct);
            return Ok();
        }

        // TODO: Видалення товару
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // LOGIC
            ProductDto productDto = _productService.GetById(id);
            _productService.Delete(productDto);
            return Ok();
        }
    }
}