using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs.Create
{
    public class CreateAuctionDto
    {
        // TODO: Додати атрибути
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
    }
}