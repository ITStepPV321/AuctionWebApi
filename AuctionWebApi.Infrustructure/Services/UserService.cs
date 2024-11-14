using AuctionWebApi.Core.Data;
using AuctionWebApi.Core.Entities;
using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Login;
using AuctionWebApi.Infrastructure.DTOs.Update;
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
        private readonly IJWTTokenGenerator _jwtTokenGenerator;

        public UserService(AuctionDbContext context, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IJWTTokenGenerator jwtTokenGenerator)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public List<UserDto> GetAll()
        {
            DbSet<User> users = _context.Users;

            return _mapper.Map<List<UserDto>>(users);
        }

        public UserDto GetById(string id)
        {
            User user = _context.Users.FirstOrDefault(user => user.Id == id)!;

            return _mapper.Map<UserDto>(user);
        }

        public async Task Register(CreateUserDto userDto)
        {
            User user = _mapper.Map<User>(userDto);

            await _userManager.CreateAsync(user, userDto.Password);
        }

        // REVIEW: Вхід користувача
        public async Task<string> Login(LoginUserDto loginUserDto)
        {
            User user = await _userManager.FindByEmailAsync(loginUserDto.Email)
                ?? throw new Exception("User now found");
            bool isPasswordValid = await _userManager.CheckPasswordAsync(user, loginUserDto.Password);

            if (!isPasswordValid)
            {
                throw new Exception("Wrong Password");
            }

            await _signInManager.SignInAsync(user, true);

            return _jwtTokenGenerator.Generate(user);
        }

        // REVIEW: Вихід користувача
        public async Task Logout()
        {
            await _signInManager.SignOutAsync();
        }

        // REVIEW: Редагувати користувача
        public async Task Update(UpdateUserDto userDto)
        {
            User user = _context.Users.Find(userDto.Id) ?? throw new Exception("User cannot be null");

            if (userDto.Email != "string")
            {
                user.Email = userDto.Email;
            }

            if (userDto.UserName != "string")
            {
                user.UserName = userDto.UserName;
            }

            if (userDto.CurrentPassword != "string" && userDto.NewPassword != "string")
            {
                await ChangePassword(user, userDto.CurrentPassword, userDto.NewPassword);
            }

            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        private async Task ChangePassword(User user, string currentPassword, string newPassword)
        {
            bool isPasswordValid = await _userManager.CheckPasswordAsync(user, currentPassword);

            if (isPasswordValid)
            {
                await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
            }
            else
            {
                throw new Exception("Invalid Password");
            }
        }

        public async Task Delete(string id)
        {
            User user = _context.Users.Find(id)!;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}