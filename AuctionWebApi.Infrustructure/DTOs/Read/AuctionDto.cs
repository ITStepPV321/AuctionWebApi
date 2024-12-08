using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs.Read
{
    public class AuctionDto
    {
        // TODO: Додати атрибути
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
    }
}