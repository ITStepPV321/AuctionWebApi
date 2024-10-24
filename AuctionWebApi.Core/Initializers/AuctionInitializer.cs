using AuctionWebApi.Core.Entities;
using AuctionWebApi.Core.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionWebApi.Core.Initializers
{
    public class AuctionInitializer : IDbInitializer<Auction>
    {
        // TODO: Додати ініціялізацію (заповнення) аукціонів
        public static void Initialize(EntityTypeBuilder<Auction> builder)
        {
            // LOGIC
        }
    }
}