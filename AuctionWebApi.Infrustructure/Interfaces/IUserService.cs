using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;
using AuctionWebApi.Infrastructure.DTOs.Login;
using AuctionWebApi.Infrastructure.DTOs.Update.User;

namespace AuctionWebApi.Infrastructure.Interfaces
{
    public interface IUserService
    {
        List<UserDto> GetAll();
        UserDto GetById(string id);
        Task Register(CreateUserDto userDto);
        Task<string> Login(LoginUserDto userDto);
        Task Logout();
        Task UpdateUserName(UpdateUserNameDto userDto);
        Task UpdateEmail(UpdateEmailDto userDto);
        Task UpdatePassword(UpdatePasswordDto userDto);
        Task Delete(string id);
    }
}