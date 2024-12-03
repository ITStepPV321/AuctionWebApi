namespace AuctionWebApi.Core.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }  // Змінено тип
        public int ProductId { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
