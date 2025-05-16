using Microsoft.AspNetCore.Http;
using RegistroDetran.Core.Entities;
using RegistroDetran.Infrastructure.Data;
using System.Net;
using System.Text.Json;

namespace RegistroDetran.Infrastructure.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context, AppDbContext dbContext)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await LogExceptionAsync(dbContext, ex);
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task LogExceptionAsync(AppDbContext dbContext, Exception ex)
        {
            var logEntry = new LogEntry
            {
                Timestamp = DateTime.UtcNow,
                Level = "Error",
                Message = ex.Message,
                Exception = ex.ToString()
            };

            dbContext.Logs.Add(logEntry);
            await dbContext.SaveChangesAsync();
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            return context.Response.WriteAsync(JsonSerializer.Serialize(new
            {
                StatusCode = context.Response.StatusCode,
                Message = "An error occurred while processing your request."
            }));
        }
    }
}
