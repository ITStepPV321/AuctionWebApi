using AuctionWebApi.Core.Data;
using AuctionWebApi.Core.Entities;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Update;
using AuctionWebApi.Infrastructure.Interfaces;
using AutoMapper;

namespace AuctionWebApi.Infrastructure.Services
{
    public class ProductService : IEntityService<CreateProductDto, ProductDto, UpdateProductDto>
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
            List<Product> products = _context.Products.ToList();
            return _mapper.Map<List<ProductDto>>(products);
        }

        // TODO: Отримати продукти за Id
        public ProductDto GetById(int id)
        {
            // LOGIC
            Product product = _context.Products.FirstOrDefault(p => p.Id == id);
            return _mapper.Map<ProductDto>(product);
        }

        // TODO: Створити новий продукт
        public void Create(CreateProductDto createDto)
        {
            // LOGIC
            if (createDto != null)
            {
                Product product = _mapper.Map<Product>(createDto);
                _context.Products.Add(product);
                _context.SaveChanges();
            }
        }

        // TODO: Редагувати продукт
        public void Update(UpdateProductDto updateDto)
        {
            // LOGIC
            ProductDto productOld = GetById(updateDto.Id);
            if (productOld != null && updateDto != null) 
            {
                Product product = _mapper.Map<Product>(updateDto);
                _context.Products.Update(product);
                _context.SaveChanges();
            }
        }

        // TODO: Видалити продукт
        public void Delete(ProductDto productDto)
        {
            // LOGIC
            if(productDto != null)
            {
                Product product = _mapper.Map<Product>(productDto);
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}