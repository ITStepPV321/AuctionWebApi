using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.Interfaces
{
    public interface IJWTTokenGenerator
    {
        /// <summary>
        /// Ґенерує JWT токен учасника аукціону
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        string Generate(User user);
    }
}