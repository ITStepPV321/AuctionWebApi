﻿namespace AuctionWebApi.Infrastructure.DTOs.Create
{
    public class CreateUserDto
    {
        // REVIEW: Додати атрибути
        public string UserName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}