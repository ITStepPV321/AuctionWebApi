using AuctionWebApi.Core.Data;
using AuctionWebApi.Core.Entities;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Read.BetHistory;
using AuctionWebApi.Infrastructure.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace AuctionWebApi.Infrastructure.Services
{
    public class BetHistoryService : IBetHistoryService
    {
        private readonly AuctionDbContext _context;
        private readonly IMapper _mapper;

        public BetHistoryService(AuctionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<BetHistoryDto> GetAll(int auctionId)
        {
            DbSet<BetHistory> betHistories = _context.BetHistories;
            
            return _mapper.Map<List<BetHistoryDto>>(betHistories);
        }

        public BetHistoryDto Get(int betHistoryId)
        {
            BetHistory betHistory = _context.BetHistories.Find(betHistoryId)!;

            return _mapper.Map<BetHistoryDto>(betHistory);
        }

        public MaxBet GetMaxBet(int auctionId)
        {
            DbSet<BetHistory> betHistories = _context.BetHistories;
            IIncludableQueryable<BetHistory, User> betHistoriesWithUsers = betHistories.Include(bh => bh.User);
            IQueryable<BetHistory> auctionBetHistory = betHistoriesWithUsers.Where(bh => bh.AuctionId == auctionId);
            IOrderedQueryable<BetHistory> orderedBetHistoryByDate = auctionBetHistory.OrderByDescending(bet => bet.Date)!;
            BetHistory maxBet = orderedBetHistoryByDate.FirstOrDefault()!;
            
            return _mapper.Map<MaxBet>(maxBet);
        }

        public BetHistoryDto GetFullMaxBet(int auctionId)
        {
            DbSet<BetHistory> betHistories = _context.BetHistories;
            IIncludableQueryable<BetHistory, User> betHistoriesWithUsers = betHistories.Include(bh => bh.User);
            IQueryable<BetHistory> auctionBetHistory = betHistoriesWithUsers.Where(bh => bh.AuctionId == auctionId);
            IOrderedQueryable<BetHistory> orderedBetHistoryByDate = auctionBetHistory.OrderByDescending(bet => bet.Date)!;
            BetHistory fullMaxBet = orderedBetHistoryByDate.FirstOrDefault()!;

            return _mapper.Map<BetHistoryDto>(fullMaxBet);
        }

        public List<BetHistoryDto> GetUserWonBets(string userId)
        {
            DbSet<BetHistory> bets = _context.BetHistories;
            IQueryable<BetHistory> usersBets = bets.Where(bh => bh.UserId == userId);
            IQueryable<IGrouping<int, BetHistory>> groupedUsersBets = usersBets.GroupBy(bh => bh.AuctionId);
            IQueryable<BetHistory> usersWonBets = groupedUsersBets
                .Select(gr => gr.OrderByDescending(bh => bh.Date).FirstOrDefault())!;

            return _mapper.Map<List<BetHistoryDto>>(usersWonBets);
        }

        public void CreateBet(CreateBetHistoryDto createBetDto)
        {
            BetHistory betHistory = _mapper.Map<BetHistory>(createBetDto);

            _context.BetHistories.Add(betHistory);
            _context.SaveChanges();
        }
    }
}
