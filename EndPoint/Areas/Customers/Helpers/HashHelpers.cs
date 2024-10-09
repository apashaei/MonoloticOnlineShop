using System.Security.Cryptography;
using System.Text;

namespace Project.EndPoint.Areas.Customers.Helpers
{
    public class HashHelpers
    {
        private readonly RandomNumberGenerator _randomNumberGenerator = RandomNumberGenerator.Create();
        public string Getsha256Hash(string value)
        {
            var algorithm = new SHA256CryptoServiceProvider();
            var byteValue = Encoding.UTF8.GetBytes(value);
            var byteHash = algorithm.ComputeHash(byteValue);
            return Convert.ToBase64String(byteHash);
        }
    }
}
