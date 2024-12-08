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
            );
        }
    }
}
