using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Read.BetHistory;

namespace AuctionWebApi.Infrastructure.Interfaces
{
    public interface IBetHistoryService
    {
        List<BetHistoryDto> GetAll(int auctionId);
        MaxBet GetMaxBet(int auctionId);
        BetHistoryDto GetFullMaxBet(int auctionId);
        BetHistoryDto Get(int betHistoryId);
        List<BetHistoryDto> GetUserWonBets(string userId);
        void CreateBet(CreateBetHistoryDto createBetDto);
    }
}
