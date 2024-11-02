using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs.Create
{
    public class CreateUserDto
    {
        // TODO: Додати атрибути
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public List<Auction> Auctions { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}