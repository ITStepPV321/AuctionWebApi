using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs.Create
{
    public class CreateAuctionDto
    {
        // TODO: Додати атрибути
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
    }
}