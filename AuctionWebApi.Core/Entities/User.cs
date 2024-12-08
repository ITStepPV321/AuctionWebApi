using Microsoft.AspNetCore.Identity;

namespace AuctionWebApi.Core.Entities
{
    public class User : IdentityUser
    {
        public ICollection<Auction> Auctions { get; set; }
        public ICollection<BetHistory> BetHistories { get; set; }

        public User()
        {
            Auctions = new HashSet<Auction>();
            BetHistories = new HashSet<BetHistory>();
        }
    }
}