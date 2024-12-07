using AuctionWebApi.Core.Entities;
using AuctionWebApi.Core.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionWebApi.Core.Initializers
{
    public class InvoiceInitializer : IDbInitializer<Invoice>
    {
        public static void Initialize(EntityTypeBuilder<Invoice> builder)
        {
            builder.HasData(
                new Invoice { Id = 1, Date = DateTime.Now.AddDays(-1), UserId = "1", AuctionId = 1 },
                new Invoice { Id = 2, Date = DateTime.Now, UserId = "2", AuctionId = 2 }
            );
        }
    }
}
