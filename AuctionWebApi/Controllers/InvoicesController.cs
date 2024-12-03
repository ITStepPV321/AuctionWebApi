using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AuctionWebApi.Infrastructure.DTOs.Update;

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly IEntityService<CreateInvoiceDto, InvoiceDto, UpdateInvoiceDto> _invoiceService;

        public InvoicesController(IEntityService<CreateInvoiceDto, InvoiceDto, UpdateInvoiceDto> invoiceService)
        {
            _invoiceService = invoiceService;
        }

        // ACHTUNG: Наступні дії робити лише завдяки сервісу!!!

        // TODO: Отримання усіх чеків
        [HttpGet]
        public IActionResult Get()
        {
            List<InvoiceDto> invoices = _invoiceService.GetAll();

            return Ok(invoices);
        }

        // TODO: Отримання чеку за Id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            InvoiceDto invoice = _invoiceService.GetById(id);

            return Ok(invoice);
        }

        // TODO: Створення чеку
        [HttpPost]
        public IActionResult Post([FromBody] CreateInvoiceDto invoiceDto)
        {
            _invoiceService.Create(invoiceDto);

            return Ok();
        }

        // TODO: Редагування чеку
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateInvoiceDto updateInvoice)
        {
            _invoiceService.Update(updateInvoice);

            return Ok();
        }

        // TODO: Видалення чеку
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            InvoiceDto invoiceDto = _invoiceService.GetById(id);
            _invoiceService.Delete(invoiceDto);

            return Ok();
        }
    }
}