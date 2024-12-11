using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs.Create
{
    public class CreateInvoiceDto
    {
        public DateTime Date { get; set; }
        public int BetHistoryId { get; set; }
    }
}