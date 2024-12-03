using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using AuctionWebApi.Infrastructure.DTOs.Update;

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IEntityService<CreateProductDto, ProductDto,UpdateProductDto> _productService;
        private readonly IMapper _mapper;
        
        public ProductsController(IEntityService<CreateProductDto, ProductDto,UpdateProductDto> productService, IMapper mapper)
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
            return Ok(products);
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
           
            _productService.Create(newProduct);
            return Ok();
        }

        // TODO: Редагування товару
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProductDto updatedProduct)
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