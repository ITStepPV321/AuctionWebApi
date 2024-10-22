using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController : ControllerBase
    {
        private readonly IEntityService<CreateAuctionDto, AuctionDto> _auctionService;

        public AuctionController(IEntityService<CreateAuctionDto, AuctionDto> auctionService)
        {
            _auctionService = auctionService;
        }

        // ACHTUNG: Наступні дії робити лише завдяки сервісу!!!

        // TODO: Отримання всіх аукціонів
        [HttpGet]
        public IActionResult Get()
        {
            // LOGIC

            return Ok();
        }

        // TODO: Отримання аукціону за Id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // LOGIC

            return Ok();
        }

        // TODO: Створення аукціону
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            // LOGIC

            return Ok();
        }

        // TODO: Редагування аукціону
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            // LOGIC

            return Ok();
        }

        // TODO: Видалення аукціону
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // LOGIC

            return Ok();
        }
    }
}