using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConsoleAppAPI
{
    public class MiddlewareClass : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Class Middleware 1 \n");
            await next(context);
            await context.Response.WriteAsync("Class Middleware 2 \n");
        }
    }
}
