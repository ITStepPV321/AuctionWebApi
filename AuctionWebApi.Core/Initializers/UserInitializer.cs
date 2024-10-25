using AuctionWebApi.Core.Entities;
using AuctionWebApi.Core.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionWebApi.Core.Initializers
{
    public class UserInitializer : IDbInitializer<User>
    {
        public static void Initialize(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = "1", UserName = "john_doe", Email = "john.doe@example.com" },
                new User { Id = "2", UserName = "jane_doe", Email = "jane.doe@example.com" }
            );
        }
    }
}
