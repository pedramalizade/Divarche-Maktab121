﻿namespace Divarcheh.Endpoints.RazorPages.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                File.WriteAllText("C:/Test/Error.txt", e.Message);
            }
            finally
            {
                await _next(context);
            }
        }
    }
}
