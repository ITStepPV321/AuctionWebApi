using AuctionWebApi.Core.Data;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.Interfaces;
using AutoMapper;

namespace AuctionWebApi.Infrastructure.Services
{
    public class ProductService : IEntityService<CreateProductDto, ProductDto>
    {
        private readonly AuctionDbContext _context;
        private readonly IMapper _mapper;

        public ProductService(AuctionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // TODO: Отримати усі продукти
        public List<ProductDto> GetAll()
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Отримати продукти за Id
        public ProductDto GetById(int id)
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Створити новий продукт
        public void Create(CreateProductDto createDto)
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Редагувати продукт
        public void Update(ProductDto dto)
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Видалити продукт
        public void Delete(int id)
        {
            // LOGIC
            throw new NotImplementedException();
        }
    }
}