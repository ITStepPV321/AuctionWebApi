﻿namespace AuctionWebApi.Infrastructure.DTOs.Update.User
{
    public class UpdatePasswordDto
    {
        public string Id { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string RepeatPassword { get; set; }
    }
}