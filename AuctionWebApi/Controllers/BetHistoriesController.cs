using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Read.BetHistory;
using AuctionWebApi.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuctionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetHistoriesController : ControllerBase
    {
        private readonly IBetHistoryService _betHistoryService;

        public BetHistoriesController(IBetHistoryService betHistoryService)
        {
            _betHistoryService = betHistoryService;
        }

        [HttpGet("get-all/{auctionId}")]
        public IActionResult GetAll(int auctionId)
        {
            List<BetHistoryDto> auctionBetHistory = _betHistoryService.GetAll(auctionId);

            return Ok(auctionBetHistory);
        }

        [HttpGet("get/{id}")]
        public IActionResult Get(int id)
        {
            BetHistoryDto bet = _betHistoryService.Get(id);
            
            return Ok(bet);
        }

        [HttpGet("get-max-bet/{auctionId}")]
        public IActionResult GetMaxBet(int auctionId)
        {
            MaxBet maxBet = _betHistoryService.GetMaxBet(auctionId);

            return Ok(maxBet);
        }

        [HttpPost("create-bet")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IActionResult Post([FromBody] CreateBetHistoryDto createBetDto)
        {
            string userId = User.FindFirst("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value!;

            createBetDto.UserId = userId;

            _betHistoryService.CreateBet(createBetDto);

            return Ok();
        }
    }
}
