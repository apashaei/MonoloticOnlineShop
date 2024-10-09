using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.ExternalApi.SendToken
{
    public interface ISendToken
    {
        bool SendToken(string Token,string RefreshToken);
    }

    public class SendToken : ISendToken
    {
        bool ISendToken.SendToken(string Token, string RefreshToken)
        {
            var options = new RestClientOptions("https://localhost:7299")
            {
                MaxTimeout = -1,
            };
            var client = new RestClient(options);
            var request = new RestRequest($"/api/Token?Token={Token}&refreshToken={RefreshToken}&apiKey=mysecretkey", Method.Get);
            RestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
