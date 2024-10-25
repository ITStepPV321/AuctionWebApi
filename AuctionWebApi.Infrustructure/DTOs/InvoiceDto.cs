using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs
{
    public class InvoiceDto
    {
        // TODO: Додати атрибути
        public int Id { get; set; } 
        public DateTime Date { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}