using AuctionWebApi.Core.Entities;
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
            List<AuctionDto> auctions = _auctionService.GetAll();

            return Ok(auctions);
        }

        // TODO: Отримання аукціону за Id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            AuctionDto auctionDto = _auctionService.GetById(id);

            return Ok(auctionDto);
        }

        // TODO: Створення аукціону
        [HttpPost]
        public IActionResult Post([FromBody] CreateAuctionDto createAuctionDto)
        {
            _auctionService.Create(createAuctionDto);

            return Ok();
        }

        // TODO: Редагування аукціону
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] AuctionDto auctionDto)
        {
            _auctionService.Update(auctionDto);

            return Ok();
        }

        // TODO: Видалення аукціону
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            AuctionDto auctionDto = _auctionService.GetById(id);

            _auctionService.Delete(auctionDto);

            return Ok();
        }
    }
}