using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionWebApi.Core.Interfaces
{
    public interface IDbInitializer<T> where T : class
    {
        static void Initialize(EntityTypeBuilder<T> builder) => throw new NotImplementedException(); 
    }
}