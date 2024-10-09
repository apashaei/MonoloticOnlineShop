using Project.Application.Interfaces.DatabaseContext;
using Project.Domain.Token;
using Project.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Token
{
    public interface ITokenServices
    {
        void SaveToken(string token, string refreshToken, string UserId);

        tokenDto GetUserTokn(string userId);


    }

    public class TokenServices : ITokenServices
    {
        private readonly IDataBaseContext _context;

        public TokenServices(IDataBaseContext dataBaseContext)
        {
            _context = dataBaseContext;   
        }

        public tokenDto GetUserTokn(string userId)
        {
            var token = _context.Tokens.Where(p=>p.UserId == userId).FirstOrDefault();
            if(token == null)
            {
                return null;
            }
            return new tokenDto
            {
                UserId = userId,
                Id = token.Id,
                RefreshToken = token.RefreshToken,
                Token = token.Token,


            };
        }

        public void SaveToken(string token, string refreshToken, string userId)
        {
            
            var Newtoken = new Tokens
            {
                RefreshToken = refreshToken,
                Token = token,
                
                UserId = userId

            };
            _context.Tokens.Add(Newtoken);
            _context.SaveChanges();
        }

    }

    public class tokenDto
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
