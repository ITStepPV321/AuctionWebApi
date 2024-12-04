using AuctionWebApi.Core.Entities;
using AuctionWebApi.Core.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionWebApi.Core.Initializers
{
    public class AuctionInitializer : IDbInitializer<Auction>
    {
        public static void Initialize(EntityTypeBuilder<Auction> builder)
        {
            builder.HasData(
                new Auction { Id = 1, Date = DateTime.Now.AddDays(-10), Name = "Product 1", Description = "Description of Product 1", Year = 2023 },
                new Auction { Id = 2, Date = DateTime.Now.AddDays(-5), Name = "Product 2", Description = "Description of Product 2", Year = 2024 },
                new Auction { Id = 3, Date = DateTime.Now, Name = "Product 3", Description = "Description of Product 3", Year = 2024 }
            );
        }
    }
}
