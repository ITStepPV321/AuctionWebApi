using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs.Read
{
    public class InvoiceDto
    {
        // TODO: Додати атрибути
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int BetHistoryId { get; set; }
    }
}