using AuctionWebApi.Core.Data;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.Interfaces;
using AutoMapper;

namespace AuctionWebApi.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly AuctionDbContext _context;
        private readonly IMapper _mapper;

        public UserService(AuctionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // TODO: Отримати усіх користувачів
        public List<UserDto> GetAll()
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Отримати користувача за Id
        public List<UserDto> GetById(string id)
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Створити нового користувача
        public void Create(CreateUserDto userDto)
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Редагувати користувача
        public void Update(UserDto userDto)
        {
            // LOGIC
            throw new NotImplementedException();
        }

        // TODO: Видалити користувача за Id
        public void Delete(int id)
        {
            // LOGIC
            throw new NotImplementedException();
        }
    }
}