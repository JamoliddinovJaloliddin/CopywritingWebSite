using CopywritingWebSite.Domain.Entities;
using CopywritingWebSite.Service.Interfaces.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CopywritingWebSite.Service.Services.Common
{
    public class AuthManager : IAuthManagaer
    {
        private readonly IConfiguration _config;

        public AuthManager(IConfiguration config)
        {
            _config = config.GetSection("Jwt");
        }

        public virtual string GenerateToken(User user)
        {
            var claims = new[]
            {
                            new Claim("Id", user.Id.ToString()),
                            new Claim(ClaimTypes.Email, user.Email),
                            new Claim(ClaimTypes.Role, user.Role.ToString())
                        };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["SecretKey"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var tokenDescriptor = new JwtSecurityToken(_config["Issuer"], _config["Audience"], claims,
                expires: DateTime.Now.AddMinutes(double.Parse(_config["Lifetime"])),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);
        }
    }
}





