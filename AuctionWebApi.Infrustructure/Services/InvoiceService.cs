using AuctionWebApi.Core.Data;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Update;
using AuctionWebApi.Infrastructure.Interfaces;
using AutoMapper;

namespace AuctionWebApi.Infrastructure.Services
{
    public class InvoiceService : IEntityService<CreateInvoiceDto, InvoiceDto, UpdateProductDto>
    {
        private readonly AuctionDbContext _context;
        private readonly IMapper _mapper;

        public InvoiceService(AuctionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // TODO: Отримати усі чеки
        public List<InvoiceDto> GetAll()
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Отримати чек за Id
        public InvoiceDto GetById(int id)
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Створити новий чек
        public void Create(CreateInvoiceDto createDto)
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Редагувати чек
        public void Update(InvoiceDto dto)
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Видалити чек
        public void Delete(InvoiceDto dto)
        {
            // LOGIC
            throw new NotImplementedException();
        }

        public void Update(UpdateProductDto dto)
        {
            throw new NotImplementedException();
        }
    }
}