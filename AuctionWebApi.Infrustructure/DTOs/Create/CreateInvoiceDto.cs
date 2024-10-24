using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs.Create
{
    public class CreateInvoiceDto
    {
        // TODO: Додати атрибути
        public DateTime Date { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}