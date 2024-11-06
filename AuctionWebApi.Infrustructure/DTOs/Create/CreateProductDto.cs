using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs.Create
{
    public class CreateProductDto
    {
        // TODO: Додати атрибути
        public string Name {  get; set; }
        public string Description { get; set; }
        public int Year {  get; set; }
        public int AuctionId {  get; set; }
       // public Auction Auction { get; set; }

    }
}