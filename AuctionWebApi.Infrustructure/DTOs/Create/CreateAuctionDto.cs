using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs.Create
{
    public class CreateAuctionDto
    {
        // TODO: Додати атрибути
        public DateTime Date { get; set; }
        public List<Product> Products { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}