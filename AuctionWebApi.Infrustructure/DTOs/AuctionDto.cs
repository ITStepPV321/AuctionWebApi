using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs
{
    public class AuctionDto
    {
        // TODO: Додати атрибути
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Product> Products { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}