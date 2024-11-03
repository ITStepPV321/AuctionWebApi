using AuctionWebApi.Core.Entities;
using AuctionWebApi.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AuctionWebApi.Infrastructure.Helpers
{
    public class JWTTokenGenerator : IJWTTokenGenerator
    {
        private readonly IConfiguration _configuration;

        public JWTTokenGenerator(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Generate(User user)
        {
            List<Claim> claimsParams = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.UserName!),
            };

            string keyJwt = _configuration.GetSection("Jwt:Key").Value!;
            string issuerJwt = _configuration.GetSection("Jwt:Issuer").Value!;
            int lifetime = int.Parse(_configuration.GetSection("Jwt:Lifetime").Value!);

            SymmetricSecurityKey secretKeyJwt = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(keyJwt));
            SigningCredentials signingCredentials = new SigningCredentials(secretKeyJwt, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken tokenOptions = new JwtSecurityToken
            (
                issuer: issuerJwt,
                claims: claimsParams,
                expires: DateTime.Now.AddMinutes(lifetime),
                signingCredentials: signingCredentials
            );

            return JsonSerializer.Serialize(new JwtSecurityTokenHandler().WriteToken(tokenOptions));
        }
    }
}
