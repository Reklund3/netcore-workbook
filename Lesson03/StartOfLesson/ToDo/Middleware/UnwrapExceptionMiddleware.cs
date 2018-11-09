using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace ToDoApp.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class UnwrapExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public UnwrapExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            await _next(httpContext);
            timer.Stop();
            System.Console.WriteLine("It takes this much time: {0}", timer.Elapsed.Milliseconds);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UnwrapExceptionMiddleware>();
        }
    }
}
