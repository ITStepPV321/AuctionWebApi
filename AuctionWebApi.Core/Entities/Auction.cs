namespace AuctionWebApi.Core.Entities
{
    public class Auction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int StartedPrice { get; set; }
        public int Price { get; set; } // Will be removed soon!!!
        public int SellerId { get; set; }

        public ICollection<BetHistory> BetHistories { get; set; }

        public Auction()
        {
            BetHistories = new HashSet<BetHistory>();
        }
    }
}
