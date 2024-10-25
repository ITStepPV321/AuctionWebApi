using AuctionWebApi.Core.Entities;
using AuctionWebApi.Core.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionWebApi.Core.Initializers
{
    public class ProductInitializer : IDbInitializer<Product>
    {
        public static void Initialize(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, Name = "Product 1", Description = "Description of Product 1", Year = 2023, AuctionId = 1 },
                new Product { Id = 2, Name = "Product 2", Description = "Description of Product 2", Year = 2024, AuctionId = 2 },
                new Product { Id = 3, Name = "Product 3", Description = "Description of Product 3", Year = 2024, AuctionId = 3 }
            );
        }
    }
}
