namespace AuctionWebApi.Core.Entities
{
    public class Product
    {
        // TODO: Додати атрибути
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int AuctionId { get; set; }
        public Auction Auction { get; set; }
    }
}