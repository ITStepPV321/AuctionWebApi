using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs
{
    public class InvoiceDto
    {
        // TODO: Додати атрибути
        public int Id { get; set; } 
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int AuctionId { get; set; }
    }
}