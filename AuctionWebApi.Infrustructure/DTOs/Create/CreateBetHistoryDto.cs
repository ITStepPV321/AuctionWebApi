namespace AuctionWebApi.Infrastructure.DTOs.Create
{
    public class CreateBetHistoryDto
    {
        public int Bet { get; set; }
        public string UserId { get; set; }
        public int AuctionId { get; set; }
        public DateTime Date { get; set; }
    }
}