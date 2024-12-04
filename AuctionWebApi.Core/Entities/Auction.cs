namespace AuctionWebApi.Core.Entities
{
    public class Auction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
    }
}
