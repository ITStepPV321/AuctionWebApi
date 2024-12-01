using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionWebApi.Infrastructure.DTOs.Update
{
    public class UpdateAuctionDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
    }
}
