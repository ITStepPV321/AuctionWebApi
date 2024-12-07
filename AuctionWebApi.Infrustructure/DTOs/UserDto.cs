﻿using AuctionWebApi.Core.Entities;

namespace AuctionWebApi.Infrastructure.DTOs
{
    public class UserDto
    {
        // TODO: Додати атрибути
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email {  get; set; }
        public List<int> AuctionIds { get; set; }
        public List<int> InvoiceIds { get; set; }
    }
}