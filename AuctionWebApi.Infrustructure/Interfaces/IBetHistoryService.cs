using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Read.BetHistory;

namespace AuctionWebApi.Infrastructure.Interfaces
{
    public interface IBetHistoryService
    {
        List<BetHistoryDto> GetAll(int auctionId);
        MaxBet GetMaxBet(int auctionId);
        BetHistoryDto Get(int betHistoryId);
        void CreateBet(CreateBetHistoryDto createBetDto);
    }
}
