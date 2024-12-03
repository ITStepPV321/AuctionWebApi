using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs
{
    public class AuctionDto
    {
        // TODO: Додати атрибути
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }

        public int Price { get; set; }
    }
}