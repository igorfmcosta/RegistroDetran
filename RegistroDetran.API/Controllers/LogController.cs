using Microsoft.AspNetCore.Mvc;
using RegistroDetran.Core.Interfaces;

namespace RegistroDetran.API.Controllers
{
    public static class LogControllers
    {
        public static void MapLogEndpoints(this WebApplication app)
        {
            app.MapGet("/api/logs", async (CancellationToken token, [FromServices] ILoggerService loggerService) =>
            {
                var logs = await loggerService.GetLogsAsync();
                return Results.Ok(logs);
            })
            .WithName("GetLogs")
            .WithOpenApi()
            .AllowAnonymous();
        }
    }
}
