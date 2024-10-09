using API.HashHelpers;
using API.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace API.Utilities
{
    public class TokenUtility
    {

        private static JwtConfig _jwtConfig;
        public static List<string> CreateToken(string UserId, string UserName)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            _jwtConfig = configuration.GetSection("JwtConfig").Get<JwtConfig>();

            HashHelper hashHelper = new HashHelper();

            var claims = new List<Claim>
                {
                    new Claim("UserId",UserId),
                    new Claim("Name",UserName)
                };

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtConfig.Key));
            var credintial = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(issuer: _jwtConfig.Issuer,
                audience: _jwtConfig.Audience,
                expires: DateTime.Now.AddMinutes(_jwtConfig.Expires),
                notBefore: DateTime.Now,
                claims: claims,
                signingCredentials: credintial
                );
            var JWTToken = new JwtSecurityTokenHandler().WriteToken(token);
            var refreshToken = Guid.NewGuid().ToString();
            return new List<string>
            {
                JWTToken,
                refreshToken
            };

        }
    }

}
