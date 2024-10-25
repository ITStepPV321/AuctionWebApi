using System;
using System.Collections.Generic;

namespace AuctionWebApi.Core.Entities
{
    public class Auction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Invoice> Invoices { get; set; }

        public Auction()
        {
            Products = new List<Product>();
            Invoices = new List<Invoice>();
        }
    }
}
