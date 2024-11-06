using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AuctionWebApi.Infrastructure.DTOs.Update;

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IEntityService<CreateInvoiceDto, InvoiceDto, UpdateProductDto> _invoiceService;

        public InvoiceController(IEntityService<CreateInvoiceDto, InvoiceDto, UpdateProductDto> invoiceService)
        {
            _invoiceService = invoiceService;
        }

        // ACHTUNG: Наступні дії робити лише завдяки сервісу!!!

        // TODO: Отримання усіх чеків
        [HttpGet]
        public IActionResult Get()
        {
            // LOGIC

            return Ok();
        }

        // TODO: Отримання чеку за Id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // LOGIC

            return Ok();
        }

        // TODO: Створення чеку
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            // LOGIC

            return Ok();
        }

        // TODO: Редагування чеку
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            // LOGIC

            return Ok();
        }

        // TODO: Видалення чеку
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // LOGIC

            return Ok();
        }
    }
}