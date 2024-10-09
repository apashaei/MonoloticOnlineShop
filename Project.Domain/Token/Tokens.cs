using Project.Domain.Attributes;
using Project.Domain.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Token
{

    [Auditable]
    public class Tokens
    {
        public int Id { get; set; }
        public User.User User { get; set; }
        public string UserId { get; set; }
        public string Token {  get; set; }
        public string RefreshToken { get; set; }
    }
}
