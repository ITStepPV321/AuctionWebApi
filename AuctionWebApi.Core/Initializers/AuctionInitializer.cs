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
                new Auction { Id = 1, Date = DateTime.Now.AddDays(-10) },
                new Auction { Id = 2, Date = DateTime.Now.AddDays(-5) },
                new Auction { Id = 3, Date = DateTime.Now }
            );
        }
    }
}
