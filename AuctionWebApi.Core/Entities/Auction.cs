namespace AuctionWebApi.Core.Entities
{
    public class Auction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }

        public Product Product { get; set; }
    }
}
