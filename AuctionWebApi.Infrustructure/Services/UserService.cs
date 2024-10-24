using AuctionWebApi.Core.Data;
using AuctionWebApi.Core.Entities;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AuctionWebApi.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly AuctionDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserService(AuctionDbContext context, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // REVIEW: Отримати усіх користувачів
        public List<UserDto> GetAll()
        {
            DbSet<User> users = _context.Users;

            return _mapper.Map<List<UserDto>>(users);
        }

        // REVIEW: Отримати користувача за Id
        public UserDto GetById(string id)
        {
            User user = _context.Users.FirstOrDefault(user => user.Id == id)!;

            return _mapper.Map<UserDto>(user);
        }

        // REVIEW: Створити нового користувача
        public async Task Register(CreateUserDto userDto)
        {
            User user = _mapper.Map<User>(userDto);

            await _userManager.CreateAsync(user, userDto.Password);
        }

        // TODO: Вхід користувача
        public async Task Login(UserDto userDto)
        {
            User user = _mapper.Map<User>(userDto);

            await _signInManager.SignInAsync(user, true);

            // TODO: JWT токен
        }

        // REVIEW: Вихід користувача
        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        // REVIEW: Редагувати користувача
        public async Task Update(UserDto userDto)
        {
            User user = _mapper.Map<User>(userDto);

            if (user == null)
            {
                throw new Exception("User cannot be null");
            }

            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        // TODO: Видалити користувача за Id
        public async Task Delete(string id)
        {
            User user = _context.Users.Find(id)!;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}