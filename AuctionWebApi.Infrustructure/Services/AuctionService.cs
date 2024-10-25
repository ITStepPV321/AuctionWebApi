using AuctionWebApi.Core.Data;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.Interfaces;
using AutoMapper;

namespace AuctionWebApi.Infrastructure.Services
{
    public class AuctionService : IEntityService<CreateAuctionDto, AuctionDto>
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
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Отримати аукціон за Id
        public AuctionDto GetById(int id)
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Створити новий аукціон
        public void Create(CreateAuctionDto createDto)
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Редагувати аукціон
        public void Update(AuctionDto dto)
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Видалити аукціон за Id
        public void Delete(AuctionDto dto)
        {
            // LOGIC
            throw new NotImplementedException();
        }
    }
}