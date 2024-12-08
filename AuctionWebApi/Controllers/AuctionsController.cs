using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Read;
using AuctionWebApi.Infrastructure.DTOs.Update;
using AuctionWebApi.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IEntityService<CreateAuctionDto, AuctionDto, UpdateAuctionDto> _auctionService;

        public AuctionsController(IEntityService<CreateAuctionDto, AuctionDto, UpdateAuctionDto> auctionService)
        {
            _auctionService = auctionService;
        }

        // ACHTUNG: Наступні дії робити лише завдяки сервісу!!!

        // TODO: Отримання всіх аукціонів
        [HttpGet]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
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
        [HttpPost("create")]
        public IActionResult Post([FromBody] CreateAuctionDto createAuctionDto)
        {
            _auctionService.Create(createAuctionDto);

            return Ok();
        }

        // TODO: Редагування аукціону
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateAuctionDto auctionDto)
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