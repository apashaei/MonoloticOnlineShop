using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Project.EndPoint.MiddleWares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CustomExecption
    {
        private readonly RequestDelegate _next;

        public CustomExecption(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CustomExecptionExtensions
    {
        public static IApplicationBuilder UseCustomExecption(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExecption>();
        }
    }
}
