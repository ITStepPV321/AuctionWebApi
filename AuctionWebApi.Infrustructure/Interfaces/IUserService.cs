using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;

namespace AuctionWebApi.Infrastructure.Interfaces
{
    public interface IUserService
    {
        List<UserDto> GetAll();
        UserDto GetById(string id);
        Task Register(CreateUserDto userDto);
        Task Login(UserDto userDto);
        Task Logout();
        Task Update(UserDto userDto);
        Task Delete(string id);
    }
}