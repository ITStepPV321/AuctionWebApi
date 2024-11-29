using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs.Create
{
    public class CreateInvoiceDto
    {
        // TODO: Додати атрибути
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}