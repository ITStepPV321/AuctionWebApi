using AuctionWebApi.Core.Entities;
using AuctionWebApi.Core.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionWebApi.Core.Initializers
{
    public class ProductInitializer : IDbInitializer<Product>
    {
        // TODO: Додати ініціялізацію (заповнення) продуктів
        public static void Initialize(EntityTypeBuilder<Product> builder)
        {
            // LOGIC
        }
    }
}