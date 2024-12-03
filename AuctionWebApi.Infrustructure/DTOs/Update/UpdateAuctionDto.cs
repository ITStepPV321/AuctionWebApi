namespace AuctionWebApi.Infrastructure.DTOs.Update
{
    public class UpdateAuctionDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
    }
}
