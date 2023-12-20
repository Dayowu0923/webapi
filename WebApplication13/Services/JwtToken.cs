﻿using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebApplication13.Models;

namespace WebApplication13.Services
{
    public class JwtToken
    {
        private readonly IConfiguration _configuration;
        private readonly IDistributedCache _cache;
        private readonly _2023gtafContext _gtafContext;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public JwtToken(IConfiguration configuration, IDistributedCache cache, _2023gtafContext gtafContext, IHttpContextAccessor httpContextAccessor)
        {
            _configuration = configuration;
            _cache = cache;
            _gtafContext = gtafContext;
            _httpContextAccessor = httpContextAccessor;
        }
        private string GenerateJwtToken(string username)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, username),
        };

            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public virtual string CreateTokenForUser(string username)
        {
            return GenerateJwtToken(username);
        }

        public string ClaimToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(token);
            var userIdClaim = jwtToken.Claims.FirstOrDefault(claim => claim.Type == "sub");
            return userIdClaim.Value;
        }
        public string GetUser()
        {
            var user = "";
            var token = _httpContextAccessor.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            if (token != null)
            {
                user = ClaimToken(token);
            }
            return user;
        }
      
    }
}