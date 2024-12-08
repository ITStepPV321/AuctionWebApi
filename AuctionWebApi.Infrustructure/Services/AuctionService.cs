using AuctionWebApi.Core.Data;
using AuctionWebApi.Core.Entities;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Read;
using AuctionWebApi.Infrastructure.DTOs.Update;
using AuctionWebApi.Infrastructure.Interfaces;
using AutoMapper;

namespace AuctionWebApi.Infrastructure.Services
{
    public class AuctionService : IEntityService<CreateAuctionDto, AuctionDto, UpdateAuctionDto>
    {
        private readonly AuctionDbContext _context;
        private readonly IMapper _mapper;

        public AuctionService(AuctionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // TODO: Отримати усі аукціони
        public List<AuctionDto> GetAll()
        {
            List<Auction> auctions = _context.Auctions.ToList();
            return _mapper.Map<List<AuctionDto>>(auctions);
        }

        // TODO: Отримати аукціон за Id
        public AuctionDto GetById(int id)
        {
            Auction auctions = _context.Auctions.Find(id)!;
            return _mapper.Map<AuctionDto>(auctions);
        }

        // TODO: Створити новий аукціон
        public void Create(CreateAuctionDto createDto)
        {
            Auction auction = _mapper.Map<Auction>(createDto);

            _context.Auctions.Add(auction);

            _context.SaveChanges();
        }

        // TODO: Видалити аукціон за Id
        public void Delete(AuctionDto dto)
        {
            Auction auction = _mapper.Map<Auction>(dto);

            _context.Auctions.Remove(auction);

            _context.SaveChanges();
        }

        public void Update(UpdateAuctionDto dto)
        {
            Auction auction = _mapper.Map<Auction>(dto);

            _context.Auctions.Update(auction);

            _context.SaveChanges();
        }
    }
}