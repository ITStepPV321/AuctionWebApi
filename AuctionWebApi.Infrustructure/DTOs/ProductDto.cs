using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs
{
    public class ProductDto
    {
        // TODO: Додати атрибути
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Auction Auction { get; set; }
    }
}