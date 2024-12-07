namespace AuctionWebApi.Core.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }  // Змінено тип
        public int AuctionId { get; set; }
        public User User { get; set; }
        public Auction Auction { get; set; }
    }
}
