using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace BooksCoreService.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MyHttpHeaderMiddleware
    {
        private readonly RequestDelegate _next;

        public MyHttpHeaderMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.Headers.Add("myheader", "from middlware");

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MyHttpHeaderMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyHttpHeaderMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyHttpHeaderMiddleware>();
        }
    }
}
