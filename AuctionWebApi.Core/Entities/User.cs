﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace AuctionWebApi.Core.Entities
{
    public class User : IdentityUser
    {
        public ICollection<Auction> Auctions { get; set; }
        public ICollection<Invoice> Invoices { get; set; }

        public User()
        {
            Auctions = new HashSet<Auction>();
            Invoices = new HashSet<Invoice>();
        }
    }
}
