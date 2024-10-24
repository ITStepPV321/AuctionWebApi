using AuctionWebApi.Core.Entities;
using AuctionWebApi.Core.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionWebApi.Core.Initializers
{
    public class UserInitializer : IDbInitializer<User>
    {
        // TODO: Додати ініціялізацію (заповнення) користувачів
        public static void Initialize(EntityTypeBuilder<User> builder)
        {
            // LOGIC
        }
    }
}