using AuctionWebApi.Infrastructure.DTOs;
using AuctionWebApi.Infrastructure.DTOs.Create;

namespace AuctionWebApi.Infrastructure.Interfaces
{
    public interface IUserService
    {
        List<UserDto> GetAll();
        List<UserDto> GetById(string id);
        void Create(CreateUserDto userDto);
        void Update(UserDto userDto);
        void Delete(int id);
    }
}