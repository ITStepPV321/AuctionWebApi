using AuctionWebApi.Core.Entities;
using AuctionWebApi.Core.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionWebApi.Core.Initializers
{
    public class InvoiceInitializer : IDbInitializer<Invoice>
    {
        // TODO: Додати ініціялізацію (заповнення) чеків
        public static void Initialize(EntityTypeBuilder<Invoice> builder)
        {
            // LOGIC
        }
    }
}