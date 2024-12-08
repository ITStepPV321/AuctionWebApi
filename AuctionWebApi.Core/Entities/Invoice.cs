namespace AuctionWebApi.Core.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int BetHistoryId { get; set; }

        public BetHistory BetHistory { get; set; }
    }
}