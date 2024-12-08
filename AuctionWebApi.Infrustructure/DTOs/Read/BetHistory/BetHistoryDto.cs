using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionWebApi.Infrastructure.DTOs.Read.BetHistory
{
    public class BetHistoryDto
    {
        public int Id { get; set; }
        public int Bet { get; set; }
        public string UserId { get; set; }
        public int AuctionId { get; set; }
        public DateTime Date { get; set; }
    }
}
