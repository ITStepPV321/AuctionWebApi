using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Login;
using AuctionWebApi.Infrastructure.DTOs.Update;

namespace AuctionWebApi.Infrastructure.Interfaces
{
    public interface IUserService
    {
        List<UserDto> GetAll();
        UserDto GetById(string id);
        Task Register(CreateUserDto userDto);
        Task<string> Login(LoginUserDto userDto);
        Task Logout();
        Task Update(UpdateUserDto userDto);
        Task Delete(string id);
    }
}