namespace AuctionWebApi.Core.Entities
{
    public class BetHistory
    {
        public int Id { get; set; }
        public int Bet { get; set; }
        public string UserId { get; set; }
        public int AuctionId { get; set; }
        public DateTime Date { get; set; }

        public User User { get; set; }
        public Auction Auction { get; set; }
        public ICollection<Invoice> Invoices { get; set; }

        public BetHistory()
        {
            Invoices = new HashSet<Invoice>();
        }
    }
}
